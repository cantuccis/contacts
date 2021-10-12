using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Storage;
using BusinessLogic;
using ContactsUI.Controls.ProfileControls;
using ContactsUI.Controls.BookControls;
using System.Configuration;

namespace ContactsUI
{
    public partial class Contacts : MaterialForm
    {
        public const string DefaultProfileImageName = "defaultProfile";

        private readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private readonly LocalStorage localStorage;
        private const string StorageFolder = "localstorage";
        private readonly string storageDirPath;

        private readonly IList<Book> books;

        public Contacts()
        {
            InitializeComponent();
            storageDirPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, StorageFolder);
            localStorage = new LocalStorage(storageDirPath);
            books = new List<Book>();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            //For testing only
            LoadTestingData();

            SetupLocalStorage();
            SetupMaterialTheme();
            SetupMenuTabs();
        }

        private void SetupMenuTabs()
        {
            contactsTab.Controls.Add(new BookProfilesNavigator(books));
            newContactTab.Controls.Add(new NewProfile(books, localStorage));
            booksTab.Controls.Add(new BookList(books));
            booksProfilesTab.Controls.Add(new ExpandableBookList(books));
        }

        private void SetupLocalStorage()
        {
            localStorage.Clear();
            Bitmap defaultProfileImage = Properties.Resources.person;
            string defaultProfileImagePath = Path.Combine(storageDirPath, DefaultProfileImageName);
            defaultProfileImage.Save(defaultProfileImagePath, System.Drawing.Imaging.ImageFormat.Png);
        }
        private void SetupMaterialTheme()
        {
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.DeepPurple400,
                MaterialSkin.Primary.DeepPurple500,
                MaterialSkin.Primary.Blue100,
                MaterialSkin.Accent.Blue200,
                MaterialSkin.TextShade.WHITE
                );
        }

        private void LoadTestingData()
        {
            var isTestingEnabled = bool.Parse(ConfigurationManager.AppSettings[ApplicationSettings.TestingDataEnabled]);
            if(isTestingEnabled)
            {
                var profilesCount = int.Parse(ConfigurationManager.AppSettings[ApplicationSettings.TestingProfilesCount]);
                var booksCount = int.Parse(ConfigurationManager.AppSettings[ApplicationSettings.TestingBooksCount]);

                string[] Names = new string[] { "John", "Johny", "Rob", "Bob", "Jessica", "Mike" };
                string[] Surnames = new string[] { "Doe", "Goodman", "McClaw", "White" };
                DateTime[] Dates = new DateTime[] { new DateTime(1997, 10, 7), new DateTime(1999, 9, 9) };
                string SomeStreetAddress = "SomeStreet 1111";
                string PicturePathSample = Path.Combine(storageDirPath,DefaultProfileImageName);
                string SomeBookName = "Somebook";
                int phoneNumber = 91000000;

                Random rand = new Random();

                for (int i = 0; i < booksCount; i++)
                    books.Add(new Book() { Name = $"{SomeBookName}{i}" });

                for (int i = 0; i < profilesCount; i++)
                {
                    var newProfile = new Profile()
                    {
                        FirstName = Names[rand.Next(Names.Length)],
                        LastName = Surnames[rand.Next(Surnames.Length)],
                        Birthday = Dates[rand.Next(Dates.Length)],
                        PhoneNumber = $"+598{phoneNumber++}",
                        Address = SomeStreetAddress,
                        PicturePath = PicturePathSample
                    };
                    books[i % booksCount].Add(newProfile);
                }

            }
        }


    }
}
