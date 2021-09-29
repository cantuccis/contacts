using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Exceptions;

namespace Storage
{
    public class LocalStorage
    {
        private readonly DirectoryInfo storageDirectory;
        public LocalStorage(string storageDirPath)
        {
            storageDirectory = new DirectoryInfo(storageDirPath);
            if (!storageDirectory.Exists)
                storageDirectory.Create();
        }
       
        public void Add(FileInfo file)
        {
            if (file == null)
                throw new ArgumentNullException("File cannot be null");

            if (Exists(file.Name))
                throw new LocalStorageException($"File {file.Name} already exists");

            string destionationPath = Path.Combine(storageDirectory.FullName, file.Name);

            try
            {
                File.Copy(file.FullName, destionationPath);
            }
            catch (Exception ex)
            {
                if (ex is UnauthorizedAccessException)
                    throw new LocalStorageException($"Unauthorized access to file {file.FullName}");
                if (ex is PathTooLongException)
                    throw new LocalStorageException($"Path too long for file {file.FullName}");
                if (ex is DirectoryNotFoundException || ex is FileNotFoundException)
                    throw new LocalStorageException($"File {file.FullName} was not found");
                    
            }
        }

        public void AddForce(FileInfo file)
        {
            if (Exists(file.Name))
                Remove(file.Name);
            Add(file);
        }

        public bool Exists(string filename) => storageDirectory.GetFiles().Any(finfo => finfo.Name == filename);

        public void Remove(string filename)
        {
            if(Exists(filename))
            {
                string filepath = Path.Combine(storageDirectory.FullName, filename);
                try
                {
                    File.Delete(filepath);
                }
                catch (Exception ex)
                {
                    if (ex is UnauthorizedAccessException)
                        throw new LocalStorageException($"Unauthorized access to file {filename}");
                    if (ex is PathTooLongException)
                        throw new LocalStorageException($"Path too long for file {filename}");
                    if (ex is DirectoryNotFoundException || ex is FileNotFoundException)
                        throw new LocalStorageException($"File {filename} was not found");

                }
            }
        }

        public IList<FileInfo> GetAll() => storageDirectory.GetFiles();

        public FileInfo Get(string name)
        {
            if (!Exists(name))
                throw new LocalStorageException($"File {name} does not exist");

            return storageDirectory.GetFiles().First(file => file.Name == name);
        }

        public void Clear()
        {
            foreach (var file in GetAll())
            {
                Remove(file.Name);
            }
        }
        
    }
}
