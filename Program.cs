using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!"); // This is a comment, best for short

            Console.WriteLine("-------------");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("-------------");

            Console.WriteLine("      /\\");
            Console.WriteLine("     /  \\");
            Console.WriteLine("    /    \\");
            Console.WriteLine("   /      \\");
            Console.WriteLine("  /        \\");
            Console.WriteLine(" /          \\");
            Console.WriteLine("/            \\");
            Console.WriteLine("---------------");

            Console.WriteLine("-------------");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("-------------");

            Console.WriteLine("|\\");
            Console.WriteLine("| \\");
            Console.WriteLine("|  \\");
            Console.WriteLine("|   \\");
            Console.WriteLine("|    \\");
            Console.WriteLine("|     \\");
            Console.WriteLine("|      \\");
            Console.WriteLine("---------");

            Console.WriteLine("My expereience of Day 1 of Techtorium was inisightful and information. We went through all the relevent areas of Office to make sure we know where to access assignments etc. We downloaded Visual Studio and were encourafed to do self directed learning.");

            Console.WriteLine("Rate yourself from 1-10 on the following traits:");
            Console.WriteLine("1.Confidence: 7");
            Console.WriteLine("2. Creativity: 8.5");
            Console.WriteLine("3. Resilience: 8");
            Console.WriteLine("4. Positivity: 7");
            Console.WriteLine("5. Hard Work: 8");
            Console.WriteLine("6. Love for Programming: 7");

            Console.WriteLine("Please ask the person sitting next to you to enter the following information:");
            Console.WriteLine("Name:");
            string userName = Console.ReadLine();
            Console.WriteLine("Name is: " + userName);

            Console.WriteLine("High School: ");
            string userHighSchool = Console.ReadLine();
            Console.WriteLine("High School is: " + userHighSchool);

            Console.WriteLine("Techtorium ID: ");
            string userTechtoriumID = Console.ReadLine();
            Console.WriteLine("Techtorium ID is: " + userTechtoriumID);

            Console.WriteLine("Contact Number: ");
            string userContactNumber = Console.ReadLine();
            Console.WriteLine("Contact Number is: " + userContactNumber);

            Console.WriteLine("Hobbies: ");
            string userHobbies = Console.ReadLine();
            Console.WriteLine("Hobbies are: " + userHobbies);

            Console.WriteLine("We would like to know if the person sitting next to you is elder than you or not.");

            Console.WriteLine("What year were you born?");
            int myAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your year of birth is: " + myAge);

            Console.WriteLine("What year was the person next to you born?");
            int yourAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The year the person next to you was born is: " + yourAge);

            if (myAge < yourAge)
            {
                Console.WriteLine("You are an elder to the person sitting nect to you.");

            }
            if (myAge > yourAge)
            {
                Console.WriteLine("You are not an elder to the person sitting nect to you.");
            }
            else if (myAge == yourAge)
            {
                Console.WriteLine("You are the same age.");
            }






            Console.ReadKey();
            /* this is once again, another comment which will be ignored by C#, best form for longer*/


        }
    }
}
