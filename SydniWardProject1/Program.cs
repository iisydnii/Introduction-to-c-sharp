/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Project:             Project1
// File Name:           SydniWardProject1 - Program.cs
// Description:         Main method 
// Course:              Server Side
// Author:              Sydni Ward
// Created:             wed, 2 Sept., 2020
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*
 *
 * Purpose: To make sure coding environment is accessible. Refresh 1250 concepts in C#. Drop files into D2L dropbox.
 *          Walk students through some basic programming concepts. Review coding expectations. Demonstrate Fields.
 * 
 * Turn-in: Complete this lab using best programming standards, and readable code. Get checked off by GA or Instructor before end of
 *          class. You did it or not. Once complete, drop the individual .cs files ONLY into the dropbox.
 * 
 */

using System;

namespace SydniWardProject1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 0; //Declare and Initialize a
            int b = 0; //Declare and Initialize b
            int c = 0; //Declare and Initialize c
            int maxNumber = 0;  //Declare and Initialize maxNumber


            //Basic input/output and math.
            //1.  In the main method of the Program.cs file, print the output of adding two numbers from user input.
            //    Output should be input1 + input2 = sum...
            //    (Yes, you will have to look up how to do input.

            //Print
            Console.WriteLine("Q1: A + B = C");         //Prompt user
            Console.WriteLine();                        //New Line
            Console.WriteLine("What is A?");            //Prompt user

            //Read Input A
            a = Convert.ToInt32(Console.ReadLine());    //Get Input

            Console.WriteLine("What is B?");            //Prompt user
            //Read Input B
            b = Convert.ToInt32(Console.ReadLine());    //Get Input

            //Sum
            c = a + b;                                  //Doing Math
            //Print
            Console.WriteLine("The answer is:   " + c); //Display Answer

            //Looping, multiplication, user input
            //2.  In the main method of the Program.cs file, take a user inputed number and input its multiplication table. The user can choose how high to multiply by.
            //    Output something like num * 0 = 0, num * 1 = num, ... to, num * maxNumber = quotient


            //Print
            Console.WriteLine();                                //New Line
            Console.WriteLine("Q2: A * Max Number = C");        //Prompt user
            Console.WriteLine();                                //New Line
            Console.WriteLine("What is A?");                    //Prompt user
            //Read Input A
            a = Convert.ToInt32(Console.ReadLine());
            //
            Console.WriteLine();                                //New Line
            Console.WriteLine("What is Max Number?");           //Prompt user
            //Read Input maxNumber
            maxNumber = Convert.ToInt32(Console.ReadLine());    //Get Input maxNumber

            //Looping to maxNumber
            for (int i = 0; i <= maxNumber; i++)
            {
                //Multipy
                c = a * i;                                      //Doing Math
                //Print
                Console.WriteLine("The answer is:   " + c);     //Display Answer

            }
            //3. On Person class
            //object creation.
            //3c. Create an object of that Person class that is under 21 back in the Program.cs file.
            Person person = new Person("Sydni", false, 18);
            Person person2 = new Person("Ethan", true, 22);

            //object modification through Fields
            //3e. In the Program.cs file, create a new Person object that is over 21, and test to make sure the logic produces the correct results.
            store(person);                                      //call store / age check method
            Console.WriteLine(person.ToString());               //Write line person toString method 
            store(person2);                                     //call store / age check method
            Console.WriteLine(person2.ToString());              //Write line person toString method 

            //Static classes and methods with their calls.
            //4.  Create a Static class file called Converter. Create static methods that accept a number and convert the following:
            //    Kelvin to Fahrenheit (it's inverse too), 
            //	  Celsius to Fahrenheit (it's inverse too),
            //    Kelvin to Celsius (it's inverse too). (Test all these within the Program.cs file!)

            Console.WriteLine("100°K = " + Converter.convertK2F(100) + "°F");//ANSWER 279.66998°F
            Console.WriteLine("100°F = " + Converter.convertF2K(100) + "°K");//ANSWER 310.92776°K
            Console.WriteLine("100°C = " + Converter.convertC2F(100) + "°F");//ANSWER 212°F
            Console.WriteLine("100°F = " + Converter.convertF2C(100) + "°C");//ANSWER 37.77778°C
            Console.WriteLine("100°K = " + Converter.convertK2C(100) + "°C");//ANSWER -173.15°C
            Console.WriteLine("100°C = " + Converter.convertC2K(100) + "°K");//ANSWER 373.15°K

            Login("Sydni", "sw2001");           // Calling Login method
            Calculator.Calculate();             // Calling calculator file - Calculate method
        }

        //String comparison, validation
        //3d. In the Program.cs file, create a block of code that does the following: Displays "Water, Beer, or Wine". User can choose to buy one of those.
        //    If the user is not "legal age," denie the purchase and redisplay the options, if the person is "legal age", approve
        //    the purchase. The user will input strings, do not make a menu. (Create this as a static method within the "Program" class.)

        /// <summary>        /// store / age check method
        /// </summary>
        /// <param name="person">object</param>
        
        public static void store(Person person)
        {
            String input;
            do
            {
                Console.WriteLine("Welcome to the drink store! What's your poison: Water, Beer, or Wine? ");
                input = Console.ReadLine().ToUpper();
                if (input == "WATER")
                {
                    break;
                }
                else if (input == "BEER" || input == "WINE")
                {
                    if (person.legalAge())
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("No luck kid! Try the water.");
                    }

                }
                else
                {
                    Console.WriteLine("That's not for sell.");
                }
            } while (true);
            Console.WriteLine(input + ", Good Choice!");
        }

        //Validation, problem solving. Loops and Conditions
        //5. In the Program.cs file create a method(s) that accepts a UserId, and Password (do not worry about hashing it & don't use a real one.).
        //    Then within the main method allow user input to input a UserId and a Password. If they get the combination correct, return success, if they don't
        //    allow them to try it again. After the user fails three times, do not allow them any more attempts.

        /// <summary>        /// login method you get 3 trys
        /// </summary>
        /// <param name="UserID">String</param>
        /// <param name="Password">String</param>
        
        public static bool Login(string UserID, string Password)
        {
            int attempts = 3;                   //Number attempts

            for (int i = 0; i < attempts; i++)  //Loop until out of attempts or correct
            {
                Console.Write("User Id:\t");    
                string user = Console.ReadLine();
                Console.Write("Password:\t");
                string password = Console.ReadLine();

                if (UserID == user && Password == password)
                {
                    Console.WriteLine("Login sucessful");
                    return true;
                }
                else
                    Console.WriteLine("Username or password is incorrect.");
            }

            Console.WriteLine("Sorry, too many incorrect attempts.");
            return false;
        }
    }
}
