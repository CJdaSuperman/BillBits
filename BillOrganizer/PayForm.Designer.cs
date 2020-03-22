namespace BillOrganizer
{
    partial class PayForm
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
            this.lblDatePaid = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.txtDatePaid = new System.Windows.Forms.TextBox();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDatePaid
            // 
            this.lblDatePaid.AutoSize = true;
            this.lblDatePaid.Location = new System.Drawing.Point(89, 66);
            this.lblDatePaid.Name = "lblDatePaid";
            this.lblDatePaid.Size = new System.Drawing.Size(166, 37);
            this.lblDatePaid.TabIndex = 0;
            this.lblDatePaid.Text = "Date Paid:";
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Location = new System.Drawing.Point(89, 153);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(211, 37);
            this.lblAmountPaid.TabIndex = 1;
            this.lblAmountPaid.Text = "Amount Paid:";
            // 
            // txtDatePaid
            // 
            this.txtDatePaid.Location = new System.Drawing.Point(272, 66);
            this.txtDatePaid.Name = "txtDatePaid";
            this.txtDatePaid.Size = new System.Drawing.Size(164, 44);
            this.txtDatePaid.TabIndex = 1;
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Location = new System.Drawing.Point(319, 146);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(155, 44);
            this.txtAmountPaid.TabIndex = 2;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnApply.Location = new System.Drawing.Point(190, 247);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(166, 65);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(569, 372);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtAmountPaid);
            this.Controls.Add(this.txtDatePaid);
            this.Controls.Add(this.lblAmountPaid);
            this.Controls.Add(this.lblDatePaid);
            this.Name = "PayForm";
            this.ShowIcon = false;
            this.Text = "Pay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatePaid;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.TextBox txtDatePaid;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Button btnApply;
    }
}