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
            Boolean again;
            Boolean again2 = true;
            int iNum;
            string sNum;
            Stack<String> staSta = new Stack<string>();

            while (again2 == true)
            {
                Console.WriteLine("Enter your Option\n");
                Console.WriteLine("1. Stack");
                Console.WriteLine("2. Queue");
                Console.WriteLine("3. Dictionary");
                Console.WriteLine("4. Exit\n");

                sNum = Console.ReadLine();

                /*while (Int32.TryParse(sNum, out iNum) == true && Int32.Parse(sNum) <= 4 && Int32.Parse(sNum) >= 1)
                {
                    Console.WriteLine("Error. Please enter a Number 1-4");
                    sNum = Console.ReadLine();
                }*/

                iNum = Int32.Parse(sNum);

                if (iNum == 1)
                {
                    while (again = true)
                    {
                        Console.WriteLine("Enter your Option\n");
                        Console.WriteLine("1. Add one time to Stack");
                        Console.WriteLine("2. Add a Huge List of Items to Stack");
                        Console.WriteLine("3. Display Stack");
                        Console.WriteLine("4. Delete from Stack");
                        Console.WriteLine("5. Clear Stack");
                        Console.WriteLine("6. Search Stack");
                        Console.WriteLine("7. Return to Main Menu\n");

                        sNum = Console.ReadLine();

                        /*while (Int32.TryParse(sNum, out iNum) == true && Int32.Parse(sNum) <= 7 && Int32.Parse(sNum) >= 1)
                        {
                            Console.WriteLine("Error. Please enter a Number 1-7");
                            sNum = Console.ReadLine();
                        }*/

                        again = true;
                        iNum = Int32.Parse(sNum);


                        if (iNum == 1)
                        {
                            Console.WriteLine("What do you want to add?\n");
                            staSta.Push(Console.ReadLine());
                            Console.WriteLine("Added Successful\n");
                        }

                        else if (iNum == 2)
                        {
                            staSta.Clear();
                            int counter = 1;

                            while (staSta.Count() <= 2000)
                            {
                                staSta.Push("New Entry" + counter);
                                counter++;
                            }

                            Console.WriteLine("Stack cleared\n");
                        }

                        else if (iNum == 3)
                        {
                            foreach (string item in staSta)
                            {
                                Console.WriteLine(item);
                            }

                            Console.WriteLine("\n");
                        }

                        else if (iNum == 4)
                        {
                            foreach (string item in staSta)
                            {
                                Console.WriteLine("What do you want to Delete?");
                                sNum = Console.ReadLine();

                                if (staSta.Peek().Equals(sNum))
                                {
                                    staSta.Pop();
                                    Console.WriteLine("Item Deleted");
                                }

                                else
                                {
                                    Console.WriteLine("Item not found");
                                }
                            }
                        }

                        else if (iNum == 5)
                        {
                            staSta.Clear();

                        }

                        else if (iNum == 6)
                        {
                            foreach (string item in staSta)
                            {
                                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                                Console.WriteLine("What do you want to search for?");
                                sNum = Console.ReadLine();

                                sw.Start();
                                if (staSta.Peek().Equals(sNum))
                                {
                                    sw.Stop();
                                    Console.WriteLine("Found It! Time to find: " + sw.Elapsed);
                                    sw.Stop();
                                }

                                else
                                {
                                    Console.WriteLine("Not found");
                                    sw.Reset();
                                }


                            }
                        }

                        else
                        {
                            again = false;
                        }
                    }
                }

                else if (iNum == 2)
                { }
                else if (iNum == 3)
                { }

                else 
                {
                    again2 = false;
                }

            }
        }
    }
}

