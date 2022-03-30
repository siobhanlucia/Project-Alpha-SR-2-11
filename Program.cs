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

            // SR02 Use the Console.WriteLine() statement to draw the following shapes.
            //Square
            Console.WriteLine("-------------");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("-------------");
            //Triangle
            Console.WriteLine("      /\\");
            Console.WriteLine("     /  \\");
            Console.WriteLine("    /    \\");
            Console.WriteLine("   /      \\");
            Console.WriteLine("  /        \\");
            Console.WriteLine(" /          \\");
            Console.WriteLine("/            \\");
            Console.WriteLine("---------------");
            //Rectangle
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
            //Right Angle Triangle
            Console.WriteLine("|\\");
            Console.WriteLine("| \\");
            Console.WriteLine("|  \\");
            Console.WriteLine("|   \\");
            Console.WriteLine("|    \\");
            Console.WriteLine("|     \\");
            Console.WriteLine("|      \\");
            Console.WriteLine("---------");

            //SR03 Print your Day1 Experience at Techtorium with WriteLine() statement

            Console.WriteLine("My expereience of Day 1 of Techtorium was inisightful and information. We went through all the relevent areas of Office to make sure we know where to access assignments etc. We downloaded Visual Studio and were encouraged to do self directed learning.");

            //SR04 Rate yourself from 1-10 for the following traits.

            Console.WriteLine("Rate yourself from 1-10 on the following traits:");
            Console.WriteLine("1.Confidence: 7");
            Console.WriteLine("2. Creativity: 8.5");
            Console.WriteLine("3. Resilience: 8");
            Console.WriteLine("4. Positivity: 7");
            Console.WriteLine("5. Hard Work: 8");
            Console.WriteLine("6. Love for Programming: 7");


            //SR05 Create a program to gather information from the person sitting next to you and this information should include.

            Console.WriteLine("Please ask the person sitting next to you to enter the following information:");
            Console.WriteLine("Name:");
            string userName = Console.ReadLine(); //User Input Name
            Console.WriteLine("Name is: " + userName);

            Console.WriteLine("High School: ");
            string userHighSchool = Console.ReadLine(); //User Input high school
            Console.WriteLine("High School is: " + userHighSchool);

            Console.WriteLine("Techtorium ID: ");
            string userTechtoriumID = Console.ReadLine(); //User Input Techtorium ID
            Console.WriteLine("Techtorium ID is: " + userTechtoriumID);

            Console.WriteLine("Contact Number: ");
            string userContactNumber = Console.ReadLine(); //User Input contact number
            Console.WriteLine("Contact Number is: " + userContactNumber);

            Console.WriteLine("Hobbies: ");
            string userHobbies = Console.ReadLine(); //User Input hobbies
            Console.WriteLine("Hobbies are: " + userHobbies);

            //SR06 Develop a code to check person sitting next to you is elder than you or not

            Console.WriteLine("We would like to know if the person sitting next to you is elder than you or not.");

            Console.WriteLine("What year were you born?");
            int myAge = Convert.ToInt32(Console.ReadLine()); //User input age
            Console.WriteLine("Your year of birth is: " + myAge);

            Console.WriteLine("What year was the person next to you born?");
            int yourAge = Convert.ToInt32(Console.ReadLine()); //User input age
            Console.WriteLine("The year the person next to you was born is: " + yourAge);

            if (myAge < yourAge) //User was born before the person sitting next to you
            {
                Console.WriteLine("You are an elder to the person sitting next to you.");

            }
            if (myAge > yourAge) //User was born after the person sitting next to you
            {
                Console.WriteLine("You are not an elder to the person sitting next to you.");
            }
            else if (myAge == yourAge) //User was born in the same year as the person sitting next to you
            {
                Console.WriteLine("You are the same age.");
            }

            //SR07 Code to check voting eligibility

            Console.WriteLine("We would like to know if you are eligible to vote in New Zealand.");

            Console.WriteLine("Are you a New Zealand citizen, permanent resident, Australian, Niuean, Tokelauan or a Cook Islander? (true or false)");
            bool myResident = Convert.ToBoolean(Console.ReadLine()); //User inputs true or false
            if (myResident == false) //User inputs false
            {
                Console.WriteLine("You are not eligible to vote.");
            }
            if(myResident == true) //User inputs true
            {
                Console.WriteLine("Have you lived in New Zealand continuously for at least 12 months? (true or false)");
                bool myBool = Convert.ToBoolean(Console.ReadLine()); //User inputs true or false

                if (myBool == false) //User inputs false
                {
                    Console.WriteLine("You are not eligible to vote.");
                }
                else if (myBool == true) //User inputs true
                {
                    if (myAge < 2005) //Takes input from SR06 line 95 to confirm age for eligibility (people born before 2005 will be over 18)
                    {
                        Console.WriteLine("You are eligible to vote.");
                    }
                    if (myAge >= 2005) //Takes input from SR06 line 95 to confirm age for eligibility (people born after or during 2005 will be under 18)
                    {
                        Console.WriteLine("You are not eligible to vote.");
                    }
                }

            }

            //SR08 Code to check whether a number is positive or negative

            Console.WriteLine("Enter a positive or negative number:");
            int Num = Convert.ToInt32(Console.ReadLine()); //User input number
            if (Num > 0) //User inputs positive number
            {
                Console.WriteLine("This is a positive number");
            }
            if (Num < 0) //User inputs negative number
            {
                Console.WriteLine("This is a negative number");
            }
            if (Num == 0) //User inputs 0
            {
                Console.WriteLine("This is neither a negative nor positive number");
            }

            //SR09 

            Console.WriteLine("David is 19 years old and Luke is 17 years old. Check by how many years Luke is younger than David.");
            int David = 19;
            int Luke = 17;

                Console.WriteLine(David - Luke); //Console writes the age difference between David and Luke by years

            //SR10 Develop a code to check whether an entered number is even or odd
            Console.WriteLine("Enter a number for the program to check if it is odd or even: ");
            Console.WriteLine("Input an integer:");
            int Number, Number1 = Convert.ToInt32(Console.ReadLine()); //User input number
                Number = Number1 % 2; //Divides number1 by 2, if 0 then the number is even

            if (Number == 0)
            {
                Console.WriteLine("Number is even");
            }
            else //if number does not equal 0 then number1 is odd
            {
                Console.WriteLine("Number is odd");
            }

            //SR11 Develop a code to generate the grades of students based on marks they have scored

            Console.WriteLine("Enter a students marks on a project to check their grade: ");
            int mark = Convert.ToInt32(Console.ReadLine()); //User input Mark
             if (94 < mark) //A+
            {
                Console.WriteLine("A+");
            }
            else if (89 < mark) //A
            {
                Console.WriteLine("A");
            }
            else if (84 < mark) //A-
            {
                Console.WriteLine("A-");
            }
            else if (79 < mark) //B+
            {
                Console.WriteLine("B+");
            }
            else if (69 < mark) //B
            {
                Console.WriteLine("B");
            }
            else if (59 < mark) //B-
            {
                Console.WriteLine("B-");
            }
            else if (54 < mark) //C+
            {
                Console.WriteLine("C+");
            }
            else if (49 < mark) //C
            {
                Console.WriteLine("C");
            }
            else if (mark < 50) //D
            {
                Console.WriteLine("D");
            }

            Console.ReadKey();
            /* this is once again, another comment which will be ignored by C#, best form for longer*/

        }
    }
}
