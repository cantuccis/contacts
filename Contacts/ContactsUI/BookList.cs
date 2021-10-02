using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace ContactsUI
{
    public partial class BookList : UserControl
    {
        private readonly IList<Book> books;
        public BookList(IList<Book> books)
        {
            this.books = books;
            InitializeComponent();
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {

        }
    }
}
