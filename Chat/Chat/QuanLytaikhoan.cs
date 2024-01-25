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

namespace Chat
{
    public partial class QuanLytaikhoan : Form
    {
        SqlConnection conn;
        SqlCommand comm;
        string str = @"Data Source=DESKTOP-H0Q7E53;Initial Catalog=Nhantinbaomat;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void hienthi()
        {
            comm = conn.CreateCommand();
            comm.CommandText = "select * from NguoiDung";
            adapter.SelectCommand = comm;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public QuanLytaikhoan()
        {
            InitializeComponent();
        }

        private void QuanLytaikhoan_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            hienthi();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            TKtextBox.Text = dgv.Rows[i].Cells[0].Value.ToString();
            MKtextBox.Text = dgv.Rows[i].Cells[1].Value.ToString();
            mailtextBox.Text = dgv.Rows[i].Cells[2].Value.ToString();
        }

        private void Them_button_Click(object sender, EventArgs e)
        {
            string tk = TKtextBox.Text;
            string mk = MKtextBox.Text;
            string mail = mailtextBox.Text;
            comm = conn.CreateCommand();
            comm.CommandText = "insert into NguoiDung values('"+tk+"','"+mk+"','"+mail+"','')";
            comm.ExecuteNonQuery();
            hienthi();
        }

        private void Xoa_button_Click(object sender, EventArgs e)
        {
            TKtextBox.ReadOnly = true;
            string tk = TKtextBox.Text;
            string mk = MKtextBox.Text;
            string mail = mailtextBox.Text;
            comm = conn.CreateCommand();
            comm.CommandText = "delete from NguoiDung where TaiKhoan=('" +tk+ "')";
            comm.ExecuteNonQuery();
            hienthi();
        }

        private void Timkiem_button_Click(object sender, EventArgs e)
        {
            try
            {
                string tk = TKtextBox.Text;
                comm = conn.CreateCommand();
                comm.CommandText = "select * from NguoiDung where TaiKhoan=('" + tk + "')";
                adapter.SelectCommand = comm;
                table.Clear();
                adapter.Fill(table);
                dgv.DataSource = table;

            }
            catch(Exception ex)
            { MessageBox.Show(""); }
            
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            hienthi();
        }

        private void QHbutton_Click(object sender, EventArgs e)
        {
            TKtextBox.ReadOnly = true;
            string tk = TKtextBox.Text;
            string qh = QHcomboBox.Text;
            comm = conn.CreateCommand();
            comm.CommandText = "update NguoiDung set QuyenHan = ('"+qh+"') where TaiKhoan=('" + tk + "')";
            comm.ExecuteNonQuery();
            hienthi();
        }
    }
}
