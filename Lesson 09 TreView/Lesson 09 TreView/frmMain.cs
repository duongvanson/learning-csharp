using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_09_TreView
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tvPhongHoc_NodeMouseClick(object sender,
            TreeNodeMouseClickEventArgs e)
        {
            tvPhongHoc.SelectedNode = e.Node;
        }

        private void mnuThem_Click(object sender, EventArgs e)
        {
            frmTuyChon frm = new frmTuyChon();
            if (frm.ShowDialog()==DialogResult.OK)
            {
                if (tvPhongHoc.SelectedNode == null)
                {
                    TreeNode root = new TreeNode(frm.txtGiaTri.Text);
                    tvPhongHoc.Nodes.Add(root);
                }
                else
                {
                    TreeNode node = new TreeNode(frm.txtGiaTri.Text);
                    tvPhongHoc.SelectedNode.Nodes.Add(node);
                }
            }
        }

        private void tvPhongHoc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lblNode.Text = tvPhongHoc.SelectedNode.Text;
        }

        private void mnuSua_Click(object sender, EventArgs e)
        {
            if (tvPhongHoc.SelectedNode == null) return;
            frmTuyChon frm = new frmTuyChon();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                tvPhongHoc.SelectedNode.Text = frm.txtGiaTri.Text;
            }
        }

        private void mnuXoa_Click(object sender, EventArgs e)
        {
            if (tvPhongHoc.SelectedNode == null) return;
            tvPhongHoc.Nodes.Remove(tvPhongHoc.SelectedNode);
        }

        private void mnuMoRong_Click(object sender, EventArgs e)
        {
            if (tvPhongHoc.SelectedNode == null) return;
            tvPhongHoc.SelectedNode.ExpandAll();
        }

        private void mnuThuGon_Click(object sender, EventArgs e)
        {
            if (tvPhongHoc.SelectedNode == null) return;
            tvPhongHoc.SelectedNode.Collapse();
        }
    }
}
