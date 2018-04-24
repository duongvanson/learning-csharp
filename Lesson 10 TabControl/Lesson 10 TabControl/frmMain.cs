using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_10_TabControl
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        Random rd = new Random();
        private void frmMain_Load(object sender, EventArgs e)
        {
            button2.ImageList = imageList1;
            button2.ImageIndex = rd.Next(3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.ImageIndex ==1)
            {
                button2.BackColor = Color.Black;
            }
            else
            {
                button2.ImageIndex = 2;
                button2.Enabled = false;
            }
        }
    }
}
