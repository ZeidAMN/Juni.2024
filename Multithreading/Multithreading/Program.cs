using System;
using System.Threading;
using System.IO;

namespace Multithreading
{
    internal class Program
    {
        // Wichtige Wörter ... Threads, Tasks, Semaphores, Mutex
        static public void schreibegrossbuchstaben()
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("A");
                Thread.Sleep(200);


            }

        }

        static public void schreibekleinbuchstaben()
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("a");
                Thread.Sleep(250);


            }

        }

        static void sucheundschreibewort(string filePath, string wort, string outputfilepath)
        {
            string text = File.ReadAllText(filePath);
            if (text.Contains(wort))
            {
                File.WriteAllText(outputfilepath, "Das Wort " + wort + " wurde gefunden.");
            }
            else
            {
                File.WriteAllText(outputfilepath, "Das Wort " + wort + " wurde nicht gefunden.");
            }
        }


        static void Main(string[] args)
        {
            // Error handling, Exception Handling
            // try, catch, throw

            string filePath = @"C:\Users\FP2402199\Downloads\test\test.cs"; // das ist typisch c#.. // wird keine probleme verursachen...
            try
            {
                // Attempt to read the content of the file
                string content = File.ReadAllText(filePath);
                // kann zu probleme führen
            }

            catch(Exception ex)
            {
                Console.WriteLine("oida da geht was nid" + ex.Message);

            }
            string wort = "kern";
            string outputfilepath = @"C:\Users\FP2402199\Downloads\test\output";

            // Suche das Wort im Dateiinhalt und schreibe das Ergebnis in eine neue Datei
            sucheundschreibewort(filePath, wort, outputfilepath);


            // wie kann ich in der datei suchen
            // nach einem wort sucht und ausgebe (ausgabe in einer eigenen datei)

            //schreibegrossbuchstaben();
            //schreibekleinbuchstaben();

            // man kanns prozess1 benennen oder thread1
            Thread thread1 = new Thread(new ThreadStart(schreibegrossbuchstaben));
            Thread thread2 = new Thread(new ThreadStart(schreibekleinbuchstaben));

            thread1.Start();
            thread2.Start();

            thread1.Join(); // wartet bis thread1 beendet ist
            thread2.Join(); // wartet bis thread2 beendet ist

            // thread2.Abort(); // wenn man was beenden will

            // klasse thread anschauen .. methoden! bitte nichts mit task, Mutex, Semaphore 

        }
    }
}
