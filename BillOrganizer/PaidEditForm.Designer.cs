namespace BillOrganizer
{
    partial class PaidEditForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblMinDue = new System.Windows.Forms.Label();
            this.txtMinDue = new System.Windows.Forms.TextBox();
            this.lblDatePaid = new System.Windows.Forms.Label();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtDatePaid = new System.Windows.Forms.TextBox();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(41, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(112, 37);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(168, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(284, 44);
            this.txtName.TabIndex = 0;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(41, 155);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(160, 37);
            this.lblDueDate.TabIndex = 5;
            this.lblDueDate.Text = "Due Date:";
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(207, 155);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(121, 44);
            this.txtDueDate.TabIndex = 1;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(41, 254);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(141, 37);
            this.lblBalance.TabIndex = 7;
            this.lblBalance.Text = "Balance:";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(188, 254);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(150, 44);
            this.txtBalance.TabIndex = 2;
            // 
            // lblMinDue
            // 
            this.lblMinDue.AutoSize = true;
            this.lblMinDue.Location = new System.Drawing.Point(41, 369);
            this.lblMinDue.Name = "lblMinDue";
            this.lblMinDue.Size = new System.Drawing.Size(144, 37);
            this.lblMinDue.TabIndex = 9;
            this.lblMinDue.Text = "Min Due:";
            // 
            // txtMinDue
            // 
            this.txtMinDue.Location = new System.Drawing.Point(188, 369);
            this.txtMinDue.Name = "txtMinDue";
            this.txtMinDue.Size = new System.Drawing.Size(150, 44);
            this.txtMinDue.TabIndex = 3;
            // 
            // lblDatePaid
            // 
            this.lblDatePaid.AutoSize = true;
            this.lblDatePaid.Location = new System.Drawing.Point(41, 479);
            this.lblDatePaid.Name = "lblDatePaid";
            this.lblDatePaid.Size = new System.Drawing.Size(166, 37);
            this.lblDatePaid.TabIndex = 11;
            this.lblDatePaid.Text = "Date Paid:";
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.Location = new System.Drawing.Point(41, 572);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(211, 37);
            this.lblPaidAmount.TabIndex = 12;
            this.lblPaidAmount.Text = "Paid Amount:";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnApply.Location = new System.Drawing.Point(473, 280);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(166, 65);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtDatePaid
            // 
            this.txtDatePaid.Location = new System.Drawing.Point(207, 476);
            this.txtDatePaid.Name = "txtDatePaid";
            this.txtDatePaid.Size = new System.Drawing.Size(121, 44);
            this.txtDatePaid.TabIndex = 4;
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Location = new System.Drawing.Point(248, 569);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(150, 44);
            this.txtPaidAmount.TabIndex = 5;
            // 
            // PaidEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(726, 662);
            this.Controls.Add(this.txtPaidAmount);
            this.Controls.Add(this.txtDatePaid);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblPaidAmount);
            this.Controls.Add(this.lblDatePaid);
            this.Controls.Add(this.txtMinDue);
            this.Controls.Add(this.lblMinDue);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtDueDate);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "PaidEditForm";
            this.ShowIcon = false;
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblMinDue;
        private System.Windows.Forms.TextBox txtMinDue;
        private System.Windows.Forms.Label lblDatePaid;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtDatePaid;
        private System.Windows.Forms.TextBox txtPaidAmount;
    }
}