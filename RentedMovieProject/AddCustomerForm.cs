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
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void btnAddCust_Click(object sender, EventArgs e)//Add button code
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtAddress.Text == "" || txtPhoneNumber.Text == "")
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                AllFunctions db = new AllFunctions();//instance of all functions
                db.AddCustomer(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPhoneNumber.Text);//calling add customer method
                MessageBox.Show("Customer Added");
                Dispose();
            }
        }
    }
}
