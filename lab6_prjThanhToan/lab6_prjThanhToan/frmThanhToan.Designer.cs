namespace lab6_prjThanhToan
{
    partial class frmThanhToan
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
            this.tbSoHD = new System.Windows.Forms.TextBox();
            this.lbSoHD = new System.Windows.Forms.Label();
            this.cbSoPhong = new System.Windows.Forms.ComboBox();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTienTT = new System.Windows.Forms.Label();
            this.lbSoCMND = new System.Windows.Forms.Label();
            this.lbSoPhong = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSoCMND = new System.Windows.Forms.TextBox();
            this.tbTienTT = new System.Windows.Forms.TextBox();
            this.lbNgay = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSoHD
            // 
            this.tbSoHD.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbSoHD.Enabled = false;
            this.tbSoHD.Location = new System.Drawing.Point(125, 36);
            this.tbSoHD.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoHD.Name = "tbSoHD";
            this.tbSoHD.Size = new System.Drawing.Size(153, 27);
            this.tbSoHD.TabIndex = 0;
            // 
            // lbSoHD
            // 
            this.lbSoHD.AutoSize = true;
            this.lbSoHD.Location = new System.Drawing.Point(22, 39);
            this.lbSoHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoHD.Name = "lbSoHD";
            this.lbSoHD.Size = new System.Drawing.Size(60, 20);
            this.lbSoHD.TabIndex = 1;
            this.lbSoHD.Text = "Số HD";
            // 
            // cbSoPhong
            // 
            this.cbSoPhong.FormattingEnabled = true;
            this.cbSoPhong.Location = new System.Drawing.Point(395, 134);
            this.cbSoPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cbSoPhong.Name = "cbSoPhong";
            this.cbSoPhong.Size = new System.Drawing.Size(216, 28);
            this.cbSoPhong.TabIndex = 2;
            // 
            // dtNgay
            // 
            this.dtNgay.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgay.Location = new System.Drawing.Point(395, 183);
            this.dtNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(216, 27);
            this.dtNgay.TabIndex = 3;
            this.dtNgay.Value = new System.DateTime(2024, 4, 12, 18, 33, 44, 0);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(199, 248);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(22, 84);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(59, 20);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Họ tên";
            // 
            // lbTienTT
            // 
            this.lbTienTT.AutoSize = true;
            this.lbTienTT.Location = new System.Drawing.Point(22, 183);
            this.lbTienTT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTienTT.Name = "lbTienTT";
            this.lbTienTT.Size = new System.Drawing.Size(86, 20);
            this.lbTienTT.TabIndex = 6;
            this.lbTienTT.Text = "Số tiền TT";
            // 
            // lbSoCMND
            // 
            this.lbSoCMND.AutoSize = true;
            this.lbSoCMND.Location = new System.Drawing.Point(21, 133);
            this.lbSoCMND.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoCMND.Name = "lbSoCMND";
            this.lbSoCMND.Size = new System.Drawing.Size(85, 20);
            this.lbSoCMND.TabIndex = 7;
            this.lbSoCMND.Text = "Số CMND";
            // 
            // lbSoPhong
            // 
            this.lbSoPhong.AutoSize = true;
            this.lbSoPhong.Location = new System.Drawing.Point(306, 136);
            this.lbSoPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoPhong.Name = "lbSoPhong";
            this.lbSoPhong.Size = new System.Drawing.Size(81, 20);
            this.lbSoPhong.TabIndex = 8;
            this.lbSoPhong.Text = "Số Phòng";
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Location = new System.Drawing.Point(125, 82);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(486, 27);
            this.tbName.TabIndex = 9;
            // 
            // tbSoCMND
            // 
            this.tbSoCMND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSoCMND.Location = new System.Drawing.Point(125, 133);
            this.tbSoCMND.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoCMND.Name = "tbSoCMND";
            this.tbSoCMND.Size = new System.Drawing.Size(153, 27);
            this.tbSoCMND.TabIndex = 10;
            // 
            // tbTienTT
            // 
            this.tbTienTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTienTT.Location = new System.Drawing.Point(125, 181);
            this.tbTienTT.Margin = new System.Windows.Forms.Padding(4);
            this.tbTienTT.Name = "tbTienTT";
            this.tbTienTT.Size = new System.Drawing.Size(153, 27);
            this.tbTienTT.TabIndex = 11;
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Location = new System.Drawing.Point(306, 182);
            this.lbNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(47, 20);
            this.lbNgay.TabIndex = 12;
            this.lbNgay.Text = "Ngày";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(338, 248);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(476, 248);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 294);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbNgay);
            this.Controls.Add(this.tbTienTT);
            this.Controls.Add(this.tbSoCMND);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbSoPhong);
            this.Controls.Add(this.lbSoCMND);
            this.Controls.Add(this.lbTienTT);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtNgay);
            this.Controls.Add(this.cbSoPhong);
            this.Controls.Add(this.lbSoHD);
            this.Controls.Add(this.tbSoHD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThanhToan";
            this.Text = "Thanh Toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSoHD;
        private System.Windows.Forms.Label lbSoHD;
        private System.Windows.Forms.ComboBox cbSoPhong;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTienTT;
        private System.Windows.Forms.Label lbSoCMND;
        private System.Windows.Forms.Label lbSoPhong;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSoCMND;
        private System.Windows.Forms.TextBox tbTienTT;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
    }
}

