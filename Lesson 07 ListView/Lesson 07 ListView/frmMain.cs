using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_07_ListView
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public List<SinhVien> SinhViens = new List<SinhVien>();
        private void reset()
        {
            txtLop.Text = "";
            txtMaSV.Text = "";
            txtTenSV.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtLop.Text != "" && txtMaSV.Text != "" && txtTenSV.Text != "")
            {
                ListViewItem lvi = new ListViewItem(txtMaSV.Text);
                lvi.SubItems.Add(txtTenSV.Text);
                lvi.SubItems.Add(txtLop.Text);
                lvSinhViens.Items.Add(lvi);
                reset();
            }
            else
            {
                MessageBox.Show("Pls, confirm full info.");
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Random rd = new Random();
            for (int i = 0; i < 5; i++)
            {
                SinhVien sv = new SinhVien("DTC" + rd.Next(20) + "HD" + rd.Next(1000000000, 1999999999) + "", Convert.ToChar(rd.Next(65, 90)) + " " + Convert.ToChar(rd.Next(65, 90)) + " " + Convert.ToChar(rd.Next(65, 90)), Convert.ToChar(rd.Next(65, 90)) + "" + Convert.ToChar(rd.Next(65, 90)) + "" + Convert.ToChar(rd.Next(65, 90)));
                SinhViens.Add(sv);
                ListViewItem lvi = new ListViewItem(sv.Ma);
                lvi.SubItems.Add(sv.HoTen);
                lvi.SubItems.Add(sv.Lop);
                lvSinhViens.Items.Add(lvi);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lvSinhViens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvSinhViens.SelectedItems.Count>0)
            {
                ListViewItem lvi = lvSinhViens.SelectedItems[0];
                txtMaSV.Text = lvi.SubItems[0].Text;
                txtTenSV.Text = lvi.SubItems[1].Text;
                txtLop.Text = lvi.SubItems[2].Text;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvSinhViens.SelectedItems.Count>0)
            {
                ListViewItem lvi = lvSinhViens.SelectedItems[0];
                lvi.SubItems[0].Text = SinhViens[lvSinhViens.SelectedItems[0].Index].Ma = txtMaSV.Text;
                lvi.SubItems[1].Text = SinhViens[lvSinhViens.SelectedItems[0].Index].HoTen = txtTenSV.Text;
                lvi.SubItems[2].Text = SinhViens[lvSinhViens.SelectedItems[0].Index].Lop = txtLop.Text;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSinhViens.SelectedItems.Count > 0)
            {
                SinhViens.RemoveAt(lvSinhViens.SelectedItems[0].Index);
                lvSinhViens.Items.RemoveAt(lvSinhViens.SelectedItems[0].Index);
                reset();
            }
        }
    }
}
