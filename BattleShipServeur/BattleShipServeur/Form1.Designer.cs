namespace BattleShipServeur
{
    partial class BattleShipServeur
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleShipServeur));
            this.btn_Send = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_ChangeLog = new System.Windows.Forms.TextBox();
            this.textbox_IPServer = new System.Windows.Forms.TextBox();
            this.textbox_PortServer = new System.Windows.Forms.TextBox();
            this.textbox_IPClient = new System.Windows.Forms.TextBox();
            this.textbox_PortClient = new System.Windows.Forms.TextBox();
            this.btn_SServer = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.lbl_Server = new System.Windows.Forms.Label();
            this.lbl_Client = new System.Windows.Forms.Label();
            this.lbl_IPServer = new System.Windows.Forms.Label();
            this.lbl_IPClient = new System.Windows.Forms.Label();
            this.lbl_PortServer = new System.Windows.Forms.Label();
            this.lbl_PortClient = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(761, 499);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(104, 51);
            this.btn_Send.TabIndex = 0;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 499);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(743, 42);
            this.textBox1.TabIndex = 1;
            // 
            // textBox_ChangeLog
            // 
            this.textBox_ChangeLog.Location = new System.Drawing.Point(12, 232);
            this.textBox_ChangeLog.Multiline = true;
            this.textBox_ChangeLog.Name = "textBox_ChangeLog";
            this.textBox_ChangeLog.Size = new System.Drawing.Size(743, 261);
            this.textBox_ChangeLog.TabIndex = 2;
            // 
            // textbox_IPServer
            // 
            this.textbox_IPServer.Location = new System.Drawing.Point(139, 52);
            this.textbox_IPServer.Name = "textbox_IPServer";
            this.textbox_IPServer.Size = new System.Drawing.Size(100, 29);
            this.textbox_IPServer.TabIndex = 3;
            // 
            // textbox_PortServer
            // 
            this.textbox_PortServer.Location = new System.Drawing.Point(586, 52);
            this.textbox_PortServer.Name = "textbox_PortServer";
            this.textbox_PortServer.Size = new System.Drawing.Size(100, 29);
            this.textbox_PortServer.TabIndex = 4;
            // 
            // textbox_IPClient
            // 
            this.textbox_IPClient.Location = new System.Drawing.Point(139, 155);
            this.textbox_IPClient.Name = "textbox_IPClient";
            this.textbox_IPClient.Size = new System.Drawing.Size(100, 29);
            this.textbox_IPClient.TabIndex = 5;
            // 
            // textbox_PortClient
            // 
            this.textbox_PortClient.Location = new System.Drawing.Point(586, 155);
            this.textbox_PortClient.Name = "textbox_PortClient";
            this.textbox_PortClient.Size = new System.Drawing.Size(100, 29);
            this.textbox_PortClient.TabIndex = 6;
            // 
            // btn_SServer
            // 
            this.btn_SServer.Location = new System.Drawing.Point(12, 87);
            this.btn_SServer.Name = "btn_SServer";
            this.btn_SServer.Size = new System.Drawing.Size(960, 36);
            this.btn_SServer.TabIndex = 7;
            this.btn_SServer.Text = "Start Server";
            this.btn_SServer.UseVisualStyleBackColor = true;
            this.btn_SServer.Click += new System.EventHandler(this.btn_SServer_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(12, 190);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(960, 36);
            this.btn_Connect.TabIndex = 8;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // lbl_Server
            // 
            this.lbl_Server.AutoSize = true;
            this.lbl_Server.Location = new System.Drawing.Point(409, 9);
            this.lbl_Server.Name = "lbl_Server";
            this.lbl_Server.Size = new System.Drawing.Size(55, 21);
            this.lbl_Server.TabIndex = 9;
            this.lbl_Server.Text = "Server";
            // 
            // lbl_Client
            // 
            this.lbl_Client.AutoSize = true;
            this.lbl_Client.Location = new System.Drawing.Point(414, 126);
            this.lbl_Client.Name = "lbl_Client";
            this.lbl_Client.Size = new System.Drawing.Size(50, 21);
            this.lbl_Client.TabIndex = 10;
            this.lbl_Client.Text = "Client";
            // 
            // lbl_IPServer
            // 
            this.lbl_IPServer.AutoSize = true;
            this.lbl_IPServer.Location = new System.Drawing.Point(110, 55);
            this.lbl_IPServer.Name = "lbl_IPServer";
            this.lbl_IPServer.Size = new System.Drawing.Size(23, 21);
            this.lbl_IPServer.TabIndex = 11;
            this.lbl_IPServer.Text = "IP";
            // 
            // lbl_IPClient
            // 
            this.lbl_IPClient.AutoSize = true;
            this.lbl_IPClient.Location = new System.Drawing.Point(110, 158);
            this.lbl_IPClient.Name = "lbl_IPClient";
            this.lbl_IPClient.Size = new System.Drawing.Size(23, 21);
            this.lbl_IPClient.TabIndex = 11;
            this.lbl_IPClient.Text = "IP";
            // 
            // lbl_PortServer
            // 
            this.lbl_PortServer.AutoSize = true;
            this.lbl_PortServer.Location = new System.Drawing.Point(541, 55);
            this.lbl_PortServer.Name = "lbl_PortServer";
            this.lbl_PortServer.Size = new System.Drawing.Size(39, 21);
            this.lbl_PortServer.TabIndex = 12;
            this.lbl_PortServer.Text = "Port";
            // 
            // lbl_PortClient
            // 
            this.lbl_PortClient.AutoSize = true;
            this.lbl_PortClient.Location = new System.Drawing.Point(541, 158);
            this.lbl_PortClient.Name = "lbl_PortClient";
            this.lbl_PortClient.Size = new System.Drawing.Size(39, 21);
            this.lbl_PortClient.TabIndex = 12;
            this.lbl_PortClient.Text = "Port";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // BattleShipServeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.lbl_PortClient);
            this.Controls.Add(this.lbl_PortServer);
            this.Controls.Add(this.lbl_IPClient);
            this.Controls.Add(this.lbl_IPServer);
            this.Controls.Add(this.lbl_Client);
            this.Controls.Add(this.lbl_Server);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.btn_SServer);
            this.Controls.Add(this.textbox_PortClient);
            this.Controls.Add(this.textbox_IPClient);
            this.Controls.Add(this.textbox_PortServer);
            this.Controls.Add(this.textbox_IPServer);
            this.Controls.Add(this.textBox_ChangeLog);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Send);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BattleShipServeur";
            this.Text = "BattleShip - Serveur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox_ChangeLog;
        private System.Windows.Forms.TextBox textbox_IPServer;
        private System.Windows.Forms.TextBox textbox_PortServer;
        private System.Windows.Forms.TextBox textbox_IPClient;
        private System.Windows.Forms.TextBox textbox_PortClient;
        private System.Windows.Forms.Button btn_SServer;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label lbl_Server;
        private System.Windows.Forms.Label lbl_Client;
        private System.Windows.Forms.Label lbl_IPServer;
        private System.Windows.Forms.Label lbl_IPClient;
        private System.Windows.Forms.Label lbl_PortServer;
        private System.Windows.Forms.Label lbl_PortClient;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

