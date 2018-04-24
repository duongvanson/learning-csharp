using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_08_DataGrid
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        List<SinhVien> sinhViens = new List<SinhVien>();
        private void frmMain_Load(object sender, EventArgs e)
        {
    
            sinhViens.Add(new SinhVien { Ma = "1", HoTen = "ABC", Lop = "KTPM" });
            sinhViens.Add(new SinhVien { Ma = "2", HoTen = "ABC 2", Lop = "KTPM 2" });
            sinhViens.Add(new SinhVien { Ma = "3", HoTen = "ABC 2", Lop = "KTPM 3" });
            dataGridView1.DataSource = sinhViens;
        }
    }
}
