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
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    public partial class Register_page : Form
    {
        public Register_page()
        {
            InitializeComponent();
        }
        public bool IsValidEmail(string email)
        {
            string emailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void regbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (reguname_tb.Text.Trim() != "" && regspass_tb.Text.Trim() != "" && regconfpass_tb.Text.Trim() != "" && regemail_tb.Text.Trim() != "" && regmobnum_tb.Text.Trim() != "")
                {
                    string emailAddress = regemail_tb.Text.Trim();
                    bool isValid = IsValidEmail(emailAddress);
                    if (isValid)
                    {
                        if (regspass_tb.Text.Trim().Length >= 8)
                        {
                            if (regspass_tb.Text.Trim() == regconfpass_tb.Text.Trim())
                            {
                                SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-Q3FVHAA;Initial Catalog=employeemanagement;Integrated Security=True");
                                Con.Open();

                                SqlCommand cmd = new SqlCommand("sp_register1", Con);
                                cmd.CommandType = CommandType.StoredProcedure;

                                SqlParameter p1 = new SqlParameter("@uname", SqlDbType.VarChar);
                                cmd.Parameters.Add(p1).Value = reguname_tb.Text.Trim();

                                SqlParameter p2 = new SqlParameter("@spassword", SqlDbType.VarChar);
                                cmd.Parameters.Add(p2).Value = regspass_tb.Text.Trim();

                                SqlParameter p3 = new SqlParameter("@Cpassword", SqlDbType.VarChar);
                                cmd.Parameters.Add(p3).Value = regconfpass_tb.Text.Trim();

                                SqlParameter p4 = new SqlParameter("@email", SqlDbType.VarChar);
                                cmd.Parameters.Add(p4).Value = regemail_tb.Text.Trim();

                                SqlParameter p5 = new SqlParameter("@mblnum", SqlDbType.VarChar);
                                cmd.Parameters.Add(p5).Value = regmobnum_tb.Text.Trim();

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
                            else
                            {
                                MessageBox.Show("Passwords do not match");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password must be at least 8 characters long");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid email address");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void regsignup_lkl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_page LP = new Login_page();
            LP.Show();
            this.Hide();
        }
    }
}
