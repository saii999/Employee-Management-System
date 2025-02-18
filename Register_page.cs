using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Register_page : Form
    {
        public Register_page()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void regbutton_Click(object sender, EventArgs e)
        {
            try
            { 
                if(reguname_tb.Text != "" && regspass_tb.Text != "" && regconfpass_tb.Text != "" && regemail_tb_tb.Text != "" && regmobnum_tb.Text != "")
                { 
                    SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-Q3FVHAA;Initial Catalog=employeemanagement;Integrated Security=True");
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("sp_register1", Con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("@uname", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = reguname_tb.Text;

                    SqlParameter p2 = new SqlParameter("@spassword", SqlDbType.VarChar);
                    cmd.Parameters.Add(p2).Value = regspass_tb.Text;

                    SqlParameter p3 = new SqlParameter("@Cpassword", SqlDbType.VarChar);
                    cmd.Parameters.Add(p3).Value = regconfpass_tb.Text;

                    SqlParameter p4 = new SqlParameter("@email", SqlDbType.VarChar);
                    cmd.Parameters.Add(p4).Value = regemail_tb_tb.Text;

                    SqlParameter p5 = new SqlParameter("@mblnum", SqlDbType.VarChar);
                    cmd.Parameters.Add(p5).Value = regmobnum_tb.Text;

                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Registered Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Registration Failed");
                    }
                    Con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
