using Product.Data.Entites;
using Product.Data.FileOperations;
using Product.Data.OperationOnCSV;
using System;
using System.Text;
using static System.Console;

namespace Product.Console
{
    public class Program
    {
        static void Main(string[] args)  
        {
            //FileProcessor file = new FileProcessor(path);

            //file.Process();

           

            //string Inputpath = @"C:\Users\S S INFOTECH\Desktop\ProductCsvData\ProductCSVDummy.txt";

            //string Output = @"C:\Users\S S INFOTECH\Desktop\ProductCsvData\ProductCSVDummyV1.txt";

            //TextFileProcessor textFileProcessor = new TextFileProcessor(Inputpath, Output);
            //textFileProcessor.process();

            //StreamProcessing streamProcessing = new StreamProcessing(Inputpath, Output);
            //streamProcessing.process();

            string ProductcsvInputPath = @"C:\Users\S S INFOTECH\Desktop\ProductCsvData\Original\ProductCSV.csv";
            string csvOutputPath = "";
            string CategorycsvInputPath = @"C:\Users\S S INFOTECH\Desktop\ProductCsvData\Original\CategoryCSV.csv";

            CSVFileProcessor cSVFileProcessor = new CSVFileProcessor(ProductcsvInputPath, csvOutputPath);
            cSVFileProcessor.process();

            OperationOnProductCSV operationOnProductCSV = new OperationOnProductCSV(ProductcsvInputPath, csvOutputPath);
            //operationOnProductCSV.AddToProductCSV();
            // operationOnProductCSV.RemoveFromProductCSVById(121);

            OperationOnCategoryCSV operationOnCategoryCSV = new OperationOnCategoryCSV(CategorycsvInputPath, csvOutputPath);
            operationOnCategoryCSV.ListOfCategoryCSV();
        }
    }
}
