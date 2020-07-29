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

            String name, date;
            String[] skills = new String[10];
            
            int salary;
            
            
            //gathering informations for the employee and creating an object
            Console.WriteLine("Input name for the employee");
            name = Console.ReadLine();
            Console.WriteLine("Input salary for the employee");
            salary =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the date the employee has joined the company");
            date = Console.ReadLine();
            
            //adding skills to the employees object
            Console.WriteLine("How many skills does the employee has (MAX 10");
            int num_skills = Convert.ToInt32(Console.ReadLine());
            for (int y=0; y<=num_skills; y++)
            {
                Console.WriteLine("Input the skill");
                String skill = Console.ReadLine();
                skills[y]=skill;
            }
            Employee obj1 = new Employee(name, salary, date, skills);
            Console.WriteLine("Input username for the employee");
            String username = Console.ReadLine();
            Console.WriteLine("Input password for the employee");
            String password = Console.ReadLine();
            Console.WriteLine("Input email for the employee");
            String email = Console.ReadLine();

            //Profile.Create_user_profile();//PROBLEM
            Console.WriteLine("_________________________________________");
            obj1.Get_name();
            obj1.Get_salary();
            obj1.Get_skills();
            Console.WriteLine("_________________________________________");
            obj1.ToString();
            Console.WriteLine("How much would the pay raise be?");
            int raise = Convert.ToInt32(Console.ReadLine());
            obj1.Pay_raise(raise);
            obj1.ToString();
        }}
}

