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

namespace Chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DNbutton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-H0Q7E53;Initial Catalog=Nhantinbaomat;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = TKtextBox.Text;
                string mk = MKextBox.Text;
                string sql = "select * from NguoiDung where TaiKhoan = '"+tk+"' and MatKhau = '"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read()==true )
                {
                    MessageBox.Show("Đăng nhập thành công");
                    Chat chat = new Chat();
                    chat.Show();
                    //Form1 form1 = new Form1();
                    //form1.Close();
                }
                else { MessageBox.Show("Đăng nhập thất bại"); }    
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex);
            } 
            
        }
    }
}
