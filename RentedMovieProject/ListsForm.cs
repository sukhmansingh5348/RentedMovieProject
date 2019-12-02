﻿using System;
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
    public partial class ListsForm : Form
    {
        public ListsForm()
        {
            InitializeComponent();
        }

        private void ListsForm_Load(object sender, EventArgs e)
        {
            dataGridViewCustomer.DataSource = new AllFunctions().FindBestCustomers();
            dataGridViewMovies.DataSource = new AllFunctions().GetBestSellingMovies();
        }
    }
}
