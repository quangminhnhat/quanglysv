using QuanLySinhVien.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void bind()
        {
            doanDB doanDB = new doanDB();
            var studentDT = doanDB.GiangViens.Select(gv => new
            {
                gv.MaGV,
                gv.HoTen,
                gv.sdt,
                gv.NgaySinh,
                gv.GioiTinh,
                gv.Khoa.TenKhoa
            }).ToList();
            dataGridView1.DataSource = studentDT;
            dataGridView1.Columns[0].HeaderText = "Mã giảng viên";
            dataGridView1.Columns[1].HeaderText = "Họ tên";
            dataGridView1.Columns[2].HeaderText = "Số điện thoại";
            dataGridView1.Columns[3].HeaderText = "Ngày sinh";
            dataGridView1.Columns[4].HeaderText = "Giới tính";
            dataGridView1.Columns[5].HeaderText = "Khoa";
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                bind();
                doanDB doanDB = new doanDB();
                List<Khoa> khoas = doanDB.Khoas.ToList();
                cmbFaculty.DataSource = khoas;
                cmbFaculty.DisplayMember = "TenKhoa";
                cmbFaculty.ValueMember = "MaKhoa";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error: {ex}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txtID.Text = row.Cells[0].Value.ToString();
                    txtName.Text = row.Cells[1].Value.ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(row.Cells[3].Value);
                    if (row.Cells[4].Value.ToString() == "Nam")
                    {
                        rdoMale.Checked = true;
                    }
                    else
                    {
                        rdoFemale.Checked = true;
                    }
                    txtContactNum.Text = row.Cells[2].Value.ToString();
                    cmbFaculty.Text = row.Cells[5].Value.ToString();
                }
            }
            catch
            {
                return;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txtID.Text = row.Cells[0].Value.ToString();
                    txtName.Text = row.Cells[1].Value.ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(row.Cells[3].Value);
                    if (row.Cells[4].Value.ToString() == "Nam")
                    {
                        rdoMale.Checked = true;
                    }
                    else
                    {
                        rdoFemale.Checked = true;
                    }
                    txtContactNum.Text = row.Cells[2].Value.ToString();
                    cmbFaculty.Text = row.Cells[5].Value.ToString();
                }
            }
            catch
            {
                return;
            }
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtContactNum.TextLength > 12)
                    throw new Exception("Số điện thoại giảng viên không hợp lệ.");
                doanDB dB = new doanDB();
                var giangVien = new GiangVien
                {
                    MaGV = txtID.Text,
                    HoTen = txtName.Text,
                    sdt = txtContactNum.Text,
                    NgaySinh = dateTimePicker1.Value,
                    GioiTinh = rdoFemale.Checked ? "Nữ" : "Nam",
                    MaKhoa = cmbFaculty.SelectedValue.ToString()
                };
                dB.GiangViens.AddOrUpdate(giangVien);
                dB.SaveChanges();
                bind();
                MessageBox.Show("Thêm thông tin thành công","Thành công!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                doanDB DB = new doanDB();
                List<GiangVien> giangViens = DB.GiangViens.ToList();
                var find = giangViens.FirstOrDefault(f => f.MaGV == txtID.Text);
                if (find != null)
                {
                    DB.GiangViens.Remove(find);
                    DB.SaveChanges();
                    bind();
                    MessageBox.Show("Giảng viên đã được xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Giảng viên không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting data:{ex}", "error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
