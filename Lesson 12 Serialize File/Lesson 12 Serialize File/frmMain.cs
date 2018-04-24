using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_12_Serialize_File
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
            sp.Ma = txtMa.Text;
            sp.Ten = txtTen.Text;
            sp.Gia = double.Parse(txtGia.Text);
            sanPhams.Add(sp);

            viewSanPham();
        }

        private void viewSanPham()
        {
            lstbSanPham.Items.Clear();
            foreach (SanPham sp in sanPhams)
            {
                lstbSanPham.Items.Add(sp);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\db.txt";
            if (FileFactory.saveFile(sanPhams, path))
            {
                MessageBox.Show("Lưu thành công!");
            }
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath + "\\db.txt";
                if (System.IO.File.Exists(path))
                {
                    sanPhams = FileFactory.openFile(path);
                }
                viewSanPham();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
