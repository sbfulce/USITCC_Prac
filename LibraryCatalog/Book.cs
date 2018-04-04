using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// add the xml using statment for readability
using System.Xml.Linq;
using System.Xml;
// for file managment 
using System.IO;
// message box ussage
using System.Windows.Forms;

namespace LibraryCatalog
{
    public class Book
    {

        public string Title { get; set; }

        public String Author { get; set; }

        public string Type { get; set; }

        public String Genre { get; set; }

        public string Rating { get; set; }

        public int BookID { get; set; }

        public void CreateEntry()
        {
            try
            {
                // create the xml file and the base 'books' element
                // this will be invoked in the begining of the form 
                XmlWriter writer = XmlWriter.Create("booksXML.xml");

                // start the document
                writer.WriteStartDocument();

                //create the outermost books class
                writer.WriteStartElement("Books");

                // write close/end document
                writer.WriteEndElement();
                writer.Close();
            }
            catch
            {
                MessageBox.Show("There was an error creating the XML file.");
            }
        }

        public void EditEntry(string FileName, string Title, string Author, string Type, string Genre, string rating, int ID)
        {
            try
            {
                // load the document
                XmlDocument document = new XmlDocument();
                document.Load(FileName);

                // get a list of nodes 
                XmlNode node = document.SelectSingleNode("/Books/Book[ID='" + ID.ToString() + "']");
                XmlNode titleNode = document.SelectSingleNode("/Books/Book/Title");
                XmlNode authorNode = document.SelectSingleNode("/Books/Book/Author");
                XmlNode typeNode = document.SelectSingleNode("/Books/Book/Type");
                XmlNode genreNode = document.SelectSingleNode("/Books/Book/Genre");
                XmlNode ratingNode = document.SelectSingleNode("/Books/Book/Rating");

                if(node != null)
                {
                    titleNode.InnerText = Title;
                    authorNode.InnerText = Author;
                    typeNode.InnerText = Type;
                    genreNode.InnerText = Genre;
                    ratingNode.InnerText = Rating;
                }

                // save
                document.Save(FileName);
            }
            catch
            {

            }
        }


        public void WriteEntry(string FileName, string Title, string Author, string Type, string Genre, string rating, int ID)
        {
            // error check 
            try
            {
                // create the nodes inside the book element
                var book = new XElement("Book", new XElement("Title", Title), new XElement("Author", Author), new XElement("Type", Type), new XElement("Genre", Genre), new XElement("Rating", Rating), new XElement("ID", BookID));
                var doc = new XDocument();

                // check to see if the "Book" element exists to be filled with book information
                if (File.Exists(FileName))
                {
                    doc = XDocument.Load(FileName);
                    doc.Element("Books").Add(book);
                }
                else
                {
                    doc = new XDocument(new XElement("Books", book));
                }
                // save the changes to the document
                doc.Save(FileName);
            }
            catch
            {
                MessageBox.Show("There was an error writing the XML values.");
            }
        }

        public void RemoveEntry(string fileName, int bookID)
        {
            try
            {
                // load the document
                XmlDocument document = new XmlDocument();
                document.Load(fileName);

                // get a list of nodes 
                XmlNode node = document.SelectSingleNode("/Books/Book[ID='" + bookID.ToString() + "']");
                node.ParentNode.RemoveChild(node);
                document.Save(fileName);
            }
            catch
            {
                MessageBox.Show("There was an error removing the XML values.");
            }
        }
    }
}