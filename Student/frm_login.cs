using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_login : Form
    {

        string sqlconnect = "server=121.199.24.155;database=School;uid=Joy;pwd=G.980813jm";

        SqlConnection sqlConnection = null;

        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    sqlConnection = new SqlConnection(sqlconnect);
                    sqlConnection.Open();
                }
                catch
                {
                    MessageBox.Show("连接数据库失败");
                }
                string sql = string.Format("select * from student where Name = '{0}' and Pwd = '{1}'",txt_name.Text.Trim(),txt_pwd.Text.Trim());
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                //int result = cmd.ExecuteNonQuery();
                //if (result > 0)
                //{
                //    MessageBox.Show("欢迎登陆!");
                //}
                SqlDataReader result = cmd.ExecuteReader();
                //MessageBox.Show(result.HasRows.ToString());
                if (result.HasRows)
                {
                    MessageBox.Show("欢迎登陆!");
                    this.Hide();
                    frm_addInfo frm_AddInfo = new frm_addInfo();
                    frm_AddInfo.Show();
                }
                else
                {
                    MessageBox.Show("登陆失败!");
                }


                
            }
            catch
            {
                MessageBox.Show("失败");
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
            
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
