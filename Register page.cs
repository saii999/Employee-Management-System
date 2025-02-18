using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-Q3FVHAA;Initial Catalog=employeemanagement;Integrated Security=True");
            Con.Open();
            SqlCommand cmd = new SqlCommand(@"sp_register", Con);
            cmd.CommandType = CommandType.StoredProcedure;
        }
    }
}
