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

namespace quanlysinhvien
{
    public partial class Form1 : Form
    {
        SqlConnection sqlcon = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if(sqlcon == null)
            {
                sqlcon = new SqlConnection(@"Data Source=LAB2-16\MISASME2021;Initial Catalog=TaiKhoan;Integrated Security=True");
            }
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }

            string tk = txtTK.Text.Trim();
            string mk = txtMK.Text.Trim();

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "SELECT * FROM TaiKhoanDN WHERE TaiKhoan = '" + tk + "'AND MatKhau = '" + mk + "'";

            sqlcmd.Connection = sqlcon;

            SqlDataReader data = sqlcmd.ExecuteReader();
            if(data.Read() == true)
            {
                MessageBox.Show("Dang Nhap Thanh Cong");
                quanlysinhvien ql   = new quanlysinhvien();
                ql.ShowDialog();
            }
            else
            {
                MessageBox.Show("Dang nhap khong thanh cong");
            }
            data.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
