using System;
using System.Drawing;
using System.Windows.Forms;

using System.IO;
using System.Net;
using System.Net.Sockets;

using Battleship_Client.ConnexionUtility;
using Battleship_Client.Bundle;

namespace BattleShipServeur
{
    public partial class GameUnits : Form
    {
        //Variable/////////////////////////////////////////////
        TcpClient tcpClient;
        public StreamReader STR;
        public StreamWriter STW;
        public string receive;
        public String text_to_send;
        //Variable/////////////////////////////////////////////

        //GameETA//////////////////////////////////////////////
        public enum GameETA
        {
            CreateGame, CreateBoat, EnemyTurn, PlayerTurn, GameWin, GameOver
        }
        public GameETA ETA { get; private set; }
        //GameETA//////////////////////////////////////////////

        public GameUnits()
        {
            InitializeComponent();
            timer_GameUnits.Start();

            IPAddress[] localip = Dns.GetHostAddresses(Dns.GetHostName()); // get my own IP
            foreach (IPAddress address in localip)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    textbox_IPPlayer.Text = address.ToString();
                }
            }
        }

        private void timer_GameUnits_Tick(object sender, EventArgs e)
        {
            if (this != null)
            {
                switch (ETA)
                {
                    case GameETA.CreateGame:
                        lbl_LOG.Text = "Create Game";
                        break;
                    case GameETA.CreateBoat:
                        lbl_LOG.Text = "Create Boat";
                        break;
                    case GameETA.EnemyTurn:
                        lbl_LOG.Text = "Enemy Turn";
                        break;
                    case GameETA.PlayerTurn:
                        lbl_LOG.Text = "Player Turn";
                        break;
                    case GameETA.GameWin:
                        lbl_LOG.Text = "Game Win";
                        break;
                    case GameETA.GameOver:
                        lbl_LOG.Text = "Game Over";
                        break;
                    default:
                        lbl_LOG.Text = "CHANGELOG";
                        break;
                }
            }
        }

        public void SetBoats()
        {
            ClientUtility.SerializeAndSend(tcpClient.GetStream(), new ClientBoat
            {
                Point_Aircraft_Carrier = new Point(0, 0),
                Orien_Aircraft_Carrier = ClientBoat.Orientation.Horizontal,

                Point_Battleship = new Point(0, 1),
                Orien_Battleship = ClientBoat.Orientation.Horizontal,

                Point_Destroyer = new Point(0, 2),
                Orien_Destroyer = ClientBoat.Orientation.Horizontal,

                Point_Patrol_Boat = new Point(0, 3),
                Orien_Patrol_Boat = ClientBoat.Orientation.Horizontal,

                Point_Submarine = new Point(0, 4),
                Orien_Submarine = ClientBoat.Orientation.Horizontal
            });
        }

        private void btn_Ready_Click(object sender, EventArgs e)
        {
            SetBoats();
            backgroundWorker2.RunWorkerAsync();
        }

        private void btn_Connexion_Click(object sender, EventArgs e)
        {
            try
            {
                TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(textbox_IPPlayer.Text));
                listener.Start();
                tcpClient = listener.AcceptTcpClient();
                STR = new StreamReader(tcpClient.GetStream());
                STW = new StreamWriter(tcpClient.GetStream());
                STW.AutoFlush = true;

                backgroundWorker1.RunWorkerAsync(); //Start receiving Data in background
                backgroundWorker2.WorkerSupportsCancellation = true; //Ability to cancel this thread
            }
            catch (Exception Exce)
            {
                MessageBox.Show(Exce.Message);
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (tcpClient.Connected)
            {
                try
                {
                    NetworkStream ns = tcpClient.GetStream();
                    do
                    {
                        continue;
                    } while ((String)ClientUtility.ReadAndDeserialize(ns) != "Start");

                    ETA = GameETA.CreateBoat;
                }
                catch (Exception Exc)
                {
                    MessageBox.Show(Exc.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (tcpClient.Connected)
            {
                STW.WriteLine(text_to_send);
                textBox_Log.Invoke(new MethodInvoker(delegate () { textBox_Log.AppendText("Me: " + text_to_send + "\n"); }));
            }
            else
            {
                MessageBox.Show("Send Failed!");
            }
            backgroundWorker2.CancelAsync();
        }
    }
}