namespace RentedMovieProject
{
    partial class Form1
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
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnViewCustomer = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnViewMovie = new System.Windows.Forms.Button();
            this.btnIssueMovie = new System.Windows.Forms.Button();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(3, 28);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(86, 67);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnViewCustomer
            // 
            this.btnViewCustomer.Location = new System.Drawing.Point(104, 28);
            this.btnViewCustomer.Name = "btnViewCustomer";
            this.btnViewCustomer.Size = new System.Drawing.Size(95, 67);
            this.btnViewCustomer.TabIndex = 1;
            this.btnViewCustomer.Text = "View Customer";
            this.btnViewCustomer.UseVisualStyleBackColor = true;
            this.btnViewCustomer.Click += new System.EventHandler(this.btnViewCustomer_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(215, 28);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(75, 67);
            this.btnAddMovie.TabIndex = 2;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnViewMovie
            // 
            this.btnViewMovie.Location = new System.Drawing.Point(305, 28);
            this.btnViewMovie.Name = "btnViewMovie";
            this.btnViewMovie.Size = new System.Drawing.Size(75, 67);
            this.btnViewMovie.TabIndex = 3;
            this.btnViewMovie.Text = "View Movie";
            this.btnViewMovie.UseVisualStyleBackColor = true;
            this.btnViewMovie.Click += new System.EventHandler(this.btnViewMovie_Click);
            // 
            // btnIssueMovie
            // 
            this.btnIssueMovie.Location = new System.Drawing.Point(402, 28);
            this.btnIssueMovie.Name = "btnIssueMovie";
            this.btnIssueMovie.Size = new System.Drawing.Size(75, 67);
            this.btnIssueMovie.TabIndex = 4;
            this.btnIssueMovie.Text = "Issue Movie";
            this.btnIssueMovie.UseVisualStyleBackColor = true;
            this.btnIssueMovie.Click += new System.EventHandler(this.btnIssueMovie_Click);
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.Location = new System.Drawing.Point(494, 28);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(87, 67);
            this.btnReturnMovie.TabIndex = 5;
            this.btnReturnMovie.Text = "Return Movie";
            this.btnReturnMovie.UseVisualStyleBackColor = true;
            this.btnReturnMovie.Click += new System.EventHandler(this.btnReturnMovie_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(727, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 67);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(599, 28);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(122, 67);
            this.btnList.TabIndex = 7;
            this.btnList.Text = "Movies/Customer List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 122);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReturnMovie);
            this.Controls.Add(this.btnIssueMovie);
            this.Controls.Add(this.btnViewMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.btnViewCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Name = "Form1";
            this.Text = "Movies Data";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnViewCustomer;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnViewMovie;
        private System.Windows.Forms.Button btnIssueMovie;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnList;
    }
}

