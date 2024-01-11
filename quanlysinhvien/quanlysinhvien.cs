using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlysinhvien
{
    public partial class quanlysinhvien : Form
    {
        public quanlysinhvien()
        {
            InitializeComponent();
        }
        private void XoattGiaoDien1()
        {
            txtMaSV.Text = "";
            txtHoTen.Text = "";
            cbGioiTinh.Text = "";
            txtLop.Text = "";
            cbTrinhDoTA.Text = "";
            txtQueQuan.Text = "";
        }
        private void XoattGiaoDien2()
        {
            txtMaSV1.Text = "";
            cbGioiTinh1.Text = "";
            txtLop1.Text = "";
            cbTrinhDoTA1.Text = "";
            txtQueQuan1.Text = "";

        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtMaSV.Text != "")
            {
                if (txtHoTen.Text != "")
                {
                    if (cbGioiTinh.Text != "")
                    {
                        if (txtLop.Text != "")
                        {
                            if (cbTrinhDoTA.Text != "")
                            {
                                if (txtQueQuan.Text != "")
                                {
                                    dataGridViewSinhVien.Rows.Add(txtMaSV.Text, txtHoTen.Text, dateTimePicker1.Text, cbGioiTinh.Text, txtLop.Text, cbTrinhDoTA.Text, txtQueQuan.Text);
                                    MessageBox.Show("Thêm thành công");
                                    XoattGiaoDien1();
                                }
                                else
                                {
                                    MessageBox.Show("chưa nhập thống tin Quê quán");
                                }
                            }
                            else
                            {
                                MessageBox.Show("chưa nhập thống tin Trình độ tiếng anh");
                            }
                        }
                        else
                        {
                            MessageBox.Show("chưa nhập thống tin Lớp");
                        }
                    }
                    else
                    {
                        MessageBox.Show("chưa nhập thống tin Giới Tính");
                    }
                }
                else
                {
                    MessageBox.Show("chưa nhập thống tin Họ và Tên");
                }
            }
            else
            {
                MessageBox.Show("chưa nhập thống tin Mã sinh viên");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewSinhVien.SelectedCells.Count > 0)
            {
                int vitri = dataGridViewSinhVien.CurrentCell.RowIndex;
                dataGridViewSinhVien[0, vitri].Value = txtMaSV.Text;
                dataGridViewSinhVien[1, vitri].Value = txtHoTen.Text;
                dataGridViewSinhVien[2, vitri].Value = dateTimePicker1.Text;
                dataGridViewSinhVien[3, vitri].Value = cbGioiTinh.Text;
                dataGridViewSinhVien[4, vitri].Value = txtLop.Text;
                dataGridViewSinhVien[5, vitri].Value = cbTrinhDoTA.Text;
                dataGridViewSinhVien[6, vitri].Value = txtQueQuan.Text;
                XoattGiaoDien1();
            }
            else
            {
                MessageBox.Show("Không có gì để sửa");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = dataGridViewSinhVien.CurrentCell.RowIndex;
                dataGridViewSinhVien.Rows.RemoveAt(index);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (radMaSV.Checked)
            {
                dataGridViewTimKiem.Rows.Clear();
                for (int i = 0; i < dataGridViewSinhVien.Rows.Count - 1; i++)
                {
                    if (txtMaSV1.Text == dataGridViewSinhVien[0, i].Value.ToString())
                    {
                        dataGridViewTimKiem.Rows.Add(dataGridViewSinhVien[0, i].Value, dataGridViewSinhVien[1, i].Value, dataGridViewSinhVien[2, i].Value, dataGridViewSinhVien[3, i].Value, dataGridViewSinhVien[4, i].Value, dataGridViewSinhVien[5, i].Value, dataGridViewSinhVien[6, i].Value);

                    }
                }
                XoattGiaoDien2();
            }
            else if (radNgaySinh.Checked)
            {
                dataGridViewTimKiem.Rows.Clear();
                for (int i = 0; i < dataGridViewSinhVien.Rows.Count - 1; i++)
                {
                    if (dateTimePicker2.Text == dataGridViewSinhVien[2, i].Value.ToString())
                    {
                        dataGridViewTimKiem.Rows.Add(dataGridViewSinhVien[0, i].Value, dataGridViewSinhVien[1, i].Value, dataGridViewSinhVien[2, i].Value, dataGridViewSinhVien[3, i].Value, dataGridViewSinhVien[4, i].Value, dataGridViewSinhVien[5, i].Value, dataGridViewSinhVien[6, i].Value);

                    }
                }
                XoattGiaoDien2();
            }
            else if (radGioiTinh.Checked)
            {
                dataGridViewTimKiem.Rows.Clear();
                for (int i = 0; i < dataGridViewSinhVien.Rows.Count - 1; i++)
                {
                    if (cbGioiTinh1.Text == dataGridViewSinhVien[3, i].Value.ToString())
                    {
                        dataGridViewTimKiem.Rows.Add(dataGridViewSinhVien[0, i].Value, dataGridViewSinhVien[1, i].Value, dataGridViewSinhVien[2, i].Value, dataGridViewSinhVien[3, i].Value, dataGridViewSinhVien[4, i].Value, dataGridViewSinhVien[5, i].Value, dataGridViewSinhVien[6, i].Value);

                    }
                }
                XoattGiaoDien2();
            }
            else if (radLop.Checked)
            {
                dataGridViewTimKiem.Rows.Clear();
                for (int i = 0; i < dataGridViewSinhVien.Rows.Count - 1; i++)
                {
                    if (txtLop1.Text == dataGridViewSinhVien[4, i].Value.ToString())
                    {
                        dataGridViewTimKiem.Rows.Add(dataGridViewSinhVien[0, i].Value, dataGridViewSinhVien[1, i].Value, dataGridViewSinhVien[2, i].Value, dataGridViewSinhVien[3, i].Value, dataGridViewSinhVien[4, i].Value, dataGridViewSinhVien[5, i].Value, dataGridViewSinhVien[6, i].Value);

                    }
                }
                XoattGiaoDien2();
            }
            else if (radTrinhDoTA.Checked)
            {
                dataGridViewTimKiem.Rows.Clear();
                for (int i = 0; i < dataGridViewSinhVien.Rows.Count - 1; i++)
                {
                    if (cbTrinhDoTA1.Text == dataGridViewSinhVien[5, i].Value.ToString())
                    {
                        dataGridViewTimKiem.Rows.Add(dataGridViewSinhVien[0, i].Value, dataGridViewSinhVien[1, i].Value, dataGridViewSinhVien[2, i].Value, dataGridViewSinhVien[3, i].Value, dataGridViewSinhVien[4, i].Value, dataGridViewSinhVien[5, i].Value, dataGridViewSinhVien[6, i].Value);

                    }
                }
                XoattGiaoDien2();
            }
            else if (radQueQuan.Checked)
            {
                dataGridViewTimKiem.Rows.Clear();
                for (int i = 0; i < dataGridViewSinhVien.Rows.Count - 1; i++)
                {
                    if (txtQueQuan1.Text == dataGridViewSinhVien[6, i].Value.ToString())
                    {
                        dataGridViewTimKiem.Rows.Add(dataGridViewSinhVien[0, i].Value, dataGridViewSinhVien[1, i].Value, dataGridViewSinhVien[2, i].Value, dataGridViewSinhVien[3, i].Value, dataGridViewSinhVien[4, i].Value, dataGridViewSinhVien[5, i].Value, dataGridViewSinhVien[6, i].Value);

                    }
                }
                XoattGiaoDien2();
            }
        }

       

        private void dataGridViewTimKiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSinhVien.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dataGridViewSinhVien.Rows[dataGridViewSinhVien.CurrentCell.RowIndex];
                txtMaSV.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                dateTimePicker1.Text = row.Cells[2].Value.ToString();
                cbGioiTinh.Text = row.Cells[3].Value.ToString();
                txtLop.Text = row.Cells[4].Value.ToString();
                cbTrinhDoTA.Text = row.Cells[5].Value.ToString();
                txtQueQuan.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
