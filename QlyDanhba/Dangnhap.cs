using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QlyDanhba
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=LAPTOP-A9QS4U2E\\SQLEXPRESS;uid=sa;pwd=123;database=QLDB");
            //jdbc:sqlserver://LAPTOP-A9QS4U2E\\SQLEXPRESS:1433;databaseName=QlSach;user=sa; password=123"
            try
            {
                con.Open();
                string user = txtusername.Text;
                string pass = txtpassword.Text;
                string sql = "select * from Taikhoan where usename='"+user+"' and password='"+pass+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dta = cmd.ExecuteReader();
                if(dta.Read()==true)
                {
                    mySave.KT = !mySave.KT;
                    MessageBox.Show("Đăng nhập thành công");
                    Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!!");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {

        }
    }
}
