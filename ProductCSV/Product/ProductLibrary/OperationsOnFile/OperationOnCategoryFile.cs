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
  public  class OperationOnCategoryFile : List<Category>
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
               if (CommonCategoryList.Count() == 0 ) {
                    CommonCategoryList = csvReader.GetRecords<Category>().ToList();
                    CommonCategoryList.ForEach(x => categoriesShortCoeds.Add(x.ShortCode));
                }
               
            }
            return CommonCategoryList;
        }


        //Finding Functions
        public Category findInCategoryCSVById(int id)
        {
            var searchedCategory = CommonCategoryList.Single(x => x.Id == id);
            return searchedCategory;
        }

        public Category findInCategoryCSVByName(string  name)
        {
            var searchedCategory = CommonCategoryList.Single(x => x.Name == name);
            return searchedCategory;
        }

        public Category findInCategoryCSVByShortCode(string shortcode)
        {
            var searchedCategory = CommonCategoryList.Single(x => x.ShortCode == shortcode);
            return searchedCategory;
        }
        //Ending Finding Functions

     

        //Removing Functions
        public void RemoveFromCategoryCSVById(int id)
        {
            Category deletecategory = CommonCategoryList.Single(x => x.Id == id);
            this.Remove(deletecategory);
        }

        public void RemoveFromCategoryCSVByName(string name)
        {
            Category deletecategory = CommonCategoryList.Single(x => x.Name == name);
            this.Remove(deletecategory);
        }

        public void RemoveFromCategoryCSVByShortCode(string shortcode)
        {
            Category deletecategory = CommonCategoryList.Single(x => x.ShortCode == shortcode);
            this.Remove(deletecategory);
        }
        // Ending removing functions

        //trying shadowing with Add METHOD of List
        public new void Add(Category category) 
        {
            CommonCategoryList.Add(category);
            categoriesShortCoeds.Add(category.ShortCode);
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

        //trying shadowing with Remove Mtehod of List

        public new void Remove(Category category) 
        {
            CommonCategoryList.Remove(category);
            categoriesShortCoeds.Remove(category.ShortCode);
            CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                TrimOptions = TrimOptions.Trim,
                Comment = '@',
                AllowComments = true,

            };

            using (var writer = new StreamWriter(FilePath))
            using (CsvWriter csvWriter = new CsvWriter(writer, config))
            {
                csvWriter.Context.RegisterClassMap<CategoryMapper>();

                csvWriter.WriteRecords(CommonCategoryList);

            }

        }
    }
}
