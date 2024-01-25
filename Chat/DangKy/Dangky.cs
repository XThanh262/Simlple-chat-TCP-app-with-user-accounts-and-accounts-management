using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Net.Mail;
using System.Net;

namespace Chat
{
    public partial class Dangky : Form
    {
        public string ma;
        private string email;

        public Dangky()
        {
            InitializeComponent();
        }
         SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-H0Q7E53;Initial Catalog=Nhantinbaomat;Integrated Security=True");

        private void DangKybutton_Click(object sender, EventArgs e)
        {
            
               
                try
                {
                    conn.Open();
                    string tk = TKtextBox.Text;
                    string mk = MKtextBox.Text;
                    string mannhap = MXNtextBox.Text;
                    email = EmailtextBox.Text;
                    string sql = "select * from NguoiDung where TaiKhoan = '" + tk + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        MessageBox.Show("Tài khoản đã tồn tại!!!"); 
                    }
                    if (mannhap != ma)
                    {
                        MessageBox.Show("Mã nhập không chích xác!!!");
                    }
                
    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối" + ex);
                }

            
        }

        private void NhanMabutton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                email = EmailtextBox.Text;
                string sql = "select * from NguoiDung where Email = '" + email + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Email này đã được dùng!");
                }
                else
                {
                 Random rd = new Random();

                    int rand_num = rd.Next(1000, 9999);
                    ma = rand_num.ToString();
                     //MessageBox.Show(ma);
                     SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                    mailclient.EnableSsl = true;
                    mailclient.Credentials = new NetworkCredential("hxthanh0206@gmail.com", "123456yuio");
                    MailMessage message = new MailMessage("hxthanh0206@gmail.com", EmailtextBox.Text);
                    message.Subject = "Mã xác nhận";
                    message.Body = "Mã xác nhận của bạn là " + ma +"";
                    mailclient.Send(message);
                    MessageBox.Show("Mã đã được gửi vui lòng kiểm tra email. Nếu không có vui lòng kiểm tra hòm thư spam");
                    conn.Close();
                }    
               
            }
            catch( Exception ex)
            {
                MessageBox.Show("lỗi!"+ex);
            }
            
        }
    }

}
    

