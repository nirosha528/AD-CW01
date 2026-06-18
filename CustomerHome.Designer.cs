namespace EShift_transport
{
    partial class CustomerHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerHome));
            this.label1 = new System.Windows.Forms.Label();
            this.btnimage = new System.Windows.Forms.Button();
            this.lbladmin = new System.Windows.Forms.Label();
            this.lbleshift = new System.Windows.Forms.Label();
            this.btnload = new System.Windows.Forms.Button();
            this.btnjob = new System.Windows.Forms.Button();
            this.btncustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(656, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 54);
            this.label1.TabIndex = 76;
            this.label1.Text = "Welcome";
            // 
            // btnimage
            // 
            this.btnimage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimage.Image = ((System.Drawing.Image)(resources.GetObject("btnimage.Image")));
            this.btnimage.Location = new System.Drawing.Point(22, 21);
            this.btnimage.Name = "btnimage";
            this.btnimage.Size = new System.Drawing.Size(207, 160);
            this.btnimage.TabIndex = 75;
            this.btnimage.UseVisualStyleBackColor = true;
            // 
            // lbladmin
            // 
            this.lbladmin.AutoSize = true;
            this.lbladmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmin.Location = new System.Drawing.Point(738, 67);
            this.lbladmin.Name = "lbladmin";
            this.lbladmin.Size = new System.Drawing.Size(159, 36);
            this.lbladmin.TabIndex = 74;
            this.lbladmin.Text = "Customer ";
            // 
            // lbleshift
            // 
            this.lbleshift.AutoSize = true;
            this.lbleshift.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleshift.Location = new System.Drawing.Point(260, 21);
            this.lbleshift.Name = "lbleshift";
            this.lbleshift.Size = new System.Drawing.Size(275, 91);
            this.lbleshift.TabIndex = 73;
            this.lbleshift.Text = "e-Shift";
            // 
            // btnload
            // 
            this.btnload.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.Location = new System.Drawing.Point(22, 418);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(190, 39);
            this.btnload.TabIndex = 72;
            this.btnload.Text = "Load";
            this.btnload.UseVisualStyleBackColor = true;
            // 
            // btnjob
            // 
            this.btnjob.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjob.Location = new System.Drawing.Point(22, 351);
            this.btnjob.Name = "btnjob";
            this.btnjob.Size = new System.Drawing.Size(190, 39);
            this.btnjob.TabIndex = 71;
            this.btnjob.Text = "Transport Job";
            this.btnjob.UseVisualStyleBackColor = true;
            // 
            // btncustomer
            // 
            this.btncustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustomer.Location = new System.Drawing.Point(22, 278);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(190, 39);
            this.btncustomer.TabIndex = 70;
            this.btncustomer.Text = "Customer";
            this.btncustomer.UseVisualStyleBackColor = true;
            // 
            // CustomerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1500, 701);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnimage);
            this.Controls.Add(this.lbladmin);
            this.Controls.Add(this.lbleshift);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.btnjob);
            this.Controls.Add(this.btncustomer);
            this.Name = "CustomerHome";
            this.Text = "CustomerHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnimage;
        private System.Windows.Forms.Label lbladmin;
        private System.Windows.Forms.Label lbleshift;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnjob;
        private System.Windows.Forms.Button btncustomer;
    }
}