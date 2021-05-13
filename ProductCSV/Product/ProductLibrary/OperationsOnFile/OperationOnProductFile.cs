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
   public class OperationOnProductFile : List<Product>
    {
        public string FilePath {get;}
        public static List<Product> CommonProductList = new List<Product>();
        public static HashSet<string> ProductShortCodes = new HashSet<string>();



        public OperationOnProductFile(string inputFilePath)
        {

            this.FilePath = inputFilePath;
        }


        //List Retun Function

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
                if (CommonProductList.Count() == 0) {

                    CommonProductList = csvReader.GetRecords<Product>().ToList();
                    CommonProductList.ForEach(x => ProductShortCodes.Add(x.ShortCode));
                }
               

            }
            return CommonProductList;

        }


        // Find Functions
        public Product findInProductCSVById(int id)
        {
            var searchedProduct = CommonProductList.Single(x => x.Id == id);

            return searchedProduct;

        }

        public Product findInProductCSVByName(string name)
        {
            var searchedProduct = CommonProductList.Single(x => x.Name == name);

            return searchedProduct;

        }

        public Product findInProductCSVByShortCode(string shortcode)
        {
            var searchedProduct = CommonProductList.Single(x => x.ShortCode == shortcode);

            return searchedProduct;

        }
        //End of Finding functions

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

        //Begin Remove Function

        public void RemoveFromProductCSVById(int id)
        {
           
            Product deleteProduct = CommonProductList.Single(x => x.Id == id);

             this.Remove(deleteProduct);

           

        }

        public void RemoveRemoveFromProductCSVByName(string name) {

            Product deleteProduct = CommonProductList.Single(x => x.Name == name);

            this.Remove(deleteProduct);


        }

        public void RemoveRemoveFromProductCSVByShortCode(string shortcode)
        {

            Product deleteProduct = CommonProductList.Single(x => x.ShortCode == shortcode);

            this.Remove(deleteProduct);


        }

        //End Of Remove Functions

        //trying shadowing with Add METHOD of List

        public new void Add(Product product) {

            CommonProductList.Add(product);
            ProductShortCodes.Add(product.ShortCode);

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

        //trying shadowing with Remove METHOD of List


        public new void Remove(Product product) {

            CommonProductList.Remove(product);
            ProductShortCodes.Remove(product.ShortCode);
            CsvConfiguration config = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                TrimOptions = TrimOptions.Trim,
                Comment = '@',
                AllowComments = true,

            };


            using (var writer = new StreamWriter(FilePath))
            using (CsvWriter csvWriter = new CsvWriter(writer, config))
            {
                csvWriter.Context.RegisterClassMap<ProductMapper>();

                csvWriter.WriteRecords(CommonProductList);

            }



        }

    }
}
