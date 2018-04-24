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
namespace Lesson_15_Add_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strConn = "Server=DUONGSON-PC;Database=Quan Ly San Pham;Integrated Security=True";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiSP();
            if (conn.State == ConnectionState.Open)
                lblStatus.Text = "Coonnecting...";
            else
            {
                lblStatus.Text = "Not connecting...";
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from DanhMuc";
            command.Connection = conn;
            SqlDataReader read = command.ExecuteReader();
            int x = 0;
            while (read.Read())
            {
                cboDanhMuc.Items.Add(read.GetString(0));
            }
            read.Close();
        }
        private void HienThiSP()
        {
            try
            {
                if (conn == null)
                    conn = new SqlConnection(strConn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from SanPham";
                command.Connection = conn;
                SqlDataReader read = command.ExecuteReader();
                lvSanPham.Items.Clear();
                while (read.Read())
                {
                    ListViewItem lvi = new ListViewItem(read.GetString(0));
                    lvi.SubItems.Add(read.GetString(1));
                    lvi.SubItems.Add(read.GetInt32(2) + "");
                    lvSanPham.Items.Add(lvi);
                }
                read.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null)
                    conn = new SqlConnection(strConn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                string query = "insert into SanPham(Ma,Ten,DonGia,MaDanhMuc)" +
                    "values(@ma,@ten,@gia,@madm)";
                command.CommandText = query;
                command.Connection = conn;

                command.Parameters.Add("@ma", SqlDbType.Char).Value = txtMa.Text;
                command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtTen.Text;
                command.Parameters.Add("@Gia", SqlDbType.Int).Value = txtGia.Text;
                command.Parameters.Add("@madm", SqlDbType.NChar).Value = cboDanhMuc.SelectedItem;

                int rel = command.ExecuteNonQuery();
                if (rel > 0)
                {
                    lblStatus.Text = "Thêm thành công!";
                }
                HienThiSP();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblStatus.Text = "Thêm thất bại!";
            }

        }

        private void btnThem2_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null)
                    conn = new SqlConnection(strConn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                string query = "Insert into SanPham(Ma,Ten,DonGia,MaDanhMuc) " +
                    "values('" + txtMa.Text + "',N'" + txtTen.Text + "'," + txtGia.Text + ",'" + cboDanhMuc.SelectedItem + "')";
                command.CommandText = query;
                command.Connection = conn;
                int rel = command.ExecuteNonQuery();
                if (rel > 0)
                {
                    lblStatus.Text = "Thêm thành công!";
                    HienThiSP();
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void cboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
