namespace BillOrganizer
{
    partial class Bills
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
            this.lstBills = new System.Windows.Forms.CheckedListBox();
            this.lblBills = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnPaid = new System.Windows.Forms.Button();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBills
            // 
            this.lstBills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstBills.FormattingEnabled = true;
            this.lstBills.Location = new System.Drawing.Point(41, 110);
            this.lstBills.Name = "lstBills";
            this.lstBills.Size = new System.Drawing.Size(530, 550);
            this.lstBills.TabIndex = 0;
            // 
            // lblBills
            // 
            this.lblBills.AutoSize = true;
            this.lblBills.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBills.Location = new System.Drawing.Point(32, 35);
            this.lblBills.Name = "lblBills";
            this.lblBills.Size = new System.Drawing.Size(100, 54);
            this.lblBills.TabIndex = 1;
            this.lblBills.Text = "Bills";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPay.Location = new System.Drawing.Point(626, 110);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(193, 96);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnPaid
            // 
            this.btnPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPaid.Location = new System.Drawing.Point(860, 110);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(193, 96);
            this.btnPaid.TabIndex = 3;
            this.btnPaid.Text = "Paid";
            this.btnPaid.UseVisualStyleBackColor = false;
            this.btnPaid.Click += new System.EventHandler(this.btnPaid_Click);
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddBill.Location = new System.Drawing.Point(626, 295);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(193, 96);
            this.btnAddBill.TabIndex = 4;
            this.btnAddBill.Text = "Add Bill";
            this.btnAddBill.UseVisualStyleBackColor = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeleteBill.Location = new System.Drawing.Point(860, 472);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(193, 96);
            this.btnDeleteBill.TabIndex = 7;
            this.btnDeleteBill.Text = "Delete Bill";
            this.btnDeleteBill.UseVisualStyleBackColor = false;
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExpand.Location = new System.Drawing.Point(626, 472);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(193, 96);
            this.btnExpand.TabIndex = 6;
            this.btnExpand.Text = "Expand";
            this.btnExpand.UseVisualStyleBackColor = false;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEdit.Location = new System.Drawing.Point(860, 295);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(193, 96);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1094, 811);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.btnDeleteBill);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.btnPaid);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblBills);
            this.Controls.Add(this.lstBills);
            this.Name = "Bills";
            this.ShowIcon = false;
            this.Text = "Bills";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstBills;
        private System.Windows.Forms.Label lblBills;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnPaid;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnEdit;
    }
}