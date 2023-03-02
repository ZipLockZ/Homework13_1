using System.Diagnostics;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Homework_13_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StreamReader stream = new StreamReader(@"C:\\Users\\ivan\\Desktop\\Text1.txt");
            listadd();
            linkedlistadd();
            Console.ReadLine();
        }

        //проверяем скорость загрузки в list
        static void listadd()
        {
            StreamReader str = new StreamReader(@"C:\\Users\\ivan\\Desktop\\Text1.txt");
            var timer = new Stopwatch();
            timer.Start();
            List<string> text = new List<string>();
            while (!str.EndOfStream)
            {
                text.Add(str.ReadLine());
            }
            timer.Stop();
            Console.WriteLine("Время добавления в list: " + timer.Elapsed.Milliseconds);
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine(text.Count);
            Console.WriteLine();
            foreach (string line in text) { Console.WriteLine(line); }
        }
        //проверяем скорость загрузки в linkedlist
        static void linkedlistadd()
        {
            StreamReader str = new StreamReader(@"C:\\Users\\ivan\\Desktop\\Text1.txt");

            var timer = new Stopwatch();
            timer.Start();

            LinkedList<string> text = new LinkedList<string>();
            var sent = text.AddFirst(str.ReadLine());

            while (!str.EndOfStream)
            {
                text.AddAfter(text.First, str.ReadLine());

            }
            timer.Stop();

            Console.WriteLine("Время добавления в linkedlist: " + timer.Elapsed.Milliseconds);
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine(text.First.Value);
            Console.WriteLine(text.Count);
            Console.WriteLine();
            foreach (string line in text) { Console.WriteLine(line); }
        }
    }
}