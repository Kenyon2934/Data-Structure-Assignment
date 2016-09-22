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
        }
    }
}
