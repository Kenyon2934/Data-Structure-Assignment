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


                //while(Int32.TryParse(iNum))
                
                //Dictionary<string, int> sDictMenu = new Dictionary<string, int>();
                string sDictMenu;
                int iDictMenu;

                Dictionary<string, int> dictDictionary = new Dictionary<string, int>();
                string sDictKey;
                string sDictValue;
                int iDictValue;

                do
                {

                    bool bFirstTime = true;
                    do
                    {
                        do
                        {
                            if (bFirstTime == false)
                            {
                                Console.WriteLine("\nPlease Enter a number between 1-7");
                            }
                            Console.WriteLine("\n\nMake a selection.\n");
                            Console.WriteLine("1. Add one item to Dictionary");
                            Console.WriteLine("2. Add Huge List of Items to Dictionary");
                            Console.WriteLine("3. Display Dictionary");
                            Console.WriteLine("4. Delete from Dictionary");
                            Console.WriteLine("5. Clear Dictionary");
                            Console.WriteLine("6. Search Dictionary");
                            Console.WriteLine("7. Return to Main Menu");
                            Console.WriteLine();

                            Console.Write("My Selection: ");
                            sDictMenu = Console.ReadLine();
                            bFirstTime = false;

                        } while (Int32.TryParse(sDictMenu, out iDictMenu) == false);

                        iDictMenu = Convert.ToInt32(sDictMenu);
                    } while (iDictMenu < 1 || iDictMenu > 7);
                    Console.WriteLine();
                    Console.WriteLine();





                    


                    if (iDictMenu == 1)
                    {
                        Console.Write("Add one item to Dictionary \nPlease input the key: ");
                        sDictKey = Console.ReadLine();
                        Console.Write("Please input the value: ");
                        do
                        {
                            sDictValue = Console.ReadLine();
                            if (Int32.TryParse(sDictValue, out iDictValue) == false)
                            {
                                Console.WriteLine("Please enter a valid number.");
                            }
                        } while (Int32.TryParse(sDictValue, out iDictValue) == false);
                        iDictValue = Convert.ToInt32(sDictValue);
                        dictDictionary.Add(sDictKey, iDictValue);
                        Console.WriteLine("Item successfully added!");
                    }


                    else if (iDictMenu == 2)
                    {
                        dictDictionary.Clear();
                        int i = 1;
                        while (i <= 2000)
                        {
                            sDictKey = "New Entry " + i;
                            dictDictionary.Add(sDictKey, i);
                            i++;
                        }
                        Console.WriteLine("2000 new entries successfully added!");
                    }



                    else if (iDictMenu == 3)
                    {
                        
                       if(!dictDictionary.Count.Equals(0))
                       {
                            string k = "Key";
                            string dashes = "--------";
                            Console.WriteLine(k.PadRight(25,' ') + "Value\n" + dashes.PadRight(25,' ') + "-----");
                               
                                foreach (var input in dictDictionary)
                                {
                                    Console.WriteLine(input.Key.PadRight(25, ' ') + input.Value);
                                }
                        Console.WriteLine("\nPrint Complete!");
                       }
                       else
                       {
                           Console.WriteLine("* Your dictionary is currently empty *");
                       }

                       
                        
                    }

                            else if (iDictMenu == 4)
                            {
                                Console.Write("What do you want to delete: ");
                                string sDictSearch = Console.ReadLine();
                                if(dictDictionary.ContainsKey(sDictSearch) == true){
                                    dictDictionary.Remove(sDictSearch);
                                    Console.WriteLine("\nRecord for " + sDictSearch + " successfully removed.");
                                }
                                else if (dictDictionary.ContainsKey(sDictSearch) == false)
                                {
                                    Console.WriteLine("The requested key does not exist!");
                                }
                            }

                            else if (iDictMenu == 5)
                            {
                                dictDictionary.Clear();
                                Console.WriteLine("Dictionary successfully cleared!");
                            }

                            else if (iDictMenu == 6)
                            {
                                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                                Console.Write("What are you searching for: ");

                                string sDictSearch = Console.ReadLine();
                                sw.Start();
                                if (dictDictionary.ContainsKey(sDictSearch)==true)
                                {
                                    sw.Stop();

                                    Console.WriteLine("\nItem found\n----------");
                                    Console.WriteLine(sDictSearch.PadRight(25, ' ') + dictDictionary[sDictSearch]);
                                    Console.WriteLine("Time to find: " + sw.Elapsed);

                                    sw.Reset();
                                }
                                else
                                {
                                    Console.WriteLine("No results found.");
                                    sw.Reset();
                                }

                            }

                } while (iDictMenu != 7);



            }
        }
    }
}
