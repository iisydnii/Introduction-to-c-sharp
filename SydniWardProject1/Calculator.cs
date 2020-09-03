////////////////////////////////////////////////////////////////////////////////////////////////////////////////// //
// Project:             Project1
// File Name:           SydniWardProject1 - Calculator.cs
// Description:         Main method 
// Course:              Server Side
// Author:              Sydni Ward
// Created:             wed, 2 Sept., 2020
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;

namespace SydniWardProject1
{
    public static class Calculator
    {
        /// <summary>
        /// Calculator - Continious loop for calculation 
        /// </summary>
        public static void Calculate()
        {
            //Loops, Conditions, and problem solving
            //6. Create whatever file(s) you need to create a 4 function calculator. (+, -, *, /). This should allow a number, then the Symbol, then the next number.
            //   Display num1 symbol num2 = value. This should be repeated until the user enters "esc" (or any combination of those letters)

            while (true)
            {
                Console.WriteLine("Enter your expression, or enter 'ESC' to exit");
                string prob = Console.ReadLine();

                if (prob.ToUpper() == "ESC")            // Input to upper case 
                    break;                              // Break loop
                else
                {
                    char[] operation = { '+', '-', '*', '/' };                      //Different Operators in form of char 
                    int indexOfOperator = prob.IndexOfAny(operation);               //String is slit between a , Operator, and B
                    int a = Convert.ToInt32(prob.Substring(0, indexOfOperator));
                    int b = Convert.ToInt32(prob.Substring(indexOfOperator + 1));
                    char _operation = prob[indexOfOperator];

                    switch (_operation)
                    {
                        case '+':
                            Console.WriteLine(a + " + " + b + " = " + (a + b));     // a add b writes answer
                            break;
                        case '-':
                            Console.WriteLine(a + " - " + b + " = " + (a - b));     // a subtract b writes answer
                            break;
                        case '*':
                            Console.WriteLine(a + " * " + b + " = " + (a * b));     // a times b writes answer
                            break;
                        case '/':
                            Console.WriteLine(a + " / " + b + " = " + (a / b));     // a divided b writes answer
                            break;
                    }
                }
            }
        }
    }
}