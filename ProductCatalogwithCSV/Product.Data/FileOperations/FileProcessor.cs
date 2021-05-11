using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data.FileOperations
{
   public class FileProcessor
    {
        private static string Backup = "Backup";
        private static string inProcessing = "inProcess";
        private static string Completed = "Complete";
        public  string FilePath { get; }


        public FileProcessor(string filePath) {

            FilePath = filePath;
        }

        public void Process() {

            Console.WriteLine($"Begin Process Of File --  {FilePath}");

            if (!File.Exists(FilePath)) {

                Console.WriteLine($"File DoesNot Exist Invalid Path  {FilePath}");

                return;
            
            }

            string rootDirectoryPath = new DirectoryInfo(FilePath).Parent.FullName;
            Console.WriteLine($"Root Data Path Is -- {rootDirectoryPath}");

            //Check if backup exist

            string InputDirectoryPath = Path.GetDirectoryName(FilePath);
            Console.WriteLine(InputDirectoryPath);
            string backupDirectoryPath = Path.Combine(rootDirectoryPath,Backup);

            if (!Directory.Exists(backupDirectoryPath)) {

                Directory.CreateDirectory(backupDirectoryPath);
            
            }

            //copying file to backup

            string inputFileName = Path.GetFileName(FilePath);
            string backUpFilePath = Path.Combine(backupDirectoryPath,inputFileName);
            Console.WriteLine($"Copin data from --{FilePath} to {backUpFilePath}");
            File.Copy(FilePath,backUpFilePath,true);

            Directory.CreateDirectory(Path.Combine(rootDirectoryPath,inProcessing));

            string inProcessingFilePath = Path.Combine(rootDirectoryPath, inProcessing, inputFileName);


            if (File.Exists(inProcessingFilePath))
            {

                Console.WriteLine($"File Already in Process  {inProcessingFilePath}");

                return;

            }
            else
            {

                Console.WriteLine($"Moving File");
                File.Move(FilePath, inProcessingFilePath);

            }

            string extension = Path.GetExtension(FilePath);
            switch (extension) {

                case ".txt":
                    ProcessTextFile(inProcessingFilePath);
                    break;

                default:
                    Console.WriteLine("UnsupportedFile Type");
                    break;
            
            }

            string completedDirectoryPath = Path.Combine(rootDirectoryPath,Completed);
            Directory.CreateDirectory(completedDirectoryPath);

            Console.WriteLine($"Moving to complete");
            // File.Move(inProcessingFilePath,Path.Combine(completedDirectoryPath,inputFileName));
            var completedFileName = $"{Path.GetFileNameWithoutExtension(FilePath)}--{Guid.NewGuid()}{extension}";
            string completedFilePath = Path.Combine(completedDirectoryPath,completedFileName);

            File.Move(inProcessingFilePath,completedFilePath);
        }

        public void ProcessTextFile(string inProcessingFilePath) {

            Console.WriteLine($"File In Processing {inProcessingFilePath}");
        
        }
    }
}
