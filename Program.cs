using System;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a third employee for the quit method.
            Employee emp1 = new Employee();
            // Call the Quit method defined by the IQuittable interface
            emp1.Quit();
        }
        public interface IQuittable
        {
            // Method that any implementing class must define
            void Quit();
        }
        public class Employee : IQuittable
        {
            // Properties for Employee class
            public int id { get; set; }
            public string firstname { get; set; }
            public string lastname { get; set; }

            // Implement the Quit method from the IQuittable interface
            public void Quit()
            {
                // Message for when employee has quit.
                Console.WriteLine("Employee has quit.");
            }

        }
    }
}