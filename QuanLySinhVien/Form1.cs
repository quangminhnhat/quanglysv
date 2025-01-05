using QuanLySinhVien.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doanDB dB = new doanDB();
            List<LOAITTAIKHOAN> lOAITTAIKHOANs = dB.LOAITTAIKHOANs.ToList();
            cmbaccountype.DataSource = lOAITTAIKHOANs;
            cmbaccountype.DisplayMember = "TenTK";
            cmbaccountype.ValueMember = "MaTK";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                doanDB dB = new doanDB();
                List<TAIKHOAN> ts = dB.TAIKHOANs.ToList();  
                var find = ts.FirstOrDefault(f => f.TEN == txtName.Text);
                if (find != null && find.MK == txtpass.Text)
                {
                    if (find.MaTK != cmbaccountype.SelectedValue.ToString())
                    {
                        MessageBox.Show("loai tài khoản sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (cmbaccountype.SelectedValue.ToString() == "TK001")
                    {
                        FormEmployee formEmployee = new FormEmployee();
                        formEmployee.FormClosed += (s, args) => Show();
                        formEmployee.Show();
                        Hide();
                    }
                    if (cmbaccountype.SelectedValue.ToString() == "TK002")
                    {
                        formTeacher formTeacher = new formTeacher();
                        formTeacher.FormClosed += (s, args) => Show();
                        formTeacher.Show();
                        Hide();
                    }
                }
                else
                {
                    MessageBox.Show("tên hoặc mật khẩu tài khoản sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"error: {ex}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
