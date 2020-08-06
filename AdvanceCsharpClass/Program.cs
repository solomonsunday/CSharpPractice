using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCsharpClass
{
    public class Program
    {
        
        static void Main(string[] args)
        {

            //Do while  Example 
            //Console.WriteLine("Please enter a number");
            //int userValue = int.Parse(Console.ReadLine());

            //int start = 0;
            //while(start <= userValue)
            //{
            //    Console.Write(start + " ");
            //    start += 2;
            //}


            //Do While Loop
            //string UserChoice = string.Empty;

            //do
            //{

            //    Console.WriteLine("Pease Enter a Number");
            //    int value = int.Parse(Console.ReadLine());

            //    int start = 0;
            //    while (start <= value)
            //    {
            //        Console.WriteLine(start + " ");
            //        start += 2;
            //    }

            //    do
            //    {
            //        Console.WriteLine("Do you want to continue - Yes or No?");

            //        UserChoice = Console.ReadLine().ToUpper();

            //        if (UserChoice != "YES" && UserChoice != "NO")
            //        {
            //            Console.WriteLine("Invalid Choice, Please say Yes or No");
            //        }

            //    } while (UserChoice != "YES" && UserChoice != "NO");
            //} while (UserChoice == "YES");


            //Coffee Purcharse Program

            int TotalCoffeeCost = 0;
            string UserDecision = string.Empty;


            do
            {
                int UserChoice = -1;
                do
                {
                    Console.WriteLine("Please Select Your Coffie Size: 1 - Small, 2 -Medium, 3 -Large");
                    UserChoice = int.Parse(Console.ReadLine());

                    switch (UserChoice)
                    {
                        case 1:
                            TotalCoffeeCost += 1;
                            break;
                        case 2:
                            TotalCoffeeCost += 2;
                            break;
                        case 3:
                            TotalCoffeeCost += 3;
                            break;

                        default:
                            Console.WriteLine("Your Choice {0} is invalid", UserChoice);
                            break;
                    }
                } while (UserChoice != 1 && UserChoice != 2 && UserChoice != 3);
                do
                {
                    Console.WriteLine("Do you want buy another coffee - Yes or No?");

                    UserDecision = Console.ReadLine().ToUpper();
                    if (UserDecision != "YES" && UserDecision != "NO")
                    {
                        Console.WriteLine("You Choice {0} is Invalid. Please Try Again... ", UserDecision);
                    }
                } while (UserDecision != "YES" && UserDecision != "NO");

            }
            while (UserDecision.ToUpper() != "NO");


            Console.WriteLine("Thank You For Shopping with Us");
            Console.WriteLine("Bill Amount = {0}", TotalCoffeeCost);            

        }
    }
}
