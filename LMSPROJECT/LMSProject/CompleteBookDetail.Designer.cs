namespace LMSProject
{
    partial class CompleteBookDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompleteBookDetail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.circularPicture2 = new LMSProject.CircularPicture();
            this.circularPicture1 = new LMSProject.CircularPicture();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvIssueBooks = new System.Windows.Forms.DataGridView();
            this.stName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bkIssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bkReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvReturnBooks = new System.Windows.Forms.DataGridView();
            this.stNameReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stNumberReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stDepartmentReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stClassReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stContactReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stEmailReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bkNameReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bkIssueDate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bkReturnDate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportIssue = new System.Windows.Forms.Button();
            this.btnExportReturn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.circularPicture2);
            this.panel1.Controls.Add(this.circularPicture1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1465, 81);
            this.panel1.TabIndex = 4;
            // 
            // circularPicture2
            // 
            this.circularPicture2.Dock = System.Windows.Forms.DockStyle.Left;
            this.circularPicture2.Image = ((System.Drawing.Image)(resources.GetObject("circularPicture2.Image")));
            this.circularPicture2.Location = new System.Drawing.Point(0, 0);
            this.circularPicture2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.circularPicture2.Name = "circularPicture2";
            this.circularPicture2.Size = new System.Drawing.Size(113, 81);
            this.circularPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPicture2.TabIndex = 8;
            this.circularPicture2.TabStop = false;
            // 
            // circularPicture1
            // 
            this.circularPicture1.Dock = System.Windows.Forms.DockStyle.Right;
            this.circularPicture1.Image = ((System.Drawing.Image)(resources.GetObject("circularPicture1.Image")));
            this.circularPicture1.Location = new System.Drawing.Point(1374, 0);
            this.circularPicture1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.circularPicture1.Name = "circularPicture1";
            this.circularPicture1.Size = new System.Drawing.Size(91, 81);
            this.circularPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPicture1.TabIndex = 8;
            this.circularPicture1.TabStop = false;
            this.circularPicture1.Click += new System.EventHandler(this.circularPicture1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(535, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(417, 49);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lịch sử sách mượn / trả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(651, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sách đã được mượn";
            // 
            // dgvIssueBooks
            // 
            this.dgvIssueBooks.AllowUserToAddRows = false;
            this.dgvIssueBooks.AllowUserToDeleteRows = false;
            this.dgvIssueBooks.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvIssueBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssueBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stName,
            this.stNumber,
            this.stDepartment,
            this.stClass,
            this.stContact,
            this.stEmail,
            this.bkName,
            this.bkIssueDate,
            this.bkReturnDate});
            this.dgvIssueBooks.Location = new System.Drawing.Point(35, 138);
            this.dgvIssueBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvIssueBooks.Name = "dgvIssueBooks";
            this.dgvIssueBooks.RowHeadersWidth = 51;
            this.dgvIssueBooks.Size = new System.Drawing.Size(1391, 281);
            this.dgvIssueBooks.TabIndex = 9;
            // 
            // stName
            // 
            this.stName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stName.DataPropertyName = "stName";
            this.stName.HeaderText = "Tên sinh viên";
            this.stName.MinimumWidth = 6;
            this.stName.Name = "stName";
            // 
            // stNumber
            // 
            this.stNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stNumber.DataPropertyName = "stNumber";
            this.stNumber.HeaderText = "Mã sinh viên";
            this.stNumber.MinimumWidth = 6;
            this.stNumber.Name = "stNumber";
            // 
            // stDepartment
            // 
            this.stDepartment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stDepartment.DataPropertyName = "stDepartment";
            this.stDepartment.HeaderText = "Khoa";
            this.stDepartment.MinimumWidth = 6;
            this.stDepartment.Name = "stDepartment";
            // 
            // stClass
            // 
            this.stClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stClass.DataPropertyName = "stSemester";
            this.stClass.HeaderText = "Lớp niên chế";
            this.stClass.MinimumWidth = 6;
            this.stClass.Name = "stClass";
            // 
            // stContact
            // 
            this.stContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stContact.DataPropertyName = "stContact";
            this.stContact.HeaderText = "Số điện thoại";
            this.stContact.MinimumWidth = 6;
            this.stContact.Name = "stContact";
            // 
            // stEmail
            // 
            this.stEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stEmail.DataPropertyName = "stEmail";
            this.stEmail.HeaderText = "Email";
            this.stEmail.MinimumWidth = 6;
            this.stEmail.Name = "stEmail";
            // 
            // bkName
            // 
            this.bkName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bkName.DataPropertyName = "bkName";
            this.bkName.HeaderText = "Tên sách";
            this.bkName.MinimumWidth = 6;
            this.bkName.Name = "bkName";
            // 
            // bkIssueDate
            // 
            this.bkIssueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bkIssueDate.DataPropertyName = "bkIssueDate";
            this.bkIssueDate.HeaderText = "Ngày mượn sách";
            this.bkIssueDate.MinimumWidth = 6;
            this.bkIssueDate.Name = "bkIssueDate";
            // 
            // bkReturnDate
            // 
            this.bkReturnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bkReturnDate.DataPropertyName = "bkReturnDate";
            this.bkReturnDate.HeaderText = "Ngày trả sách";
            this.bkReturnDate.MinimumWidth = 6;
            this.bkReturnDate.Name = "bkReturnDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(651, 433);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sách đã được trả";
            // 
            // dgvReturnBooks
            // 
            this.dgvReturnBooks.AllowUserToAddRows = false;
            this.dgvReturnBooks.AllowUserToDeleteRows = false;
            this.dgvReturnBooks.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvReturnBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stNameReturn,
            this.stNumberReturn,
            this.stDepartmentReturn,
            this.stClassReturn,
            this.stContactReturn,
            this.stEmailReturn,
            this.bkNameReturn,
            this.bkIssueDate2,
            this.bkReturnDate2});
            this.dgvReturnBooks.Location = new System.Drawing.Point(35, 469);
            this.dgvReturnBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvReturnBooks.Name = "dgvReturnBooks";
            this.dgvReturnBooks.RowHeadersWidth = 51;
            this.dgvReturnBooks.Size = new System.Drawing.Size(1391, 286);
            this.dgvReturnBooks.TabIndex = 11;
            // 
            // stNameReturn
            // 
            this.stNameReturn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stNameReturn.DataPropertyName = "stName";
            this.stNameReturn.HeaderText = "Tên sinh viên";
            this.stNameReturn.MinimumWidth = 6;
            this.stNameReturn.Name = "stNameReturn";
            // 
            // stNumberReturn
            // 
            this.stNumberReturn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stNumberReturn.DataPropertyName = "stNumber";
            this.stNumberReturn.HeaderText = "Mã sinh viên";
            this.stNumberReturn.MinimumWidth = 6;
            this.stNumberReturn.Name = "stNumberReturn";
            // 
            // stDepartmentReturn
            // 
            this.stDepartmentReturn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stDepartmentReturn.DataPropertyName = "stDepartment";
            this.stDepartmentReturn.HeaderText = "Khoa";
            this.stDepartmentReturn.MinimumWidth = 6;
            this.stDepartmentReturn.Name = "stDepartmentReturn";
            // 
            // stClassReturn
            // 
            this.stClassReturn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stClassReturn.DataPropertyName = "stSemester";
            this.stClassReturn.HeaderText = "Lớp niên chế";
            this.stClassReturn.MinimumWidth = 6;
            this.stClassReturn.Name = "stClassReturn";
            // 
            // stContactReturn
            // 
            this.stContactReturn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stContactReturn.DataPropertyName = "stContact";
            this.stContactReturn.HeaderText = "Số điện thoại";
            this.stContactReturn.MinimumWidth = 6;
            this.stContactReturn.Name = "stContactReturn";
            // 
            // stEmailReturn
            // 
            this.stEmailReturn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stEmailReturn.DataPropertyName = "stEmail";
            this.stEmailReturn.HeaderText = "Email";
            this.stEmailReturn.MinimumWidth = 6;
            this.stEmailReturn.Name = "stEmailReturn";
            // 
            // bkNameReturn
            // 
            this.bkNameReturn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bkNameReturn.DataPropertyName = "bkName";
            this.bkNameReturn.HeaderText = "Tên sách";
            this.bkNameReturn.MinimumWidth = 6;
            this.bkNameReturn.Name = "bkNameReturn";
            // 
            // bkIssueDate2
            // 
            this.bkIssueDate2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bkIssueDate2.DataPropertyName = "bkIssueDate";
            this.bkIssueDate2.HeaderText = "Ngày mượn sách";
            this.bkIssueDate2.MinimumWidth = 6;
            this.bkIssueDate2.Name = "bkIssueDate2";
            // 
            // bkReturnDate2
            // 
            this.bkReturnDate2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bkReturnDate2.DataPropertyName = "bkReturnDate";
            this.bkReturnDate2.HeaderText = "Ngày trả sách";
            this.bkReturnDate2.MinimumWidth = 6;
            this.bkReturnDate2.Name = "bkReturnDate2";
            // 
            // btnExportIssue
            // 
            this.btnExportIssue.BackColor = System.Drawing.Color.Lime;
            this.btnExportIssue.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportIssue.Location = new System.Drawing.Point(960, 94);
            this.btnExportIssue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportIssue.Name = "btnExportIssue";
            this.btnExportIssue.Size = new System.Drawing.Size(163, 41);
            this.btnExportIssue.TabIndex = 13;
            this.btnExportIssue.Text = "Xuất Excel";
            this.btnExportIssue.UseVisualStyleBackColor = false;
            this.btnExportIssue.Click += new System.EventHandler(this.btnExportIssue_Click);
            // 
            // btnExportReturn
            // 
            this.btnExportReturn.BackColor = System.Drawing.Color.Lime;
            this.btnExportReturn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportReturn.Location = new System.Drawing.Point(960, 425);
            this.btnExportReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportReturn.Name = "btnExportReturn";
            this.btnExportReturn.Size = new System.Drawing.Size(163, 41);
            this.btnExportReturn.TabIndex = 14;
            this.btnExportReturn.Text = "Xuất Excel";
            this.btnExportReturn.UseVisualStyleBackColor = false;
            this.btnExportReturn.Click += new System.EventHandler(this.btnExportReturn_Click);
            // 
            // CompleteBookDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1465, 769);
            this.Controls.Add(this.btnExportReturn);
            this.Controls.Add(this.btnExportIssue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIssueBooks);
            this.Controls.Add(this.dgvReturnBooks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CompleteBookDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompleteBookDetail";
            this.Load += new System.EventHandler(this.CompleteBookDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CircularPicture circularPicture2;
        private CircularPicture circularPicture1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvIssueBooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvReturnBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn stName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn stDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn stClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn stContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn stEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkIssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn stNameReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stNumberReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stDepartmentReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stClassReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stContactReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stEmailReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkNameReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkIssueDate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkReturnDate2;
        private System.Windows.Forms.Button btnExportIssue;
        private System.Windows.Forms.Button btnExportReturn;
    }
}