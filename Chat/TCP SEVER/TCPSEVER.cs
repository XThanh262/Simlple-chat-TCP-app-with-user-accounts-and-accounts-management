using SimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_SEVER
{
    public partial class TCPSEVER : Form
    {
        SqlCommand comm;
        SqlConnection conn;
        string str = @"Data Source=DESKTOP-H0Q7E53;Initial Catalog=Nhantinbaomat;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string tk;
        string ip;

        public TCPSEVER()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    IPtextbox.Text = ""+address.ToString()+":1200";
                }
            }
        }
        SimpleTcpServer server;
        

        private void Startbutton_Click(object sender, EventArgs e)
        {
            server.Start();
            Chattextbox.Text += $"Bắt đầu....{Environment.NewLine}";
            Startbutton.Enabled = false;
            Guibutton.Enabled = true;
        }

        private void TCPSEVER_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            Guibutton.Enabled = false;
            server = new SimpleTcpServer(IPtextbox.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
        }

       

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                Chattextbox.Text += $"{e.IpPort}: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
                string chuoitn = ""+ Encoding.UTF8.GetString(e.Data)+"";
                string xn = chuoitn.Split('*')[0];
                string nguoigui = chuoitn.Split('*')[1];
                string nguoinhan = chuoitn.Split('*')[2];
                string tn = chuoitn.Split('*')[3];
                MessageBox.Show(""+nguoinhan + "" + tn +"");
                if (xn == "#@") // kiểm tra tin nhắn và chọn client ip form listbox
                {
                    server.Send(nguoinhan, tn);
                    //Chattextbox.Text += $""+nguoigui+": "+tn+"";
                    TNtextbox.Text = string.Empty;
                }
            });
            
        }
        private void Events_ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                Chattextbox.Text += $"{e.IpPort} Đã đóng kết nối.{Environment.NewLine}";
                listClientIP.Items.Remove(e.IpPort);
            });
        }


        private void Events_ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                
                Chattextbox.Text += $"{e.IpPort} Đã kết nối.{Environment.NewLine}";
                ip = e.IpPort;
                conn = new SqlConnection(str);
                conn.Open();
                comm = conn.CreateCommand();
                comm.CommandText = "UPDATE NguoiDung SET IpPort = ('"+ip+"') WHERE TaiKhoan = ('987')"; 
                comm.ExecuteNonQuery();
                listClientIP.Items.Add(""+e.IpPort+"");
            });
        }

        private void Guibutton_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                if (!string.IsNullOrEmpty(TNtextbox.Text) && listClientIP.SelectedItem != null) // kiểm tra tin nhắn và chọn client ip form listbox
                {
                    server.Send(listClientIP.SelectedItem.ToString(), TNtextbox.Text);
                    Chattextbox.Text += $"Sever: {TNtextbox.Text}{Environment.NewLine}";
                    TNtextbox.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập tin nhắn hoặc bạn chưa chọn IP bạn muốn gửi tin nhắn!");
                }    
            }
        }
    }
}
