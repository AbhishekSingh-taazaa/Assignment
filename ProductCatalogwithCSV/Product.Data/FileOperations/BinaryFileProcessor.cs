using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data.FileOperations
{
   public class BinaryFileProcessor
    {
        public string InputFilePath { get; set; }
        public string OutputFilePath { get; set; }

        public BinaryFileProcessor(string inputFilePath,string outputFilePath) {

            this.InputFilePath = inputFilePath;
            this.OutputFilePath = outputFilePath;


        }

        public void process() { }

    }
}
