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
            //declare varibles
            Boolean again;
            Boolean again2 = true;
            int iNum;
            string sNum;
            Stack<String> staSta = new Stack<string>();
            Stack<String> staSta2 = new Stack<string>();

            //Loop until user wants to exit
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

                //for stack
                if (iNum == 1)
                {
                    //loop until the user wants to exit
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

                        //for add
                        if (iNum == 1)
                        {
                            Console.WriteLine("What do you want to add?\n");
                            staSta.Push(Console.ReadLine());
                            Console.WriteLine("Added Successful\n");
                        }

                        //to add 2000 entries 
                        else if (iNum == 2)
                        {
                            staSta.Clear();
                            int counter = 1;

                            while (counter<= 2000)
                            {
                                staSta.Push("New Entry" + counter);
                                counter++;
                            }

                            
                        }
            
                       //display all items
                        else if (iNum == 3)
                        {
                            foreach (string item in staSta)
                            {
                                Console.WriteLine(item);
                            }

                            Console.WriteLine("\n");
                        }

                            //delete a specific item
                        else if (iNum == 4)
                        {


                            Console.WriteLine("What do you want to Delete?");
                            sNum = Console.ReadLine();
                           
                            if (staSta.Contains(sNum))
                            {
                                foreach (string item in staSta)
                                {

                                    if (staSta.Peek() != sNum)
                                    {
                                        //holds items that user does not want to delte
                                        staSta2.Push(staSta.Pop());
                                    }

                                    else
                                    {
                                        //deletes the item
                                        staSta.Pop();
                                        Console.WriteLine("Item Deleted");

                                    }
                                }

                               
                                int iCounter = staSta2.Count();
                               
                                //gives the item back to the orginal stack
                                for (int iCount = 0; iCount < iCounter; iCount++)
                                {
                                    staSta.Push(staSta2.Pop());
                                }
                            }

                            else
                            {
                                Console.WriteLine("Item Not Found");
                            }
                        }
                        
                        
                        //clears stack
                        else if (iNum == 5)
                        {
                            staSta.Clear();
                            Console.WriteLine("Stack cleared\n");

                        }
                        
                        //searchs stack
                        else if (iNum == 6)
                        {
                                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                                Console.WriteLine("What do you want to search for?");
                                sNum = Console.ReadLine();

                                sw.Start();
                                if (staSta.Contains(sNum))
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

