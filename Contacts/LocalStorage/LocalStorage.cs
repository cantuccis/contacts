using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalStorage
{
    public class LocalStorage
    {
        public readonly DirectoryInfo StorageDirectory;
        public LocalStorage(string storageDirPath)
        {
            StorageDirectory = new DirectoryInfo(storageDirPath);
        }
       
        public void Add(FileInfo file)
        {
            if (file == null)
                throw new ArgumentNullException("File cannot be null");

            if (Exists(file.Name))
                throw new LocalStorageException($"File {file.Name} already exists");

            string destionationPath = Path.Combine(StorageDirectory.FullName, file.FullName);

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

        public bool Exists(string filename) => StorageDirectory.GetFiles().Any(finfo => finfo.Name == filename);

        public void Remove(string filename)
        {
            if(Exists(filename))
            {
                string filepath = Path.Combine(StorageDirectory.FullName, filename);
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
    }
}
