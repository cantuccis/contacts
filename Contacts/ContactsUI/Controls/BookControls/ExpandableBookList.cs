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
using ContactsUI.Controls.ProfileControls;

namespace ContactsUI.Controls.BookControls
{
    public partial class ExpandableBookList : UserControl
    {
        private IList<Book> books;
        public ExpandableBookList(IList<Book> books)
        {
            this.books = books;
            InitializeComponent();
            LoadBooks();
        }

        private void LoadBooks()
        {
            this.panel.Controls.Clear();
            foreach (var book in books)
            {
                IList<Control> miniProfiles = book
                    .GetAllProfiles()
                    .Select(profile => (Control) new MiniProfile(profile.PicturePath, $"{profile.FirstName} {profile.LastName.Substring(0,1)}."))
                    .ToList();
                var expandableBook = new ExpandableBook(
                    book.Name,
                    miniProfiles
                  );
                this.panel.Controls.Add(expandableBook);
            }
            Refresh();
        }

        private void ExpandableBookList_VisibleChanged(object sender, EventArgs e)
        {
            LoadBooks();
        }
    }
}
