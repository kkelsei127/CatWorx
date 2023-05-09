// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker

{
    class Program
    {
        static void Main(string[] args)
        
        {
            List<string> employees = new List<string>();
            while (true){
                Console.WriteLine("Please enter a CatWorx employee name: ");
            
                string input = Console.ReadLine() ?? "";
                // the "??" is called a null coalescing operator 
                    //if null it returns an empty string

                // Break if the user hits ENTER without typing a name
                if (input == "") {break;}

                employees.Add(input);
            }
            
            for (int i = 0; i < employees.Count; i++ ){
                Console.WriteLine(employees[i]);
            }
        }
    }
}