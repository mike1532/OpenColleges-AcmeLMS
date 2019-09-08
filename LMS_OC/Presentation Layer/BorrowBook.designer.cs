namespace LMS_OC.Presentation_Layer
{
    partial class frmBorrowBook
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDateOfIssue = new System.Windows.Forms.DateTimePicker();
            this.txtReturnDate = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.gbOffice = new System.Windows.Forms.GroupBox();
            this.lblLibrarianID = new System.Windows.Forms.Label();
            this.txtLibrarianID = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblDateOfIssue = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbDetails.SuspendLayout();
            this.gbOffice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(503, 43);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "BORROW BOOK";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.dateTimePickerDateOfIssue);
            this.gbDetails.Controls.Add(this.txtReturnDate);
            this.gbDetails.Controls.Add(this.txtStudentName);
            this.gbDetails.Controls.Add(this.txtBookTitle);
            this.gbDetails.Controls.Add(this.gbOffice);
            this.gbDetails.Controls.Add(this.btnClear);
            this.gbDetails.Controls.Add(this.btnConfirm);
            this.gbDetails.Controls.Add(this.txtBookID);
            this.gbDetails.Controls.Add(this.txtStudentID);
            this.gbDetails.Controls.Add(this.lblBookTitle);
            this.gbDetails.Controls.Add(this.lblStudentID);
            this.gbDetails.Controls.Add(this.lblStudentName);
            this.gbDetails.Controls.Add(this.lblDateOfIssue);
            this.gbDetails.Controls.Add(this.lblReturnDate);
            this.gbDetails.Controls.Add(this.lblBookID);
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(9, 54);
            this.gbDetails.Margin = new System.Windows.Forms.Padding(4);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Padding = new System.Windows.Forms.Padding(4);
            this.gbDetails.Size = new System.Drawing.Size(485, 348);
            this.gbDetails.TabIndex = 0;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Please enter details";
            // 
            // dateTimePickerDateOfIssue
            // 
            this.dateTimePickerDateOfIssue.CustomFormat = "ddd d MMM yyyy";
            this.dateTimePickerDateOfIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateOfIssue.Location = new System.Drawing.Point(206, 144);
            this.dateTimePickerDateOfIssue.Name = "dateTimePickerDateOfIssue";
            this.dateTimePickerDateOfIssue.Size = new System.Drawing.Size(253, 27);
            this.dateTimePickerDateOfIssue.TabIndex = 16;
            this.dateTimePickerDateOfIssue.Leave += new System.EventHandler(this.dateTimePickerDateOfIssue_Leave);
            // 
            // txtReturnDate
            // 
            this.txtReturnDate.Enabled = false;
            this.txtReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnDate.Location = new System.Drawing.Point(206, 177);
            this.txtReturnDate.Name = "txtReturnDate";
            this.txtReturnDate.Size = new System.Drawing.Size(253, 27);
            this.txtReturnDate.TabIndex = 15;
            this.txtReturnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Enabled = false;
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(206, 103);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(253, 27);
            this.txtStudentName.TabIndex = 14;
            this.txtStudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Enabled = false;
            this.txtBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookTitle.Location = new System.Drawing.Point(114, 67);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(345, 27);
            this.txtBookTitle.TabIndex = 13;
            // 
            // gbOffice
            // 
            this.gbOffice.Controls.Add(this.lblLibrarianID);
            this.gbOffice.Controls.Add(this.txtLibrarianID);
            this.gbOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOffice.Location = new System.Drawing.Point(7, 217);
            this.gbOffice.Name = "gbOffice";
            this.gbOffice.Size = new System.Drawing.Size(466, 73);
            this.gbOffice.TabIndex = 12;
            this.gbOffice.TabStop = false;
            this.gbOffice.Text = "Office Use Only";
            // 
            // lblLibrarianID
            // 
            this.lblLibrarianID.AutoSize = true;
            this.lblLibrarianID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrarianID.Location = new System.Drawing.Point(101, 34);
            this.lblLibrarianID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLibrarianID.Name = "lblLibrarianID";
            this.lblLibrarianID.Size = new System.Drawing.Size(102, 20);
            this.lblLibrarianID.TabIndex = 9;
            this.lblLibrarianID.Text = "Librarian ID:";
            // 
            // txtLibrarianID
            // 
            this.txtLibrarianID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLibrarianID.Enabled = false;
            this.txtLibrarianID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibrarianID.Location = new System.Drawing.Point(230, 32);
            this.txtLibrarianID.Margin = new System.Windows.Forms.Padding(4);
            this.txtLibrarianID.Name = "txtLibrarianID";
            this.txtLibrarianID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLibrarianID.Size = new System.Drawing.Size(93, 26);
            this.txtLibrarianID.TabIndex = 10;
            this.txtLibrarianID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(330, 297);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 43);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(186, 297);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(144, 43);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "&Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtBookID
            // 
            this.txtBookID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.Location = new System.Drawing.Point(113, 33);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBookID.Size = new System.Drawing.Size(97, 26);
            this.txtBookID.TabIndex = 1;
            this.txtBookID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBookID.Leave += new System.EventHandler(this.txtBookID_Leave);
            // 
            // txtStudentID
            // 
            this.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(362, 33);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(97, 26);
            this.txtStudentID.TabIndex = 2;
            this.txtStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStudentID.Leave += new System.EventHandler(this.txtStudentID_Leave);
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.Location = new System.Drawing.Point(17, 72);
            this.lblBookTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(89, 20);
            this.lblBookTitle.TabIndex = 6;
            this.lblBookTitle.Text = "Book Title:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(247, 36);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(93, 20);
            this.lblStudentID.TabIndex = 5;
            this.lblStudentID.Text = "Student ID:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(17, 108);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(120, 20);
            this.lblStudentName.TabIndex = 4;
            this.lblStudentName.Text = "Student Name:";
            // 
            // lblDateOfIssue
            // 
            this.lblDateOfIssue.AutoSize = true;
            this.lblDateOfIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfIssue.Location = new System.Drawing.Point(17, 144);
            this.lblDateOfIssue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateOfIssue.Name = "lblDateOfIssue";
            this.lblDateOfIssue.Size = new System.Drawing.Size(114, 20);
            this.lblDateOfIssue.TabIndex = 3;
            this.lblDateOfIssue.Text = "Date of Issue:";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.Location = new System.Drawing.Point(17, 180);
            this.lblReturnDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(105, 20);
            this.lblReturnDate.TabIndex = 2;
            this.lblReturnDate.Text = "Return Date:";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(17, 36);
            this.lblBookID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(74, 20);
            this.lblBookID.TabIndex = 0;
            this.lblBookID.Text = "Book ID:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(338, 410);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 43);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "C&lose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmBorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 466);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmBorrowBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " Borrow Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBorrowBook_FormClosing);
            this.Load += new System.EventHandler(this.frmBorrowBook_Load);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.gbOffice.ResumeLayout(false);
            this.gbOffice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblDateOfIssue;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtLibrarianID;
        private System.Windows.Forms.Label lblLibrarianID;
        private System.Windows.Forms.GroupBox gbOffice;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtReturnDate;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfIssue;
    }
}