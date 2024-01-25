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
using TCP_SEVER;

namespace TCP
{
    public partial class TCPClient : Form
    {
        TCPSEVER tcpsever = new TCPSEVER();
        SqlCommand comm;
        SqlConnection conn;
        string str = @"Data Source=DESKTOP-H0Q7E53;Initial Catalog=Nhantinbaomat;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string tk;
        string ip;

        public TCPClient()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    IPtextbox.Text = "" + address.ToString() + ":1200";
                }
            }
        }
        SimpleTcpClient client;
        private void Connectbutton_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect();
                Guibutton.Enabled = true;
                Connectbutton.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Guibutton_Click(object sender, EventArgs e)
        {

            if(client.IsConnected)
            {
                if (!string.IsNullOrEmpty(TNtextbox.Text) && Onlinelistbox.SelectedItem != null) // kiểm tra tin nhắn và chọn client ip form listbox
                {
                    string nguoinhan = Onlinelistbox.SelectedItem.ToString();
                    string nguoigui = IPtextbox.Text;
                    client.Send("#@*"+IPtextbox+"*"+nguoinhan+"* "+TNtextbox.Text+"*");
                    Chattextbox.Text += $"Bạn: {TNtextbox.Text}{Environment.NewLine}";
                    TNtextbox.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập tin nhắn hoặc bạn chưa chọn IP bạn muốn gửi tin nhắn!");
                }
                //if (!string.IsNullOrEmpty(TNtextbox.Text))
                //{
                //    client.Send(TNtextbox.Text);
                //    Chattextbox.Text += $"Bạn: {TNtextbox.Text}{Environment.NewLine}";
                //    TNtextbox.Text = string.Empty;
                //}    
                    
            }    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            client = new SimpleTcpClient(IPtextbox.Text);
            client.Events.Connected += Events_Connected;
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Disconnected += Events_Disconnected;
            Guibutton.Enabled = false;
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                Chattextbox.Text += $"Sever: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine} ";
            });
           
        }

        private void Events_Disconnected(object sender, ClientDisconnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                Chattextbox.Text += $"Đã ngừng kết nối.{Environment.NewLine}";
                
            });
            
        }

        private void Events_Connected(object sender, ClientConnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                Chattextbox.Text += $"Đã kết nối đến sever.{Environment.NewLine}";
                //comm = conn.CreateCommand();
                //comm.CommandText = "select * from NguoiDung";
                //comm.ExecuteNonQuery();
                
               
            });

            
        }
        void hienthi()
        {
            comm = conn.CreateCommand();
            comm.CommandText = "select * from NguoiDung";
            adapter.SelectCommand = comm;
            table.Clear();
            adapter.Fill(table);
            Onlinelistbox.DataSource = table;
        }

        private void Rfbutton_Click(object sender, EventArgs e)
        {
            string ip = "";
            comm = conn.CreateCommand();
            comm.CommandText = "select TaiKhoan from NguoiDung where IpPort !=('"+ip+"')";
            adapter.SelectCommand = comm;
            table.Clear();
            adapter.Fill(table);
            Onlinelistbox.DataSource = table;
            Onlinelistbox.ValueMember = "TaiKhoan";
            Onlinelistbox.DisplayMember = "TaiKhoan";
        }
    }
}
