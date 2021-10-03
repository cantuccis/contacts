using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BrumCustomAlerts;
using BusinessLogic;
using BusinessLogic.Exceptions;
using MaterialSkin;
using Storage;
using Storage.Exceptions;

namespace ContactsUI.Controls.ProfileControls
{
    public partial class NewProfile : UserControl
    {
        private LocalStorage localStorage;
        private FileInfo selectedImage;
        private IList<Book> books;
        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        public NewProfile(IList<Book> books, LocalStorage localStorage)
        {
            this.localStorage = localStorage ?? throw new ArgumentNullException(nameof(localStorage));
            this.books = books ?? throw new ArgumentNullException(nameof(books));
            this.selectedImage = localStorage.Get(Contacts.DefaultProfileImageName);
            InitializeComponent();
        }

        private void RefreshNewProfileView()
        {
            firstNameInput.Clear();
            lastNameInput.Clear();
            phoneInput.Clear();
            addressInput.Clear();
            newProfilePicture.Image = newProfilePicture.InitialImage;
            profilePictureFilenameLabel.Text = "";
            selectedImage = localStorage.Get(Contacts.DefaultProfileImageName);
            LoadBooks();
        }

        private void LoadBooks()
        {
            bookComboBox.ResetText();
            bookComboBox.Items.Clear();
            bookComboBox.Items.AddRange(books.Select(b => b.Name).ToArray());
            saveProfileButton.Enabled = books.Count > 0;
        }

        private void RefreshResultLabel()
        {
            resultLabel.Text = "";
        }

        private void saveProfileButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveProfile();
            }
            catch (Exception ex)
            {
                if (ex is BusinessLogicException || ex is LocalStorageException)
                {
                    resultLabel.Text = ex.Message;
                    resultLabel.ForeColor = Color.DarkRed;
                }
            }

        }

        private void SaveProfile()
        {
            RefreshResultLabel();
            string selectedBook = (string)bookComboBox.SelectedItem ?? string.Empty;
            if (selectedBook == string.Empty)
            {
                resultLabel.Text = "You must select a book first";
            } 
            else
            {
                var newProfile = new Profile()
                {
                    FirstName = firstNameInput.Text,
                    LastName = lastNameInput.Text,
                    PhoneNumber = phoneInput.Text,
                    Address = addressInput.Text,
                    PicturePath = selectedImage.FullName,
                    Birthday = birthdayPicker.Value,
                };
                if(selectedImage.Name != Contacts.DefaultProfileImageName)
                    localStorage.AddForce(selectedImage);
                var book = books.First(b => b.Name == selectedBook);
                book.Add(newProfile);
                BrumAlertFactory.OpenAlert(
                    $"Profile {newProfile.FirstName} {newProfile.LastName} was created",
                    materialSkinManager.TextHighEmphasisColor,
                    materialSkinManager.CardsColor,
                    new Bitmap(selectedImage.FullName),
                    5000,
                    AlertLocation.BottomMiddle);

                RefreshNewProfileView();
            }
            
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog pictureFileDialog = new OpenFileDialog();
            pictureFileDialog.Title = "Open Image";
            pictureFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (pictureFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImage = new FileInfo(pictureFileDialog.FileName);
                profilePictureFilenameLabel.Text = selectedImage.Name;
                newProfilePicture.Image = new Bitmap(pictureFileDialog.FileName);
            }
        }

        private void NewProfile_VisibleChanged(object sender, EventArgs e) 
        {
            RefreshNewProfileView();
            RefreshResultLabel();
        }

    }
}
