using System;
using System.IO;
using System.Threading;

namespace MutexFileExample
{
    internal class Program
    {
        private static Mutex mutex = new Mutex(); // Mutex für die Datei-Synchronisation

        private static string filePath = @"C:\Users\FP2402199\Downloads\testing\output.txt"; // Pfad zur Ausgabedatei

        public static void WriteToFile(string input)
        {
            try
            {
                mutex.WaitOne(); // Mutex erwerben, um exklusiven Zugriff zu gewährleisten

                // Eingabe an Datei anhängen
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine(input);
                }

                // Aktuellen Dateiinhalt lesen und in der Konsole anzeigen
                string fileContent = File.ReadAllText(filePath);
                Console.Clear(); // Konsole leeren, um den aktuellen Dateiinhalt anzuzeigen
                Console.WriteLine($"Aktueller Inhalt der Datei '{Path.GetFileName(filePath)}':");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine(fileContent);
                Console.WriteLine("-------------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fehler beim Schreiben in die Datei:" + ex.Message);
            }
            finally
            {
                mutex.ReleaseMutex(); // Mutex freigeben
            }
        }

        static void Main(string[] args)
        {
            // Starten eines Threads für die Konsoleneingabe
            Thread consoleThread = new Thread(() =>
            {
                while (true)
                {
                    Console.WriteLine("Geben Sie einen Text ein (Geben Sie 'exit' ein, um zu beenden):");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "exit")
                        break;

                    WriteToFile(input);
                }
            });

            // Starten des Threads für die Konsoleneingabe
            consoleThread.Start();

            // Warten, bis der Konsolen-Thread beendet ist
            consoleThread.Join();

            Console.WriteLine("Konsolen-Thread beendet.");
        }
    }
}