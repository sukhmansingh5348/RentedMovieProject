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
    public partial class EditMovieForm : Form
    {
        public EditMovieForm()
        {
            InitializeComponent();
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(txtYear.Text, out a))
            {
                MessageBox.Show("Year and Copies must be a valid integer");
            }
            else
            {
                int rental = 0;
                if ((DateTime.Now.Year - a) > 5)
                {
                    rental = 2;
                }
                else
                {
                    rental = 5;
                }
                AllFunctions database = new AllFunctions();
                database.EditMovie(txtRating.Text, txtTitle.Text, txtYear.Text, txtCopies.Text, rental.ToString(), txtPlot.Text, txtGenre.Text,DateTime.Now, txtMoviesID.Text);
                MessageBox.Show("Movie Updated");
                Dispose();
            }
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            AllFunctions database = new AllFunctions();
            database.DeleteMovie(txtMoviesID.Text);
            MessageBox.Show("Movie Deleted");
            Dispose();
        }
    }
}
