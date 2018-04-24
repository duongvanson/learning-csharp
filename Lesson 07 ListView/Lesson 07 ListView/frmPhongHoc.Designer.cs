namespace Lesson_07_ListView
{
    partial class frmPhongHoc
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
            this.lvPhongHoc = new System.Windows.Forms.ListView();
            this.colMaPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTinhTrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemTN = new System.Windows.Forms.Button();
            this.txtTenToaNha = new System.Windows.Forms.TextBox();
            this.txtMaToaNha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThemPH = new System.Windows.Forms.Button();
            this.cboToaNha = new System.Windows.Forms.ComboBox();
            this.txtTenPH = new System.Windows.Forms.TextBox();
            this.txtMaPH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvPhongHoc
            // 
            this.lvPhongHoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPhong,
            this.colTenPhong,
            this.colTinhTrang});
            this.lvPhongHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvPhongHoc.FullRowSelect = true;
            this.lvPhongHoc.GridLines = true;
            this.lvPhongHoc.HideSelection = false;
            this.lvPhongHoc.Location = new System.Drawing.Point(0, 0);
            this.lvPhongHoc.Name = "lvPhongHoc";
            this.lvPhongHoc.Size = new System.Drawing.Size(784, 331);
            this.lvPhongHoc.TabIndex = 0;
            this.lvPhongHoc.UseCompatibleStateImageBehavior = false;
            this.lvPhongHoc.View = System.Windows.Forms.View.Details;
            // 
            // colMaPhong
            // 
            this.colMaPhong.Text = "Mã Phòng Học";
            this.colMaPhong.Width = 260;
            // 
            // colTenPhong
            // 
            this.colTenPhong.Text = "Tên Phòng Học";
            this.colTenPhong.Width = 260;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.Text = "Tình Trạng";
            this.colTinhTrang.Width = 260;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemTN);
            this.groupBox1.Controls.Add(this.txtTenToaNha);
            this.groupBox1.Controls.Add(this.txtMaToaNha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 239);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm Tòa Nhà";
            // 
            // btnThemTN
            // 
            this.btnThemTN.Location = new System.Drawing.Point(121, 146);
            this.btnThemTN.Name = "btnThemTN";
            this.btnThemTN.Size = new System.Drawing.Size(128, 40);
            this.btnThemTN.TabIndex = 4;
            this.btnThemTN.Text = "Thêm";
            this.btnThemTN.UseVisualStyleBackColor = true;
            this.btnThemTN.Click += new System.EventHandler(this.btnThemTN_Click);
            // 
            // txtTenToaNha
            // 
            this.txtTenToaNha.Location = new System.Drawing.Point(121, 80);
            this.txtTenToaNha.Name = "txtTenToaNha";
            this.txtTenToaNha.Size = new System.Drawing.Size(259, 31);
            this.txtTenToaNha.TabIndex = 3;
            // 
            // txtMaToaNha
            // 
            this.txtMaToaNha.Location = new System.Drawing.Point(121, 33);
            this.txtMaToaNha.Name = "txtMaToaNha";
            this.txtMaToaNha.Size = new System.Drawing.Size(259, 31);
            this.txtMaToaNha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTinhTrang);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnThemPH);
            this.groupBox2.Controls.Add(this.cboToaNha);
            this.groupBox2.Controls.Add(this.txtTenPH);
            this.groupBox2.Controls.Add(this.txtMaPH);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(386, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 239);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm Phòng Học";
            // 
            // btnThemPH
            // 
            this.btnThemPH.Location = new System.Drawing.Point(132, 199);
            this.btnThemPH.Name = "btnThemPH";
            this.btnThemPH.Size = new System.Drawing.Size(128, 40);
            this.btnThemPH.TabIndex = 6;
            this.btnThemPH.Text = "Thêm";
            this.btnThemPH.UseVisualStyleBackColor = true;
            this.btnThemPH.Click += new System.EventHandler(this.btnThemPH_Click);
            // 
            // cboToaNha
            // 
            this.cboToaNha.FormattingEnabled = true;
            this.cboToaNha.Location = new System.Drawing.Point(132, 109);
            this.cboToaNha.Name = "cboToaNha";
            this.cboToaNha.Size = new System.Drawing.Size(259, 31);
            this.cboToaNha.TabIndex = 5;
            // 
            // txtTenPH
            // 
            this.txtTenPH.Location = new System.Drawing.Point(132, 75);
            this.txtTenPH.Name = "txtTenPH";
            this.txtTenPH.Size = new System.Drawing.Size(259, 31);
            this.txtTenPH.TabIndex = 4;
            // 
            // txtMaPH
            // 
            this.txtMaPH.Location = new System.Drawing.Point(132, 33);
            this.txtMaPH.Name = "txtMaPH";
            this.txtMaPH.Size = new System.Drawing.Size(259, 31);
            this.txtMaPH.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tòa Nhà:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Trạng thái:";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(132, 157);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(259, 31);
            this.txtTinhTrang.TabIndex = 8;
            // 
            // frmPhongHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 570);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvPhongHoc);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmPhongHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhongHoc";
            this.Load += new System.EventHandler(this.frmPhongHoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPhongHoc;
        private System.Windows.Forms.ColumnHeader colMaPhong;
        private System.Windows.Forms.ColumnHeader colTenPhong;
        private System.Windows.Forms.ColumnHeader colTinhTrang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemTN;
        private System.Windows.Forms.TextBox txtTenToaNha;
        private System.Windows.Forms.TextBox txtMaToaNha;
        private System.Windows.Forms.Button btnThemPH;
        private System.Windows.Forms.ComboBox cboToaNha;
        private System.Windows.Forms.TextBox txtTenPH;
        private System.Windows.Forms.TextBox txtMaPH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label label6;
    }
}