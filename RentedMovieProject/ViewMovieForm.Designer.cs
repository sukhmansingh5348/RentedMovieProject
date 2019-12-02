namespace RentedMovieProject
{
    partial class ViewMovieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewMovieView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMovieView
            // 
            this.dataGridViewMovieView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovieView.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMovieView.Name = "dataGridViewMovieView";
            this.dataGridViewMovieView.Size = new System.Drawing.Size(997, 342);
            this.dataGridViewMovieView.TabIndex = 0;
            this.dataGridViewMovieView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMovieView_CellMouseDoubleClick);
            // 
            // ViewMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 342);
            this.Controls.Add(this.dataGridViewMovieView);
            this.Name = "ViewMovieForm";
            this.Text = "ViewMovieForm";
            this.Load += new System.EventHandler(this.ViewMovieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMovieView;
    }
}