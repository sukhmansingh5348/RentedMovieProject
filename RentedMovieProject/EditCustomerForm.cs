using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentedMovieProject
{
    public partial class EditCustomerForm : Form
    {
        public EditCustomerForm()
        {
            InitializeComponent();
        }

        private void btnUpdateCust_Click(object sender, EventArgs e)
        {
            AllFunctions db = new AllFunctions();
            db.EditCustomer(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPhoneNo.Text, txtCustomerID.Text);
            MessageBox.Show("Customer Updated");
            Dispose();
        }

        private void btnDaleteCust_Click(object sender, EventArgs e)
        {
            AllFunctions db = new AllFunctions();
            db.DeleteCustomer(txtCustomerID.Text);
            MessageBox.Show("Customer Deleted");
            Dispose();
        }
    }
}
