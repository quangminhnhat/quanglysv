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
using System.Xml.Linq;

namespace QuanLySinhVien
{
    public partial class formTeacher : Form
    {
        public formTeacher()
        {
            InitializeComponent();
        }

        private void formTeacher_Load(object sender, EventArgs e)
        {

            try
            {
                bind();
                doanDB doanDB = new doanDB();
                List<Khoa> khoas = doanDB.Khoas.ToList();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error: {ex}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bind()
        {
            doanDB doanDB = new doanDB();
            var studentDT = doanDB.SinhViens.Select(sv => new
            {
                sv.MaSinhVien,
                sv.HoTen,
                sv.NgaySinh,
                sv.GioiTinh,
                sv.TenLop,
                sv.Khoa.TenKhoa,
                sv.DiemQT,
                sv.DiemTK
            }).ToList();
            dataGridView1.DataSource = studentDT;
            dataGridView1.Columns[0].HeaderText = "Mã sinh viên";
            dataGridView1.Columns[1].HeaderText = "Họ tên";
            dataGridView1.Columns[2].HeaderText = "Ngày sinh";
            dataGridView1.Columns[3].HeaderText = "Giới tính";
            dataGridView1.Columns[4].HeaderText = "Lớp";
            dataGridView1.Columns[5].HeaderText = "Khoa";
            dataGridView1.Columns[6].HeaderText = "Điểm quá trình";
            dataGridView1.Columns[7].HeaderText = "Điểm tổng kết";
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            try
            {
                doanDB DB = new doanDB();
                List<SinhVien> SinhViens = DB.SinhViens.ToList();
                var student = SinhViens.FirstOrDefault(f => f.MaSinhVien == txtID.Text);
                if (student != null)
                {
                    student.DiemQT = int.Parse(txtProcessScore.Text);
                    student.DiemTK = int.Parse(txtFinalScore.Text);
                    DB.SaveChanges();
                    bind();
                    MessageBox.Show("Chỉnh sửa thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sinh viên không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    txtProcessScore.Text = row.Cells[6].Value.ToString();
                    txtFinalScore.Text = row.Cells [7].Value.ToString();
                }
            }
            catch
            {
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                doanDB DB = new doanDB();
                List<SinhVien> SinhViens = DB.SinhViens.ToList();
                var student = SinhViens.FirstOrDefault(f => f.MaSinhVien == txtID.Text);
                if (student != null)
                {
                    student.DiemQT = null;
                    student.DiemTK = null;
                    DB.SaveChanges();
                    bind();
                    MessageBox.Show("Chỉnh sửa thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sinh viên không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteProcessScore_Click(object sender, EventArgs e)
        {
            try
            {
                doanDB DB = new doanDB();
                List<SinhVien> SinhViens = DB.SinhViens.ToList();
                var student = SinhViens.FirstOrDefault(f => f.MaSinhVien == txtID.Text);
                if (student != null)
                {
                    student.DiemQT = null;
                    DB.SaveChanges();
                    bind();
                    MessageBox.Show("Chỉnh sửa thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sinh viên không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteFinalScore_Click(object sender, EventArgs e)
        {
            try
            {
                doanDB DB = new doanDB();
                List<SinhVien> SinhViens = DB.SinhViens.ToList();
                var student = SinhViens.FirstOrDefault(f => f.MaSinhVien == txtID.Text);
                if (student != null)
                {
                    student.DiemTK = null;
                    DB.SaveChanges();
                    bind();
                    MessageBox.Show("Chỉnh sửa thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sinh viên không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
