namespace BTTuan8
{
    partial class FormSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSV));
            txtMaKhoa = new TextBox();
            txtDienThoai = new TextBox();
            txtDiaChi = new TextBox();
            checkBoxGioiTinh = new CheckBox();
            txtNgaySinh = new TextBox();
            txtHoTen = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtMaSo = new TextBox();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            themBtn = new ToolStripButton();
            xoaBtn = new ToolStripButton();
            luuBtn = new ToolStripButton();
            dataGridView1 = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Location = new Point(573, 169);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(195, 27);
            txtMaKhoa.TabIndex = 28;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(573, 136);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(195, 27);
            txtDienThoai.TabIndex = 27;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(573, 103);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(195, 27);
            txtDiaChi.TabIndex = 26;
            // 
            // checkBoxGioiTinh
            // 
            checkBoxGioiTinh.AutoSize = true;
            checkBoxGioiTinh.Location = new Point(206, 199);
            checkBoxGioiTinh.Name = "checkBoxGioiTinh";
            checkBoxGioiTinh.Size = new Size(18, 17);
            checkBoxGioiTinh.TabIndex = 25;
            checkBoxGioiTinh.UseVisualStyleBackColor = true;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(206, 166);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(195, 27);
            txtNgaySinh.TabIndex = 24;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(206, 133);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(195, 27);
            txtHoTen.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(489, 169);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 22;
            label7.Text = "Ma khoa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(489, 136);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 21;
            label6.Text = "Dien thoai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(489, 103);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 20;
            label5.Text = "Dia chi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 199);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 19;
            label4.Text = "Gioi tinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 169);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 18;
            label3.Text = "Ngay Sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 136);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 17;
            label2.Text = "Ho ten";
            // 
            // txtMaSo
            // 
            txtMaSo.Location = new Point(206, 100);
            txtMaSo.Name = "txtMaSo";
            txtMaSo.Size = new Size(195, 27);
            txtMaSo.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 103);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 15;
            label1.Text = "Ma so";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { themBtn, xoaBtn, luuBtn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(886, 27);
            toolStrip1.TabIndex = 30;
            toolStrip1.Text = "toolStrip1";
            // 
            // themBtn
            // 
            themBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            themBtn.Image = (Image)resources.GetObject("themBtn.Image");
            themBtn.ImageTransparentColor = Color.Magenta;
            themBtn.Name = "themBtn";
            themBtn.Size = new Size(29, 24);
            themBtn.Text = "toolStripButton1";
            themBtn.Click += themBtn_Click;
            // 
            // xoaBtn
            // 
            xoaBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            xoaBtn.Image = (Image)resources.GetObject("xoaBtn.Image");
            xoaBtn.ImageTransparentColor = Color.Magenta;
            xoaBtn.Name = "xoaBtn";
            xoaBtn.Size = new Size(29, 24);
            xoaBtn.Text = "toolStripButton2";
            xoaBtn.Click += toolStripButton2_Click;
            // 
            // luuBtn
            // 
            luuBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            luuBtn.Image = (Image)resources.GetObject("luuBtn.Image");
            luuBtn.ImageTransparentColor = Color.Magenta;
            luuBtn.Name = "luuBtn";
            luuBtn.Size = new Size(29, 24);
            luuBtn.Text = "toolStripButton3";
            luuBtn.Click += luuBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(47, 252);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(795, 233);
            dataGridView1.TabIndex = 31;
            dataGridView1.SelectionChanged += DataGridView_SelectionChanged;
            // 
            // FormSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 510);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Controls.Add(txtMaKhoa);
            Controls.Add(txtDienThoai);
            Controls.Add(txtDiaChi);
            Controls.Add(checkBoxGioiTinh);
            Controls.Add(txtNgaySinh);
            Controls.Add(txtHoTen);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMaSo);
            Controls.Add(label1);
            Name = "FormSV";
            Text = "Nhập thông số sinh viên";
            Load += FormSV_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtMaKhoa;
        private TextBox txtDienThoai;
        private TextBox txtDiaChi;
        private CheckBox checkBoxGioiTinh;
        private TextBox txtNgaySinh;
        private TextBox txtHoTen;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtMaSo;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton themBtn;
        private ToolStripButton xoaBtn;
        private ToolStripButton luuBtn;
        private DataGridView dataGridView1;
    }
}