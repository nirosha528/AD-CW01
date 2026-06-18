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
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome home = new AdminHome();
            home.Show();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerDetails customer = new CustomerDetails();
            customer.Show();
        }
    }
}
