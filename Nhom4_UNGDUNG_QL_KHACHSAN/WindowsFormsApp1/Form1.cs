using System.Windows.Forms;
using System;
using WindowsFormsApp1;

namespace QUANLY_KHACHSAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txt_tendangnhap.Focus(); //Đưa con trỏ hiển thị ngay trong textbox
            txt_matkhau.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dangnhap()
        {
            if (txt_tendangnhap.Text.Length == 0 && txt_matkhau.Text.Length == 0)
                MessageBox.Show("Bạn chưa đăng nhập mật khẩu !");
                else
                    if (this.txt_tendangnhap.Text.Length == 0)
                        MessageBox.Show("Bạn chưa đăng nhập tên đăng nhập !");
                    else
                        if (this.txt_matkhau.Text.Length == 0)
                            MessageBox.Show("Bạn chưa nhập mật khẩu!");
                          else
                               if (this.txt_tendangnhap.Text == "admin" && this.txt_matkhau.Text == "123456")
                                   MessageBox.Show("Đăng nhập thành công !");
                               else
                                    MessageBox.Show("Sai mật khẩu !");

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_tendangnhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_dangnhap_Click_1(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            if (this.txt_tendangnhap.Text == "admin" && this.txt_matkhau.Text == "123456")
            {
                fm.Show();
            }
            dangnhap();
        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}