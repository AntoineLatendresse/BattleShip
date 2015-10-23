using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.IO;

namespace BattleShipServeur
{
    public partial class BattleShipServeur : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string receive;
        public String text_to_send;

        public BattleShipServeur()
        {
            InitializeComponent();
            IPAddress[] localip = Dns.GetHostAddresses(Dns.GetHostName()); // get my own IP
            foreach(IPAddress address in localip)
            {
                if(address.AddressFamily == AddressFamily.InterNetwork)
                {
                    textbox_IPServer.Text = address.ToString();
                }
            }
        }

        private void btn_SServer_Click(object sender, EventArgs e) // Start Server
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(textbox_PortServer.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;

            backgroundWorker1.RunWorkerAsync(); //Start receiving Data in background
            backgroundWorker2.WorkerSupportsCancellation = true; //Ability to cancel this thread
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) // receive Data
        {
            while(client.Connected)
            {
                try
                {
                    receive = STR.ReadLine();
                    this.textBox_ChangeLog.Invoke(new MethodInvoker(delegate() { textBox_ChangeLog.AppendText("You: " + receive + "\n"); }));
                    receive = "";
                }
                catch(Exception Exc)
                {
                    MessageBox.Show(Exc.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e) // send Data
        {
            if(client.Connected)
            {
                STW.WriteLine(text_to_send);
                this.textBox_ChangeLog.Invoke(new MethodInvoker(delegate() { textBox_ChangeLog.AppendText("Me: " + text_to_send + "\n"); }));
            }
            else
            {
                MessageBox.Show("Send Failed!");
            }
            backgroundWorker2.CancelAsync();
        }

        private void btn_Connect_Click(object sender, EventArgs e) // Connect to Server
        {
            client = new TcpClient();
            IPEndPoint IP_End = new IPEndPoint(IPAddress.Parse(textbox_IPClient.Text), int.Parse(textbox_PortClient.Text));
            try
            {
                client.Connect(IP_End);
                if(client.Connected)
                {
                    textBox_ChangeLog.AppendText("Connected to Server" + "\n");
                    STW = new StreamWriter(client.GetStream());
                    STR = new StreamReader(client.GetStream());
                    STW.AutoFlush = true;

                    backgroundWorker1.RunWorkerAsync(); //Start receiving Data in background
                    backgroundWorker2.WorkerSupportsCancellation = true; //Ability to cancel this thread
                }
            }
            catch(Exception Exc)
            {
                MessageBox.Show(Exc.Message.ToString());
            }
        }

        private void btn_Send_Click(object sender, EventArgs e) // Send Button
        {
            if(textBox1.Text !=  "")
            {
                text_to_send = textBox1.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            textBox1.Text = "";
        }
    }
}
