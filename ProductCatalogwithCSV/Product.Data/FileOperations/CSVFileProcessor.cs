using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prod= Product.Data.Entites;
using CsvHelper.Configuration;
using System.Globalization;

namespace Product.Data.FileOperations
{
    public class CSVFileProcessor
    {
        public string InputFilePath { get; set; }
        public string OutputFilePath { get; set; }

        public CSVFileProcessor(string inputpath, string outputpath)
        {

            this.InputFilePath = inputpath;
            this.OutputFilePath = outputpath;



        }

        public void process()
        {

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                TrimOptions = TrimOptions.Trim,
                Comment = '@',
                AllowComments = true,

            };

            List<dynamic> productsrecord = new List<dynamic>();
            using (StreamReader input = File.OpenText(InputFilePath))
            using (CsvReader csvReader = new CsvReader(input, config))
            {

              

                    var products = csvReader.GetRecords<prod.Product>().ToList();


                    products.ForEach(x => Console.WriteLine(x));

                



            }
        }


    }
}
