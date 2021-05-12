using CsvHelper;
using CsvHelper.Configuration;
using ProductLibrary.Entities;
using ProductLibrary.EntityCSVMapper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary.OperationsOnFile
{
   public class OperationOnProductFile
    {
        public string FilePath {get;}
        public static List<Product> CommonProductList = new List<Product>();

      

        public OperationOnProductFile(string inputFilePath)
        {

            this.FilePath = inputFilePath;
        }

        public List<Product> ListOfProductCSV()
        {
            CsvConfiguration config = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                TrimOptions = TrimOptions.Trim,
                Comment = '@',
                AllowComments = true,

            };
            using (StreamReader input = File.OpenText(FilePath))
            using (CsvReader csvReader = new CsvReader(input, config))
            {

                CommonProductList = csvReader.GetRecords<Product>().ToList();

            }
            return CommonProductList;

        }



        public Product findInProductCSVById(int id)
        {
            var searchedProduct = CommonProductList.Single(x => x.Id == id);

            return searchedProduct;

        }


        public void AddToProductCSV(Product product)
        {
            bool append = true;
            CsvConfiguration config = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                TrimOptions = TrimOptions.Trim,
                Comment = '@',
                AllowComments = true,
                HasHeaderRecord = !append

        };

 
            using (var writer = new StreamWriter(FilePath, append))
                using (CsvWriter csvWriter = new CsvWriter(writer, config))
            {

                csvWriter.NextRecord();
                csvWriter.WriteRecord(product);

            }


        }

        public void RemoveFromProductCSVById(int id)
        {
            CsvConfiguration config = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                TrimOptions = TrimOptions.Trim,
                Comment = '@',
                AllowComments = true,

            };

            Product deleteProduct = CommonProductList.Single(x => x.Id == id);

            CommonProductList.Remove(deleteProduct);

            using (var writer = new StreamWriter(FilePath))
            using (CsvWriter csvWriter = new CsvWriter(writer, config))
            {
                csvWriter.Context.RegisterClassMap<ProductMapper>();

                csvWriter.WriteRecords(CommonProductList);

            }


        }

    }
}
