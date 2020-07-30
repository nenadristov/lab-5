using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Employee.Change_min(70000);
            Employee.print_min();
            //creating employee objects for the employee
            Employee emp1 = new Employee("John Doe", "01/01/2001", new Profile("jonnyDoe", "jonny@gmail.com", "qwerty"), 70001);
            Employee emp2 = new Employee("Jane Doe", "01/01/2002", new Profile("janeDoe", "jane@hotmail.com", "12345678"), 70002);

            //performance
            PerformanceLevel performance1 = new PerformanceLevel();
            performance1 += 4;
            performance1 += 5;

            //employee 1 performance
            performance1.ToString();

            PerformanceLevel performance2 = new PerformanceLevel();
            performance2 += 2;
            performance2 += 2;

            //employee 2 performance
            performance2.ToString();

            //operators
            Console.WriteLine($"{emp1.Get_name()}== {emp2.Get_name()} {performance1==performance2}");
            Console.WriteLine($"{emp1.Get_name()} != {emp2.Get_name()}? {performance1!= performance2}");
            Console.WriteLine($"{emp1.Get_name()} == 3?  {performance1 == 3}" );
            Console.WriteLine($"{emp1.Get_name()} != 4?  {performance2 != 4}");
            Console.WriteLine($"{emp1.Get_name()} > {emp2.Get_name()}?  {performance1 > performance2}");
            Console.WriteLine($"{emp1.Get_name()} < {emp2.Get_name()}?  {performance1 < performance2}\n\n");

            //phone number

            Telephone_number emp1_tel = new Telephone_number("389", "078-223-305");


            emp1_tel.ToString();



            Console.ReadLine();
        }
    }
}

