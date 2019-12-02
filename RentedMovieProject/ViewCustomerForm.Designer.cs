namespace RentedMovieProject
{
    partial class ViewCustomerForm
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
            this.dataGridViewViewCustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewViewCustomer
            // 
            this.dataGridViewViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViewCustomer.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewViewCustomer.Name = "dataGridViewViewCustomer";
            this.dataGridViewViewCustomer.Size = new System.Drawing.Size(672, 310);
            this.dataGridViewViewCustomer.TabIndex = 0;
            this.dataGridViewViewCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewViewCustomer_CellContentClick);
            this.dataGridViewViewCustomer.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewViewCustomer_CellMouseDoubleClick);
            // 
            // ViewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 310);
            this.Controls.Add(this.dataGridViewViewCustomer);
            this.Name = "ViewCustomerForm";
            this.Text = "ViewCustomerForm";
            this.Load += new System.EventHandler(this.ViewCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewViewCustomer;
    }
}