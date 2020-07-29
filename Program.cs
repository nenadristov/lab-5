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
            //gathering information for the employee
            Console.WriteLine("Input name for the employee");
            string name = Console.ReadLine();
            Console.WriteLine("Input salary for the employee");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the date the employee has joined the company");
            string date = Console.ReadLine();

            //gathering information for the employee's profile
            Console.WriteLine("Input username for the employee");
            string username = Console.ReadLine();
            Console.WriteLine("Input email for the employee");
            string email = Console.ReadLine();
            Console.WriteLine("Input password for the employee");
            string password = Console.ReadLine();


            //new Employee object
            Employee emp1 = new Employee(name,  date, new Profile(username, email, email), salary);
            Console.WriteLine("How many skills are you going to add? ");
            int num_skills = Convert.ToInt32(Console.ReadLine());
            for( int i=0; i<=num_skills; i++)
            {
                int y=i+i;
                Console.WriteLine($"Input skill #{i}");
                string[]  skill = new string[10];
                skill[i]=Console.ReadLine();
                emp1.AddSkills(skill);
                ;
            }
            

            Console.WriteLine("_________________________________________\n\n");
            emp1.Get_name();
            emp1.Get_salary();
            emp1.Get_date_joined();
            emp1.Get_skills();

            Console.WriteLine("_________________________________________\n\n");
            emp1.ToString();


            Console.WriteLine("Do you want to alter some skill\nIf yes type 'yes'");
            String alter_skill = Console.ReadLine();
            if (alter_skill.ToLower() == "yes")
            {
                emp1.Get_skills();
                Console.WriteLine("Input the index of the skill you want to change");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input the skill you want to change");
                String new_skill = Console.ReadLine();
                emp1.Alter_skills(index, new_skill);
            }

            //Console.WriteLine("Do you want to remove some skill\nIf yes type 'yes'");
            //String remove_skill = Console.ReadLine();
            // (remove_skill.ToLower() == "yes")
            //{
            // emp1.Get_skills();
            // Console.WriteLine("Input the index of the skill you want to remove");
            // String remove_skill = Console.ReadLine();

            //emp1.Remove_skills(remove_skill);
            //}

            Console.WriteLine("Do you want to chenge the profile's password\nIf yes type 'yes'");
            String chane_password = Console.ReadLine();
            if (chane_password.ToLower() == "yes")
            {
               
                Console.WriteLine("Input the OLD password");
                String old_pass = Console.ReadLine();
                Console.WriteLine("Input the NEW password");
                String new_pass = Console.ReadLine();
                emp1.ChangePassword(old_pass, new_pass);
            }
            
            Console.ReadLine();
        }
    }
}

