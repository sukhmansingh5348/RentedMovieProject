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
    public partial class ViewCustomerForm : Form
    {
        public ViewCustomerForm()
        {
            InitializeComponent();
        }

        private void dataGridViewViewCustomer_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditCustomerForm customerForm = new EditCustomerForm();
            customerForm.txtCustomerID.Text = this.dataGridViewViewCustomer.CurrentRow.Cells[0].Value.ToString();
            customerForm.txtFirstName.Text = this.dataGridViewViewCustomer.CurrentRow.Cells[1].Value.ToString();
            customerForm.txtLastName.Text = this.dataGridViewViewCustomer.CurrentRow.Cells[2].Value.ToString();
            customerForm.txtAddress.Text = this.dataGridViewViewCustomer.CurrentRow.Cells[3].Value.ToString();
            customerForm.txtPhoneNo.Text = this.dataGridViewViewCustomer.CurrentRow.Cells[4].Value.ToString();
            customerForm.ShowDialog();
            dataGridViewViewCustomer.DataSource = new AllFunctions().FindAllCustomers();
        }

        private void dataGridViewViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewCustomerForm_Load(object sender, EventArgs e)
        {
            dataGridViewViewCustomer.DataSource = new AllFunctions().FindAllCustomers();
        }
    }
}
