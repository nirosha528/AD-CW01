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

namespace EShift_transport
{
    public partial class AdminSignup : Form
    {
        public AdminSignup()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LS1RA34\SQLEXPRESS;Initial Catalog=eShift;Integrated Security=True");
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                String Query = "INSERT INTO AdminSignup (UserId, Username, Password) VALUES (@UserId,@Username,@Password)";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@UserId", int.Parse(txtuserid.Text));
                cmd.Parameters.AddWithValue("@Username", txtusername.Text);
                cmd.Parameters.AddWithValue("@Password", int.Parse(txtpassword.Text));
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data inserted successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Correct Id");
            }
        }
    }
}
