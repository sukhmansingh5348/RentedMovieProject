namespace RentedMovieProject
{
    partial class ListsForm
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
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(0, 27);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.Size = new System.Drawing.Size(828, 150);
            this.dataGridViewCustomer.TabIndex = 0;
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovies.Location = new System.Drawing.Point(0, 216);
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.Size = new System.Drawing.Size(828, 236);
            this.dataGridViewMovies.TabIndex = 1;
            // 
            // ListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.dataGridViewMovies);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Name = "ListsForm";
            this.Text = "ListsForm";
            this.Load += new System.EventHandler(this.ListsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.DataGridView dataGridViewMovies;
    }
}