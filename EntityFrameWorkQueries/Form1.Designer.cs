namespace EntityFrameWorkQueries
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectAllVendors = new System.Windows.Forms.Button();
            this.btnAllCaliVendors = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectAllVendors
            // 
            this.btnSelectAllVendors.Location = new System.Drawing.Point(81, 64);
            this.btnSelectAllVendors.Name = "btnSelectAllVendors";
            this.btnSelectAllVendors.Size = new System.Drawing.Size(334, 46);
            this.btnSelectAllVendors.TabIndex = 0;
            this.btnSelectAllVendors.Text = "Select * FROM Vendors";
            this.btnSelectAllVendors.UseVisualStyleBackColor = true;
            this.btnSelectAllVendors.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAllCaliVendors
            // 
            this.btnAllCaliVendors.Location = new System.Drawing.Point(81, 171);
            this.btnAllCaliVendors.Name = "btnAllCaliVendors";
            this.btnAllCaliVendors.Size = new System.Drawing.Size(334, 107);
            this.btnAllCaliVendors.TabIndex = 1;
            this.btnAllCaliVendors.Text = "Select*FROM Vendors \r\nWHERE VendorState=\'CA\' \r\nORDER by VendorName Ascending";
            this.btnAllCaliVendors.UseVisualStyleBackColor = true;
            this.btnAllCaliVendors.Click += new System.EventHandler(this.btnAllCaliVendors_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(81, 333);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 741);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAllCaliVendors);
            this.Controls.Add(this.btnSelectAllVendors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSelectAllVendors;
        private Button btnAllCaliVendors;
        private Button button3;
    }
}