using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace PracticeProject.HackerRank
{
    [MemoryDiagnoser]
    public class HackerRank
    {

        public HackerRank()
        {
            GetExcelColumnName();
            

        }

        [Benchmark]
        public void GetExcelColumnName()
        {
            int columnNumber = 23;
            string columnName = string.Empty;
            while (columnNumber > 0)
            {
                int remainder = (columnNumber - 1) % 26;
                columnName = (char)(remainder + 'A') + columnName;
                columnNumber = (columnNumber - 1) / 26;
            }
        }
    }
}
