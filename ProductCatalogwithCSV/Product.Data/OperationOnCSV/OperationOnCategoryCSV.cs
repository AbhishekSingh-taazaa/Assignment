using CsvHelper;
using CsvHelper.Configuration;
using Product.Data.Entites;
using Product.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data.OperationOnCSV
{
   public class OperationOnCategoryCSV
    {
        public string InputFilePath { get; set; }
        public string OutputFilePath { get; set; }

        public OperationOnCategoryCSV(string inputFilePath, string outputFilePath)
        {

            this.InputFilePath = inputFilePath;
            this.OutputFilePath = outputFilePath;



        }

        public List<Category> ListOfCategoryCSV()
        {

            List<Category> categories = new List<Category> ();
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                TrimOptions = TrimOptions.Trim,
                Comment = '@',
                AllowComments = true,

            };


            using (StreamReader input = File.OpenText(InputFilePath))
            using (CsvReader csvReader = new CsvReader(input, config))
            {



                categories = csvReader.GetRecords<Category>().ToList();


                categories.ForEach(x => Console.WriteLine(x));





            }
            return categories;
        }



        public Category findInCategoryCSVById(int id)
        {

            List<Category> categoryList = new List<Category>();

            categoryList = this.ListOfCategoryCSV();

            var searchedCategory = categoryList.Single(x => x.Id == id);


            return searchedCategory;

        }


        public void AddToCategoryCSV(Category category)
        {

            bool append = true;
           
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                TrimOptions = TrimOptions.Trim,
                Comment = '@',
                AllowComments = true,
                HasHeaderRecord = !append

            };
            using (var writer = new StreamWriter(InputFilePath, append))
            using (CsvWriter csvWriter = new CsvWriter(writer, config))
            {

                csvWriter.NextRecord();
                csvWriter.WriteRecord(category);


            }


        }

        public void RemoveFromCategoryCSVById(int id)
        {
            List<Category> categoriesoverwrite = new List<Category>();

            categoriesoverwrite = this.ListOfCategoryCSV();

            Category deletecategory = categoriesoverwrite.Single(x => x.Id == id);

            categoriesoverwrite.Remove(deletecategory);

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                TrimOptions = TrimOptions.Trim,
                Comment = '@',
                AllowComments = true,



            };
            using (var writer = new StreamWriter(InputFilePath))
            using (CsvWriter csvWriter = new CsvWriter(writer, config))
            {
                csvWriter.Context.RegisterClassMap<CategoryMap>();


                csvWriter.WriteRecords(categoriesoverwrite);


            }


        }

    }
}
