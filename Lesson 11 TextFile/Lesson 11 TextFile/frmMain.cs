using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_11_TextFile
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        List<SanPham> sanPhams = new List<SanPham>();
        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSP = txtMaSP.Text;
            sp.TenSP = txtTenSP.Text;
            sp.Gia = double.Parse(txtGia.Text);
            sanPhams.Add(sp);

            hienThiSanPham();
        }

        private void hienThiSanPham()
        {
            lstbSanPham.Items.Clear();
            foreach (SanPham sp in sanPhams)
            {
                lstbSanPham.Items.Add(sp);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath + "\\database.txt";
                if (FileInOut.LuuFile(sanPhams, path))
                    MessageBox.Show("Lưu thành công!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath + "\\database.txt";
                if(System.IO.File.Exists(path))
                {
                    sanPhams = FileInOut.DocFile(path);
                    hienThiSanPham();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
