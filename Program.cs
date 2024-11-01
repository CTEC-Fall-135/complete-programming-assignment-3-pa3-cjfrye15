﻿
using System;

namespace ClassDemo
    {
        class Student
        {
            // Private field for the name 
            private string name;

            // Property for the address 
            private string address;

            public string Address
            {
                get { return address; }
                set { address = value; }
            }

            // Automatic property for ID 
            public int ID { get; set; }

            // Defualt constructor
            public Student() : this("Unknown Name", "Unknown Address", 0)
            {

            }

            // Constructor that only takes a name
            public Student(string name) : this(name, "Unknown Address", 0)
            {

            }

            // Primary Contruct 
            public Student(string name, string address, int id)
            {
                this.name = name; // using "this" keyword to set the name field 
                this.address = address; // setting address via property 
                this.ID = id; // setting ID via automatic property 

            }

            // getter and setter for the name field 
            public string GetName()
            {
                return name;
            }

            // method to print the state of the object
            public void PrintState()
            {
                Console.WriteLine($"Name: {name}, Address: {Address}, ID: {ID}");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                // Create an instance using the primary construct 
                Student student = new Student("John Doe", "123 Elm Street", 1001);
                student.PrintState(); // Print Name: John Doe, Address: 123 Elm Street, ID: 1001

                // Create an instance using the constructor with the name parameter 
                Student student2 = new Student("Jane Smith");
                student2.PrintState(); // Print Name: Jane Smith, Address: Unknown address, ID: 0 

                // Create an instance using the defualt construct 
                Student student3 = new Student();
                student3.PrintState(); // Print Name: Unknown Name, Address: Unknown Address ID: 


            }

        }
    }





}






































}

