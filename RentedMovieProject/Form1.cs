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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void ShowDialog(Form frm)
        {
            frm.ShowDialog();
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            ShowDialog(new AddCustomerForm() { StartPosition = FormStartPosition.CenterScreen });
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            ShowDialog(new ViewCustomerForm() { StartPosition = FormStartPosition.CenterScreen });
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            ShowDialog(new AddMovieForm() { StartPosition = FormStartPosition.CenterScreen });
        }

        private void btnViewMovie_Click(object sender, EventArgs e)
        {
            ShowDialog(new ViewMovieForm() { StartPosition = FormStartPosition.CenterScreen });
        }

        private void btnIssueMovie_Click(object sender, EventArgs e)
        {
            ShowDialog(new IssueMovieForm() { StartPosition = FormStartPosition.CenterScreen });
        }

        private void btnReturnMovie_Click(object sender, EventArgs e)
        {
            ShowDialog(new ReturnMovieFrom() { StartPosition = FormStartPosition.CenterScreen });
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ShowDialog(new ListsForm() { StartPosition = FormStartPosition.CenterScreen });
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
