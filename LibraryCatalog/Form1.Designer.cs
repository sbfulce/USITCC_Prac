namespace LibraryCatalog
{
    partial class Form1
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
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTitleSearch = new System.Windows.Forms.Label();
            this.txtTitleSearch = new System.Windows.Forms.TextBox();
            this.txtAuthorSearch = new System.Windows.Forms.TextBox();
            this.lblAuthorSearch = new System.Windows.Forms.Label();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblEdit = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lsvCatalog = new System.Windows.Forms.ListView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lsvSearch = new System.Windows.Forms.ListView();
            this.btnSearchTitle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(59, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(369, 12);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(81, 25);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 62);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(66, 25);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(205, 62);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(77, 25);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "Genre:";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(489, 62);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(80, 25);
            this.lblRating.TabIndex = 4;
            this.lblRating.Text = "Rating:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(77, 9);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(286, 31);
            this.txtTitle.TabIndex = 1;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(456, 9);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(242, 31);
            this.txtAuthor.TabIndex = 2;
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Items.AddRange(new object[] {
            "Science fiction",
            "Drama",
            "Action and Adventure",
            "Romance",
            "Mystery",
            "Horror"});
            this.cmbGenre.Location = new System.Drawing.Point(288, 59);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(195, 33);
            this.cmbGenre.TabIndex = 4;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Hardback",
            "Paperback",
            "Auido Book"});
            this.cmbType.Location = new System.Drawing.Point(77, 59);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(122, 33);
            this.cmbType.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(723, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 81);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Book";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTitleSearch
            // 
            this.lblTitleSearch.AutoSize = true;
            this.lblTitleSearch.Location = new System.Drawing.Point(12, 489);
            this.lblTitleSearch.Name = "lblTitleSearch";
            this.lblTitleSearch.Size = new System.Drawing.Size(133, 25);
            this.lblTitleSearch.TabIndex = 12;
            this.lblTitleSearch.Text = "Title Search:";
            // 
            // txtTitleSearch
            // 
            this.txtTitleSearch.Location = new System.Drawing.Point(151, 486);
            this.txtTitleSearch.Name = "txtTitleSearch";
            this.txtTitleSearch.Size = new System.Drawing.Size(142, 31);
            this.txtTitleSearch.TabIndex = 13;
            // 
            // txtAuthorSearch
            // 
            this.txtAuthorSearch.Location = new System.Drawing.Point(575, 485);
            this.txtAuthorSearch.Name = "txtAuthorSearch";
            this.txtAuthorSearch.Size = new System.Drawing.Size(132, 31);
            this.txtAuthorSearch.TabIndex = 14;
            // 
            // lblAuthorSearch
            // 
            this.lblAuthorSearch.AutoSize = true;
            this.lblAuthorSearch.Location = new System.Drawing.Point(414, 488);
            this.lblAuthorSearch.Name = "lblAuthorSearch";
            this.lblAuthorSearch.Size = new System.Drawing.Size(155, 25);
            this.lblAuthorSearch.TabIndex = 15;
            this.lblAuthorSearch.Text = "Author Search:";
            // 
            // cmbRating
            // 
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Items.AddRange(new object[] {
            "5 Stars",
            "4 Stars",
            "3 Stars",
            "2 Stars",
            "1 Star"});
            this.cmbRating.Location = new System.Drawing.Point(575, 59);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new System.Drawing.Size(123, 33);
            this.cmbRating.TabIndex = 5;
            // 
            // btnSearchAuthor
            // 
            this.btnSearchAuthor.Location = new System.Drawing.Point(723, 479);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.btnSearchAuthor.Size = new System.Drawing.Size(93, 39);
            this.btnSearchAuthor.TabIndex = 17;
            this.btnSearchAuthor.Text = "Search";
            this.btnSearchAuthor.UseVisualStyleBackColor = true;
            this.btnSearchAuthor.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(723, 96);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(107, 47);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Location = new System.Drawing.Point(12, 118);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(631, 25);
            this.lblEdit.TabIndex = 19;
            this.lblEdit.Text = "To edit an entry, re-enter all the fields above and then click \'Edit\' ";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(723, 149);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(107, 43);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Delete";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(12, 167);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(620, 25);
            this.lblDelete.TabIndex = 21;
            this.lblDelete.Text = "To delete an entry, click on the entry in the list and click \'Delete\'";
            // 
            // lsvCatalog
            // 
            this.lsvCatalog.FullRowSelect = true;
            this.lsvCatalog.Location = new System.Drawing.Point(17, 198);
            this.lsvCatalog.Name = "lsvCatalog";
            this.lsvCatalog.Size = new System.Drawing.Size(813, 272);
            this.lsvCatalog.TabIndex = 22;
            this.lsvCatalog.UseCompatibleStateImageBehavior = false;
            this.lsvCatalog.View = System.Windows.Forms.View.Details;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(352, 802);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 39);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lsvSearch
            // 
            this.lsvSearch.FullRowSelect = true;
            this.lsvSearch.Location = new System.Drawing.Point(17, 524);
            this.lsvSearch.Name = "lsvSearch";
            this.lsvSearch.Size = new System.Drawing.Size(813, 272);
            this.lsvSearch.TabIndex = 24;
            this.lsvSearch.UseCompatibleStateImageBehavior = false;
            this.lsvSearch.View = System.Windows.Forms.View.Details;
            this.lsvSearch.SelectedIndexChanged += new System.EventHandler(this.lsvSearch_SelectedIndexChanged);
            // 
            // btnSearchTitle
            // 
            this.btnSearchTitle.Location = new System.Drawing.Point(299, 483);
            this.btnSearchTitle.Name = "btnSearchTitle";
            this.btnSearchTitle.Size = new System.Drawing.Size(103, 35);
            this.btnSearchTitle.TabIndex = 25;
            this.btnSearchTitle.Text = "Search";
            this.btnSearchTitle.UseVisualStyleBackColor = true;
            this.btnSearchTitle.Click += new System.EventHandler(this.btnSearchTitle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 855);
            this.Controls.Add(this.btnSearchTitle);
            this.Controls.Add(this.lsvSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lsvCatalog);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSearchAuthor);
            this.Controls.Add(this.cmbRating);
            this.Controls.Add(this.lblAuthorSearch);
            this.Controls.Add(this.txtAuthorSearch);
            this.Controls.Add(this.txtTitleSearch);
            this.Controls.Add(this.lblTitleSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTitleSearch;
        private System.Windows.Forms.TextBox txtTitleSearch;
        private System.Windows.Forms.TextBox txtAuthorSearch;
        private System.Windows.Forms.Label lblAuthorSearch;
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.Button btnSearchAuthor;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.ListView lsvCatalog;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView lsvSearch;
        private System.Windows.Forms.Button btnSearchTitle;
    }
}

