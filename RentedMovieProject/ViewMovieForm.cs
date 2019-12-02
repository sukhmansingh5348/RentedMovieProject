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
    public partial class ViewMovieForm : Form
    {
        public ViewMovieForm()
        {
            InitializeComponent();
        }

        private void dataGridViewMovieView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditMovieForm editMovie = new EditMovieForm();
            editMovie.txtMoviesID.Text = this.dataGridViewMovieView.CurrentRow.Cells[0].Value.ToString();
            editMovie.txtTitle.Text = this.dataGridViewMovieView.CurrentRow.Cells[2].Value.ToString();
            editMovie.txtRating.Text = this.dataGridViewMovieView.CurrentRow.Cells[1].Value.ToString();
            editMovie.txtYear.Text = this.dataGridViewMovieView.CurrentRow.Cells[3].Value.ToString();
            editMovie.txtCopies.Text = this.dataGridViewMovieView.CurrentRow.Cells[4].Value.ToString();
            editMovie.txtPlot.Text = this.dataGridViewMovieView.CurrentRow.Cells[5].Value.ToString();
            editMovie.txtGenre.Text = this.dataGridViewMovieView.CurrentRow.Cells[6].Value.ToString();
            editMovie.ShowDialog();
            dataGridViewMovieView.DataSource = new AllFunctions().FindAllMovies();
        }

        private void ViewMovieForm_Load(object sender, EventArgs e)
        {
            dataGridViewMovieView.DataSource = new AllFunctions().FindAllMovies();
        }
    }
}
