using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Ly_Sinh_Vien.io;
namespace Quan_Ly_Sinh_Vien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        Dictionary<string, Khoa> DB = new Dictionary<string, Khoa>();
        private void frmMain_Load(object sender, EventArgs e)
        {
            DuLieu();
            hienThi();
            hienThiKhoa();
        }

        private void hienThiKhoa()
        {
            cboKhoa.Items.Clear();
            foreach (KeyValuePair<string,Khoa> item in DB)
            {
                Khoa kh = item.Value;
                cboKhoa.Items.Add(kh);
            }
        }

        private void DuLieu()
        {
            Khoa cntt = new Khoa { Ma = "CNTT", Ten = "Công nghệ thông tin" };
            Khoa dttt = new Khoa { Ma = "DTTT", Ten = "Điện tử truyền thông" };
            Khoa tdh = new Khoa { Ma = "TDH", Ten = "Tự động hóa" };

            LopHoc cntt1 = new LopHoc { Ma = "CNTT1", Ten = "Công nghệ 1", KhoaChuQuan = cntt };
            LopHoc cntt2 = new LopHoc { Ma = "CNTT2", Ten = "Công nghệ 2", KhoaChuQuan = cntt };
            LopHoc dttt1 = new LopHoc { Ma = "DTTT1", Ten = "Điện tử 1", KhoaChuQuan = dttt };
            LopHoc tdh1 = new LopHoc { Ma = "TDH1", Ten = "Tự động 1", KhoaChuQuan = tdh };

            DB.Add(cntt.Ma, cntt);
            DB.Add(dttt.Ma, dttt);
            DB.Add(tdh.Ma, tdh);
            cntt.Lops.Add(cntt1.Ma, cntt1);
            cntt.Lops.Add(cntt2.Ma, cntt2);
            dttt.Lops.Add(dttt1.Ma, dttt1);
            tdh.Lops.Add(tdh1.Ma, tdh1);

            SinhVien sv1 = new SinhVien
            {
                Ma = "01",
                HoTen = "Duong Van Son",
                GioiTinh=false,
                NamSinh=1998
            };
            sv1.LopChuQuan = cntt1;
            cntt1.SinhViens.Add(sv1.Ma,sv1);
            SinhVien sv2 = new SinhVien
            {
                Ma = "02",
                HoTen = "Duong Anh",
                GioiTinh = true,
                NamSinh = 1998
            };
            sv2.LopChuQuan = dttt1;
            dttt1.SinhViens.Add(sv2.Ma, sv2);

            SinhVien sv3 = new SinhVien
            {
                Ma = "03",
                HoTen = "Duong Huyen",
                GioiTinh = true,
                NamSinh = 1998
            };
            sv3.LopChuQuan = cntt1;
            cntt1.SinhViens.Add(sv3.Ma, sv3);
        }
        private void hienThi()
        {
            tvKhoa.Nodes.Clear();
            foreach (KeyValuePair<string,Khoa> item in DB)
            {
                Khoa kh = item.Value;
                TreeNode nKhoa = new TreeNode(kh.Ten);
                nKhoa.Tag = kh;
                tvKhoa.Nodes.Add(nKhoa);
                foreach (KeyValuePair<string,LopHoc> lop in kh.Lops)
                {
                    LopHoc lp = lop.Value;
                    TreeNode nlop = new TreeNode(lp.Ten);
                    nlop.Tag = lp;
                    nKhoa.Nodes.Add(nlop);
                }
            }
            tvKhoa.ExpandAll();
        }

        private void tvKhoa_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node!=null)
            {
                if(e.Node.Level == 1)
                {
                    LopHoc lp = e.Node.Tag as LopHoc;
                    hienThiSinhVien(lp);
                }
                else
                {
                    lvSinhVien.Items.Clear();
                }
            }
        }

        private void hienThiSinhVien(LopHoc lp)
        {
            lvSinhVien.Items.Clear();
            foreach (KeyValuePair<string,SinhVien> item in lp.SinhViens)
            {
                SinhVien sv = item.Value;
                ListViewItem lvi = new ListViewItem(sv.Ma);
                lvi.SubItems.Add(sv.HoTen);
                lvi.SubItems.Add(sv.GioiTinh == true ? "Nữ" : "Nam");
                lvi.SubItems.Add(sv.NamSinh+"");

                lvSinhVien.Items.Add(lvi);
                lvi.Tag = sv;
            }
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvSinhVien.SelectedItems[0];
                SinhVien sv = lvi.Tag as SinhVien;
                txtMa.Text = sv.Ma;
                txtHoTen.Text = sv.HoTen;
                txtNamSinh.Text = sv.NamSinh + "";
                if (sv.GioiTinh)
                    radNu.Checked = true;
                else
                    radNam.Checked = true;
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void hienThiLop(Khoa kh)
        {
            cboLop.Items.Clear();
            foreach (KeyValuePair<string,LopHoc> item in kh.Lops)
            {
                LopHoc lp = item.Value;
                cboLop.Items.Add(lp);
            }
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhoa.SelectedIndex == -1) return;
            Khoa kh = cboKhoa.SelectedItem as Khoa;
            hienThiLop(kh);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboKhoa.SelectedIndex==-1)
            {
                MessageBox.Show("chon khoa");
                return;
            }
            if(cboLop.SelectedIndex==-1)
            {
                MessageBox.Show("chon lop");
                return;
            }
            SinhVien sv = new SinhVien();
            sv.Ma = txtMa.Text;
            sv.HoTen = txtHoTen.Text;
            sv.GioiTinh = radNu.Checked;
            sv.NamSinh = Convert.ToInt32(txtNamSinh.Text);

            LopHoc lp = cboLop.SelectedItem as LopHoc;
            lp.SinhViens.Add(sv.Ma, sv);
            sv.LopChuQuan = lp;
            MessageBox.Show("Them thanh cong");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count>0)
            {
                ListViewItem lvi = lvSinhVien.SelectedItems[0];
                SinhVien sv = lvi.Tag as SinhVien;
                LopHoc lp = sv.LopChuQuan;
                lp.SinhViens.Remove(sv.Ma);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuLuuDuLieu_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            if(sf.ShowDialog()==DialogResult.OK)
            {
                if(FileFactory.saveFile(DB,sf.FileName))
                {
                    MessageBox.Show("Lưu sự liệu thành công!");
                }
            }
        }

        private void mnuDocDuLieu_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if(of.ShowDialog()== DialogResult.OK)
            {
                DB = FileFactory.openFile(of.FileName);
                hienThi();
                MessageBox.Show("Đọc dữ liệu thành công!");
            }
        }
    }
}
