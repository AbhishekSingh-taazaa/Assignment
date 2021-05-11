using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data.FileOperations
{
  public  class StreamProcessing
    {
        public string InputFilePath { get; set; }
        public string OutputFilePath { get; set; }

        public StreamProcessing(string inputFilePath, string outputFilePath)
        {

            this.InputFilePath = inputFilePath;
            this.OutputFilePath = outputFilePath;
           


        }

        public void process() {

           // using (var inputFileStream = new FileStream(InputFilePath, FileMode.Open))
          //  using (var outputFileStream = new FileStream(OutputFilePath, FileMode.OpenOrCreate))
            using (var inputStreamReader = new StreamReader(InputFilePath))
            using (var outputStreamWriter = new StreamWriter(OutputFilePath)) {

                while (!inputStreamReader.EndOfStream) {

                    string line = inputStreamReader.ReadLine();
                    string processedLine = line.ToUpperInvariant();
                    bool isLastLine = inputStreamReader.EndOfStream;

                    if (isLastLine) {

                        outputStreamWriter.Write(processedLine);
                    }
                    else
                    {
                        outputStreamWriter.WriteLine(processedLine);
                    }
                }
            
            
            }
        }

    }

}
