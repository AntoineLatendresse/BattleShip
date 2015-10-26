namespace BattleShipServeur
{
    partial class GameUnits
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameUnits));
            this.btn_Ready = new System.Windows.Forms.Button();
            this.btn_Connexion = new System.Windows.Forms.Button();
            this.lbl_ENEMY = new System.Windows.Forms.Label();
            this.timer_GameUnits = new System.Windows.Forms.Timer(this.components);
            this.lbl_PLAYER = new System.Windows.Forms.Label();
            this.lbl_LOG = new System.Windows.Forms.Label();
            this.textbox_IPPlayer = new System.Windows.Forms.TextBox();
            this.textbox_IPEnemy = new System.Windows.Forms.TextBox();
            this.textbox_PortPlayer = new System.Windows.Forms.TextBox();
            this.textbox_PortEnemy = new System.Windows.Forms.TextBox();
            this.lbl_AddressPlayer = new System.Windows.Forms.Label();
            this.lbl_PortPlayer = new System.Windows.Forms.Label();
            this.lbl_AddressEnemy = new System.Windows.Forms.Label();
            this.lbl_PortEnemy = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.textBox_Log = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Ready
            // 
            this.btn_Ready.Location = new System.Drawing.Point(12, 471);
            this.btn_Ready.Name = "btn_Ready";
            this.btn_Ready.Size = new System.Drawing.Size(114, 63);
            this.btn_Ready.TabIndex = 0;
            this.btn_Ready.Text = "Ready";
            this.btn_Ready.UseVisualStyleBackColor = true;
            this.btn_Ready.Click += new System.EventHandler(this.btn_Ready_Click);
            // 
            // btn_Connexion
            // 
            this.btn_Connexion.Location = new System.Drawing.Point(1352, 471);
            this.btn_Connexion.Name = "btn_Connexion";
            this.btn_Connexion.Size = new System.Drawing.Size(114, 63);
            this.btn_Connexion.TabIndex = 1;
            this.btn_Connexion.Text = "Connexion";
            this.btn_Connexion.UseVisualStyleBackColor = true;
            this.btn_Connexion.Click += new System.EventHandler(this.btn_Connexion_Click);
            // 
            // lbl_ENEMY
            // 
            this.lbl_ENEMY.AutoSize = true;
            this.lbl_ENEMY.Location = new System.Drawing.Point(1041, 9);
            this.lbl_ENEMY.Name = "lbl_ENEMY";
            this.lbl_ENEMY.Size = new System.Drawing.Size(61, 21);
            this.lbl_ENEMY.TabIndex = 2;
            this.lbl_ENEMY.Text = "ENEMY";
            // 
            // timer_GameUnits
            // 
            this.timer_GameUnits.Tick += new System.EventHandler(this.timer_GameUnits_Tick);
            // 
            // lbl_PLAYER
            // 
            this.lbl_PLAYER.AutoSize = true;
            this.lbl_PLAYER.Location = new System.Drawing.Point(329, 9);
            this.lbl_PLAYER.Name = "lbl_PLAYER";
            this.lbl_PLAYER.Size = new System.Drawing.Size(63, 21);
            this.lbl_PLAYER.TabIndex = 2;
            this.lbl_PLAYER.Text = "PLAYER";
            // 
            // lbl_LOG
            // 
            this.lbl_LOG.AutoSize = true;
            this.lbl_LOG.Location = new System.Drawing.Point(688, 9);
            this.lbl_LOG.Name = "lbl_LOG";
            this.lbl_LOG.Size = new System.Drawing.Size(32, 21);
            this.lbl_LOG.TabIndex = 3;
            this.lbl_LOG.Text = "log";
            // 
            // textbox_IPPlayer
            // 
            this.textbox_IPPlayer.Location = new System.Drawing.Point(12, 12);
            this.textbox_IPPlayer.Name = "textbox_IPPlayer";
            this.textbox_IPPlayer.Size = new System.Drawing.Size(159, 29);
            this.textbox_IPPlayer.TabIndex = 4;
            // 
            // textbox_IPEnemy
            // 
            this.textbox_IPEnemy.Location = new System.Drawing.Point(1307, 12);
            this.textbox_IPEnemy.Name = "textbox_IPEnemy";
            this.textbox_IPEnemy.Size = new System.Drawing.Size(159, 29);
            this.textbox_IPEnemy.TabIndex = 4;
            // 
            // textbox_PortPlayer
            // 
            this.textbox_PortPlayer.Location = new System.Drawing.Point(12, 47);
            this.textbox_PortPlayer.Name = "textbox_PortPlayer";
            this.textbox_PortPlayer.Size = new System.Drawing.Size(159, 29);
            this.textbox_PortPlayer.TabIndex = 4;
            // 
            // textbox_PortEnemy
            // 
            this.textbox_PortEnemy.Location = new System.Drawing.Point(1307, 47);
            this.textbox_PortEnemy.Name = "textbox_PortEnemy";
            this.textbox_PortEnemy.Size = new System.Drawing.Size(159, 29);
            this.textbox_PortEnemy.TabIndex = 4;
            // 
            // lbl_AddressPlayer
            // 
            this.lbl_AddressPlayer.AutoSize = true;
            this.lbl_AddressPlayer.Location = new System.Drawing.Point(177, 12);
            this.lbl_AddressPlayer.Name = "lbl_AddressPlayer";
            this.lbl_AddressPlayer.Size = new System.Drawing.Size(109, 21);
            this.lbl_AddressPlayer.TabIndex = 5;
            this.lbl_AddressPlayer.Text = "AddressPlayer";
            // 
            // lbl_PortPlayer
            // 
            this.lbl_PortPlayer.AutoSize = true;
            this.lbl_PortPlayer.Location = new System.Drawing.Point(177, 47);
            this.lbl_PortPlayer.Name = "lbl_PortPlayer";
            this.lbl_PortPlayer.Size = new System.Drawing.Size(81, 21);
            this.lbl_PortPlayer.TabIndex = 5;
            this.lbl_PortPlayer.Text = "PortPlayer";
            // 
            // lbl_AddressEnemy
            // 
            this.lbl_AddressEnemy.AutoSize = true;
            this.lbl_AddressEnemy.Location = new System.Drawing.Point(1188, 12);
            this.lbl_AddressEnemy.Name = "lbl_AddressEnemy";
            this.lbl_AddressEnemy.Size = new System.Drawing.Size(113, 21);
            this.lbl_AddressEnemy.TabIndex = 5;
            this.lbl_AddressEnemy.Text = "AddressEnemy";
            // 
            // lbl_PortEnemy
            // 
            this.lbl_PortEnemy.AutoSize = true;
            this.lbl_PortEnemy.Location = new System.Drawing.Point(1216, 47);
            this.lbl_PortEnemy.Name = "lbl_PortEnemy";
            this.lbl_PortEnemy.Size = new System.Drawing.Size(85, 21);
            this.lbl_PortEnemy.TabIndex = 5;
            this.lbl_PortEnemy.Text = "PortEnemy";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // textBox_Log
            // 
            this.textBox_Log.Location = new System.Drawing.Point(333, 33);
            this.textBox_Log.Name = "textBox_Log";
            this.textBox_Log.Size = new System.Drawing.Size(769, 29);
            this.textBox_Log.TabIndex = 6;
            // 
            // GameUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 546);
            this.Controls.Add(this.textBox_Log);
            this.Controls.Add(this.lbl_PortEnemy);
            this.Controls.Add(this.lbl_AddressEnemy);
            this.Controls.Add(this.lbl_PortPlayer);
            this.Controls.Add(this.lbl_AddressPlayer);
            this.Controls.Add(this.textbox_PortEnemy);
            this.Controls.Add(this.textbox_IPEnemy);
            this.Controls.Add(this.textbox_PortPlayer);
            this.Controls.Add(this.textbox_IPPlayer);
            this.Controls.Add(this.lbl_LOG);
            this.Controls.Add(this.lbl_PLAYER);
            this.Controls.Add(this.lbl_ENEMY);
            this.Controls.Add(this.btn_Connexion);
            this.Controls.Add(this.btn_Ready);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GameUnits";
            this.Text = "GameUnits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ready;
        private System.Windows.Forms.Button btn_Connexion;
        private System.Windows.Forms.Label lbl_ENEMY;
        private System.Windows.Forms.Timer timer_GameUnits;
        private System.Windows.Forms.Label lbl_PLAYER;
        private System.Windows.Forms.Label lbl_LOG;
        private System.Windows.Forms.TextBox textbox_IPPlayer;
        private System.Windows.Forms.TextBox textbox_IPEnemy;
        private System.Windows.Forms.TextBox textbox_PortPlayer;
        private System.Windows.Forms.TextBox textbox_PortEnemy;
        private System.Windows.Forms.Label lbl_AddressPlayer;
        private System.Windows.Forms.Label lbl_PortPlayer;
        private System.Windows.Forms.Label lbl_AddressEnemy;
        private System.Windows.Forms.Label lbl_PortEnemy;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox textBox_Log;
    }
}