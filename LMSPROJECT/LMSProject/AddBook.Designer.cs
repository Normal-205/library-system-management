using System.Windows.Forms;

namespace LMSProject
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.circularPicture2 = new LMSProject.CircularPicture();
            this.exitButton = new LMSProject.CircularPicture();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBookCancel = new FlatButton.JFlatButton();
            this.btnSaveBook = new FlatButton.JFlatButton();
            this.bkPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtbkQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtbkPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtbkPublication = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbkAuthor = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtbkName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.circularPicture2);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 64);
            this.panel1.TabIndex = 3;
            // 
            // circularPicture2
            // 
            this.circularPicture2.Image = ((System.Drawing.Image)(resources.GetObject("circularPicture2.Image")));
            this.circularPicture2.Location = new System.Drawing.Point(3, 3);
            this.circularPicture2.Name = "circularPicture2";
            this.circularPicture2.Size = new System.Drawing.Size(72, 58);
            this.circularPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPicture2.TabIndex = 8;
            this.circularPicture2.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(677, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(60, 58);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitButton.TabIndex = 8;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(284, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thêm sách mới";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Controls.Add(this.btnBookCancel);
            this.panel5.Controls.Add(this.btnSaveBook);
            this.panel5.Controls.Add(this.bkPurchaseDate);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.txtbkQuantity);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.txtbkPrice);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.panel11);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.txtbkPublication);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtbkAuthor);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.txtbkName);
            this.panel5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel5.Location = new System.Drawing.Point(34, 201);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(680, 281);
            this.panel5.TabIndex = 17;
            // 
            // btnBookCancel
            // 
            this.btnBookCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBookCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBookCancel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnBookCancel.ButtonText = "Làm mới";
            this.btnBookCancel.CausesValidation = false;
            this.btnBookCancel.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnBookCancel.ErrorImageLeft")));
            this.btnBookCancel.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnBookCancel.ErrorImageRight")));
            this.btnBookCancel.FocusBackground = System.Drawing.Color.Empty;
            this.btnBookCancel.FocusFontColor = System.Drawing.Color.Empty;
            this.btnBookCancel.ForeColors = System.Drawing.Color.White;
            this.btnBookCancel.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.btnBookCancel.HoverFontColor = System.Drawing.Color.White;
            this.btnBookCancel.ImageLeft = null;
            this.btnBookCancel.ImageRight = null;
            this.btnBookCancel.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnBookCancel.Location = new System.Drawing.Point(568, 214);
            this.btnBookCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnBookCancel.Name = "btnBookCancel";
            this.btnBookCancel.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnBookCancel.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnBookCancel.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnBookCancel.Size = new System.Drawing.Size(96, 52);
            this.btnBookCancel.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnBookCancel.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBookCancel.TabIndex = 31;
            this.btnBookCancel.Click += new System.EventHandler(this.btnBookCancel_Click);
            // 
            // btnSaveBook
            // 
            this.btnSaveBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btnSaveBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btnSaveBook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnSaveBook.ButtonText = "Lưu";
            this.btnSaveBook.CausesValidation = false;
            this.btnSaveBook.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnSaveBook.ErrorImageLeft")));
            this.btnSaveBook.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnSaveBook.ErrorImageRight")));
            this.btnSaveBook.FocusBackground = System.Drawing.Color.Empty;
            this.btnSaveBook.FocusFontColor = System.Drawing.Color.Empty;
            this.btnSaveBook.ForeColors = System.Drawing.Color.White;
            this.btnSaveBook.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.btnSaveBook.HoverFontColor = System.Drawing.Color.White;
            this.btnSaveBook.ImageLeft = null;
            this.btnSaveBook.ImageRight = null;
            this.btnSaveBook.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnSaveBook.Location = new System.Drawing.Point(457, 214);
            this.btnSaveBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveBook.Name = "btnSaveBook";
            this.btnSaveBook.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnSaveBook.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnSaveBook.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnSaveBook.Size = new System.Drawing.Size(96, 52);
            this.btnSaveBook.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnSaveBook.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSaveBook.TabIndex = 31;
            this.btnSaveBook.Click += new System.EventHandler(this.btnSaveBook_Click);
            // 
            // bkPurchaseDate
            // 
            this.bkPurchaseDate.CustomFormat = "dd/MM/yyyy";
            this.bkPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bkPurchaseDate.Location = new System.Drawing.Point(510, 29);
            this.bkPurchaseDate.Name = "bkPurchaseDate";
            this.bkPurchaseDate.Size = new System.Drawing.Size(122, 21);
            this.bkPurchaseDate.TabIndex = 30;
            this.bkPurchaseDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(332, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "Số lượng";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel9.Location = new System.Drawing.Point(510, 147);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(124, 2);
            this.panel9.TabIndex = 28;
            // 
            // txtbkQuantity
            // 
            this.txtbkQuantity.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtbkQuantity.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbkQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtbkQuantity.Location = new System.Drawing.Point(510, 127);
            this.txtbkQuantity.Name = "txtbkQuantity";
            this.txtbkQuantity.Size = new System.Drawing.Size(122, 23);
            this.txtbkQuantity.TabIndex = 27;
            this.txtbkQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bkQuantity_Keypress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(332, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "Giá Sách";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel10.Location = new System.Drawing.Point(510, 100);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(124, 2);
            this.panel10.TabIndex = 25;
            // 
            // txtbkPrice
            // 
            this.txtbkPrice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtbkPrice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbkPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtbkPrice.Location = new System.Drawing.Point(510, 78);
            this.txtbkPrice.Name = "txtbkPrice";
            this.txtbkPrice.Size = new System.Drawing.Size(122, 23);
            this.txtbkPrice.TabIndex = 24;
            this.txtbkPrice.TextChanged += new System.EventHandler(this.txtbkPrice_TextChanged);
            this.txtbkPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bkPrice_Keypress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label9.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(332, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "Ngày Nhập Sách";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel11.Location = new System.Drawing.Point(510, 51);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(124, 2);
            this.panel11.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nhà Xuất Bản";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel6.Location = new System.Drawing.Point(173, 149);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(110, 2);
            this.panel6.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tên Tác Giả";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel7.Location = new System.Drawing.Point(173, 100);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(110, 2);
            this.panel7.TabIndex = 17;
            // 
            // txtbkPublication
            // 
            this.txtbkPublication.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtbkPublication.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbkPublication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtbkPublication.Location = new System.Drawing.Point(173, 127);
            this.txtbkPublication.Name = "txtbkPublication";
            this.txtbkPublication.Size = new System.Drawing.Size(108, 23);
            this.txtbkPublication.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tên Sách";
            // 
            // txtbkAuthor
            // 
            this.txtbkAuthor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtbkAuthor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbkAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtbkAuthor.Location = new System.Drawing.Point(173, 78);
            this.txtbkAuthor.Name = "txtbkAuthor";
            this.txtbkAuthor.Size = new System.Drawing.Size(108, 23);
            this.txtbkAuthor.TabIndex = 14;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel8.Location = new System.Drawing.Point(173, 54);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(110, 2);
            this.panel8.TabIndex = 18;
            // 
            // txtbkName
            // 
            this.txtbkName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtbkName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbkName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtbkName.Location = new System.Drawing.Point(173, 32);
            this.txtbkName.Name = "txtbkName";
            this.txtbkName.Size = new System.Drawing.Size(108, 23);
            this.txtbkName.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(306, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(739, 494);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBook";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private CircularPicture exitButton;
        private CircularPicture circularPicture2;
        private System.Windows.Forms.Panel panel5;
        private FlatButton.JFlatButton btnBookCancel;
        private FlatButton.JFlatButton btnSaveBook;
        private System.Windows.Forms.DateTimePicker bkPurchaseDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtbkQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtbkPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtbkPublication;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbkAuthor;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtbkName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}