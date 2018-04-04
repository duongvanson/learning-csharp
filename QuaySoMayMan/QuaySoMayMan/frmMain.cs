using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuaySoMayMan
{
    public partial class frmMain : Form
    {
        int tienPlayer = 10000;
        int tienMay = 10000;
        int mot, hai, ba;
        int count = 0;
        Random rd = new Random();
        public frmMain()
        {
            InitializeComponent();
        }
        public void khoiTao()
        {
            lblTienMay.Text = tienMay + "";
            lblTienPlayer.Text = tienPlayer + "";
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            khoiTao();
        }

        private void btnChoiLai_Click(object sender, EventArgs e)
        {
            tienMay = 10000;
            tienPlayer = 10000;
            khoiTao();
            btnQuay.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuay_Click(object sender, EventArgs e)
        {
            if (tienPlayer <= 0)
            {
                MessageBox.Show("Bạn hết tiền rồi!");
                btnQuay.Enabled = false;
            }
            if (tienMay <= 0)
            {
                tienMay = 10000;
            }
            lblSo1.Text = mot + "";
            lblSo2.Text = hai + "";
            lblSo3.Text = ba + "";
            if (mot != 7 && hai != 7 && ba != 7)
            {
                tienPlayer -= 1000;
                tienMay += 1000;
            }
            if ((mot == 7 && hai != 7 && ba != 7) || (mot != 7 && hai == 7 && ba != 7) || (mot != 7 && hai != 7 && ba == 7))
            {
                tienPlayer += (int)(tienMay * 0.5);
                tienMay -= (int)(tienMay * 0.5);
            }
            if ((mot == 7 && hai == 7 && ba != 7) || (mot != 7 && hai != 7 && ba == 7) || mot != 7 && hai == 7 && ba == 7)
            {
                tienPlayer += (int)(tienMay * 0.7);
                tienMay -= (int)(tienMay * 0.7);
            }
            if (mot == 7 && hai == 7 && ba == 7)
            {
                MessageBox.Show("THẮNG LỚN!");
                tienPlayer += tienPlayer;
                tienMay -= tienPlayer;
            }
            khoiTao();
            timeRun.Start();
        }
        private void timeRun_Tick(object sender, EventArgs e)
        {
            mot = rd.Next(0, 7);
            hai = rd.Next(0, 8);
            ba = rd.Next(0, 9);
            lblSo1.Text = mot + "";
            lblSo2.Text = hai + "";
            lblSo3.Text = ba + "";
            if (count > 100)
            {
                count = 0;
                timeRun.Stop();
            }
            count++;
        }
    }
}
