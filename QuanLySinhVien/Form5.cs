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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                bind();
                doanDB doanDB = new doanDB();
                List<LOAITTAIKHOAN> lOAITTAIKHOANs = doanDB.LOAITTAIKHOANs.ToList();
                cmbAccountType.DataSource = lOAITTAIKHOANs;
                cmbAccountType.DisplayMember = "TenTK";
                cmbAccountType.ValueMember = "MaTK";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error: {ex}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bind()
        {
            doanDB doanDB = new doanDB();
            var values = doanDB.TAIKHOANs.Select(tk => new
            {
                tk.TEN,
                tk.MK,
                tk.LOAITTAIKHOAN.TenTK
            }).ToList();
            dataGridView1.DataSource = values;
            dataGridView1.Columns[0].HeaderText = "Tên tài khoản";
            dataGridView1.Columns[1].HeaderText = "mật khẩu";
            dataGridView1.Columns[2].HeaderText = "loại tài khoản";
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            try
            {
                doanDB dB = new doanDB();
                var tAIKHOAN = new TAIKHOAN
                {
                    TEN = txtName.Text,
                    MK = txtPassword.Text,
                    MaTK = cmbAccountType.SelectedValue.ToString()
                };
                dB.TAIKHOANs.AddOrUpdate(tAIKHOAN);
                dB.SaveChanges();
                bind();
                MessageBox.Show("Thêm thông tin thành công", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                List<TAIKHOAN> tAIKHOANs = DB.TAIKHOANs.ToList();
                var find = tAIKHOANs.FirstOrDefault(f => f.TEN == txtName.Text);
                if (find != null)
                {
                    DB.TAIKHOANs.Remove(find);
                    DB.SaveChanges();
                    bind();
                    MessageBox.Show("Tài khoản đã được xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tài khoản không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting data:{ex}", "error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txtName.Text = row.Cells[0].Value.ToString();
                    txtPassword.Text = row.Cells[1].Value.ToString();
                    cmbAccountType.Text = row.Cells[2].Value.ToString();
                }
            }
            catch
            {
                return;
            }
        }
    }
}
