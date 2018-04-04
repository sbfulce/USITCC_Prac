using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryCatalog
{
    public partial class Form1 : Form
    {
        Book Book = new Book();
        int bookID = 1;

        // This creates the columns for the catalog
        public Form1()
        {
            InitializeComponent();
            Book.CreateEntry();
            lsvCatalog.Columns.Add("ID");
            lsvCatalog.Columns.Add("Title");
            lsvCatalog.Columns.Add("Author");
            lsvCatalog.Columns.Add("Type");
            lsvCatalog.Columns.Add("Genre");
            lsvCatalog.Columns.Add("Rating");

            lsvSearch.Columns.Add("ID");
            lsvSearch.Columns.Add("Title");
            lsvSearch.Columns.Add("Author");
            lsvSearch.Columns.Add("Type");
            lsvSearch.Columns.Add("Genre");
            lsvSearch.Columns.Add("Rating");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtAuthor.Text))
            {
                MessageBox.Show("You must enter both the title and the author to log this entry.");
            }
            else
            {
                Book.BookID = bookID;
                // write to the file
                Book.WriteEntry("booksXML.xml", txtTitle.Text, txtAuthor.Text, cmbType.Text, cmbGenre.Text, cmbRating.Text, bookID);
                Book.Title = txtTitle.Text;
                Book.Author = txtAuthor.Text;
                Book.Type = cmbType.Text;
                Book.Genre = cmbGenre.Text;
                Book.Rating = cmbRating.Text;
            }
            // add the items to the view
            ListViewItem item = new ListViewItem((bookID).ToString());
            item.SubItems.Add(Book.Title);
            item.SubItems.Add(Book.Author);
            item.SubItems.Add(Book.Type);
            item.SubItems.Add(Book.Genre);
            item.SubItems.Add(Book.Rating);
            lsvCatalog.Items.Add(item);

            lsvCatalog.Text = bookID.ToString();

            // increment the book id
            bookID++;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // remove catalog entry
            if (lsvCatalog.Items.Count > 0)
            {
                //Book.RemoveEntry("booksXML.xml", Convert.ToInt32(bookID));
                Book.RemoveEntry("booksXML.xml", Int32.Parse(lsvCatalog.SelectedItems[0].Text));
                lsvCatalog.Items.Remove(lsvCatalog.SelectedItems[0]);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(lsvCatalog.SelectedItems.Count > 0)
            {
                // create the item based on the ID
                ListViewItem item = new ListViewItem((bookID).ToString());

                // pass the ID to the update method
                bookID = Int32.Parse(lsvCatalog.SelectedItems[0].Text);
                Book.EditEntry("booksXML.xml", txtTitle.Text, txtAuthor.Text, cmbType.Text, cmbGenre.Text, cmbRating.Text, bookID);

                
                ListViewItem items = lsvCatalog.SelectedItems[0];
                items.SubItems[1].Text = txtTitle.Text;
                items.SubItems[2].Text = txtAuthor.Text;
                items.SubItems[3].Text = cmbType.Text;
                items.SubItems[4].Text = cmbGenre.Text;
                items.SubItems[5].Text = cmbRating.Text;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lsvSearch.Items.Clear();

            foreach (ListViewItem item in lsvCatalog.Items)
            {
                if (item.SubItems[2].Text == txtAuthorSearch.Text)
                {
                    ListViewItem itemSearch = new ListViewItem(item.SubItems[0].Text);
                    itemSearch.SubItems.Add(item.SubItems[1].Text);
                    itemSearch.SubItems.Add(item.SubItems[2].Text);
                    itemSearch.SubItems.Add(item.SubItems[3].Text);
                    itemSearch.SubItems.Add(item.SubItems[4].Text);
                    itemSearch.SubItems.Add(item.SubItems[5].Text);
                    lsvSearch.Items.Add(itemSearch);

                }
            }
        }

        private void lsvSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchTitle_Click(object sender, EventArgs e)
        {
            lsvSearch.Items.Clear();
         
            foreach(ListViewItem item in lsvCatalog.Items)
            {
                if(item.SubItems[1].Text == txtTitleSearch.Text)
                {
                    ListViewItem itemSearch = new ListViewItem(item.SubItems[0].Text);
                    itemSearch.SubItems.Add(item.SubItems[1].Text);
                    itemSearch.SubItems.Add(item.SubItems[2].Text);
                    itemSearch.SubItems.Add(item.SubItems[3].Text);
                    itemSearch.SubItems.Add(item.SubItems[4].Text);
                    itemSearch.SubItems.Add(item.SubItems[5].Text);
                    lsvSearch.Items.Add(itemSearch);

                }
            }
            

        }
    }
}
