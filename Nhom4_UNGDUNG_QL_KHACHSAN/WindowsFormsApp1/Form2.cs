using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con;

        private void Form2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=TMI\SQLEXPRESS2012;Initial Catalog=QUANLY_KHACHSAN;Integrated Security=True");
            con.Open();
            string sql = "SELECT* FROM PHIEUDANGKY";
            SqlCommand cdm = new SqlCommand(sql, con);//thực thi các chức năng câu lệnh trong sql
            SqlDataAdapter com = new SqlDataAdapter(cdm);   // vận chuyển dữ liệu
            DataTable datatable = new DataTable();// tạo 1 bảng ảo trong hệ thống
            com.Fill(datatable);
            PhieuDangKy.DataSource = datatable; //Bảng ảo này được đổ vào datagridview
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO PHIEUDANGKY VALUES (@MAPDK, @MAKH, @MANV, @NGAYDAT, @NGAYDI, @MAPHONG, @TRATRUOC, @DVT, @MAPHIEUDV )";
            SqlCommand cdm = new SqlCommand(sqlINSERT, con);
            cdm.Parameters.AddWithValue("MAPDK", txtmapdk.Text);
            cdm.Parameters.AddWithValue("MAKH", txtmakh.Text);
            cdm.Parameters.AddWithValue("MANV", txtmanv.Text);
            cdm.Parameters.AddWithValue("NGAYDAT", txtngaydat.Text);
            cdm.Parameters.AddWithValue("NGAYDI", txtngaydi.Text);
            cdm.Parameters.AddWithValue("MAPHONG", txtmaphong.Text);
            cdm.Parameters.AddWithValue("TRATRUOC", txttratruoc.Text);
            cdm.Parameters.AddWithValue("DVT", txtdvt.Text);
            cdm.Parameters.AddWithValue("MAPHIEUDV", txtmapdv.Text);
            cdm.ExecuteNonQuery();
            Form2_Load(sender,e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE PHIEUDANGKY SET MAKH = @MAKH, MANV = @MANV, NGAYDAT = @NGAYDAT, NGAYDI = @NGAYDI, MAPHONG = @MAPHONG, TRATRUOC = @TRATRUOC, DVT = @DVT, MAPHIEUDV = @MAPHIEUDV WHERE MAPDK = @MAPDK";
            SqlCommand cdmedit = new SqlCommand(sqlEDIT, con);
            cdmedit.Parameters.AddWithValue("MAPDK", txtmapdk.Text);
            cdmedit.Parameters.AddWithValue("MAKH", txtmakh.Text);
            cdmedit.Parameters.AddWithValue("MANV", txtmanv.Text);
            cdmedit.Parameters.AddWithValue("NGAYDAT", txtngaydat.Text);
            cdmedit.Parameters.AddWithValue("NGAYDI", txtngaydi.Text);
            cdmedit.Parameters.AddWithValue("MAPHONG", txtmaphong.Text);
            cdmedit.Parameters.AddWithValue("TRATRUOC", txttratruoc.Text);
            cdmedit.Parameters.AddWithValue("DVT", txtdvt.Text);
            cdmedit.Parameters.AddWithValue("MAPHIEUDV", txtmapdv.Text);
            cdmedit.ExecuteNonQuery();
            Form2_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM PHIEUDANGKY WHERE MAPDK = @MAPDK";
            SqlCommand cdmdelete = new SqlCommand(sqlDELETE, con);
            cdmdelete.Parameters.AddWithValue("MAPDK", txtmapdk.Text);
            cdmdelete.Parameters.AddWithValue("MAKH", txtmakh.Text);
            cdmdelete.Parameters.AddWithValue("MANV", txtmanv.Text);
            cdmdelete.Parameters.AddWithValue("NGAYDAT", txtngaydat.Text);
            cdmdelete.Parameters.AddWithValue("NGAYDI", txtngaydi.Text);
            cdmdelete.Parameters.AddWithValue("MAPHONG", txtmaphong.Text);
            cdmdelete.Parameters.AddWithValue("TRATRUOC", txttratruoc.Text);
            cdmdelete.Parameters.AddWithValue("DVT", txtdvt.Text);
            cdmdelete.Parameters.AddWithValue("MAPHIEUDV", txtmapdv.Text);
            cdmdelete.ExecuteNonQuery();
            Form2_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sqlSearch = "SELECT* FROM PHIEUDANGKY WHERE MAPDK = @MAPDK";
            SqlCommand cdmsearch = new SqlCommand(sqlSearch, con);
            cdmsearch.Parameters.AddWithValue("MAPDK", txtMaCanTim.Text);
            cdmsearch.Parameters.AddWithValue("MAKH", txtmakh.Text);
            cdmsearch.Parameters.AddWithValue("MANV", txtmanv.Text);
            cdmsearch.Parameters.AddWithValue("NGAYDAT", txtngaydat.Text);
            cdmsearch.Parameters.AddWithValue("NGAYDI", txtngaydi.Text);
            cdmsearch.Parameters.AddWithValue("MAPHONG", txtmaphong.Text);
            cdmsearch.Parameters.AddWithValue("TRATRUOC", txttratruoc.Text);
            cdmsearch.Parameters.AddWithValue("DVT", txtdvt.Text);
            cdmsearch.Parameters.AddWithValue("MAPHIEUDV", txtmapdv.Text);
            cdmsearch.ExecuteNonQuery();
            SqlDataAdapter com = new SqlDataAdapter(cdmsearch); 
            DataTable datatable = new DataTable();
            com.Fill(datatable);
            PhieuDangKy.DataSource = datatable;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
