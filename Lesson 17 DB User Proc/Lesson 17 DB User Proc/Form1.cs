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
namespace Lesson_17_DB_User_Proc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strConn = "Server=DUONGSON-PC;Database=dataLearn;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {
            hienThiSanPham();
            if (conn.State == ConnectionState.Open)
                lblStatus.Text = "Connecting...";
        }
        private void hienThiSanPham()
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "LayToanBoSanPham";
            command.Connection = conn;
            SqlDataReader read = command.ExecuteReader();
            lvSanPham.Items.Clear();
            while (read.Read())
            {
                ListViewItem lvi = new ListViewItem(read.GetInt32(0) + "");
                lvi.SubItems.Add(read.GetString(1));
                lvi.SubItems.Add(read.GetInt32(2) + "");
                lvSanPham.Items.Add(lvi);
            }
            read.Close();
        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count == 0) return;
            ListViewItem lvi = lvSanPham.SelectedItems[0];
            int ma =int.Parse(lvi.SubItems[0].Text);
            hienChiTiet(ma);
        }

        private void hienChiTiet(int ma)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ChiTietSanPham";
            command.Connection = conn;

            SqlParameter par = new SqlParameter("@ma", SqlDbType.Int);
            par.Value = ma;
            command.Parameters.Add(par);
            SqlDataReader read = command.ExecuteReader();
            if(read.Read())
            {
                txtMa.Text = read.GetInt32(0) + "";
                txtTen.Text = read.GetString(1);
                txtGia.Text = read.GetInt32(2)+"";
                txtMaDM.Text = read.GetInt32(3)+"";
            }
            read.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ThemSanPham";
            command.Connection = conn;

            command.Parameters.Add("@ma", SqlDbType.Int).Value = txtMa.Text;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtTen.Text;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = txtGia.Text;
            command.Parameters.Add("@madm", SqlDbType.Int).Value = txtMaDM.Text;
            if(command.ExecuteNonQuery()>0)
            {
                lblStatus.Text = "Add Succses!";
                hienThiSanPham();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "CapNhat";
            command.Connection = conn;

            command.Parameters.Add("@ma", SqlDbType.Int).Value = txtMa.Text;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = txtGia.Text;
            if (command.ExecuteNonQuery() > 0)
            {
                lblStatus.Text = "Update Succses!";
                hienThiSanPham();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "Xoa";
            command.Connection = conn;
            command.Parameters.Add("@ma", SqlDbType.Int).Value = txtMa.Text;
            if(command.ExecuteNonQuery()>0)
            {
                lblStatus.Text = "Delete Succses!";
                hienThiSanPham();
            }
        }
    }
}
