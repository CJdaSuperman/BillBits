namespace BillOrganizer
{
    partial class PaidOffForm
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
            this.lstPaidBills = new System.Windows.Forms.CheckedListBox();
            this.lblBills = new System.Windows.Forms.Label();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.lblNextMonth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstPaidBills
            // 
            this.lstPaidBills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstPaidBills.FormattingEnabled = true;
            this.lstPaidBills.Location = new System.Drawing.Point(41, 131);
            this.lstPaidBills.Name = "lstPaidBills";
            this.lstPaidBills.Size = new System.Drawing.Size(530, 550);
            this.lstPaidBills.TabIndex = 1;
            // 
            // lblBills
            // 
            this.lblBills.AutoSize = true;
            this.lblBills.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBills.Location = new System.Drawing.Point(32, 52);
            this.lblBills.Name = "lblBills";
            this.lblBills.Size = new System.Drawing.Size(193, 54);
            this.lblBills.TabIndex = 2;
            this.lblBills.Text = "Paid Bills";
            // 
            // btnExpand
            // 
            this.btnExpand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExpand.Location = new System.Drawing.Point(669, 143);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(193, 96);
            this.btnExpand.TabIndex = 0;
            this.btnExpand.Text = "Expand";
            this.btnExpand.UseVisualStyleBackColor = false;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRestore.Location = new System.Drawing.Point(669, 299);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(193, 96);
            this.btnRestore.TabIndex = 2;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBack.Location = new System.Drawing.Point(778, 458);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(193, 96);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEdit.Location = new System.Drawing.Point(901, 143);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(193, 96);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeleteBill.Location = new System.Drawing.Point(901, 299);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(193, 96);
            this.btnDeleteBill.TabIndex = 3;
            this.btnDeleteBill.Text = "Delete Bill";
            this.btnDeleteBill.UseVisualStyleBackColor = false;
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // lblNextMonth
            // 
            this.lblNextMonth.AutoSize = true;
            this.lblNextMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextMonth.ForeColor = System.Drawing.Color.Blue;
            this.lblNextMonth.Location = new System.Drawing.Point(206, 708);
            this.lblNextMonth.Name = "lblNextMonth";
            this.lblNextMonth.Size = new System.Drawing.Size(190, 37);
            this.lblNextMonth.TabIndex = 5;
            this.lblNextMonth.Text = "Next Month";
            this.lblNextMonth.Click += new System.EventHandler(this.lblNextMonth_Click);
            // 
            // PaidOffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1112, 809);
            this.Controls.Add(this.lblNextMonth);
            this.Controls.Add(this.btnDeleteBill);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.lblBills);
            this.Controls.Add(this.lstPaidBills);
            this.Name = "PaidOffForm";
            this.ShowIcon = false;
            this.Text = "Paid Bills";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstPaidBills;
        private System.Windows.Forms.Label lblBills;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.Label lblNextMonth;
    }
}