using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary.FileProcessing
{
   public class FileProcess
    {
        public string ProductFilePath { get; set; }
        public string CategoryFilePath { get; set; }

        public string rootDirectoryPathProduct { get; set; }
        public string rootDirectoryPathCategory { get; set; }
   
        public FileProcess(string productFilePath, string categoryFilePath)
        {
            ProductFilePath = productFilePath;
            CategoryFilePath = categoryFilePath;

        }

        public void FileChecker() {

            if (!File.Exists(ProductFilePath)) {


                File.Create(ProductFilePath);
            
            }
            else if (!File.Exists(CategoryFilePath)) {

                File.Create(CategoryFilePath);
            
            }


            
        }


        public void BackupCreater() {

            string rootDirectoryPathProduct = new DirectoryInfo(ProductFilePath).Parent.FullName;
            string rootDirectoryPathCategory = new DirectoryInfo(CategoryFilePath).Parent.FullName;

            string BackupPathProduct = Path.Combine(rootDirectoryPathProduct, "Backup");
            string BackupPathCategory = Path.Combine(rootDirectoryPathCategory, "Backup");


            Directory.CreateDirectory(BackupPathProduct);
            Directory.CreateDirectory(BackupPathCategory);

            File.Copy(ProductFilePath, BackupPathProduct);
            File.Copy(CategoryFilePath, BackupPathCategory);


        }

        public string  InProgressProductFile() {

            string inputFileName = Path.GetFileName(ProductFilePath);
            string inProgressDirectoryPath = Path.Combine(rootDirectoryPathProduct,"InProgress");
            Directory.CreateDirectory(inProgressDirectoryPath);
            string inProgressFielPath = Path.Combine(inProgressDirectoryPath,inputFileName);
          

            if (File.Exists(inProgressFielPath))
            {
           throw new Exception("File is AlreadyExist");
            }

            return "";
        }
    }
}
