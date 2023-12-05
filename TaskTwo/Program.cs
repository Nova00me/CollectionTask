
using static System.Net.Mime.MediaTypeNames;

namespace TaskTwo
{
    class Pogram
    {
        public static void Main(string[] args)
        {
            string Text = File.ReadAllText(@"C:\Users\Nova\Desktop\Text1.txt");
            Dictionary<string, int> counts = new Dictionary<string, int>();
            SortedSet<int> ints = new SortedSet<int>();
            char[] chars = { ' ', ',', '.', '(', ')', '<', '>', '\"', '\'', ':', ';', '-' };


            string[] worlds = Text.Split(chars, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in worlds)
            {
                if(counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }
            var sortedWords = from pair in counts orderby pair.Value descending select pair; //эту строку взял из chat - gpt

            foreach (var pair in sortedWords.Take(10))
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
        }

    }
}