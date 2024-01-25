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
namespace Chat
{
    public partial class Chat : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string reciveve;
        public string TextToSend;
        public Chat()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if(address.AddressFamily== AddressFamily.InterNetwork)
                {
                    SeverIP_textBox.Text = address.ToString();
                }    
            } 
                
        }
        private void StartButton_Click (object sender, EventArgs e)
        {
            try
            {
                TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(SeverPort_textBox.Text));
                listener.Start();
                client = listener.AcceptTcpClient();
                STR = new StreamReader(client.GetStream());
                STW = new StreamWriter(client.GetStream());
                STW.AutoFlush = true;
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.WorkerSupportsCancellation = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi start: " + ex.Message.ToString());
            }

        }

        private void Connect_button_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(ClientIP_textBox.Text), int.Parse(ClientPort_textBox.Text));
            try
            {
                ChatScreen_textBox.AppendText("Đã kết nối với sever" + "\n");
                STW = new StreamWriter(client.GetStream());
                STR = new StreamReader(client.GetStream());
                STW.AutoFlush = true;
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.WorkerSupportsCancellation = true;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi connect: "  + ex.Message.ToString());
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(client.Connected)
            {
                try
                {
                    reciveve = STR.ReadLine();
                    this.ChatScreen_textBox.Invoke(new MethodInvoker(delegate ()
                    {
                        ChatScreen_textBox.AppendText("Bạn: " + reciveve + "\n");
                    }));
                    reciveve = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi wk1: " + ex.Message.ToString());
                }
            }    
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if(client.Connected)
            {
                STW.WriteLine(TextToSend);
                this.ChatScreen_textBox.Invoke(new MethodInvoker(delegate ()
                {
                    ChatScreen_textBox.AppendText("Khách: " + TextToSend + "\n");
                }));
            }
            else 
            {
                MessageBox.Show("Lỗi gửi!");
            }
            backgroundWorker2.CancelAsync();
        }

        private void Send_button_Click(object sender, EventArgs e)
        {
            if(Chat_textBox.Text!="")
            {
                TextToSend = Chat_textBox.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            Chat_textBox.Text = "";
        }
    }
}
