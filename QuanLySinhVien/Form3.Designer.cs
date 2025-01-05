namespace QuanLySinhVien
{
    partial class formTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteFinalScore = new System.Windows.Forms.Button();
            this.btnDeleteProcessScore = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProcessScore = new System.Windows.Forms.TextBox();
            this.txtFinalScore = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnAddEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(478, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(773, 417);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteFinalScore);
            this.groupBox1.Controls.Add(this.btnDeleteProcessScore);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtProcessScore);
            this.groupBox1.Controls.Add(this.txtFinalScore);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 279);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên để  chỉnh sửa điểm";
            // 
            // btnDeleteFinalScore
            // 
            this.btnDeleteFinalScore.Location = new System.Drawing.Point(246, 238);
            this.btnDeleteFinalScore.Name = "btnDeleteFinalScore";
            this.btnDeleteFinalScore.Size = new System.Drawing.Size(172, 26);
            this.btnDeleteFinalScore.TabIndex = 5;
            this.btnDeleteFinalScore.Text = "Xóa điểm Điểm tổng kết";
            this.btnDeleteFinalScore.UseVisualStyleBackColor = true;
            this.btnDeleteFinalScore.Click += new System.EventHandler(this.btnDeleteFinalScore_Click);
            // 
            // btnDeleteProcessScore
            // 
            this.btnDeleteProcessScore.Location = new System.Drawing.Point(246, 166);
            this.btnDeleteProcessScore.Name = "btnDeleteProcessScore";
            this.btnDeleteProcessScore.Size = new System.Drawing.Size(172, 26);
            this.btnDeleteProcessScore.TabIndex = 4;
            this.btnDeleteProcessScore.Text = "Xóa điểm Điểm quá trình";
            this.btnDeleteProcessScore.UseVisualStyleBackColor = true;
            this.btnDeleteProcessScore.Click += new System.EventHandler(this.btnDeleteProcessScore_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Điểm tổng kết:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Điểm quá trình:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã học sinh:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProcessScore
            // 
            this.txtProcessScore.Location = new System.Drawing.Point(141, 138);
            this.txtProcessScore.Name = "txtProcessScore";
            this.txtProcessScore.Size = new System.Drawing.Size(287, 22);
            this.txtProcessScore.TabIndex = 2;
            // 
            // txtFinalScore
            // 
            this.txtFinalScore.Location = new System.Drawing.Point(141, 210);
            this.txtFinalScore.Name = "txtFinalScore";
            this.txtFinalScore.Size = new System.Drawing.Size(287, 22);
            this.txtFinalScore.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(141, 56);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(287, 22);
            this.txtID.TabIndex = 0;
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.Location = new System.Drawing.Point(109, 354);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.Size = new System.Drawing.Size(122, 23);
            this.btnAddEdit.TabIndex = 2;
            this.btnAddEdit.Text = "Thêm/Sửa điểm";
            this.btnAddEdit.UseVisualStyleBackColor = true;
            this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(306, 354);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa điểm";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // formTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 441);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "formTeacher";
            this.Text = "Giáo viên";
            this.Load += new System.EventHandler(this.formTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProcessScore;
        private System.Windows.Forms.TextBox txtFinalScore;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteFinalScore;
        private System.Windows.Forms.Button btnDeleteProcessScore;
    }
}