using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using ContactsUI.Controls.Util;
using MaterialSkin;

namespace ContactsUI.Controls.BookControls
{
    public partial class BookList : UserControl
    {
        private readonly IList<Book> books;
        public BookList(IList<Book> books)
        {
            this.books = books;
            InitializeComponent();
        }

        private void LoadBooks()
        {
            booksList.Clear();
            foreach (var book in books)
                AddItem(book.Name);
        }

        private void AddItem(string text) => booksList.Items.Add(new MaterialListBoxItem(text));

        private void addBookButton_Click(object sender, EventArgs e)
        {
            var bookName = Prompt.ShowInputDialog("Insert book", "Name");
            if(bookName?.Length > 0)
            {
                Book newBook = new()
                {
                    Name = bookName
                };
                books.Add(newBook);
                AddItem(newBook.Name);
            }

        }

        private void editBookButton_Click(object sender, EventArgs e)
        {
            if(booksList.SelectedIndex >= 0)
            {
                var bookName = booksList.SelectedItem?.Text;
                var newBookName = Prompt.ShowInputDialog("Update book", "Name", bookName);
                if(newBookName.Length > 0)
                {
                    var book = books.First(b => b.Name == bookName);
                    book.Name = newBookName;
                    LoadBooks();
                }
            }
        }

        private void removeBookButton_Click(object sender, EventArgs e)
        {
            if (booksList.SelectedIndex >= 0)
            {
                var bookName = booksList.SelectedItem?.Text;
                bool isRemovalConfirmed = Prompt.ShowConfirmationDialog("Confirm", $"Are you sure you want to delete {bookName}?\nAll contacts stored in this book will be deleted.");
                if (isRemovalConfirmed)
                {
                    var book = books.First(b => b.Name == bookName);
                    books.Remove(book);
                    LoadBooks();
                }
            }
        }
    }
}
