/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Project:             Project1
// File Name:           SydniWardProject1 - Converter.cs
// Description:         Main method 
// Course:              Server Side
// Author:              Sydni Ward
// Created:             wed, 2 Sept., 2020
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace SydniWardProject1
{
    public static class Converter
    {
		//Static classes and methods with their calls.
		//4.  Create a Static class file called Converter. Create static methods that accept a number and convert the following:
		//    Kelvin to Fahrenheit (it's inverse too), 
		//	  Celsius to Fahrenheit (it's inverse too),
		//    Kelvin to Celsius (it's inverse too). (Test all these within the Program.cs file!)

		/// <summary>
		/// Kelvin to Fahrenheit
		/// </summary>
		public static float convertK2F(float kelvin)
		{
			return convertC2F(convertK2C(kelvin));			//Conversion
		}

		/// <summary>
		/// Fahrenheit to Kelvin
		/// <summary>
		public static float convertF2K(float fahrenheit)
		{
			return convertC2K(convertF2C(fahrenheit));      //Conversion
		}

		/// <summary>
		/// Celsius to Fahrenheit
		/// <summary>
		public static float convertC2F(float celsius)
		{
			return celsius * 9 / 5 + 32;                    //Conversion
		}

		/// <summary>
		/// Fahrenheit to Celsius
		/// <summary>
		public static float convertF2C(float fahrenheit)
		{
			return 5f / 9f * (fahrenheit - 32);             //Conversion
		}

		/// <summary>
		/// Kelvin to Celsius
		/// <summary>
		public static float convertK2C(float kelvin)
		{
			return kelvin - 273.15f;                        //Conversion
		}

		/// <summary>
		/// Celsius to Kelvin
		/// <summary>
		public static float convertC2K(float celsius)
		{
			return celsius + 273.15f;                       //Conversion
		}	

	}
}
