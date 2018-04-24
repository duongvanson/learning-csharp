using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_06_Menu
{
    public partial class Form1 : Form
    {
        Random rd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tạo10ButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text = rd.Next(100)+"";
                btn.Size = new Size(100, 50);
                btn.ContextMenuStrip = doiMauButton;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void tạo20BottonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < 20; i++)
            {
                Button btn = new Button();
                btn.Text = rd.Next(100) + "";
                btn.Size = new Size(100, 50);
                btn.ContextMenuStrip = doiMauButton;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = doiMauButton.SourceControl as Button;
            btn.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = doiMauButton.SourceControl as Button;
            btn.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = doiMauButton.SourceControl as Button;
            btn.BackColor = Color.Blue;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string s = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            lblDate.Text = s;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                backgroundWorker1.ReportProgress(i*100/100,i);
                System.Threading.Thread.Sleep(200);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            processRun.Value = e.ProgressPercentage;
            lblStatus.Text = e.UserState + "";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Xong");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
    }
}
