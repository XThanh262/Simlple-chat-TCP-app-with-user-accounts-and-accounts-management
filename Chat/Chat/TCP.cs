using Chat;
using SimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCP_SEVER;

namespace TCP
{
    public partial class TCPCLIENT : Form
    {
        TCPSEVER tcpsever = new TCPSEVER();
        SqlCommand comm;
        SqlConnection conn;
        string str = @"Data Source=DESKTOP-H0Q7E53;Initial Catalog=Nhantinbaomat;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public static string tkddntcp;


        public TCPCLIENT(string tkddn)
        {
            InitializeComponent();
            TKlable.Text = tkddn;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Guibutton_Click(object sender, EventArgs e)
        {

            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(TNtextbox.Text) && Onlinelistbox.SelectedItem != null) // kiểm tra tin nhắn và chọn client ip form listbox
                {
                    comm = conn.CreateCommand();
                    comm.CommandText = "select IpPort from Nguoidung where TaiKhoan = '" + NguoiNhanlabel.Text + "'";
                    comm.ExecuteNonQuery();
                    string nguoinhan = (string)comm.ExecuteScalar();
                    string nguoigui = TKlable.Text;
                    client.Send("@@*" + nguoigui + "*" + nguoinhan + "*" + TNtextbox.Text + "*");
                    Chattextbox.Text += $"Bạn: {TNtextbox.Text}{Environment.NewLine}";
                    TNtextbox.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập tin nhắn hoặc bạn chưa chọn IP bạn muốn gửi tin nhắn!");
                }
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
            TCPSEVER tCPSEVER = new TCPSEVER();
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                Chattextbox.Text += $" {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine} ";
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
                client.Send("!!*" + TKlable.Text + "*");

            });


        }



        private void Rfbutton_Click(object sender, EventArgs e)
        {
            string ip = "";
            comm = conn.CreateCommand();
            comm.CommandText = "select TaiKhoan from NguoiDung where IpPort !=('" + ip + "')";
            adapter.SelectCommand = comm;
            table.Clear();
            adapter.Fill(table);
            Onlinelistbox.DataSource = table;
            Onlinelistbox.ValueMember = "TaiKhoan";
            Onlinelistbox.DisplayMember = "TaiKhoan";
           
        }

        private void DXbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        /*string hash = "nh@nt!nb@oma@t";


        private void MHbutton_Click(object sender, EventArgs e)
        {
            byte[] dta = UTF8Encoding.UTF8.GetBytes(CMHtextBox.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(dta, 0, dta.Length);
                    DMHtextBox.Text = Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        private void GMbutton_Click(object sender, EventArgs e)
        {
            byte[] dta = Convert.FromBase64String(DMHtextBox.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(dta, 0, dta.Length);
                    DGMtextBox.Text = UTF8Encoding.UTF8.GetString(results);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NguoiNhanlabel.Text != "")
            {
                comm = conn.CreateCommand();
                comm.CommandText = "select Email from Nguoidung where TaiKhoan = '" + NguoiNhanlabel.Text + "'";
                comm.ExecuteNonQuery();
                EmailtextBox.Text = (string)comm.ExecuteScalar();
                if (EmailtextBox.Text != "")
                {
                    SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                    mailclient.EnableSsl = true;
                    mailclient.Credentials = new NetworkCredential("hxthanh0206@gmail.com", "123456yuio");
                    MailMessage message = new MailMessage("hxthanh0206@gmail.com", EmailtextBox.Text);
                    message.Subject = "Tin nhắn bảo mật!";
                    message.Body = "Chuỗi ký tự mã hóa của bạn là: " + DMHtextBox.Text + "";
                    mailclient.Send(message);

                }
                else
                {

                }


            }
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (object selectedItem in Onlinelistbox.SelectedItems)
            {

                DataRowView dr = (DataRowView)selectedItem;
                String result = dr["TaiKhoan"].ToString();
                NguoiNhanlabel.Text = result;
                Chattextbox.Text = "";
            }
           
        }
    }
}
