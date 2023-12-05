using System.Diagnostics;

namespace TaskOne
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> bookList = new List<string>();
            Stopwatch sw = new Stopwatch();

            var book = File.ReadAllText(@"C:\Users\Nova\Desktop\Text1.txt"); //путь 

            bookList.AddRange(book.Split(" ")); 
            
            LinkedList<string> bookLinkedList = new LinkedList<string>(bookList);

            #region ListSet
            sw.Start();

            bookList.Insert(33, "Hello");

            sw.Stop();

            Console.WriteLine($"Скорость вставки слова Hello в индекс 33 = {sw.Elapsed.TotalMilliseconds} милесекунд");
            #endregion
            #region LinkedListSet
            int temsp = 0;
            foreach (var item in bookLinkedList)
            {
                temsp++;
                if(temsp == 33)
                {
                    var ssa = bookLinkedList.Find(item);
                    sw.Start();
                    bookLinkedList.AddAfter(ssa, "Hello");
                    sw.Stop();
                    Console.WriteLine($"Скорость вставки слова Hello в индекс 33 = {sw.Elapsed.TotalMilliseconds} миллесекунд");
                    break;
                }
            }
            #endregion


        }
    }
}