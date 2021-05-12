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
  public  class OperationOnCategoryFile
    {
        public string FilePath { get; set; }
        public static List<Category> CommonCategoryList = new List<Category>();
        public static HashSet<string> categoriesShortCoeds = new HashSet<string>(); 

        CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            TrimOptions = TrimOptions.Trim,
            Comment = '@',
            AllowComments = true,

        };


        public OperationOnCategoryFile(string inputFilePath)
        {

            this.FilePath = inputFilePath;

        }

        public List<Category> ListOfCategoryCSV()
        {
            CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                TrimOptions = TrimOptions.Trim,
                Comment = '@',
                AllowComments = true,

            };

            using (StreamReader reader = File.OpenText(FilePath))
            using (CsvReader csvReader = new CsvReader(reader, config))
            {
                //if (CommonCategoryList.Count() == 0 ) { }
                CommonCategoryList = csvReader.GetRecords<Category>().ToList();
            }
            return CommonCategoryList;
        }



        public Category findInCategoryCSVById(int id)
        {

            var searchedCategory = CommonCategoryList.Single(x => x.Id == id);

            return searchedCategory;

        }


        public void AddToCategoryCSV(Category category)
        {
            bool append = true;
            CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
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
                csvWriter.WriteRecord(category);


            }


        }

        public void RemoveFromCategoryCSVById(int id)
        {
            CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                TrimOptions = TrimOptions.Trim,
                Comment = '@',
                AllowComments = true,

            };

            Category deletecategory = CommonCategoryList.Single(x => x.Id == id);

            CommonCategoryList.Remove(deletecategory);

            using (var writer = new StreamWriter(FilePath))
            using (CsvWriter csvWriter = new CsvWriter(writer, config))
            {
                csvWriter.Context.RegisterClassMap<CategoryMapper>();

                csvWriter.WriteRecords(CommonCategoryList);

            }

        }
    }
}
