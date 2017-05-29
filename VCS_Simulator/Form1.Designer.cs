namespace CommunicationSample
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_newClient = new System.Windows.Forms.Button();
            this.tx_PortName = new System.Windows.Forms.TextBox();
            this.rtb_Server = new System.Windows.Forms.RichTextBox();
            this.rtb_Client = new System.Windows.Forms.RichTextBox();
            this.btn_newServer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_IP2 = new System.Windows.Forms.TextBox();
            this.btn_ServerSent = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_Ip1 = new System.Windows.Forms.TextBox();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Clientsend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_TcpLog = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tmrUpdateForm = new System.Windows.Forms.Timer(this.components);
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_newClient
            // 
            this.btn_newClient.Location = new System.Drawing.Point(175, 10);
            this.btn_newClient.Name = "btn_newClient";
            this.btn_newClient.Size = new System.Drawing.Size(56, 23);
            this.btn_newClient.TabIndex = 0;
            this.btn_newClient.Text = "new";
            this.btn_newClient.UseVisualStyleBackColor = true;
            this.btn_newClient.Click += new System.EventHandler(this.btn_newClient_Click);
            // 
            // tx_PortName
            // 
            this.tx_PortName.Location = new System.Drawing.Point(218, 2);
            this.tx_PortName.Name = "tx_PortName";
            this.tx_PortName.Size = new System.Drawing.Size(68, 22);
            this.tx_PortName.TabIndex = 1;
            this.tx_PortName.Text = "26000";
            // 
            // rtb_Server
            // 
            this.rtb_Server.Location = new System.Drawing.Point(8, 39);
            this.rtb_Server.Name = "rtb_Server";
            this.rtb_Server.Size = new System.Drawing.Size(230, 132);
            this.rtb_Server.TabIndex = 2;
            this.rtb_Server.Text = "";
            // 
            // rtb_Client
            // 
            this.rtb_Client.Location = new System.Drawing.Point(11, 40);
            this.rtb_Client.Name = "rtb_Client";
            this.rtb_Client.Size = new System.Drawing.Size(220, 131);
            this.rtb_Client.TabIndex = 2;
            this.rtb_Client.Text = "";
            // 
            // btn_newServer
            // 
            this.btn_newServer.Location = new System.Drawing.Point(173, 10);
            this.btn_newServer.Name = "btn_newServer";
            this.btn_newServer.Size = new System.Drawing.Size(62, 23);
            this.btn_newServer.TabIndex = 0;
            this.btn_newServer.Text = "new";
            this.btn_newServer.UseVisualStyleBackColor = true;
            this.btn_newServer.Click += new System.EventHandler(this.btn_newServer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_IP2);
            this.groupBox1.Controls.Add(this.btn_ServerSent);
            this.groupBox1.Controls.Add(this.rtb_Server);
            this.groupBox1.Controls.Add(this.btn_newServer);
            this.groupBox1.Location = new System.Drawing.Point(266, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 250);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TCPServer";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(183, 187);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(46, 22);
            this.textBox7.TabIndex = 7;
            this.textBox7.Text = "3";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(131, 187);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(46, 22);
            this.textBox6.TabIndex = 7;
            this.textBox6.Text = "255";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(79, 188);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(46, 22);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "123";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(27, 188);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(46, 22);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ip";
            // 
            // tb_IP2
            // 
            this.tb_IP2.Location = new System.Drawing.Point(27, 216);
            this.tb_IP2.Name = "tb_IP2";
            this.tb_IP2.Size = new System.Drawing.Size(113, 22);
            this.tb_IP2.TabIndex = 5;
            // 
            // btn_ServerSent
            // 
            this.btn_ServerSent.Location = new System.Drawing.Point(146, 215);
            this.btn_ServerSent.Name = "btn_ServerSent";
            this.btn_ServerSent.Size = new System.Drawing.Size(83, 23);
            this.btn_ServerSent.TabIndex = 4;
            this.btn_ServerSent.Text = "send";
            this.btn_ServerSent.UseVisualStyleBackColor = true;
            this.btn_ServerSent.Click += new System.EventHandler(this.btn_ServerSend_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.tb_Ip1);
            this.groupBox2.Controls.Add(this.textBox0);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_Clientsend);
            this.groupBox2.Controls.Add(this.btn_newClient);
            this.groupBox2.Controls.Add(this.rtb_Client);
            this.groupBox2.Location = new System.Drawing.Point(18, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 250);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TCPClient";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(185, 182);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(46, 22);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Server Ip";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(46, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "35";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, -11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "port";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "33";
            // 
            // tb_Ip1
            // 
            this.tb_Ip1.Location = new System.Drawing.Point(63, 12);
            this.tb_Ip1.Name = "tb_Ip1";
            this.tb_Ip1.Size = new System.Drawing.Size(106, 22);
            this.tb_Ip1.TabIndex = 1;
            // 
            // textBox0
            // 
            this.textBox0.Location = new System.Drawing.Point(29, 183);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(46, 22);
            this.textBox0.TabIndex = 7;
            this.textBox0.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 6;
            // 
            // btn_Clientsend
            // 
            this.btn_Clientsend.Location = new System.Drawing.Point(27, 216);
            this.btn_Clientsend.Name = "btn_Clientsend";
            this.btn_Clientsend.Size = new System.Drawing.Size(204, 23);
            this.btn_Clientsend.TabIndex = 4;
            this.btn_Clientsend.Text = "send";
            this.btn_Clientsend.UseVisualStyleBackColor = true;
            this.btn_Clientsend.Click += new System.EventHandler(this.btn_ClientSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Prot";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rtb_TcpLog
            // 
            this.rtb_TcpLog.Location = new System.Drawing.Point(64, 291);
            this.rtb_TcpLog.Name = "rtb_TcpLog";
            this.rtb_TcpLog.Size = new System.Drawing.Size(456, 93);
            this.rtb_TcpLog.TabIndex = 9;
            this.rtb_TcpLog.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Log";
            // 
            // tmrUpdateForm
            // 
            this.tmrUpdateForm.Enabled = true;
            this.tmrUpdateForm.Tick += new System.EventHandler(this.tmrUpdateForm_Tick);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(7, 375);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(51, 23);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 410);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtb_TcpLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tx_PortName);
            this.Controls.Add(this.btn_clear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_newClient;
        private System.Windows.Forms.TextBox tx_PortName;
        private System.Windows.Forms.RichTextBox rtb_Server;
        private System.Windows.Forms.RichTextBox rtb_Client;
        private System.Windows.Forms.Button btn_newServer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Ip1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_IP2;
        private System.Windows.Forms.Button btn_ServerSent;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Clientsend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_TcpLog;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer tmrUpdateForm;
        private System.Windows.Forms.Button btn_clear;
    }
}

