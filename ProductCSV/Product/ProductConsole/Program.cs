using ProductConsole.Catalog;
using ProductLibrary.Entities;
using System;
using ProductLibrary.OperationsOnFile;

namespace ProductConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string ProductFilePath = @"C:\Users\S S INFOTECH\Desktop\ProductCsvData\Original\ProductCSV.csv";
            string CategoryFilePath = @"C:\Users\S S INFOTECH\Desktop\ProductCsvData\Original\CategoryCSV.csv";

           MainMenu mainMenu = new MainMenu(ProductFilePath, CategoryFilePath);
           


        }
    }
}
