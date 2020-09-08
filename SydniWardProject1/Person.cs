////////////////////////////////////////////////////////////////////////////////////////////////////////////////// //
// Project:             Project1
// File Name:           SydniWardProject1 - Person.cs
// Description:         Main method 
// Course:              Server Side
// Author:              Sydni Ward
// Created:             wed, 2 Sept., 2020
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;

namespace SydniWardProject
{
    public class Person
    {
        private string _name;
        private bool _gender;
        private int _age;

        //classes, fields, validation through backing fields
        //3.  Create a Person class in a separate class file, with the following Properties. (Name, Gender)
        //     Using backing fields create Age and do the following:
        //     Age cannot be any larger than 120, if they go larger set to 120.

        /// <summary>
        /// Age get - return  and set - max age to 120
        /// </summary>
        public int age
        {
            get { return _age; }
            set
            {
                if (_age <= 120 || _age >= 0)
                    _age = age;
                else if (_age > 120)
                    _age = 120;
                else
                    _age = 0;
            }
        }


        //constructors
        //3a. Create a fully parameterized constructor.

        /// <summary>
        /// Person Constructor - Name Gender Age
        /// </summary>
        public Person(String name, bool gender, int age)
        {
            this._name = name;
            this._gender = gender;
            this._age = age;
        }

        //methods
        //3b. Create a method call legalAge(). This will return a true or false depending if the person is 21 or over

        /// <summary>
        /// Check Legal age
        /// </summary>
        public bool legalAge()
        {
            return _age >= 21;
        }

        //ToString Method
        //3f. Go back to the Person.cs file and create theToString method that displays the information of the object. (Test it!)

        /// <summary>
        /// to String method 
        /// </summary>
        public override string ToString()
        {
            string text =
                "Name:\t" + _name + "\n" +
                "Gender:\t";

            if (!_gender)
                text += "female\n";
            else
                text += "male\n";

            text += "Age:\t" + _age;

            return text;
        }

        //Equals Method
        //3g. In the Person.cs file create the equals method. (Test it!)

        /// <summary>
        /// Check if person is equal to another person
        /// </summary>
        public bool Equals(Person other)
        {
            return this._name == other._name && this._gender == other._gender && this.age == other.age;
        }
    }
}

        
