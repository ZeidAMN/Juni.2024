using System;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading02
{
    internal class Program
    {

        public static void schreibebuchtstaben()
        {
            int i;
            for (i = 0; i < 100; i++)
            {
                Console.WriteLine((char)('a' + i));
                Thread.Sleep(250);
            }

        }

        public static void schreibebuchtstabengross()
        {
            int i;
            for (i = 0; i < 100; i++)
            {
                Console.WriteLine((char)('A' + i));
                Thread.Sleep(250);
            }


        }

        static void Main(string[] args)
        {
            Task task1 = new Task(() => { schreibebuchtstaben(); });
            Task task2 = new Task(() => { schreibebuchtstabengross(); });

            task1.Start();
            task2.Start();

            // Task.WaitAll(task1);

            task1.Wait();
            task2.Wait();

            int ergebnis;

            Func<int, int> quadrieren = x => x * x;

            ergebnis = quadrieren(5); // ergebnis wird 25 sein
            Console.WriteLine(ergebnis);
            // lambda expression .. 

        }
    }
}
