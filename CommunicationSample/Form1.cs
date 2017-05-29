using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Communication;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace CommunicationSample
{
    public partial class Form1 : Form
    {
        CommunicationClient Client;
        CommunicationServer Server;
        IPAddress IP = null;
        
        public Form1()
        {
            InitializeComponent();
            
            IPHostEntry iphostentry = Dns.GetHostEntry(Dns.GetHostName()); 
            foreach (IPAddress ipaddress in iphostentry.AddressList)    
                if (ipaddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork) 
                    IP = ipaddress;
            tb_Ip1.Text = IP.ToString();
            tb_IP2.Text = IP.ToString();
        }

        private void btn_newClient_Click(object sender, EventArgs e)
        {
            IPAddress IP;
            if (!IPAddress.TryParse(tb_Ip1.Text, out IP))
                MessageBox.Show("IP illegal");
            Client = new CommunicationClient(tb_Ip1.Text, Int32.Parse(tx_PortName.Text));
            //Receive Thread
            Task.Run(() => receiveFromServer());
            
        }

        private void btn_newServer_Click(object sender, EventArgs e)
        {
            Server = new CommunicationServer(Int32.Parse(tx_PortName.Text));
            //Receive Thread
            Task.Run(() => receiveFromClient());
        }

        private void btn_ServerSend_Click(object sender, EventArgs e)
        {
            try
            {
                //Message
                byte[] message = new byte[4];
                message[0] = byte.Parse(textBox4.Text);
                message[1] = byte.Parse(textBox5.Text);
                message[2] = byte.Parse(textBox6.Text);
                message[3] = byte.Parse(textBox7.Text);
                //Package
                Communication.Communication.IPandMessage sendMessage = new Communication.Communication.IPandMessage(IP, message);
                Server.sendMessage(sendMessage);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void btn_ClientSend_Click(object sender, EventArgs e)
        {
            try
            {
                //Message
                byte[] message = new byte[4];
                message[0] = byte.Parse(textBox0.Text);
                message[1] = byte.Parse(textBox1.Text);
                message[2] = byte.Parse(textBox2.Text);
                message[3] = byte.Parse(textBox3.Text);
                //Package
                Communication.Communication.IPandMessage sendMessage = new Communication.Communication.IPandMessage(IP, message);
                Client.sendMessage(sendMessage);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            rtb_TcpLog.Clear();
        }

        private string MessageFromClient = "";
        private void receiveFromClient()
        {
            while (true)
            {
                Thread.Sleep(20);
                Communication.Communication.IPandMessage receiveMessage = Server.receiveMessage();
                if (receiveMessage == null)
                    continue;
                MessageFromClient += "(" + receiveMessage.IP + ")-";
                byte[] receiveMessageBytes = receiveMessage.Message.ToArray();
                foreach (byte item in receiveMessageBytes)
                    MessageFromClient += "[" + item + "]";
                MessageFromClient += "\r\n";

            }
        }
        private string MessageFromServer = "";
        private void receiveFromServer()
        {
            while (true)
            {
                Thread.Sleep(20);
                Communication.Communication.IPandMessage receiveMessage = Client.receiveMessage();
                if (receiveMessage == null)
                    continue;
                MessageFromServer += "(" + receiveMessage.IP + ")-";
                byte[] receiveMessageBytes = receiveMessage.Message.ToArray();
                foreach (byte item in receiveMessageBytes)
                    MessageFromServer += "[" + item + "]";
                MessageFromServer += "\r\n";
            }
        }

        private void tmrUpdateForm_Tick(object sender, EventArgs e)
        {
            if (MessageFromClient != "")
            {
                rtb_Server.AppendText(MessageFromClient);
                MessageFromClient = "";
            }
            if (MessageFromServer != "")
            {
                rtb_Client.AppendText(MessageFromServer);
                MessageFromServer = "";
            }
            if (Communication.Communication.ConnectionMessage != "")
            {
                rtb_TcpLog.AppendText(Communication.Communication.ConnectionMessage);
                Communication.Communication.ConnectionMessage = "";
            }
        }


    }
}
