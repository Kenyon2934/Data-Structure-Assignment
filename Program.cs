using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum;
            string 

            Console.WriteLine("Enter your Options\n");
            Console.WriteLine("1. Stack");
            Console.WriteLine("2. Queue");
            Console.WriteLine("3. Dictionary");
            Console.WriteLine("4. Exit\n");

            sNum = Console.Read();

            while(Int32.TryParse(iNum))
            
            Console.WriteLine("1. Add one Item to queue");
            Console.WriteLine("2. Add Huge List of Items to Queue");
            Console.WriteLine("3. Display Queue");
            Console.WriteLine("4. Delete from Queue");
            Console.WriteLine("5. Clear Queue");
            Console.WriteLine("6. Search Queue");
            Console.WriteLine("7. Return to Main Menu\n");

            selected = Console.ReadLine();

                if (selected == "1")
                {
                    Console.WriteLine("Please enter a string");
                    qItems.Enqueue(Console.ReadLine());
                }

                else if (selected == "2")
                {
                    qItems.Clear();
                    int counter = 1;
                    while (qItems.Count() <= 2000)
                    {
                        qItems.Enqueue("New Entry" + counter);
                        counter++;
                    }
                }

                else if (selected == "3")
                {
                    foreach (string item in qItems)
                    {
                        Console.WriteLine(item);
                    }
                }

                else if (selected == "4")
                {
                    string input = "";
                    Console.Write("Which item do you want to delete?");
                    input = Console.ReadLine();
                    
                }

                else if (selected == "5")
                {
                    qItems.Clear();
                    Console.WriteLine("All items removed");
                }

                else if (selected == "6") 
                {
                    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                    string input = "";
                    Console.Write("Enter Search field: ");
                    input = Console.ReadLine();
                    sw.Start();
                    if (qItems.Contains(input))
                    {
                        sw.Stop();
                        Console.WriteLine("Found It! Time to find: " + sw.Elapsed);
                        sw.Reset();
                    }
                    else
                    {
                        Console.WriteLine("Not found");
                        sw.Reset();
                    }
                }
        }
    }
}
