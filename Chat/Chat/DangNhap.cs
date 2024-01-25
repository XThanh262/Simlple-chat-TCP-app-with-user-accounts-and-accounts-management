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
using TCP_SEVER;
using TCP;

namespace Chat
{
    
    public partial class DangNhap : Form
    {
        private SqlCommand comm;

        public DangNhap()
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
                    conn.Close();
                    conn.Open();
                    sql = "select QuyenHan from Nguoidung where TaiKhoan = '" + tk + "'";
                    SqlCommand cmm = new SqlCommand(sql,conn);
                    string data = (string)cmm.ExecuteScalar();
                    if (data == "Admin")
                    {
                        QuanLytaikhoan quanLytaikhoan = new QuanLytaikhoan();
                        quanLytaikhoan.Show();

                    }
                    
                    TCPCLIENT tCPCLIENT = new TCPCLIENT(TKtextBox.Text);
                    tCPCLIENT.Show();
                    



                }
                else { MessageBox.Show("Đăng nhập thất bại"); }    
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex);
            } 
            
        }

       

        private void DKbutton_Click(object sender, EventArgs e)
        {   
            
            Dangky dangky = new Dangky();
            dangky.Show();
            
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            TCPSEVER tCPSEVER = new TCPSEVER();
            tCPSEVER.Show();
        }
    }
}
