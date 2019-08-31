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
            this.btnSearchAgain = new System.Windows.Forms.Button();
            this.lvResults = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
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
            this.lblTitle.Size = new System.Drawing.Size(764, 46);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "SEARCH BOOKS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // rbTitle
            // 
            this.rbTitle.AutoSize = true;
            this.rbTitle.Checked = true;
            this.rbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTitle.Location = new System.Drawing.Point(282, 63);
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
            this.txtSearch.Location = new System.Drawing.Point(239, 110);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(287, 27);
            this.txtSearch.TabIndex = 19;
            // 
            // rbAuthor
            // 
            this.rbAuthor.AutoSize = true;
            this.rbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAuthor.Location = new System.Drawing.Point(403, 63);
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
            this.cbAuthor.Location = new System.Drawing.Point(239, 130);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(287, 28);
            this.cbAuthor.TabIndex = 21;
            this.cbAuthor.Visible = false;
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.btnSearchAgain);
            this.gbResults.Controls.Add(this.lvResults);
            this.gbResults.Controls.Add(this.btnReserve);
            this.gbResults.Controls.Add(this.btnClose);
            this.gbResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResults.Location = new System.Drawing.Point(5, 165);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(745, 469);
            this.gbResults.TabIndex = 22;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Search Results";
            this.gbResults.Visible = false;
            // 
            // btnSearchAgain
            // 
            this.btnSearchAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAgain.Location = new System.Drawing.Point(511, 414);
            this.btnSearchAgain.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchAgain.Name = "btnSearchAgain";
            this.btnSearchAgain.Size = new System.Drawing.Size(144, 43);
            this.btnSearchAgain.TabIndex = 22;
            this.btnSearchAgain.Text = "Search &Again";
            this.btnSearchAgain.UseVisualStyleBackColor = true;
            this.btnSearchAgain.Click += new System.EventHandler(this.btnSearchAgain_Click);
            // 
            // lvResults
            // 
            this.lvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvResults.FullRowSelect = true;
            this.lvResults.Location = new System.Drawing.Point(14, 49);
            this.lvResults.Name = "lvResults";
            this.lvResults.Size = new System.Drawing.Size(714, 337);
            this.lvResults.TabIndex = 21;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Title";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 269;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Author";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 167;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ISBN";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 138;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "No. Avail";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 95;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Rack No.";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 100;
            // 
            // btnReserve
            // 
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.Location = new System.Drawing.Point(112, 414);
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
            this.btnClose.Location = new System.Drawing.Point(310, 414);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 43);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbAuthor
            // 
            this.lbAuthor.FormattingEnabled = true;
            this.lbAuthor.ItemHeight = 16;
            this.lbAuthor.Location = new System.Drawing.Point(585, 138);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(20, 20);
            this.lbAuthor.TabIndex = 23;
            this.lbAuthor.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(310, 165);
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
            this.ClientSize = new System.Drawing.Size(764, 635);
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
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.ListBox lbAuthor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lvResults;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnSearchAgain;
    }
}