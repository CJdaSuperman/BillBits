namespace BillOrganizer
{
    partial class AddBillForm
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
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblMinDue = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtMinDue = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblName.Location = new System.Drawing.Point(47, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(112, 37);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblDueDate.Location = new System.Drawing.Point(47, 166);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(160, 37);
            this.lblDueDate.TabIndex = 1;
            this.lblDueDate.Text = "Due Date:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblBalance.Location = new System.Drawing.Point(44, 287);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(141, 37);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Balance:";
            // 
            // lblMinDue
            // 
            this.lblMinDue.AutoSize = true;
            this.lblMinDue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblMinDue.Location = new System.Drawing.Point(44, 403);
            this.lblMinDue.Name = "lblMinDue";
            this.lblMinDue.Size = new System.Drawing.Size(144, 37);
            this.lblMinDue.TabIndex = 3;
            this.lblMinDue.Text = "Min Due:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(182, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(409, 44);
            this.txtName.TabIndex = 4;
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(229, 166);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(165, 44);
            this.txtDueDate.TabIndex = 5;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(229, 287);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(165, 44);
            this.txtBalance.TabIndex = 6;
            // 
            // txtMinDue
            // 
            this.txtMinDue.Location = new System.Drawing.Point(229, 403);
            this.txtMinDue.Name = "txtMinDue";
            this.txtMinDue.Size = new System.Drawing.Size(165, 44);
            this.txtMinDue.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.Location = new System.Drawing.Point(233, 521);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 84);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(616, 648);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMinDue);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtDueDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMinDue);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblName);
            this.Name = "AddBillForm";
            this.ShowIcon = false;
            this.Text = "AddBillForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblMinDue;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtMinDue;
        private System.Windows.Forms.Button btnAdd;
    }
}