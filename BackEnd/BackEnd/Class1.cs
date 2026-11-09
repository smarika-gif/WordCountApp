using System.Diagnostics;

namespace BackEnd
{
    public class  SearchResult
    {
        public string SearchWord { get; set; }
        public int Count { get; set; }
        public double SearchTime { get; set; }
    }
    public class Class1
    {

       public static SearchResult WordCount(string input, string searchWord)
        {
            if (string.IsNullOrEmpty(searchWord))
            {
                return new SearchResult
                {
                    SearchWord = searchWord,
                    Count = 0,
                    SearchTime = 0

                };
            }
            
            int count = 0;
            int index = 0;

            StringComparison comparison = StringComparison.Ordinal;

            Stopwatch stopwatch = Stopwatch.StartNew();

            while ((index = input.IndexOf(searchWord, index, comparison)) != -1)
            {
                count++;
                index += searchWord.Length;
            }
            stopwatch.Stop();

            return new SearchResult
            {
                SearchWord = searchWord,
                Count = count,
                SearchTime = stopwatch.Elapsed.TotalMilliseconds
            };
        }
        






    }
}
