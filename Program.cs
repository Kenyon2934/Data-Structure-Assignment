
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Data_Structure
{
    class Program
    {
        static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }
        public static int subMenu(int mainMenuPick)
        {
            int iMenu;
            bool bFirstTime = true;
            string sMainMenu = "";
            string sSubMenuPick;

            if (mainMenuPick == 1)
            {
                sMainMenu = "Stack";
            }
            else if (mainMenuPick == 2)
            {
                sMainMenu = "Queue";
            }
            else if (mainMenuPick == 3)
            {
                sMainMenu = "Dictionary";
            }
            do //this loop will make sure that the user inputs a number between (and including) 1 and 7.
            {
                do //this loop will make sure that the user is actually inputting an int. 
                {
                    Console.WriteLine("\n".PadRight(50,'-') + "\n");
                    if (bFirstTime == false) //this will execute if the user fails to enter a valid entry the first time. 
                    {
                        Console.WriteLine("Please Enter a number between 1-7"); //instructional error message.
                    } //this is the menu.
                    Console.WriteLine("Enter your Selection\n");
                    Console.WriteLine("1. Add one item to " + sMainMenu);
                    Console.WriteLine("2. Add Huge List of Items to " + sMainMenu);
                    Console.WriteLine("3. Display " + sMainMenu);
                    Console.WriteLine("4. Delete from " + sMainMenu);
                    Console.WriteLine("5. Clear " + sMainMenu);
                    Console.WriteLine("6. Search " + sMainMenu);
                    Console.WriteLine("7. Return to Main Menu\n");
                    sSubMenuPick = Console.ReadLine(); //here's where the user inputs option
                    bFirstTime = false; //this changes the bool to false so that if the loop happens, it will give the error message.
                } while (Int32.TryParse(sSubMenuPick, out iMenu) == false);
                iMenu = Convert.ToInt32(sSubMenuPick); //this will convert the input to an int. 
                Console.WriteLine("\n");
            } while (iMenu < 1 || iMenu > 7);
            return iMenu;
        }
        static void Main(string[] args)
        {
            Stack<string> staSta = new Stack<string>();
            Queue<string> qItems = new Queue<string>();
            Dictionary<string, int> dictDictionary = new Dictionary<string, int>();
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();//creates stopwatch item to time the search.

            bool bFirstTime = true; //this boolean will help facilitate giving an error message if the user inputs an invalid option
            int iGenMenu;
            string sGenMenu;
            do
            {
                bFirstTime = true;
                do
                {
                    do
                    {
                        if (bFirstTime == false)
                        {
                            Console.WriteLine("Please Enter a number between 1-4");
                        }
                        Console.WriteLine("Enter your Options\n");
                        Console.WriteLine("1. Stack");
                        Console.WriteLine("2. Queue");
                        Console.WriteLine("3. Dictionary");
                        Console.WriteLine("4. Exit\n");
                        sGenMenu = Console.ReadLine();
                        bFirstTime = false;
                    } while (Int32.TryParse(sGenMenu, out iGenMenu) == false);
                    iGenMenu = Convert.ToInt32(sGenMenu);
                } while (iGenMenu < 1 || iGenMenu > 4);
                bFirstTime = true;
                if (iGenMenu == 1)
                {
                    int iStaMenu;
                    string sStaValue;

                    do
                    {
                        bFirstTime = true;
                        iStaMenu = subMenu(iGenMenu);

                        if (iStaMenu == 1)
                        {
                            Console.WriteLine("What do you want to add?\n");

                            staSta.Push(UppercaseFirst(Console.ReadLine()));
                            Console.WriteLine("Added Successful");
                        }

                        else if (iStaMenu == 2)
                        {
                            staSta.Clear();
                            int counter = 1;

                            while (staSta.Count() <= 2000)
                            {
                                staSta.Push("New Entry" + counter);
                                counter++;
                            }

                            Console.WriteLine("Stack cleared");
                        }

                        else if (iStaMenu == 3)
                        {
                            foreach (string item in staSta)
                            {
                                Console.WriteLine(item);
                            }
                        }

                        else if (iStaMenu == 4)
                        {
                            string input;
                            Console.Write("Which item do you want to delete?\n");
                            input = UppercaseFirst(Console.ReadLine());
                            Stack<string> tempStack = new Stack<string>(); //Temporary stack to move non-deleted items to
                            if (staSta.Contains(input))
                            {
                                while (staSta.Count > 0)
                                {
                                    string currentItem = staSta.Pop().ToString(); //Remove and look at the first item in the stack
                                    if (currentItem != input)
                                    {
                                        tempStack.Push(currentItem); //Don't delete it, add to the temporary stack   
                                    }
                                    else
                                    {
                                        //Do nothing, this is the one to delete
                                    }
                                }
                                while (tempStack.Count > 0)
                                {
                                    staSta.Push(tempStack.Pop()); //Add back the items in the temporary stack to the original queue
                                }
                                Console.WriteLine("Item Deleted!");
                            }
                            else
                            {
                                Console.WriteLine("Item not found"); //Report that the item to delete isn't in the stack
                            }
                        }

                        //clears stack
                        else if (iStaMenu == 5)
                        {
                            staSta.Clear();

                        }

                        else if (iStaMenu == 6)
                        {
                            string input;
                            Console.Write("Enter Search field: ");
                            input = UppercaseFirst(Console.ReadLine());
                            //Start the timer
                            sw.Start();
                            if (staSta.Contains(input))
                            {
                                //Stop the timer
                                sw.Stop();
                                Console.WriteLine("Found It! Time to find: " + sw.Elapsed);
                                //Reset the timer
                                sw.Reset();
                            }
                            else
                            {
                                Console.WriteLine("Not found");
                                sw.Reset();
                            }
                        }

                    } while (iStaMenu != 7);
                }
                else if (iGenMenu == 2)
                {
                    int iQMenu;
                    do
                    {
                        bFirstTime = true;
                        iQMenu = subMenu(iGenMenu);
                        if (iQMenu == 1)
                        {
                            Console.WriteLine("Please enter a string");
                            qItems.Enqueue(UppercaseFirst(Console.ReadLine())); //Add item to the queue
                        }

                        else if (iQMenu == 2)
                        {
                            qItems.Clear(); //Clear the queue
                            int counter = 1;
                            while (qItems.Count() <= 2000)
                            {
                                qItems.Enqueue("New Entry" + counter); //Add item to the queue
                                counter++; //count how many entries have been made
                            }
                        }

                        else if (iQMenu == 3)
                        {
                            //Display all items
                            foreach (string item in qItems)
                            {
                                Console.WriteLine(item);
                            }
                        }

                        else if (iQMenu == 4)
                        {
                            string input = "";
                            Console.Write("Which item do you want to delete?");
                            input = UppercaseFirst(Console.ReadLine());
                            Queue<string> tempQueue = new Queue<string>(); //Temporary queue to move non-deleted items to
                            if (qItems.Contains(input))
                            {
                                while (qItems.Count > 0)
                                {
                                    string currentItem = qItems.Dequeue().ToString(); //Remove and look at the first item in the queue
                                    if (currentItem != input)
                                    {
                                        tempQueue.Enqueue(currentItem); //Don't delete it, add to the temporary queue   
                                    }
                                    else
                                    {
                                        //Do nothing, this is the one to delete
                                    }
                                }
                                while (tempQueue.Count > 0)
                                {
                                    qItems.Enqueue(tempQueue.Dequeue()); //Add back the items in the temporary queue to the original queue
                                }
                                Console.WriteLine("Item Deleted!");
                            }
                            else
                            {
                                Console.WriteLine("Item not found"); //Report that the item to delete isn't in the queue
                            }
                        }
                        else if (iQMenu == 5)
                        {
                            //Clear the queue
                            qItems.Clear();
                            Console.WriteLine("All items removed");
                        }

                        else if (iQMenu == 6)
                        {
                            string input = "";
                            Console.Write("Enter Search field: ");
                            input = UppercaseFirst(Console.ReadLine());
                            //Start the timer
                            sw.Start();
                            if (qItems.Contains(input))
                            {
                                //Stop the timer
                                sw.Stop();
                                Console.WriteLine("Found It! Time to find: " + sw.Elapsed);
                                //Reset the timer
                                sw.Reset();
                            }
                            else
                            {
                                Console.WriteLine("Not found");
                                sw.Reset();
                            }
                        }

                    } while (iQMenu != 7);
                }
                else if (iGenMenu == 3)
                {
                    int iDictMenu;
                    int iDictValue;
                    string sDictValue;
                    string sDictKey;
                    string sYNAnswer;

                    do //this do loop will make sure that the dictionary code is run until the user chooses to exit
                    {
                        bFirstTime = true;
                        iDictMenu = subMenu(iGenMenu);

                        if (iDictMenu == 1) //option 1 is selected: Adding one item to dictionary.
                        {
                            Console.Write("Add one item to Dictionary \nPlease input the key: ");
                            sDictKey = Console.ReadLine(); //this will become the dictionary key
                            Console.Write("Please input the value: ");
                            do //this loop will make sure that the user has input an integer before it will exit the loop.
                            {
                                sDictValue = Console.ReadLine();
                                if (Int32.TryParse(sDictValue, out iDictValue) == false) //this if statement will display an error message if user input a non-int
                                {
                                    Console.WriteLine("Please enter a valid number.");
                                }
                            } while (Int32.TryParse(sDictValue, out iDictValue) == false);
                            iDictValue = Convert.ToInt32(sDictValue);  //converts from string to integer for dictionary value. 
                            Console.Write("Do you want to make sure the key is upper case? (Y/N): ");
                            sYNAnswer = Console.ReadLine();
                            sYNAnswer = sYNAnswer.Substring(0, 1);
                            sYNAnswer = UppercaseFirst(sYNAnswer);
                            if (sYNAnswer == "Y")
                            {
                                sDictKey = UppercaseFirst(sDictKey);
                            }
                            dictDictionary.Add(sDictKey, iDictValue);  //add the item to the dictionary using the two obtained value
                            Console.WriteLine("Item successfully added!");
                        }


                        else if (iDictMenu == 2) //option 2: add huge list of items to the dictionary. 
                        {
                            dictDictionary.Clear(); //clears the current dictionary.
                            int i = 1;
                            while (i <= 2000) //this count will create 2000 items in the form of "New Entry 1, New Entry 2,..."
                            {
                                sDictKey = "New Entry " + i;
                                dictDictionary.Add(sDictKey, i);
                                i++;
                            }
                            Console.WriteLine("2000 new entries successfully added!"); //confirmation to the user. 
                        }



                        else if (iDictMenu == 3) //option 3: displaying the items currently in the dictionary. 
                        {

                            if (!dictDictionary.Count.Equals(0))
                            {
                                string k = "Key"; //this will help facilitate header padding.
                                string dashes = "--------";
                                Console.WriteLine(k.PadRight(25, ' ') + "Value\n" + dashes.PadRight(25, ' ') + "-----"); //this is the header

                                foreach (var input in dictDictionary)//for each item in the dictionary we will print out what is in there
                                {
                                    Console.WriteLine(input.Key.PadRight(25, ' ') + input.Value);
                                }
                                Console.WriteLine("\nPrint Complete!"); //confirmation to the user.
                            }
                            else
                            {
                                Console.WriteLine("* Your dictionary is currently empty *"); //this line will tell the user that the dictionary is empty
                            }



                        }

                        else if (iDictMenu == 4) //option 4: Delete from Dictionary
                        {
                            Console.Write("What do you want to delete: ");//prompt the user to enter then key name of the item they want to delete.
                            string sDictSearch = Console.ReadLine(); //stores string value the user enters.
                            if (dictDictionary.ContainsKey(sDictSearch) == true) //this will execute if the dictionary contains the user value. 
                            {
                                dictDictionary.Remove(sDictSearch);//will remove the item. 
                                Console.WriteLine("\nRecord for " + sDictSearch + " successfully removed."); //confirmation to the user. 
                            }
                            else if (dictDictionary.ContainsKey(UppercaseFirst(sDictSearch)) == true)// Check if the key exist with the first letter upper case
                            {
                                Console.Write("\nThe requested key does not exist, but we found this:\n\nItem found\n----------\n" + UppercaseFirst(sDictSearch).PadRight(25, ' ') + dictDictionary[UppercaseFirst(sDictSearch)]);
                                Console.Write("\n\nDo you wanna delete this record? (Y/N) ");
                                sYNAnswer = Console.ReadLine();
                                sYNAnswer = sYNAnswer.Substring(0, 1);
                                sYNAnswer = UppercaseFirst(sYNAnswer);
                                if (sYNAnswer == "Y")
                                {
                                    dictDictionary.Remove(UppercaseFirst(sDictSearch));//will remove the item. 
                                    Console.WriteLine("\nRecord for " + UppercaseFirst(sDictSearch) + " successfully removed."); //confirmation to the user. 
                                }
                            }
                            else if (dictDictionary.ContainsKey(sDictSearch) == false) //this is what executes if no match is found
                            {
                                Console.WriteLine("The requested key does not exist!"); //message to user. 
                            }
                        }

                        else if (iDictMenu == 5) //option 5: clear all items from the dictionar
                        {
                            dictDictionary.Clear(); //this line clears the dictionary. 
                            Console.WriteLine("Dictionary successfully cleared!"); //confirmation to user. 
                        }

                        else if (iDictMenu == 6) //option 6: search the dictionary
                        {
                            Console.Write("What are you searching for: "); //user prompt

                            string sDictSearch = Console.ReadLine();//this will store the string the user inputs. 
                            sw.Start(); //this starts the stopwatch to time the search. 
                            if (dictDictionary.ContainsKey(sDictSearch) == true) //this is if the the value is found. 
                            {
                                sw.Stop();

                                Console.WriteLine("\nItem found\n----------"); //information to the user 
                                Console.WriteLine(sDictSearch.PadRight(25, ' ') + dictDictionary[sDictSearch]); //display the found item
                                Console.WriteLine("Time to find: " + sw.Elapsed); //display the time it took to find

                                sw.Reset();//reset the stopwatch
                            }
                            else if (dictDictionary.ContainsKey(UppercaseFirst(sDictSearch)) == true)// Check if the key exist with the first letter upper case
                            {
                                sw.Stop();

                                Console.Write("\nThe requested key does not exist, but we found this:\n" + "\nItem found\n----------\n" + UppercaseFirst(sDictSearch).PadRight(25, ' ') + dictDictionary[UppercaseFirst(sDictSearch)]); //display the found item with an upper case first letter
                                Console.WriteLine("\nTime to find: " + sw.Elapsed); //display the time it took to find
                            }
                            else
                            {
                                Console.WriteLine("No results found."); //this informs the user that nothing was found
                                sw.Stop();//stops the stopwatch
                                sw.Reset();//resets the stopwatch
                            }

                        }

                    } while (iDictMenu != 7); //this line will exit that menu once 7 is selected.

                }
            } while (iGenMenu != 4);
        }
    }
}
