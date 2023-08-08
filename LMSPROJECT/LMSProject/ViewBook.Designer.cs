namespace LMSProject
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.btnRefreshbkname = new FlatButton.JFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bkAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bkPublication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bkDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bkPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bkQuanity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtbkDate = new System.Windows.Forms.TextBox();
            this.btnBkInfosRefresh = new FlatButton.JFlatButton();
            this.btnBkDelete = new FlatButton.JFlatButton();
            this.btnBkInfosUpdate = new FlatButton.JFlatButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtbkQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtbkPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtbkPublication = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbkAuthor = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtbkName = new System.Windows.Forms.TextBox();
            this.circularPicture2 = new LMSProject.CircularPicture();
            this.circularPicture1 = new LMSProject.CircularPicture();
            this.circularPicture3 = new LMSProject.CircularPicture();
            this.btnExportExcel = new FlatButton.JFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.circularPicture2);
            this.panel1.Controls.Add(this.circularPicture1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 84);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(320, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 49);
            this.label2.TabIndex = 6;
            this.label2.Text = "Danh sách ấn phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(233, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên Sách";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel4.Location = new System.Drawing.Point(393, 267);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(208, 2);
            this.panel4.TabIndex = 13;
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBookName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtBookName.Location = new System.Drawing.Point(393, 229);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(207, 36);
            this.txtBookName.TabIndex = 12;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // btnRefreshbkname
            // 
            this.btnRefreshbkname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefreshbkname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btnRefreshbkname.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btnRefreshbkname.ButtonText = "Làm mới";
            this.btnRefreshbkname.CausesValidation = false;
            this.btnRefreshbkname.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnRefreshbkname.ErrorImageLeft")));
            this.btnRefreshbkname.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnRefreshbkname.ErrorImageRight")));
            this.btnRefreshbkname.FocusBackground = System.Drawing.Color.Empty;
            this.btnRefreshbkname.FocusFontColor = System.Drawing.Color.Empty;
            this.btnRefreshbkname.ForeColors = System.Drawing.Color.White;
            this.btnRefreshbkname.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.btnRefreshbkname.HoverFontColor = System.Drawing.Color.White;
            this.btnRefreshbkname.ImageLeft = null;
            this.btnRefreshbkname.ImageRight = null;
            this.btnRefreshbkname.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnRefreshbkname.Location = new System.Drawing.Point(653, 229);
            this.btnRefreshbkname.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefreshbkname.Name = "btnRefreshbkname";
            this.btnRefreshbkname.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnRefreshbkname.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnRefreshbkname.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnRefreshbkname.Size = new System.Drawing.Size(144, 39);
            this.btnRefreshbkname.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnRefreshbkname.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnRefreshbkname.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookID,
            this.bkName,
            this.bkAuthor,
            this.bkPublication,
            this.bkDate,
            this.bkPrice,
            this.bkQuanity});
            this.dataGridView1.Location = new System.Drawing.Point(53, 290);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(920, 254);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // bookID
            // 
            this.bookID.DataPropertyName = "bkId";
            this.bookID.HeaderText = "Mã sách";
            this.bookID.MinimumWidth = 6;
            this.bookID.Name = "bookID";
            this.bookID.ReadOnly = true;
            this.bookID.Width = 125;
            // 
            // bkName
            // 
            this.bkName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.bkName.DataPropertyName = "bkName";
            this.bkName.HeaderText = "Tên sách";
            this.bkName.MinimumWidth = 6;
            this.bkName.Name = "bkName";
            this.bkName.ReadOnly = true;
            this.bkName.Width = 145;
            // 
            // bkAuthor
            // 
            this.bkAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.bkAuthor.DataPropertyName = "bkAuthor";
            this.bkAuthor.HeaderText = "Tên TG";
            this.bkAuthor.MinimumWidth = 6;
            this.bkAuthor.Name = "bkAuthor";
            this.bkAuthor.ReadOnly = true;
            this.bkAuthor.Width = 144;
            // 
            // bkPublication
            // 
            this.bkPublication.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.bkPublication.DataPropertyName = "bkPublication";
            this.bkPublication.HeaderText = "NXB";
            this.bkPublication.MinimumWidth = 6;
            this.bkPublication.Name = "bkPublication";
            this.bkPublication.ReadOnly = true;
            this.bkPublication.Width = 145;
            // 
            // bkDate
            // 
            this.bkDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.bkDate.DataPropertyName = "bkDate";
            this.bkDate.HeaderText = "Ngày nhập";
            this.bkDate.MinimumWidth = 6;
            this.bkDate.Name = "bkDate";
            this.bkDate.ReadOnly = true;
            this.bkDate.Width = 144;
            // 
            // bkPrice
            // 
            this.bkPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.bkPrice.DataPropertyName = "bkPrice";
            this.bkPrice.HeaderText = "Đơn giá";
            this.bkPrice.MinimumWidth = 6;
            this.bkPrice.Name = "bkPrice";
            this.bkPrice.ReadOnly = true;
            this.bkPrice.Width = 145;
            // 
            // bkQuanity
            // 
            this.bkQuanity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.bkQuanity.DataPropertyName = "bkQuanity";
            this.bkQuanity.HeaderText = "Số lượng";
            this.bkQuanity.MinimumWidth = 6;
            this.bkQuanity.Name = "bkQuanity";
            this.bkQuanity.ReadOnly = true;
            this.bkQuanity.Width = 144;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel5.Controls.Add(this.txtbkDate);
            this.panel5.Controls.Add(this.btnBkInfosRefresh);
            this.panel5.Controls.Add(this.btnBkDelete);
            this.panel5.Controls.Add(this.btnBkInfosUpdate);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.txtbkQuantity);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.txtbkPrice);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.panel11);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.txtbkPublication);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtbkAuthor);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.txtbkName);
            this.panel5.Location = new System.Drawing.Point(53, 576);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(920, 292);
            this.panel5.TabIndex = 16;
            // 
            // txtbkDate
            // 
            this.txtbkDate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtbkDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbkDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtbkDate.Location = new System.Drawing.Point(677, 33);
            this.txtbkDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtbkDate.Name = "txtbkDate";
            this.txtbkDate.Size = new System.Drawing.Size(207, 27);
            this.txtbkDate.TabIndex = 32;
            // 
            // btnBkInfosRefresh
            // 
            this.btnBkInfosRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBkInfosRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btnBkInfosRefresh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btnBkInfosRefresh.ButtonText = "Làm mới";
            this.btnBkInfosRefresh.CausesValidation = false;
            this.btnBkInfosRefresh.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnBkInfosRefresh.ErrorImageLeft")));
            this.btnBkInfosRefresh.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnBkInfosRefresh.ErrorImageRight")));
            this.btnBkInfosRefresh.FocusBackground = System.Drawing.Color.Empty;
            this.btnBkInfosRefresh.FocusFontColor = System.Drawing.Color.Empty;
            this.btnBkInfosRefresh.ForeColors = System.Drawing.Color.White;
            this.btnBkInfosRefresh.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.btnBkInfosRefresh.HoverFontColor = System.Drawing.Color.White;
            this.btnBkInfosRefresh.ImageLeft = null;
            this.btnBkInfosRefresh.ImageRight = null;
            this.btnBkInfosRefresh.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnBkInfosRefresh.Location = new System.Drawing.Point(775, 224);
            this.btnBkInfosRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.btnBkInfosRefresh.Name = "btnBkInfosRefresh";
            this.btnBkInfosRefresh.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnBkInfosRefresh.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnBkInfosRefresh.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnBkInfosRefresh.Size = new System.Drawing.Size(120, 46);
            this.btnBkInfosRefresh.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnBkInfosRefresh.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBkInfosRefresh.TabIndex = 31;
            this.btnBkInfosRefresh.Click += new System.EventHandler(this.btnBkInfosRefresh_Click);
            // 
            // btnBkDelete
            // 
            this.btnBkDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBkDelete.BackColor = System.Drawing.Color.Red;
            this.btnBkDelete.BackgroundColor = System.Drawing.Color.Red;
            this.btnBkDelete.ButtonText = "Xoá";
            this.btnBkDelete.CausesValidation = false;
            this.btnBkDelete.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnBkDelete.ErrorImageLeft")));
            this.btnBkDelete.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnBkDelete.ErrorImageRight")));
            this.btnBkDelete.FocusBackground = System.Drawing.Color.Empty;
            this.btnBkDelete.FocusFontColor = System.Drawing.Color.Empty;
            this.btnBkDelete.ForeColors = System.Drawing.Color.White;
            this.btnBkDelete.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.btnBkDelete.HoverFontColor = System.Drawing.Color.White;
            this.btnBkDelete.ImageLeft = null;
            this.btnBkDelete.ImageRight = null;
            this.btnBkDelete.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnBkDelete.Location = new System.Drawing.Point(624, 224);
            this.btnBkDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnBkDelete.Name = "btnBkDelete";
            this.btnBkDelete.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnBkDelete.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnBkDelete.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnBkDelete.Size = new System.Drawing.Size(120, 46);
            this.btnBkDelete.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnBkDelete.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBkDelete.TabIndex = 31;
            this.btnBkDelete.Click += new System.EventHandler(this.btnBkDelete_Click);
            // 
            // btnBkInfosUpdate
            // 
            this.btnBkInfosUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBkInfosUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBkInfosUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBkInfosUpdate.ButtonText = "Cập Nhật";
            this.btnBkInfosUpdate.CausesValidation = false;
            this.btnBkInfosUpdate.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnBkInfosUpdate.ErrorImageLeft")));
            this.btnBkInfosUpdate.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnBkInfosUpdate.ErrorImageRight")));
            this.btnBkInfosUpdate.FocusBackground = System.Drawing.Color.Empty;
            this.btnBkInfosUpdate.FocusFontColor = System.Drawing.Color.Empty;
            this.btnBkInfosUpdate.ForeColors = System.Drawing.Color.White;
            this.btnBkInfosUpdate.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.btnBkInfosUpdate.HoverFontColor = System.Drawing.Color.White;
            this.btnBkInfosUpdate.ImageLeft = null;
            this.btnBkInfosUpdate.ImageRight = null;
            this.btnBkInfosUpdate.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnBkInfosUpdate.Location = new System.Drawing.Point(477, 224);
            this.btnBkInfosUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnBkInfosUpdate.Name = "btnBkInfosUpdate";
            this.btnBkInfosUpdate.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnBkInfosUpdate.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnBkInfosUpdate.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnBkInfosUpdate.Size = new System.Drawing.Size(120, 46);
            this.btnBkInfosUpdate.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnBkInfosUpdate.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBkInfosUpdate.TabIndex = 31;
            this.btnBkInfosUpdate.Click += new System.EventHandler(this.btnBkInfosUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(477, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 28);
            this.label7.TabIndex = 29;
            this.label7.Text = "Số lượng";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel9.Location = new System.Drawing.Point(677, 183);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(208, 2);
            this.panel9.TabIndex = 28;
            // 
            // txtbkQuantity
            // 
            this.txtbkQuantity.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtbkQuantity.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbkQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtbkQuantity.Location = new System.Drawing.Point(677, 156);
            this.txtbkQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtbkQuantity.Name = "txtbkQuantity";
            this.txtbkQuantity.Size = new System.Drawing.Size(207, 27);
            this.txtbkQuantity.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(477, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 28);
            this.label8.TabIndex = 26;
            this.label8.Text = "Giá Sách";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel10.Location = new System.Drawing.Point(677, 123);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(208, 2);
            this.panel10.TabIndex = 25;
            // 
            // txtbkPrice
            // 
            this.txtbkPrice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtbkPrice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbkPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtbkPrice.Location = new System.Drawing.Point(677, 96);
            this.txtbkPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtbkPrice.Name = "txtbkPrice";
            this.txtbkPrice.Size = new System.Drawing.Size(207, 27);
            this.txtbkPrice.TabIndex = 24;
            this.txtbkPrice.TextChanged += new System.EventHandler(this.txtbkPrice_TxtChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label9.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(477, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 28);
            this.label9.TabIndex = 23;
            this.label9.Text = "Ngày Nhập Sách";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel11.Location = new System.Drawing.Point(677, 62);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(208, 2);
            this.panel11.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nhà Xuất Bản";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel6.Location = new System.Drawing.Point(224, 182);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(208, 2);
            this.panel6.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(51, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 28);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tên Tác Giả";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel7.Location = new System.Drawing.Point(224, 122);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(208, 2);
            this.panel7.TabIndex = 17;
            // 
            // txtbkPublication
            // 
            this.txtbkPublication.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtbkPublication.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbkPublication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtbkPublication.Location = new System.Drawing.Point(224, 155);
            this.txtbkPublication.Margin = new System.Windows.Forms.Padding(4);
            this.txtbkPublication.Name = "txtbkPublication";
            this.txtbkPublication.Size = new System.Drawing.Size(207, 27);
            this.txtbkPublication.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(51, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 28);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tên Sách";
            // 
            // txtbkAuthor
            // 
            this.txtbkAuthor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtbkAuthor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbkAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtbkAuthor.Location = new System.Drawing.Point(224, 95);
            this.txtbkAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtbkAuthor.Name = "txtbkAuthor";
            this.txtbkAuthor.Size = new System.Drawing.Size(207, 27);
            this.txtbkAuthor.TabIndex = 14;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel8.Location = new System.Drawing.Point(224, 65);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(208, 2);
            this.panel8.TabIndex = 18;
            // 
            // txtbkName
            // 
            this.txtbkName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtbkName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbkName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtbkName.Location = new System.Drawing.Point(224, 38);
            this.txtbkName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbkName.Name = "txtbkName";
            this.txtbkName.Size = new System.Drawing.Size(207, 27);
            this.txtbkName.TabIndex = 15;
            // 
            // circularPicture2
            // 
            this.circularPicture2.Dock = System.Windows.Forms.DockStyle.Left;
            this.circularPicture2.Image = ((System.Drawing.Image)(resources.GetObject("circularPicture2.Image")));
            this.circularPicture2.Location = new System.Drawing.Point(0, 0);
            this.circularPicture2.Margin = new System.Windows.Forms.Padding(4);
            this.circularPicture2.Name = "circularPicture2";
            this.circularPicture2.Size = new System.Drawing.Size(101, 84);
            this.circularPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPicture2.TabIndex = 8;
            this.circularPicture2.TabStop = false;
            // 
            // circularPicture1
            // 
            this.circularPicture1.Dock = System.Windows.Forms.DockStyle.Right;
            this.circularPicture1.Image = ((System.Drawing.Image)(resources.GetObject("circularPicture1.Image")));
            this.circularPicture1.Location = new System.Drawing.Point(930, 0);
            this.circularPicture1.Margin = new System.Windows.Forms.Padding(4);
            this.circularPicture1.Name = "circularPicture1";
            this.circularPicture1.Size = new System.Drawing.Size(83, 84);
            this.circularPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circularPicture1.TabIndex = 8;
            this.circularPicture1.TabStop = false;
            this.circularPicture1.Click += new System.EventHandler(this.circularPicture1_Click);
            // 
            // circularPicture3
            // 
            this.circularPicture3.Image = ((System.Drawing.Image)(resources.GetObject("circularPicture3.Image")));
            this.circularPicture3.Location = new System.Drawing.Point(424, 84);
            this.circularPicture3.Margin = new System.Windows.Forms.Padding(4);
            this.circularPicture3.Name = "circularPicture3";
            this.circularPicture3.Size = new System.Drawing.Size(191, 139);
            this.circularPicture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPicture3.TabIndex = 5;
            this.circularPicture3.TabStop = false;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExportExcel.BackColor = System.Drawing.Color.Lime;
            this.btnExportExcel.BackgroundColor = System.Drawing.Color.Lime;
            this.btnExportExcel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnExportExcel.ButtonText = "Xuất Excel";
            this.btnExportExcel.CausesValidation = false;
            this.btnExportExcel.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.ErrorImageLeft")));
            this.btnExportExcel.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.ErrorImageRight")));
            this.btnExportExcel.FocusBackground = System.Drawing.Color.Empty;
            this.btnExportExcel.FocusFontColor = System.Drawing.Color.Empty;
            this.btnExportExcel.ForeColors = System.Drawing.Color.White;
            this.btnExportExcel.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.btnExportExcel.HoverFontColor = System.Drawing.Color.White;
            this.btnExportExcel.ImageLeft = null;
            this.btnExportExcel.ImageRight = null;
            this.btnExportExcel.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.Location = new System.Drawing.Point(829, 229);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(5);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnExportExcel.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnExportExcel.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.Size = new System.Drawing.Size(133, 39);
            this.btnExportExcel.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnExportExcel.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnExportExcel.TabIndex = 17;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 900);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRefreshbkname);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.circularPicture3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBook";
            this.Load += new System.EventHandler(this.ViewBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CircularPicture circularPicture2;
        private CircularPicture circularPicture1;
        private CircularPicture circularPicture3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtBookName;
        private FlatButton.JFlatButton btnRefreshbkname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtbkPublication;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbkAuthor;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtbkName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtbkQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtbkPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel11;
        private FlatButton.JFlatButton btnBkInfosRefresh;
        private FlatButton.JFlatButton btnBkDelete;
        private FlatButton.JFlatButton btnBkInfosUpdate;
        private System.Windows.Forms.TextBox txtbkDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkPublication;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkQuanity;
        private FlatButton.JFlatButton btnExportExcel;
    }
}