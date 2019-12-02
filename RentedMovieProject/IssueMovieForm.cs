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
    public partial class IssueMovieForm : Form
    {
        public IssueMovieForm()
        {
            InitializeComponent();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter valid Customer ID");
            }
            else
            {
                AllFunctions database = new AllFunctions();
                database.AddRentalRecord(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue.ToString()), Convert.ToDateTime(dateTimePicker1.Text));
                MessageBox.Show("Movie Rented");
            }
        }

        private void IssueMovieForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentedMovieProjectDataSet3.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.rentedMovieProjectDataSet3.Customer);
            // TODO: This line of code loads data into the 'rentedMovieProjectDataSet2.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter1.Fill(this.rentedMovieProjectDataSet2.Movies);
            // TODO: This line of code loads data into the 'rentedMovieProjectDataSet1.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.rentedMovieProjectDataSet1.Customer);
            // TODO: This line of code loads data into the 'rentedMovieProjectDataSet.Movies' table. You can move, or remove it, as needed.
           // this.moviesTableAdapter.Fill(this.rentedMovieProjectDataSet.Movies);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            DataTable table = new AllFunctions().FindCustomerByID(comboBox2.SelectedValue.ToString());

            if (table.Rows.Count > 0)
            {
                textBox1.Text = table.Rows[0]["FirstName"].ToString();
                textBox2.Text = table.Rows[0]["Address"].ToString();
                textBox3.Text = table.Rows[0]["Phone"].ToString();
            }
        }
    }
}
