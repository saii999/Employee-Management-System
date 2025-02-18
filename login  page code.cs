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
using System.Linq.Expressions;
               

namespace WindowsFormsApp2
{
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        static void Main()
        {
        }
        private void loginuname_tb_TextChanged(object sender, EventArgs e)
        {
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-Q3FVHAA;Initial Catalog=employeemanagement;Integrated Security=True");
                Con.Open();

                SqlCommand cmd = new SqlCommand("sp_login", Con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@uname", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = loginuname_tb.Text.Trim();

                SqlParameter p2 = new SqlParameter("@cpassword", SqlDbType.VarChar);
                cmd.Parameters.Add(p2).Value = loginpasswrd_tbl.Text.Trim();

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds); 
                int a = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                if (a > 0)
                {
                    MessageBox.Show("Welcome Back");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
    

