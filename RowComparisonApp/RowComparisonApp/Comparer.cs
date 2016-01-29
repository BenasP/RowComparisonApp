using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RowComparisonApp
{
    public class Comparer
    {
        private string filePath;

        public Comparer(string filePath)
        {
            this.filePath = filePath;
        }

        public void Run()
        {
            var fileData = Reader.GetFileData(filePath);

            var linesWithMultipleValues = fileData.Where(l => l.Contains(";")).ToList();
            var linesWithDifferentValues = CompareValues(linesWithMultipleValues);

            Writer.Results(fileData, linesWithMultipleValues, linesWithDifferentValues);
        }

        private List<string> CompareValues(IEnumerable<string> linesWithMultipleValues)
        {
            var linesWithDifferentValues = new List<string>();
            foreach (var lineWithMultipleValue in linesWithMultipleValues)
            {
                var values = lineWithMultipleValue.Split(';');
                if (values.Distinct().Count() != 1)
                {
                    linesWithDifferentValues.Add(lineWithMultipleValue);
                }
            }

            return linesWithDifferentValues;
        }
    }

    public class Writer
    {
        public static void Results(List<string> allData, List<string> filteredData, List<string> filteredDataWithDiffValues)
        {
            var file = new StreamWriter(@"results.txt");
            file.WriteLine($"{ allData.Count } lines processed");
            file.WriteLine($"{ filteredData.Count } lines with multiple values processed");
            file.WriteLine($"{ filteredDataWithDiffValues.Count } lines with multiple different values");
            foreach (var line in filteredDataWithDiffValues)
            {
                file.WriteLine(line);
            }
        }
    }
}
