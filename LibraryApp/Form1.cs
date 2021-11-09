using LibraryApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        Library library = new Library(new List<Book>());



        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtISBN;
        }
        private void CleanTheScreen()
        {
            txtISBN.Clear();
            txtAuthor.Clear();
            txtBookName.Clear();
            txtReceiveDate.Clear();
            txtReturnDate.Clear();
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.BookData.Name = txtBookName.Text;
            book.BookData.Author = txtAuthor.Text;
            book.BookData.ISBN = txtISBN.Text;
            library.AddBook(book);
            // Might have been like that as well if we like to list all books whenever we add a new book
            // txtList.Text = library.ListBooks();
            CleanTheScreen();
        }
        
        private void btnListBooks_Click(object sender, EventArgs e)
        {
            txtList.Text = library.ListBooks();

        }

        private void btnRemoveBooks_Click(object sender, EventArgs e)
        {
            library.RemoveBooks();
            txtList.Clear();
        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allows one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
