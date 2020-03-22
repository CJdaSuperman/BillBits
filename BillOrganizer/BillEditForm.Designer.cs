namespace BillOrganizer
{
    partial class BillEditForm
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
            this.btnApply = new System.Windows.Forms.Button();
            this.txtMinDue = new System.Windows.Forms.TextBox();
            this.lblMinDue = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lbl1MonthAgo = new System.Windows.Forms.Label();
            this.lbl2MonthsAgo = new System.Windows.Forms.Label();
            this.lbl3MonthsAgo = new System.Windows.Forms.Label();
            this.txt1MonthAgoPaid = new System.Windows.Forms.TextBox();
            this.lblPreviousDates = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.txt2MonthsAgoPaid = new System.Windows.Forms.TextBox();
            this.txt3MonthsAgoPaid = new System.Windows.Forms.TextBox();
            this.txt1MonthAgoDate = new System.Windows.Forms.TextBox();
            this.txt2MonthsAgoDate = new System.Windows.Forms.TextBox();
            this.txt3MonthsAgoDate = new System.Windows.Forms.TextBox();
            this.grpPreviousMonth = new System.Windows.Forms.GroupBox();
            this.lblEdit = new System.Windows.Forms.Label();
            this.grpPreviousMonth.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnApply.Location = new System.Drawing.Point(477, 284);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(166, 65);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtMinDue
            // 
            this.txtMinDue.Location = new System.Drawing.Point(192, 373);
            this.txtMinDue.Name = "txtMinDue";
            this.txtMinDue.Size = new System.Drawing.Size(150, 44);
            this.txtMinDue.TabIndex = 3;
            // 
            // lblMinDue
            // 
            this.lblMinDue.AutoSize = true;
            this.lblMinDue.Location = new System.Drawing.Point(45, 373);
            this.lblMinDue.Name = "lblMinDue";
            this.lblMinDue.Size = new System.Drawing.Size(144, 37);
            this.lblMinDue.TabIndex = 18;
            this.lblMinDue.Text = "Min Due:";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(192, 258);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(150, 44);
            this.txtBalance.TabIndex = 2;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(45, 258);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(141, 37);
            this.lblBalance.TabIndex = 17;
            this.lblBalance.Text = "Balance:";
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(211, 159);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(121, 44);
            this.txtDueDate.TabIndex = 1;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(45, 159);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(160, 37);
            this.lblDueDate.TabIndex = 15;
            this.lblDueDate.Text = "Due Date:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(172, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(284, 44);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(45, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(112, 37);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name:";
            // 
            // lbl1MonthAgo
            // 
            this.lbl1MonthAgo.AutoSize = true;
            this.lbl1MonthAgo.Location = new System.Drawing.Point(5, 73);
            this.lbl1MonthAgo.Name = "lbl1MonthAgo";
            this.lbl1MonthAgo.Size = new System.Drawing.Size(207, 37);
            this.lbl1MonthAgo.TabIndex = 19;
            this.lbl1MonthAgo.Text = "1 Month Ago:";
            // 
            // lbl2MonthsAgo
            // 
            this.lbl2MonthsAgo.AutoSize = true;
            this.lbl2MonthsAgo.Location = new System.Drawing.Point(5, 169);
            this.lbl2MonthsAgo.Name = "lbl2MonthsAgo";
            this.lbl2MonthsAgo.Size = new System.Drawing.Size(225, 37);
            this.lbl2MonthsAgo.TabIndex = 20;
            this.lbl2MonthsAgo.Text = "2 Months Ago:";
            // 
            // lbl3MonthsAgo
            // 
            this.lbl3MonthsAgo.AutoSize = true;
            this.lbl3MonthsAgo.Location = new System.Drawing.Point(5, 250);
            this.lbl3MonthsAgo.Name = "lbl3MonthsAgo";
            this.lbl3MonthsAgo.Size = new System.Drawing.Size(225, 37);
            this.lbl3MonthsAgo.TabIndex = 21;
            this.lbl3MonthsAgo.Text = "3 Months Ago:";
            // 
            // txt1MonthAgoPaid
            // 
            this.txt1MonthAgoPaid.Location = new System.Drawing.Point(475, 73);
            this.txt1MonthAgoPaid.Name = "txt1MonthAgoPaid";
            this.txt1MonthAgoPaid.Size = new System.Drawing.Size(150, 44);
            this.txt1MonthAgoPaid.TabIndex = 22;
            // 
            // lblPreviousDates
            // 
            this.lblPreviousDates.AutoSize = true;
            this.lblPreviousDates.Location = new System.Drawing.Point(219, 13);
            this.lblPreviousDates.Name = "lblPreviousDates";
            this.lblPreviousDates.Size = new System.Drawing.Size(232, 37);
            this.lblPreviousDates.TabIndex = 23;
            this.lblPreviousDates.Text = "Previous Dates";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(506, 13);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(81, 37);
            this.lblPaid.TabIndex = 24;
            this.lblPaid.Text = "Paid";
            // 
            // txt2MonthsAgoPaid
            // 
            this.txt2MonthsAgoPaid.Location = new System.Drawing.Point(475, 162);
            this.txt2MonthsAgoPaid.Name = "txt2MonthsAgoPaid";
            this.txt2MonthsAgoPaid.Size = new System.Drawing.Size(150, 44);
            this.txt2MonthsAgoPaid.TabIndex = 25;
            // 
            // txt3MonthsAgoPaid
            // 
            this.txt3MonthsAgoPaid.Location = new System.Drawing.Point(475, 250);
            this.txt3MonthsAgoPaid.Name = "txt3MonthsAgoPaid";
            this.txt3MonthsAgoPaid.Size = new System.Drawing.Size(150, 44);
            this.txt3MonthsAgoPaid.TabIndex = 26;
            // 
            // txt1MonthAgoDate
            // 
            this.txt1MonthAgoDate.Location = new System.Drawing.Point(268, 73);
            this.txt1MonthAgoDate.Name = "txt1MonthAgoDate";
            this.txt1MonthAgoDate.Size = new System.Drawing.Size(121, 44);
            this.txt1MonthAgoDate.TabIndex = 27;
            // 
            // txt2MonthsAgoDate
            // 
            this.txt2MonthsAgoDate.Location = new System.Drawing.Point(268, 169);
            this.txt2MonthsAgoDate.Name = "txt2MonthsAgoDate";
            this.txt2MonthsAgoDate.Size = new System.Drawing.Size(121, 44);
            this.txt2MonthsAgoDate.TabIndex = 28;
            // 
            // txt3MonthsAgoDate
            // 
            this.txt3MonthsAgoDate.Location = new System.Drawing.Point(268, 250);
            this.txt3MonthsAgoDate.Name = "txt3MonthsAgoDate";
            this.txt3MonthsAgoDate.Size = new System.Drawing.Size(121, 44);
            this.txt3MonthsAgoDate.TabIndex = 29;
            // 
            // grpPreviousMonth
            // 
            this.grpPreviousMonth.Controls.Add(this.txt3MonthsAgoDate);
            this.grpPreviousMonth.Controls.Add(this.txt2MonthsAgoDate);
            this.grpPreviousMonth.Controls.Add(this.txt1MonthAgoDate);
            this.grpPreviousMonth.Controls.Add(this.txt3MonthsAgoPaid);
            this.grpPreviousMonth.Controls.Add(this.txt2MonthsAgoPaid);
            this.grpPreviousMonth.Controls.Add(this.lblPaid);
            this.grpPreviousMonth.Controls.Add(this.lblPreviousDates);
            this.grpPreviousMonth.Controls.Add(this.txt1MonthAgoPaid);
            this.grpPreviousMonth.Controls.Add(this.lbl3MonthsAgo);
            this.grpPreviousMonth.Controls.Add(this.lbl2MonthsAgo);
            this.grpPreviousMonth.Controls.Add(this.lbl1MonthAgo);
            this.grpPreviousMonth.Enabled = false;
            this.grpPreviousMonth.Location = new System.Drawing.Point(26, 509);
            this.grpPreviousMonth.Name = "grpPreviousMonth";
            this.grpPreviousMonth.Size = new System.Drawing.Size(639, 338);
            this.grpPreviousMonth.TabIndex = 30;
            this.grpPreviousMonth.TabStop = false;
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.ForeColor = System.Drawing.Color.Blue;
            this.lblEdit.Location = new System.Drawing.Point(45, 481);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(72, 37);
            this.lblEdit.TabIndex = 31;
            this.lblEdit.Text = "Edit";
            this.lblEdit.Click += new System.EventHandler(this.lblEdit_Click);
            // 
            // BillEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(688, 868);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.grpPreviousMonth);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtMinDue);
            this.Controls.Add(this.lblMinDue);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtDueDate);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "BillEditForm";
            this.ShowIcon = false;
            this.Text = "BillEditForm";
            this.grpPreviousMonth.ResumeLayout(false);
            this.grpPreviousMonth.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtMinDue;
        private System.Windows.Forms.Label lblMinDue;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lbl1MonthAgo;
        private System.Windows.Forms.Label lbl2MonthsAgo;
        private System.Windows.Forms.Label lbl3MonthsAgo;
        private System.Windows.Forms.TextBox txt1MonthAgoPaid;
        private System.Windows.Forms.Label lblPreviousDates;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.TextBox txt2MonthsAgoPaid;
        private System.Windows.Forms.TextBox txt3MonthsAgoPaid;
        private System.Windows.Forms.TextBox txt1MonthAgoDate;
        private System.Windows.Forms.TextBox txt2MonthsAgoDate;
        private System.Windows.Forms.TextBox txt3MonthsAgoDate;
        private System.Windows.Forms.GroupBox grpPreviousMonth;
        private System.Windows.Forms.Label lblEdit;
    }
}