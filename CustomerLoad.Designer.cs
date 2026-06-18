namespace EShift_transport
{
    partial class CustomerLoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerLoad));
            this.txtloadid = new System.Windows.Forms.TextBox();
            this.lblloadid = new System.Windows.Forms.Label();
            this.btnload = new System.Windows.Forms.Button();
            this.btnjob = new System.Windows.Forms.Button();
            this.btncustomer = new System.Windows.Forms.Button();
            this.cmbquantity = new System.Windows.Forms.ComboBox();
            this.lblproductid = new System.Windows.Forms.Label();
            this.dataGridViewloaddetails = new System.Windows.Forms.DataGridView();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.lblproductname = new System.Windows.Forms.Label();
            this.lblquantity = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnimage = new System.Windows.Forms.Button();
            this.lblload = new System.Windows.Forms.Label();
            this.lbleshift = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewloaddetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtloadid
            // 
            this.txtloadid.Location = new System.Drawing.Point(481, 362);
            this.txtloadid.Name = "txtloadid";
            this.txtloadid.Size = new System.Drawing.Size(257, 22);
            this.txtloadid.TabIndex = 266;
            // 
            // lblloadid
            // 
            this.lblloadid.AutoSize = true;
            this.lblloadid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloadid.Location = new System.Drawing.Point(350, 355);
            this.lblloadid.Name = "lblloadid";
            this.lblloadid.Size = new System.Drawing.Size(100, 29);
            this.lblloadid.TabIndex = 265;
            this.lblloadid.Text = "Load Id";
            // 
            // btnload
            // 
            this.btnload.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.Location = new System.Drawing.Point(12, 371);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(190, 39);
            this.btnload.TabIndex = 264;
            this.btnload.Text = "Load";
            this.btnload.UseVisualStyleBackColor = true;
            // 
            // btnjob
            // 
            this.btnjob.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjob.Location = new System.Drawing.Point(12, 304);
            this.btnjob.Name = "btnjob";
            this.btnjob.Size = new System.Drawing.Size(190, 39);
            this.btnjob.TabIndex = 263;
            this.btnjob.Text = "Transport Job";
            this.btnjob.UseVisualStyleBackColor = true;
            // 
            // btncustomer
            // 
            this.btncustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustomer.Location = new System.Drawing.Point(12, 231);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(190, 39);
            this.btncustomer.TabIndex = 262;
            this.btncustomer.Text = "Customer";
            this.btncustomer.UseVisualStyleBackColor = true;
            // 
            // cmbquantity
            // 
            this.cmbquantity.FormattingEnabled = true;
            this.cmbquantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbquantity.Location = new System.Drawing.Point(603, 228);
            this.cmbquantity.Name = "cmbquantity";
            this.cmbquantity.Size = new System.Drawing.Size(257, 24);
            this.cmbquantity.TabIndex = 261;
            // 
            // lblproductid
            // 
            this.lblproductid.AutoSize = true;
            this.lblproductid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductid.Location = new System.Drawing.Point(350, 175);
            this.lblproductid.Name = "lblproductid";
            this.lblproductid.Size = new System.Drawing.Size(0, 29);
            this.lblproductid.TabIndex = 260;
            // 
            // dataGridViewloaddetails
            // 
            this.dataGridViewloaddetails.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewloaddetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewloaddetails.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridViewloaddetails.Location = new System.Drawing.Point(355, 423);
            this.dataGridViewloaddetails.Name = "dataGridViewloaddetails";
            this.dataGridViewloaddetails.RowHeadersWidth = 51;
            this.dataGridViewloaddetails.RowTemplate.Height = 24;
            this.dataGridViewloaddetails.Size = new System.Drawing.Size(1052, 230);
            this.dataGridViewloaddetails.TabIndex = 259;
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(795, 348);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(124, 43);
            this.btnsearch.TabIndex = 258;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(603, 175);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(257, 22);
            this.txtproductname.TabIndex = 257;
            // 
            // lblproductname
            // 
            this.lblproductname.AutoSize = true;
            this.lblproductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductname.Location = new System.Drawing.Point(350, 165);
            this.lblproductname.Name = "lblproductname";
            this.lblproductname.Size = new System.Drawing.Size(179, 29);
            this.lblproductname.TabIndex = 256;
            this.lblproductname.Text = "Product Name";
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantity.Location = new System.Drawing.Point(350, 221);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(108, 29);
            this.lblquantity.TabIndex = 255;
            this.lblquantity.Text = "Quantity";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(976, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 43);
            this.btnAdd.TabIndex = 254;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnimage
            // 
            this.btnimage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimage.Image = ((System.Drawing.Image)(resources.GetObject("btnimage.Image")));
            this.btnimage.Location = new System.Drawing.Point(12, 12);
            this.btnimage.Name = "btnimage";
            this.btnimage.Size = new System.Drawing.Size(207, 160);
            this.btnimage.TabIndex = 253;
            this.btnimage.UseVisualStyleBackColor = true;
            // 
            // lblload
            // 
            this.lblload.AutoSize = true;
            this.lblload.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblload.Location = new System.Drawing.Point(715, 47);
            this.lblload.Name = "lblload";
            this.lblload.Size = new System.Drawing.Size(192, 36);
            this.lblload.TabIndex = 252;
            this.lblload.Text = "Load Details";
            // 
            // lbleshift
            // 
            this.lbleshift.AutoSize = true;
            this.lbleshift.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleshift.Location = new System.Drawing.Point(236, 12);
            this.lbleshift.Name = "lbleshift";
            this.lbleshift.Size = new System.Drawing.Size(275, 91);
            this.lbleshift.TabIndex = 251;
            this.lbleshift.Text = "e-Shift";
            // 
            // CustomerLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1508, 707);
            this.Controls.Add(this.txtloadid);
            this.Controls.Add(this.lblloadid);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.btnjob);
            this.Controls.Add(this.btncustomer);
            this.Controls.Add(this.cmbquantity);
            this.Controls.Add(this.lblproductid);
            this.Controls.Add(this.dataGridViewloaddetails);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtproductname);
            this.Controls.Add(this.lblproductname);
            this.Controls.Add(this.lblquantity);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnimage);
            this.Controls.Add(this.lblload);
            this.Controls.Add(this.lbleshift);
            this.Name = "CustomerLoad";
            this.Text = "CustomerLoad";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewloaddetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtloadid;
        private System.Windows.Forms.Label lblloadid;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnjob;
        private System.Windows.Forms.Button btncustomer;
        private System.Windows.Forms.ComboBox cmbquantity;
        private System.Windows.Forms.Label lblproductid;
        private System.Windows.Forms.DataGridView dataGridViewloaddetails;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.Label lblproductname;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnimage;
        protected internal System.Windows.Forms.Label lblload;
        private System.Windows.Forms.Label lbleshift;
    }
}