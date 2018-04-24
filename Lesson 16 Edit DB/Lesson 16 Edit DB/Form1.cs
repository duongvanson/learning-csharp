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
namespace Lesson_16_Edit_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strConn = "Server=DUONGSON-PC; Database=dataLearn;Integrated Security=True";
        private void Form1_Load(object sender, EventArgs e)
        {
            hienThiDM();
            if (conn.State == ConnectionState.Open)
                lblStatus.Text = "connecting...";
            else
                lblStatus.Text = "not connecting...";
        }
        private void hienThiDM()
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from DanhMuc";
            command.Connection = conn;
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                string ma = read.GetInt32(0)+"";
                string ten = read.GetString(1);
                cboDanhMuc.Items.Add(ma + "-" + ten);
            }
            read.Close();
        }
        int madm = -1;
        private void cboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDanhMuc.SelectedIndex == -1) return;
            string line = cboDanhMuc.SelectedItem+"";
            string[] arr = line.Split('-');
            madm = int.Parse(arr[0]);
            hienThiSanPham(madm);
        }

        private void hienThiSanPham(int madm)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from SanPham where MaDanhMuc=" + madm;
            command.Connection = conn;
            lvSanPham.Items.Clear();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetInt32(0)+"");
                lvi.SubItems.Add(reader.GetString(1));
                lvi.SubItems.Add(reader.GetInt32(2) + "");
                lvSanPham.Items.Add(lvi);
            }
            reader.Close();
        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem lvi = lvSanPham.SelectedItems[0];
            txtMa.Text = lvi.SubItems[0].Text+"";
            txtTen.Text = lvi.SubItems[1].Text + "";
            txtGia.Text = lvi.SubItems[2].Text + "";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string query = "update SanPham set " +
                "Ten=N'"+txtTen.Text+
                "',DonGia="+txtGia.Text+ 
                "where Ma=" + txtMa.Text;
            command.CommandText=query;
            command.Connection = conn;
            int rel = command.ExecuteNonQuery();
            if (rel > 0)
            {
                lblStatus.Text = "Update Succses!";
                hienThiSanPham(madm);
            }
        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string query = "update SanPham set Ten=@ten, DonGia=@donGia where Ma=@ma";
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value=txtTen.Text;
            command.Parameters.Add("@donGia", SqlDbType.Int).Value=txtGia.Text;
            command.Parameters.Add("@ma", SqlDbType.VarChar).Value=txtMa.Text;
            command.CommandText = query;
            command.Connection = conn;
            int rel = command.ExecuteNonQuery();
            if (rel > 0)
            {
                lblStatus.Text = "Update Succses!";
                hienThiSanPham(madm);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string query = "insert into SanPham(Ma,Ten,DonGia,MaDanhMuc)" +
                "values(@ma,@ten, @donGia, @maDM)";
            command.CommandText = query;
            command.Connection = conn;

            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtTen.Text;
            command.Parameters.Add("@donGia", SqlDbType.Int).Value = txtGia.Text;
            command.Parameters.Add("@ma", SqlDbType.Int).Value = txtMa.Text;
            command.Parameters.Add("@maDM", SqlDbType.Int).Value = txtMaDM.Text;
            int rel = command.ExecuteNonQuery();
            if (rel > 0)
            {
                txtMa.ResetText();
                txtTen.ResetText();
                txtGia.ResetText();
                txtMaDM.ResetText();
                lblStatus.Text = "Add Succses!";
                hienThiSanPham(madm);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            //Cach 1
            //string query = "delete SanPham where Ma="+txtMa.Text;
            //Cach 2
            string query = "delete SanPham where Ma=@ma";
            command.Parameters.Add("@ma", SqlDbType.Int).Value = txtMa.Text;
            command.CommandText=query;
            command.Connection = conn;


            if (command.ExecuteNonQuery() > 0)
            {
                lblStatus.Text = "Delete Succses!";
                hienThiSanPham(madm);
            }
                
        }
    }
}
