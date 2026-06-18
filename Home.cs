using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EShift_transport
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerLogin customerlog = new CustomerLogin();
            customerlog.Show();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin adminlog = new AdminLogin();
            adminlog.Show();
        }
    }
}
