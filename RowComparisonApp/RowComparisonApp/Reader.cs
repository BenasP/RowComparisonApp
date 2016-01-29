using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RowComparisonApp
{
    public static class Reader
    {
        public static List<string> GetFileData(string filePath)
        {
            return File.ReadAllLines(filePath).ToList();
        }
    }
}
