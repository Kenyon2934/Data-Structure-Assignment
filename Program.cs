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
            
            do{
                do
                {
                    if (bFirstTime == false)
                    {
                        Console.WriteLine("Please Enter a number between 1-7");
                    }
                    Console.WriteLine("Enter your Options\n");
                    Console.WriteLine("1. Add one item to Dictionary");
                    Console.WriteLine("2. Add Huge List of Items to Dictionary");
                    Console.WriteLine("3. Display Dictionary");
                    Console.WriteLine("4. Delete from Dictionary");
                    Console.WriteLine("5. Clear Dictionary");
                    Console.WriteLine("6. Search Dictionary");
                    Console.WriteLine("7. Return to Main Menu");
                    sDictMenu = Console.ReadLine();
                    bFirstTime = false;
                } while (Int32.TryParse(sDictMenu, out iDictMenu) == false);
                iDictMenu = Convert.ToInt32(sDictMenu);
            } while (iDictMenu <= 1 || iDictMenu >= 7);
            Console.WriteLine(iDictMenu);
            
            if(iDictMenu == 1){
                Console.Write("Please input the key: ");
                sDictKey = Console.ReadLine();
                Console.Write("Please input the value: ");
                sDictValue = Console.ReadLine();
                iDictValue = Convert.ToInt32(sDictValue);

                dictDictionary.Add(sDictKey, iDictValue);
            }
            else if (iDictMenu == 2)
            {
                dictDictionary.Clear();
                int i = 1;
                while (i <= 2000)
                {
                    sDictKey = "New Entry" + i;
                    dictDictionary.Add(sDictKey, i);
                    i++;
                }
            }
            else if (iDictMenu == 3)
            {
                foreach (var input in dictDictionary)
                {
                    Console.WriteLine(input.Key.PadRight(25, ' ') + input.Value);
                }
            }
            else if (iDictMenu == 4)
            {
                Console.Write("What do you wanna delete: ");
                string sDictSearch = Console.ReadLine();
                if(dictDictionary.ContainsKey(sDictSearch) == true){
                    dictDictionary.Remove(sDictSearch);
                }
                else if (dictDictionary.ContainsKey(sDictSearch) == false)
                {
                    Console.WriteLine("The requested key does not exist!");
                }
            }
            else if (iDictMenu == 5)
            {
                dictDictionary.Clear();
            }
            else if (iDictMenu == 6)
            {
                Console.Write("What are you looking for: ");

            }

            Console.ReadLine();

        }
    }
}
