using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Lesson_13_Connect_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        //string strConnect = "Server=DUONGSON-PC;Database=Quan Ly San Pham;Integrated Security=True";
        string strConnect = "Server=DUONGSON-PC;Database=Quan Ly San Pham;User Id=sa;pwd=son2112";

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConnect);
                conn.Open();
                MessageBox.Show("Kết nối thành công!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnDongKetNoi_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
                MessageBox.Show("Đã ngắt kết nối!");
            }
        }
    }
}
