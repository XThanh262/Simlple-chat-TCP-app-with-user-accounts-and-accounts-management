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
using TCP;

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
        string nguoigui;

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

        private void Events_ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                Chattextbox.Text += $"{e.IpPort} Đã đóng kết nối.{Environment.NewLine}";
                ip = e.IpPort;
                //conn.Open();
                //conn = new SqlConnection(str);
                comm = conn.CreateCommand();
                comm.CommandText = "UPDATE NguoiDung SET IpPort = '' WHERE IpIport = '" + ip + "'";
                comm.ExecuteNonQuery();
                listClientIP.Items.Remove(e.IpPort);
            });
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                Chattextbox.Text += $"{tk}:{e.IpPort}: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
                string chuoitn = ""+ Encoding.UTF8.GetString(e.Data)+"";
                string xn = chuoitn.Split('*')[0];
                if(xn=="!!")
                {
                    string tk = chuoitn.Split('*')[1];
                    
                    comm = conn.CreateCommand();
                    comm.CommandText = "UPDATE NguoiDung SET IpPort = '" + e.IpPort + "' WHERE TaiKhoan = '" + tk + "'";
                    comm.ExecuteNonQuery();
                }    
                
                if (xn == "@@")
                {
                    string nguoigui = chuoitn.Split('*')[1];
                    string ip = chuoitn.Split('*')[2];
                    string tn = chuoitn.Split('*')[3];
                    string tntv = "" + nguoigui + ": " + tn + "";
                    //MessageBox.Show("" +ip+"//"+tn+"");
                    server.Send(ip, tntv);
                    TNtextbox.Text = string.Empty;
                }
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
                comm.CommandText = "UPDATE NguoiDung SET IpPort = '"+ip+"' WHERE TaiKhoan = '"+tk+"'"; 
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
