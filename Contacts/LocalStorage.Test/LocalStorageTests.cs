using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Storage;

namespace Storage.Test
{
    [TestClass]
    public class LocalStorageTests
    {
        private LocalStorage localStorage = new LocalStorage("images");

        private readonly FileInfo file1 = new FileInfo(@"..\..\contacts-testimgs\testimg1.png");
        private readonly FileInfo file2 = new FileInfo(@"..\..\contacts-testimgs\testimg2.jpg");
        private readonly FileInfo file3 = new FileInfo(@"..\..\contacts-testimgs\testimg3.jpg");
        private readonly FileInfo file4 = new FileInfo(@"..\..\contacts-testimgs\testimg4.jpg");
        private readonly FileInfo file5 = new FileInfo(@"..\..\contacts-testimgs\testimg5.jpg");
        private readonly FileInfo file6 = new FileInfo(@"..\..\contacts-testimgs\testimg6.jpg");
        private readonly FileInfo file7 = new FileInfo(@"..\..\contacts-testimgs\testimg7.jpg");
        IList<FileInfo> files;

        [TestInitialize]
        public void Setup()
        {
            files = new FileInfo[] { file1, file2, file3, file4, file5, file6, file7 };
            localStorage.Clear();
        }

        [TestMethod]
        public void SaveFileTest()
        {
            localStorage.Add(file1);
            Assert.IsTrue(localStorage.Exists(file1.Name));
        }

        [TestMethod]
        public void SaveSeveralFilesTest()
        {
            foreach (var file in files)
            {
                localStorage.Add(file);
            }

            foreach (var file in files)
            {
                Assert.IsTrue(localStorage.Exists(file.Name));

            }
        }

        [TestMethod]
        public void RemoveFileTest()
        {
            localStorage.Add(file1);
            localStorage.Add(file2);
            localStorage.Add(file3);
            localStorage.Remove(file2.Name);
            Assert.IsFalse(localStorage.Exists(file2.Name));
        }

        [TestMethod]
        public void GetAllTest()
        {
            foreach (var file in files)
            {
                localStorage.Add(file);
            }

            IList<string> returnedFiles = localStorage.GetAll().Select(file => file.Name).ToList();

            foreach (var file in files)
            {
                Assert.IsTrue(returnedFiles.Contains(file.Name));

            }
        }

        [TestMethod]
        public void GetFileTest()
        {
            localStorage.Add(file1);

            FileInfo retrievedFile = localStorage.Get(file1.Name);

            Assert.AreEqual(retrievedFile.Name, file1.Name);
        }
    }
}
