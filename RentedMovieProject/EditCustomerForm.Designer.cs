namespace RentedMovieProject
{
    partial class EditCustomerForm
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
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.btnDaleteCust = new System.Windows.Forms.Button();
            this.btnUpdateCust = new System.Windows.Forms.Button();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(197, 20);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(295, 20);
            this.txtCustomerID.TabIndex = 58;
            this.txtCustomerID.Visible = false;
            // 
            // btnDaleteCust
            // 
            this.btnDaleteCust.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDaleteCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaleteCust.ForeColor = System.Drawing.Color.White;
            this.btnDaleteCust.Location = new System.Drawing.Point(366, 237);
            this.btnDaleteCust.Name = "btnDaleteCust";
            this.btnDaleteCust.Size = new System.Drawing.Size(126, 64);
            this.btnDaleteCust.TabIndex = 57;
            this.btnDaleteCust.Text = "Delete Customer";
            this.btnDaleteCust.UseVisualStyleBackColor = false;
            this.btnDaleteCust.Click += new System.EventHandler(this.btnDaleteCust_Click);
            // 
            // btnUpdateCust
            // 
            this.btnUpdateCust.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUpdateCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCust.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCust.Location = new System.Drawing.Point(130, 237);
            this.btnUpdateCust.Name = "btnUpdateCust";
            this.btnUpdateCust.Size = new System.Drawing.Size(135, 64);
            this.btnUpdateCust.TabIndex = 56;
            this.btnUpdateCust.Text = "Update Customer";
            this.btnUpdateCust.UseVisualStyleBackColor = false;
            this.btnUpdateCust.Click += new System.EventHandler(this.btnUpdateCust_Click);
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(197, 185);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(295, 20);
            this.txtPhoneNo.TabIndex = 55;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(197, 142);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(295, 24);
            this.txtAddress.TabIndex = 54;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(197, 66);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(295, 20);
            this.txtFirstName.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(118, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Phone No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(118, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(118, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "First Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(197, 110);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(295, 20);
            this.txtLastName.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(118, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Last Name:";
            // 
            // EditCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 324);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.btnDaleteCust);
            this.Controls.Add(this.btnUpdateCust);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "EditCustomerForm";
            this.Text = "EditCustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Button btnDaleteCust;
        private System.Windows.Forms.Button btnUpdateCust;
        public System.Windows.Forms.TextBox txtPhoneNo;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtLastName;
        public System.Windows.Forms.Label label1;
    }
}