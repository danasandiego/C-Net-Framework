using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object and initialize its properties
            Employee emp1 = new Employee();
            emp1.id = 1;
            emp1.firstname = "Dana";
            emp1.lastname = "Santos-San Diego";
            
            // Create the second Employee object and initialize its properties
            Employee emp2 = new Employee();
            emp2.id = 2;
            emp2.firstname = "Thelma";
            emp2.lastname = "Masamoc";
            
            // Compare the two Employee objects based on their IDs
            if (emp1.id == emp2.id)
            {
                // If IDs are the same, print this message
                Console.WriteLine("Employee 1 is equal to Employee 2.");
            }
            else
            {
                // If IDs are different, print this message
                Console.WriteLine("Employee 1 is not equal to Employee 2.");
            }
            Console.ReadKey(); // Wait for user input before closing the console window
        }
    }

    public class Employee
    {
        // Properties for Employee class
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
    
        // Overload the == operator to compare Employee objects based on their IDs
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if the ID of both Employee objects are equal
            if (emp1.id.Equals(emp2.id))
            {
                return true; // IDs are equal
            }
            return false; // IDs are not equal
        }

        // Overload the != operator to compare Employee objects based on their IDs
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Check if the ID of both Employee objects are not equal
            if (!emp1.id.Equals(emp2.id))
            {
                return true; // IDs are not equal
            }
            return false; // IDs are equal
        }

        // Override the Equals method to compare Employee objects based on their IDs
        public override bool Equals(object obj)
        {
            // Cast the object to an Employee type
            Employee employee = obj as Employee;
            
            // Check if the cast was successful and if the IDs are equal
            if (employee != null)
            {
                return employee.id.Equals(this.id);
            }
            return false; // Object is not an Employee or IDs are not equal
        }

        // Override the GetHashCode method to ensure consistency with Equals
        public override int GetHashCode()
        {
            // Use the ID for hash code generation
            return id.GetHashCode();
        }
    }
}
