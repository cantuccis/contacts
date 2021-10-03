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

namespace ContactsUI.Controls.BookControls
{
    public partial class BookProfilesNavigator : UserControl
    {
        private IList<Book> books;
        private readonly string AllBooksOption = "All";

        public BookProfilesNavigator(IList<Book> books)
        {
            this.books = books ?? throw new ArgumentNullException(nameof(books));
            InitializeComponent();
            RefreshBookCombobox();
        }

        private void RefreshBookCombobox()
        {
            bookComboBox.Items.Clear();
            bookComboBox.Items.Add(AllBooksOption);
            bookComboBox.Items.AddRange(books.Select(b => b.Name).ToArray());
            bookComboBox.SelectedIndex = 0;
            bookComboBox.Refresh();
        }

        private void ShowProfiles(string bookName)
        {
            navigatorPanel.Controls.Clear();
            var profiles = bookName != AllBooksOption
                ? books.First(b => b.Name == bookName).GetAllProfiles()
                : books.SelectMany(b => b.GetAllProfiles()).ToList();
            navigatorPanel.Controls.Add(new ProfilesNavigator(profiles));
        }

        private void BookProfilesNavigator_VisibleChanged(object sender, EventArgs e)
        {
            RefreshBookCombobox();
        }

        private void bookComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ShowProfiles((string)bookComboBox.SelectedItem);
        }
    }
}
