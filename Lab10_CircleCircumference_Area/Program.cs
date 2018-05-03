using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_CircleCircumference_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            //Introduction
            Console.WriteLine("Greetings!");
            Console.WriteLine("Welcome to the Circle Circumference and Area Calculator.");

            bool success = true;
            while (success)
            {
                Console.WriteLine("Please enter the radius: ");
                double Radius1 = 0;
               
                while (!double.TryParse(Console.ReadLine(), out Radius1))
                {
                    Console.WriteLine("ERROR, that is not a valid radius");
                    Console.WriteLine("Please try again. Enter a number: ");
                }

                Circle realCircle = new Circle(Radius1);
                i++;
                               
                Console.Write($"\nThe Formatted Circumference is: {realCircle.CalculateFormattedCircumference()}");
                Console.Write($"\nThe Formatted Area is: {realCircle.CalculateFormattedArea()}");

                Console.WriteLine("Would you like to continue calculating more circles");
                Console.WriteLine("OR get totals on how many circles you've calculated?");
                Console.WriteLine("Type 'y' to continue or 'n' to get totals.");
                string FinalChoice = Console.ReadLine();

                if (FinalChoice == "n")
                {
                    Console.WriteLine($"\nCongratulations! You've created {i} cirles.");
                    success = false;
                }
            }
            Console.WriteLine("\n\nPress enter to say GOODBYE...");
            Console.ReadKey();
        }
    }
}









//static void Main(string[] args)

//{
//            User user1 = new User("Peter Gunther", "HelloWorld",
//                "peter@grandcircus.co", 25);
//User user2 = new User("Jacob Snover", "boolean",
//    "jacob@grandcircus.co", 21);

//Console.WriteLine(user1.GetName());
//            Console.WriteLine(user1.GetAge());

//            //my setters/getters control private info
//            Console.WriteLine(user1.GetRegDate());
//            //methods below doesn't exist--RegDate can't be changed            
//            //user1.SetRegDate();
//            //user1.regDate = DateTime.Now;

//            //can't get password--it's private
//            //Console.WriteLine(user1.password);
//            //can change it--there's a setter
//            //user must have forgotten password
//            user1.SetPassword("HelloWhirled");
//            //TODO: CheckPassword () method

//            user1.SetName("Peter Guenther");
//            Console.WriteLine(user1.GetName());

//            //outputting will just show type
//            //unless...
//            Console.WriteLine(user1);

//            Console.Write($"Please enter {user1.GetName()}'s password: ");
//            string pass = Console.ReadLine();

//            if (user1.CheckPassword(pass))
//            {
//                Console.WriteLine("You are now logged in!");
//            }
//            else
//            {
//                Console.WriteLine("Authentication failed.");
//            }
//        }
