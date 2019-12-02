namespace RentedMovieProject
{
    partial class IssueMovieForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.moviesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rentedMovieProjectDataSet2 = new RentedMovieProject.RentedMovieProjectDataSet2();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rentedMovieProjectDataSet3 = new RentedMovieProject.RentedMovieProjectDataSet3();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnIssue = new System.Windows.Forms.Button();
            this.moviesTableAdapter1 = new RentedMovieProject.RentedMovieProjectDataSet2TableAdapters.MoviesTableAdapter();
            this.customerTableAdapter1 = new RentedMovieProject.RentedMovieProjectDataSet3TableAdapters.CustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMovieProjectDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMovieProjectDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Issue Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 294);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone No:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.moviesBindingSource1;
            this.comboBox1.DisplayMember = "Title";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(320, 76);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "ID";
            // 
            // moviesBindingSource1
            // 
            this.moviesBindingSource1.DataMember = "Movies";
            this.moviesBindingSource1.DataSource = this.rentedMovieProjectDataSet2;
            // 
            // rentedMovieProjectDataSet2
            // 
            this.rentedMovieProjectDataSet2.DataSetName = "RentedMovieProjectDataSet2";
            this.rentedMovieProjectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.customerBindingSource1;
            this.comboBox2.DisplayMember = "FirstName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(320, 119);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(265, 24);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.ValueMember = "ID";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.rentedMovieProjectDataSet3;
            // 
            // rentedMovieProjectDataSet3
            // 
            this.rentedMovieProjectDataSet3.DataSetName = "RentedMovieProjectDataSet3";
            this.rentedMovieProjectDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(320, 160);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 210);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 22);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(320, 251);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(265, 22);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(320, 294);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(265, 22);
            this.textBox3.TabIndex = 11;
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(320, 366);
            this.btnIssue.Margin = new System.Windows.Forms.Padding(4);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(153, 49);
            this.btnIssue.TabIndex = 12;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // moviesTableAdapter1
            // 
            this.moviesTableAdapter1.ClearBeforeFill = true;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // IssueMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 442);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IssueMovieForm";
            this.Text = "Issue Movie";
            this.Load += new System.EventHandler(this.IssueMovieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMovieProjectDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMovieProjectDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnIssue;
        private RentedMovieProjectDataSet2 rentedMovieProjectDataSet2;
        private System.Windows.Forms.BindingSource moviesBindingSource1;
        private RentedMovieProjectDataSet2TableAdapters.MoviesTableAdapter moviesTableAdapter1;
        private RentedMovieProjectDataSet3 rentedMovieProjectDataSet3;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private RentedMovieProjectDataSet3TableAdapters.CustomerTableAdapter customerTableAdapter1;
    }
}