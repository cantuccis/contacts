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

namespace ContactsUI
{
    public partial class Contacts : MaterialForm
    {
        public const string DefaultProfileImageName = "defaultProfile";

        private readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private readonly LocalStorage localStorage;
        private const string StorageFolder = "LocalStorage";
        private readonly string storageDirPath;

        IList<Profile> profiles;

        public Contacts()
        {
            InitializeComponent();
            storageDirPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, StorageFolder);
            localStorage = new LocalStorage(storageDirPath);
            profiles = new List<Profile>();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;

            SetupLocalStorage();
            SetupMaterialTheme();
            SetupMenuTabs();
        }

        private void SetupMenuTabs()
        {
            contactsTab.Controls.Add(new ProfilesNavigator(profiles));
            newContactTab.Controls.Add(new NewProfile(profiles, localStorage));
        }

        private void SetupLocalStorage()
        {
            localStorage.Clear();
            Bitmap defaultProfileImage = Properties.Resources.person;
            string defaultProfileImagePath = Path.Combine(storageDirPath, DefaultProfileImageName);
            defaultProfileImage.Save(defaultProfileImagePath);
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
                MaterialSkin.Accent.Blue700,
                MaterialSkin.TextShade.WHITE
                );
        }

    }
}
