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

namespace Student
{
    public partial class frm_addInfo : Form
    {
        string sqlconnect = "server=121.199.24.155;database=School;uid=Joy;pwd=G.980813jm";

        SqlConnection sqlConnection = null;

        public frm_addInfo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_addInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string sex = rad_male.Checked ? "男" : "女";
            int age = Convert.ToInt32(num_age.Value);
            string address = txt_address.Text;
            DateTime birth = date_birth.Value;
            try
            {
                string sql = string.Format("insert into student(Name,Sex,Age,Birth,Address) values('{0}','{1}','{2}','{3}','{4}')", name, sex, age, birth, address);
                sqlConnection = new SqlConnection(sqlconnect);
                sqlConnection.Open();
                //MessageBox.Show("Ok");
                SqlCommand comm = new SqlCommand(sql, sqlConnection);
                int result = comm.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Fail");
                }

            }
            catch
            {
                MessageBox.Show("Fail");
            }
            finally{
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
            
            
        }

        private void combo_class_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
