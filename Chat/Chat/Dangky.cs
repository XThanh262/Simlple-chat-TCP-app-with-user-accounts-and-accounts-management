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
using System.IO;

namespace Chat
{
    public partial class Dangky : Form
    {
        public string ma;
        public string email;
        SqlCommand comm;
        SqlConnection conn;
        string str = @"Data Source=DESKTOP-H0Q7E53;Initial Catalog=Nhantinbaomat;Integrated Security=True";


        public Dangky()
        {
            InitializeComponent();
            
        }
        private void Dangky_Load(object sender, EventArgs e)
        {
            
        }
         

        private void DangKybutton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-H0Q7E53;Initial Catalog=Nhantinbaomat;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = TKDKtextBox.Text;
                string mk = MKDKtextBox.Text;
                string kmk = KTMtextBox.Text;
                string email = EmailtextBox.Text;
                
                string sql = "select * from NguoiDung where TaiKhoan = '" + tk + "'"; 
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Tài khoản đã tồn tại!");
                    return;
                }
                else 
                {
                    if(mk != kmk)
                    {
                        MessageBox.Show("Mật khẩu kiểm tra không chính xác!");
                        return;
                    }
                    else
                    {
                        if(MXNtextBox.Text != ma)
                        {
                            MessageBox.Show("Mã xác nhận không chính xác!");
                            return;
                        }
                        else
                        {
                            conn = new SqlConnection(str);
                            conn.Open();
                            comm = conn.CreateCommand();
                            comm.CommandText = "insert into NguoiDung values('" + tk + "','" + mk + "','" + email + "',' ','NguoiDung')";
                            comm.ExecuteNonQuery();                          
                            MessageBox.Show("Đăng ký thành công");
                            DangNhap dangNhap = new DangNhap();
                        }    
                    }    
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex);
            }

        }
    
      

        private void NhanMabutton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-H0Q7E53;Initial Catalog=Nhantinbaomat;Integrated Security=True");
            try
            {
                conn.Open();
                if(EmailtextBox.Text == "")
                {

                    MessageBox.Show("Bạn chưa điền email!");
                }
                else
                {
                    string email = EmailtextBox.Text;
                    string sql = "select * from NguoiDung where Email = '" + email + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read()== true)
                    {
                        MessageBox.Show("Email: " + email + " đã bị sử dụng!");
                    }
                    else
                    {
                        Random rd = new Random();
                        int rand_num = rd.Next(1000, 9999);
                        ma = rand_num.ToString();
                        MessageBox.Show(ma);
                        SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                        mailclient.EnableSsl = true;
                        mailclient.Credentials = new NetworkCredential("hxthanh0206@gmail.com", "123456yuio");
                        MailMessage message = new MailMessage("hxthanh0206@gmail.com", EmailtextBox.Text);
                        message.Subject = "Mã xác nhận";
                        message.Body = "Mã xác nhận của bạn là " + ma +"";
                        mailclient.Send(message);
                        MessageBox.Show("Mã đã được gửi vui lòng kiểm tra email. Nếu không có vui lòng kiểm tra hòm thư spam");
                        
                    }    
                    
                }
                    
                    
               
            }
            catch( Exception ex)
            {
                MessageBox.Show("Bạn chưa điền email!"+ex);
            }
            
        }

        
    }

}
    

