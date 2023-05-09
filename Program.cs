// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker

{
    class Program
    {
        static List<Employee> GetEmployees(){
            List<Employee> employees = new List<Employee>();
            while (true){
                Console.WriteLine("Please enter a CatWorx employee name (Press enter to exit): ");
            
                string firstName = Console.ReadLine() ?? "";
                // the "??" is called a null coalescing operator 
                    //if null it returns an empty string

                // Break if the user hits ENTER without typing a name
                if (firstName == "") {break;}
                
                // add a Console.ReadLine() for each value
                Console.Write("Enter their last name: ");
                string lastName = Console.ReadLine() ?? "";
                Console.Write("Enter their ID: ");
                int id = Int32.Parse(Console.ReadLine() ?? "");
                Console.Write("Lastly, enter their Photo URL:");
                string photoUrl = Console.ReadLine() ?? "";

                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);
                Console.WriteLine("Added new employee! :3");
            }
            return employees;
        }
        
        static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++ ){
                string template = "{0,-10}\t{1,-20}\t{2}";
                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
            }
        }
        static void Main(string[] args)
        
        {
            List<Employee> employees = GetEmployees();
            PrintEmployees(employees);
        }
    }
}