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
    public partial class frmPhongHoc : Form
    {
        public frmPhongHoc()
        {
            InitializeComponent();
        }
        public List<ToaNhaHoc> toaNhas = new List<ToaNhaHoc>();
        private void frmPhongHoc_Load(object sender, EventArgs e)
        {
            ToaNhaHoc C1 = new ToaNhaHoc();
            C1.MaToaNha = "C1";
            C1.TenToaNha = "Tòa nhà C1";
            toaNhas.Add(C1);

            PhongHoc C1P101 = new PhongHoc();
            C1P101.MaPhongHoc = "C1.101";
            C1P101.TenPhongHoc = "Phòng 101 Tòa C1";
            C1P101.TinhTrang = "Đang học";
            C1.themPhong(C1P101);

            PhongHoc C1P102 = new PhongHoc();
            C1P102.MaPhongHoc = "C1.102";
            C1P102.TenPhongHoc = "Phòng 102 Tòa C1";
            C1P102.TinhTrang = "Rảnh";
            C1.themPhong(C1P102);

            ToaNhaHoc C2 = new ToaNhaHoc();
            C2.MaToaNha = "C2";
            C2.TenToaNha = "Tòa nhà C2";
            toaNhas.Add(C2);

            PhongHoc C2P105 = new PhongHoc();
            C2P105.MaPhongHoc = "C2.105";
            C2P105.TenPhongHoc = "Phòng 105 Tòa C2";
            C2P105.TinhTrang = "Rảnh";
            C2.themPhong(C2P105);

            capNhat();
        }
        private void capNhat()
        {
            lvPhongHoc.Groups.Clear();
            lvPhongHoc.Items.Clear();
            foreach (ToaNhaHoc thh in toaNhas)
            {
                ListViewGroup lvg = new ListViewGroup(thh.TenToaNha);
                lvPhongHoc.Groups.Add(lvg);
                foreach (PhongHoc ph in thh.PhongHocs)
                {
                    ListViewItem lvi = new ListViewItem(ph.MaPhongHoc);
                    lvi.SubItems.Add(ph.TenPhongHoc);
                    lvi.SubItems.Add(ph.TinhTrang);
                    lvPhongHoc.Items.Add(lvi);
                    lvi.Group = lvg;
                }
            }
            cboToaNha.Items.Clear();
            for (int i = 0; i < toaNhas.Count; i++)
            {
                cboToaNha.Items.Add(toaNhas[i].TenToaNha);
            }
        }
        private void btnThemTN_Click(object sender, EventArgs e)
        {
            ToaNhaHoc thn = new ToaNhaHoc();
            thn.MaToaNha = txtMaToaNha.Text;
            thn.TenToaNha = txtTenToaNha.Text;
            toaNhas.Add(thn);
            capNhat();
            MessageBox.Show("Thêm tòa nhà thành công!");
        }

        private void btnThemPH_Click(object sender, EventArgs e)
        {
            if (cboToaNha.SelectedIndex != -1)
            {
                PhongHoc ph = new PhongHoc();
                ph.MaPhongHoc = txtMaPH.Text;
                ph.TenPhongHoc = txtTenPH.Text;
                ph.TinhTrang = txtTinhTrang.Text;
                for (int i = 0; i < toaNhas.Count; i++)
                {
                    if (toaNhas[i].TenToaNha == cboToaNha.SelectedItem.ToString())
                    {
                        toaNhas[i].themPhong(ph);
                    }
                }
                MessageBox.Show("Thêm phòng học thành công!");
            }
            capNhat();
        }
    }
}
