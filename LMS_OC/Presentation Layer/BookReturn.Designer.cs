namespace LMS_OC.Presentation_Layer
{
    partial class frmBookReturn
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbEnterDetails = new System.Windows.Forms.GroupBox();
            this.gbOfficeUse = new System.Windows.Forms.GroupBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblLibrarianID = new System.Windows.Forms.Label();
            this.lblIssueID = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtLibrarianID = new System.Windows.Forms.TextBox();
            this.txtIssueID = new System.Windows.Forms.TextBox();
            this.btnSearchRecords = new System.Windows.Forms.Button();
            this.gbRecordInfo = new System.Windows.Forms.GroupBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblDateOfIssue = new System.Windows.Forms.Label();
            this.lblDateReturned = new System.Windows.Forms.Label();
            this.dateTimePickerReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblDisplayTitle = new System.Windows.Forms.Label();
            this.lblDisplayDateIssued = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSearchAgain = new System.Windows.Forms.Button();
            this.gbEnterDetails.SuspendLayout();
            this.gbOfficeUse.SuspendLayout();
            this.gbRecordInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(338, 409);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 43);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(507, 43);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "RETURN BOOK";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // gbEnterDetails
            // 
            this.gbEnterDetails.Controls.Add(this.txtBookID);
            this.gbEnterDetails.Controls.Add(this.txtStudentID);
            this.gbEnterDetails.Controls.Add(this.lblStudentID);
            this.gbEnterDetails.Controls.Add(this.lblBookID);
            this.gbEnterDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEnterDetails.Location = new System.Drawing.Point(24, 58);
            this.gbEnterDetails.Name = "gbEnterDetails";
            this.gbEnterDetails.Size = new System.Drawing.Size(200, 100);
            this.gbEnterDetails.TabIndex = 0;
            this.gbEnterDetails.TabStop = false;
            this.gbEnterDetails.Text = "Enter Details";
            // 
            // gbOfficeUse
            // 
            this.gbOfficeUse.Controls.Add(this.txtLibrarianID);
            this.gbOfficeUse.Controls.Add(this.txtIssueID);
            this.gbOfficeUse.Controls.Add(this.lblLibrarianID);
            this.gbOfficeUse.Controls.Add(this.lblIssueID);
            this.gbOfficeUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOfficeUse.Location = new System.Drawing.Point(282, 58);
            this.gbOfficeUse.Name = "gbOfficeUse";
            this.gbOfficeUse.Size = new System.Drawing.Size(200, 100);
            this.gbOfficeUse.TabIndex = 6;
            this.gbOfficeUse.TabStop = false;
            this.gbOfficeUse.Text = "Office Use Only";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(6, 67);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(66, 18);
            this.lblBookID.TabIndex = 0;
            this.lblBookID.Text = "Book ID:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(6, 34);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(80, 18);
            this.lblStudentID.TabIndex = 1;
            this.lblStudentID.Text = "Student ID:";
            // 
            // lblLibrarianID
            // 
            this.lblLibrarianID.AutoSize = true;
            this.lblLibrarianID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrarianID.Location = new System.Drawing.Point(6, 67);
            this.lblLibrarianID.Name = "lblLibrarianID";
            this.lblLibrarianID.Size = new System.Drawing.Size(86, 18);
            this.lblLibrarianID.TabIndex = 2;
            this.lblLibrarianID.Text = "Librarian ID:";
            // 
            // lblIssueID
            // 
            this.lblIssueID.AutoSize = true;
            this.lblIssueID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueID.Location = new System.Drawing.Point(6, 34);
            this.lblIssueID.Name = "lblIssueID";
            this.lblIssueID.Size = new System.Drawing.Size(65, 18);
            this.lblIssueID.TabIndex = 3;
            this.lblIssueID.Text = "Issue ID:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(109, 31);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(75, 24);
            this.txtStudentID.TabIndex = 0;
            this.txtStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBookID
            // 
            this.txtBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.Location = new System.Drawing.Point(109, 64);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(75, 24);
            this.txtBookID.TabIndex = 1;
            this.txtBookID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLibrarianID
            // 
            this.txtLibrarianID.Enabled = false;
            this.txtLibrarianID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibrarianID.Location = new System.Drawing.Point(110, 64);
            this.txtLibrarianID.Name = "txtLibrarianID";
            this.txtLibrarianID.Size = new System.Drawing.Size(75, 24);
            this.txtLibrarianID.TabIndex = 7;
            this.txtLibrarianID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIssueID
            // 
            this.txtIssueID.Enabled = false;
            this.txtIssueID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueID.Location = new System.Drawing.Point(110, 31);
            this.txtIssueID.Name = "txtIssueID";
            this.txtIssueID.Size = new System.Drawing.Size(75, 24);
            this.txtIssueID.TabIndex = 8;
            this.txtIssueID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearchRecords
            // 
            this.btnSearchRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRecords.Location = new System.Drawing.Point(167, 165);
            this.btnSearchRecords.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchRecords.Name = "btnSearchRecords";
            this.btnSearchRecords.Size = new System.Drawing.Size(172, 36);
            this.btnSearchRecords.TabIndex = 1;
            this.btnSearchRecords.Text = "&Search Records";
            this.btnSearchRecords.UseVisualStyleBackColor = true;
            this.btnSearchRecords.Click += new System.EventHandler(this.btnSearchRecords_Click);
            // 
            // gbRecordInfo
            // 
            this.gbRecordInfo.Controls.Add(this.lblDisplayDateIssued);
            this.gbRecordInfo.Controls.Add(this.lblDisplayTitle);
            this.gbRecordInfo.Controls.Add(this.lblDisplayName);
            this.gbRecordInfo.Controls.Add(this.dateTimePickerReturnDate);
            this.gbRecordInfo.Controls.Add(this.lblDateReturned);
            this.gbRecordInfo.Controls.Add(this.lblDateOfIssue);
            this.gbRecordInfo.Controls.Add(this.lblBookTitle);
            this.gbRecordInfo.Controls.Add(this.lblStudentName);
            this.gbRecordInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRecordInfo.Location = new System.Drawing.Point(24, 174);
            this.gbRecordInfo.Name = "gbRecordInfo";
            this.gbRecordInfo.Size = new System.Drawing.Size(458, 228);
            this.gbRecordInfo.TabIndex = 7;
            this.gbRecordInfo.TabStop = false;
            this.gbRecordInfo.Text = "Information";
            this.gbRecordInfo.Visible = false;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(6, 43);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(106, 18);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "Student Name:";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.Location = new System.Drawing.Point(6, 82);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(79, 18);
            this.lblBookTitle.TabIndex = 2;
            this.lblBookTitle.Text = "Book Title:";
            // 
            // lblDateOfIssue
            // 
            this.lblDateOfIssue.AutoSize = true;
            this.lblDateOfIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfIssue.Location = new System.Drawing.Point(6, 121);
            this.lblDateOfIssue.Name = "lblDateOfIssue";
            this.lblDateOfIssue.Size = new System.Drawing.Size(90, 18);
            this.lblDateOfIssue.TabIndex = 3;
            this.lblDateOfIssue.Text = "Date Issued:";
            // 
            // lblDateReturned
            // 
            this.lblDateReturned.AutoSize = true;
            this.lblDateReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReturned.Location = new System.Drawing.Point(6, 160);
            this.lblDateReturned.Name = "lblDateReturned";
            this.lblDateReturned.Size = new System.Drawing.Size(107, 18);
            this.lblDateReturned.TabIndex = 4;
            this.lblDateReturned.Text = "Date Returned:";
            // 
            // dateTimePickerReturnDate
            // 
            this.dateTimePickerReturnDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerReturnDate.CustomFormat = "ddd d MMM yyyy";
            this.dateTimePickerReturnDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReturnDate.Location = new System.Drawing.Point(140, 156);
            this.dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            this.dateTimePickerReturnDate.Size = new System.Drawing.Size(284, 27);
            this.dateTimePickerReturnDate.TabIndex = 5;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.Location = new System.Drawing.Point(140, 43);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(94, 18);
            this.lblDisplayName.TabIndex = 6;
            this.lblDisplayName.Text = "display name";
            this.lblDisplayName.Visible = false;
            // 
            // lblDisplayTitle
            // 
            this.lblDisplayTitle.AutoSize = true;
            this.lblDisplayTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTitle.Location = new System.Drawing.Point(140, 82);
            this.lblDisplayTitle.Name = "lblDisplayTitle";
            this.lblDisplayTitle.Size = new System.Drawing.Size(117, 18);
            this.lblDisplayTitle.TabIndex = 7;
            this.lblDisplayTitle.Text = "display book title";
            this.lblDisplayTitle.Visible = false;
            // 
            // lblDisplayDateIssued
            // 
            this.lblDisplayDateIssued.AutoSize = true;
            this.lblDisplayDateIssued.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayDateIssued.Location = new System.Drawing.Point(140, 121);
            this.lblDisplayDateIssued.Name = "lblDisplayDateIssued";
            this.lblDisplayDateIssued.Size = new System.Drawing.Size(132, 18);
            this.lblDisplayDateIssued.TabIndex = 8;
            this.lblDisplayDateIssued.Text = "display date issued";
            this.lblDisplayDateIssued.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(181, 409);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(135, 42);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "&Return Book";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSearchAgain
            // 
            this.btnSearchAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAgain.Location = new System.Drawing.Point(24, 410);
            this.btnSearchAgain.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchAgain.Name = "btnSearchAgain";
            this.btnSearchAgain.Size = new System.Drawing.Size(135, 42);
            this.btnSearchAgain.TabIndex = 10;
            this.btnSearchAgain.Text = "&Search Again";
            this.btnSearchAgain.UseVisualStyleBackColor = true;
            this.btnSearchAgain.Click += new System.EventHandler(this.btnSearchAgain_Click);
            // 
            // frmBookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 464);
            this.Controls.Add(this.btnSearchAgain);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.gbRecordInfo);
            this.Controls.Add(this.btnSearchRecords);
            this.Controls.Add(this.gbOfficeUse);
            this.Controls.Add(this.gbEnterDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmBookReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Book Return";
            this.Load += new System.EventHandler(this.frmBookReturn_Load);
            this.gbEnterDetails.ResumeLayout(false);
            this.gbEnterDetails.PerformLayout();
            this.gbOfficeUse.ResumeLayout(false);
            this.gbOfficeUse.PerformLayout();
            this.gbRecordInfo.ResumeLayout(false);
            this.gbRecordInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbEnterDetails;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.GroupBox gbOfficeUse;
        private System.Windows.Forms.Label lblLibrarianID;
        private System.Windows.Forms.Label lblIssueID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtLibrarianID;
        private System.Windows.Forms.TextBox txtIssueID;
        private System.Windows.Forms.Button btnSearchRecords;
        private System.Windows.Forms.GroupBox gbRecordInfo;
        private System.Windows.Forms.Label lblDisplayDateIssued;
        private System.Windows.Forms.Label lblDisplayTitle;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnDate;
        private System.Windows.Forms.Label lblDateReturned;
        private System.Windows.Forms.Label lblDateOfIssue;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSearchAgain;
    }
}