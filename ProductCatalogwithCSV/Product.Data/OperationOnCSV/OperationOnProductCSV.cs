using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prod = Product.Data.Entites;
using CsvHelper.Configuration;
using System.Globalization;
using Product.Data.Mapping;

namespace Product.Data.OperationOnCSV
{
   public class OperationOnProductCSV
    {
        public string InputFilePath { get; set; }
        public string OutputFilePath { get; set; }

        public OperationOnProductCSV(string inputFilePath, string outputFilePath)
        {

            this.InputFilePath = inputFilePath;
            this.OutputFilePath = outputFilePath;



        }

     public List<prod.Product>  ListOfProductCSV() {

            List<prod.Product> products = new List<prod.Product>();
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                TrimOptions = TrimOptions.Trim,
                Comment = '@',
                AllowComments = true,

            };

          
            using (StreamReader input = File.OpenText(InputFilePath))
            using (CsvReader csvReader = new CsvReader(input, config))
            {



                 products = csvReader.GetRecords<prod.Product>().ToList();


                products.ForEach(x => Console.WriteLine(x));





            }
            return products;
        }



        public prod.Product findInProductCSVById(int id) {

            List<prod.Product> productList = new List<prod.Product>();

            productList = this.ListOfProductCSV();

            var searchedProduct = productList.Single(x => x.Id == id);


            return searchedProduct;
        
        }


        public void AddToProductCSV(prod.Product product) {
           
            bool append = true;
            //prod.Product productt = new prod.Product {
            //    Id = 123,
            //     Name = "Grapes",
            //     Manufacturer ="Rexer",
            //     ShortCode = "GRAP10",
            //     Description="Fruits",
            //     SellingPrice=350,
            //     ProductCategory ="Food"
                
            //};
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                TrimOptions = TrimOptions.Trim,
                Comment = '@',
                AllowComments = true,
                HasHeaderRecord = !append

            };
            using (var writer = new StreamWriter(InputFilePath, append))
            using (CsvWriter csvWriter = new CsvWriter(writer, config)) {

                csvWriter.NextRecord();
                csvWriter.WriteRecord(product);
             
            
            }


        }

        public void RemoveFromProductCSVById(int id) {
            List<prod.Product> productsoverwrite = new List<prod.Product>();
            
            productsoverwrite = this.ListOfProductCSV();
           
            prod.Product deleteProduct = productsoverwrite.Single(x => x.Id == id);

            productsoverwrite.Remove(deleteProduct);

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                TrimOptions = TrimOptions.Trim,
                Comment = '@',
                AllowComments = true,
                
            

            };
            using (var writer = new StreamWriter(InputFilePath))
            using (CsvWriter csvWriter = new CsvWriter(writer, config))
            {
                csvWriter.Context.RegisterClassMap<ProductMap>();


                csvWriter.WriteRecords(productsoverwrite);


            }


        }


    }
}
