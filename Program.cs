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
        struct Profile
        {
            public String username { get; set; }
            public String password { get; set; }
            public String email { get; set; }

            public void Create_profile(String username, String password, String email)
            {
                this.username = username;
                this.password = password;
                this.email = email;
            }
            public static Profile Create(String username, String password, String email)
            {
                return new Profile();
            }
            public void Change_password(String old_password, String new_password)
            {
                if (old_password == password)
                {
                    password = new_password;
                    Console.WriteLine("Password has been successfully changed!");
                }
            }
            public override string ToString()
            {
                return $"Username: {username}\n email: {email}\n Password: CLASSIFIED";
            }
        }
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
                y++;
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

            Profile str1 = Profile.Create(username, password, email);
            Console.WriteLine("_________________________________________");
            obj1.Get_name();
            obj1.Get_salary();
            obj1.Get_skills();
            Console.WriteLine("_________________________________________");
            obj1.ToString();
            Console.WriteLine("How much would the pay raise be?");
            int raise = Convert.ToInt32(Console.ReadLine());
            obj1.Pay_raise(raise);
            obj1.Get_salary();
            obj1.ToString();
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(str1.username);
            Console.WriteLine(str1.email);
            Console.WriteLine("Do you want to change tha password\nIf yes type 'yes'");
            string change = Console.ReadLine();
            if (change.ToLower() == "yes")
            {
                Console.WriteLine("Input your OLD password");
                String old = Console.ReadLine();
                Console.WriteLine("Input your NEW password");
                String new_pass = Console.ReadLine();
                str1.Change_password(old, new_pass);

            }
            str1.ToString();


            Console.ReadLine();
        }

    }
}

