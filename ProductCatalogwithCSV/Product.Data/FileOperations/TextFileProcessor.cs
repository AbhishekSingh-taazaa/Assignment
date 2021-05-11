using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Product.Data.FileOperations
{
   public class TextFileProcessor
    {
        public string InputFilePath { get; set; }
        public string OutputFilePath { get; set; }

        public TextFileProcessor(string inputpath,string outputpath) {

            this.InputFilePath = inputpath;
            this.OutputFilePath = outputpath;
        
        }

        public void process() {

          string data =   File.ReadAllText(InputFilePath);
            string updata = data.ToUpper();

            //File.WriteAllText(OutputFilePath,updata, new UTF8Encoding(true));

            File.AppendAllText(OutputFilePath,data);
        
        }
    }
}
