namespace LMS_OC.Presentation_Layer
{
    partial class frmSearchBooks
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
            this.rbTitle = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rbAuthor = new System.Windows.Forms.RadioButton();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtRackNo = new System.Windows.Forms.TextBox();
            this.txtCopiesBorrowed = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCopyAvailable = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblRackNo = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblCopiesBorrowed = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(497, 46);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "SEARCH BOOKS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // rbTitle
            // 
            this.rbTitle.AutoSize = true;
            this.rbTitle.Checked = true;
            this.rbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTitle.Location = new System.Drawing.Point(159, 65);
            this.rbTitle.Name = "rbTitle";
            this.rbTitle.Size = new System.Drawing.Size(62, 24);
            this.rbTitle.TabIndex = 18;
            this.rbTitle.TabStop = true;
            this.rbTitle.Text = "Title";
            this.rbTitle.UseVisualStyleBackColor = true;
            this.rbTitle.CheckedChanged += new System.EventHandler(this.rbTitle_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(106, 108);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(287, 27);
            this.txtSearch.TabIndex = 19;
            // 
            // rbAuthor
            // 
            this.rbAuthor.AutoSize = true;
            this.rbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAuthor.Location = new System.Drawing.Point(261, 65);
            this.rbAuthor.Name = "rbAuthor";
            this.rbAuthor.Size = new System.Drawing.Size(79, 24);
            this.rbAuthor.TabIndex = 20;
            this.rbAuthor.Text = "Author";
            this.rbAuthor.UseVisualStyleBackColor = true;
            this.rbAuthor.CheckedChanged += new System.EventHandler(this.rbAuthor_CheckedChanged);
            // 
            // cbAuthor
            // 
            this.cbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(106, 128);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(287, 28);
            this.cbAuthor.TabIndex = 21;
            this.cbAuthor.Visible = false;
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.txtAuthor);
            this.gbResults.Controls.Add(this.lblAuthor);
            this.gbResults.Controls.Add(this.btnReserve);
            this.gbResults.Controls.Add(this.btnClose);
            this.gbResults.Controls.Add(this.txtBookTitle);
            this.gbResults.Controls.Add(this.txtISBN);
            this.gbResults.Controls.Add(this.txtRackNo);
            this.gbResults.Controls.Add(this.txtCopiesBorrowed);
            this.gbResults.Controls.Add(this.txtPrice);
            this.gbResults.Controls.Add(this.txtCopyAvailable);
            this.gbResults.Controls.Add(this.lblISBN);
            this.gbResults.Controls.Add(this.lblRackNo);
            this.gbResults.Controls.Add(this.lblAvailable);
            this.gbResults.Controls.Add(this.lblCopiesBorrowed);
            this.gbResults.Controls.Add(this.lblPrice);
            this.gbResults.Controls.Add(this.lblBookTitle);
            this.gbResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResults.Location = new System.Drawing.Point(12, 154);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(472, 469);
            this.gbResults.TabIndex = 22;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Search Results";
            this.gbResults.Visible = false;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(168, 89);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(287, 26);
            this.txtAuthor.TabIndex = 22;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(19, 92);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(58, 20);
            this.lblAuthor.TabIndex = 21;
            this.lblAuthor.Text = "Author";
            // 
            // btnReserve
            // 
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.Location = new System.Drawing.Point(64, 384);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(4);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(144, 43);
            this.btnReserve.TabIndex = 20;
            this.btnReserve.Text = "&Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(274, 384);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 43);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookTitle.Location = new System.Drawing.Point(168, 46);
            this.txtBookTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(287, 26);
            this.txtBookTitle.TabIndex = 7;
            // 
            // txtISBN
            // 
            this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(168, 132);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(287, 26);
            this.txtISBN.TabIndex = 9;
            // 
            // txtRackNo
            // 
            this.txtRackNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRackNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRackNo.Location = new System.Drawing.Point(168, 175);
            this.txtRackNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtRackNo.Name = "txtRackNo";
            this.txtRackNo.Size = new System.Drawing.Size(287, 26);
            this.txtRackNo.TabIndex = 10;
            // 
            // txtCopiesBorrowed
            // 
            this.txtCopiesBorrowed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCopiesBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopiesBorrowed.Location = new System.Drawing.Point(168, 261);
            this.txtCopiesBorrowed.Margin = new System.Windows.Forms.Padding(4);
            this.txtCopiesBorrowed.Name = "txtCopiesBorrowed";
            this.txtCopiesBorrowed.Size = new System.Drawing.Size(287, 26);
            this.txtCopiesBorrowed.TabIndex = 14;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(168, 304);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(287, 26);
            this.txtPrice.TabIndex = 16;
            // 
            // txtCopyAvailable
            // 
            this.txtCopyAvailable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCopyAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopyAvailable.Location = new System.Drawing.Point(168, 218);
            this.txtCopyAvailable.Margin = new System.Windows.Forms.Padding(4);
            this.txtCopyAvailable.Name = "txtCopyAvailable";
            this.txtCopyAvailable.Size = new System.Drawing.Size(287, 26);
            this.txtCopyAvailable.TabIndex = 12;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(19, 135);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(48, 20);
            this.lblISBN.TabIndex = 18;
            this.lblISBN.Text = "ISBN";
            // 
            // lblRackNo
            // 
            this.lblRackNo.AutoSize = true;
            this.lblRackNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRackNo.Location = new System.Drawing.Point(19, 178);
            this.lblRackNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRackNo.Name = "lblRackNo";
            this.lblRackNo.Size = new System.Drawing.Size(73, 20);
            this.lblRackNo.TabIndex = 17;
            this.lblRackNo.Text = "Rack No";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(19, 221);
            this.lblAvailable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(133, 20);
            this.lblAvailable.TabIndex = 15;
            this.lblAvailable.Text = "Copies Available";
            // 
            // lblCopiesBorrowed
            // 
            this.lblCopiesBorrowed.AutoSize = true;
            this.lblCopiesBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopiesBorrowed.Location = new System.Drawing.Point(19, 264);
            this.lblCopiesBorrowed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCopiesBorrowed.Name = "lblCopiesBorrowed";
            this.lblCopiesBorrowed.Size = new System.Drawing.Size(138, 20);
            this.lblCopiesBorrowed.TabIndex = 13;
            this.lblCopiesBorrowed.Text = "Copies Borrowed";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(19, 307);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 20);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Price";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.Location = new System.Drawing.Point(19, 49);
            this.lblBookTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(41, 20);
            this.lblBookTitle.TabIndex = 8;
            this.lblBookTitle.Text = "Title";
            // 
            // lbAuthor
            // 
            this.lbAuthor.FormattingEnabled = true;
            this.lbAuthor.ItemHeight = 16;
            this.lbAuthor.Location = new System.Drawing.Point(411, 136);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(20, 20);
            this.lbAuthor.TabIndex = 23;
            this.lbAuthor.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(176, 163);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 43);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmSearchBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 635);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.gbResults);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.rbAuthor);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.rbTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmSearchBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Search books in library";
            this.Load += new System.EventHandler(this.frmSearchBooks_Load);
            this.gbResults.ResumeLayout(false);
            this.gbResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rbTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbAuthor;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtRackNo;
        private System.Windows.Forms.TextBox txtCopiesBorrowed;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCopyAvailable;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblRackNo;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblCopiesBorrowed;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.ListBox lbAuthor;
        private System.Windows.Forms.Button btnSearch;
    }
}