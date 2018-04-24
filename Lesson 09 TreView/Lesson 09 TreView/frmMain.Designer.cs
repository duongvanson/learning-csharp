namespace Lesson_09_TreView
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("P101");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Tòa C1", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("P101");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("P102");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Tòa C2", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tvPhongHoc = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNode = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuThem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSua = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMoRong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThuGon = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvPhongHoc
            // 
            this.tvPhongHoc.ContextMenuStrip = this.contextMenuStrip1;
            this.tvPhongHoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvPhongHoc.ImageIndex = 0;
            this.tvPhongHoc.ImageList = this.imageList1;
            this.tvPhongHoc.Location = new System.Drawing.Point(0, 0);
            this.tvPhongHoc.Name = "tvPhongHoc";
            treeNode1.Name = "Node3";
            treeNode1.Text = "P101";
            treeNode2.Name = "ndC1";
            treeNode2.Text = "Tòa C1";
            treeNode3.Name = "Node4";
            treeNode3.Text = "P101";
            treeNode4.Name = "Node6";
            treeNode4.Text = "P102";
            treeNode5.Name = "ndC2";
            treeNode5.Text = "Tòa C2";
            this.tvPhongHoc.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode5});
            this.tvPhongHoc.SelectedImageIndex = 1;
            this.tvPhongHoc.Size = new System.Drawing.Size(446, 456);
            this.tvPhongHoc.TabIndex = 0;
            this.tvPhongHoc.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvPhongHoc_AfterSelect);
            this.tvPhongHoc.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvPhongHoc_NodeMouseClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(446, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin chọn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNode
            // 
            this.lblNode.AutoSize = true;
            this.lblNode.Location = new System.Drawing.Point(452, 47);
            this.lblNode.Name = "lblNode";
            this.lblNode.Size = new System.Drawing.Size(68, 23);
            this.lblNode.TabIndex = 2;
            this.lblNode.Text = "label2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThem,
            this.mnuSua,
            this.mnuXoa,
            this.toolStripMenuItem1,
            this.mnuMoRong,
            this.mnuThuGon});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 120);
            // 
            // mnuThem
            // 
            this.mnuThem.Name = "mnuThem";
            this.mnuThem.Size = new System.Drawing.Size(120, 22);
            this.mnuThem.Text = "Thêm";
            this.mnuThem.Click += new System.EventHandler(this.mnuThem_Click);
            // 
            // mnuSua
            // 
            this.mnuSua.Name = "mnuSua";
            this.mnuSua.Size = new System.Drawing.Size(120, 22);
            this.mnuSua.Text = "Sửa";
            this.mnuSua.Click += new System.EventHandler(this.mnuSua_Click);
            // 
            // mnuXoa
            // 
            this.mnuXoa.Name = "mnuXoa";
            this.mnuXoa.Size = new System.Drawing.Size(120, 22);
            this.mnuXoa.Text = "Xóa";
            this.mnuXoa.Click += new System.EventHandler(this.mnuXoa_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 6);
            // 
            // mnuMoRong
            // 
            this.mnuMoRong.Name = "mnuMoRong";
            this.mnuMoRong.Size = new System.Drawing.Size(120, 22);
            this.mnuMoRong.Text = "Mở rộng";
            this.mnuMoRong.Click += new System.EventHandler(this.mnuMoRong_Click);
            // 
            // mnuThuGon
            // 
            this.mnuThuGon.Name = "mnuThuGon";
            this.mnuThuGon.Size = new System.Drawing.Size(120, 22);
            this.mnuThuGon.Text = "Thu gọn";
            this.mnuThuGon.Click += new System.EventHandler(this.mnuThuGon_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "imgingest-73472534501430461.png");
            this.imageList1.Images.SetKeyName(1, "opendrive-icon-32.png");
            this.imageList1.Images.SetKeyName(2, "flat-file-checker.gif");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 456);
            this.Controls.Add(this.lblNode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvPhongHoc);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmMain";
            this.Text = "Quản lý phòng học";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvPhongHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNode;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuThem;
        private System.Windows.Forms.ToolStripMenuItem mnuSua;
        private System.Windows.Forms.ToolStripMenuItem mnuXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuMoRong;
        private System.Windows.Forms.ToolStripMenuItem mnuThuGon;
        private System.Windows.Forms.ImageList imageList1;
    }
}

