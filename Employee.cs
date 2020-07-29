using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class Employee
    {
        
        
            

        private String name;
        private int salary;
        private string date_joined;
        private String[] skills= new String[10];

        public Employee(String name, int salary, string date_joined, String[] skills)
        {
            this.name = name;
            this.salary = salary;
            this.date_joined = date_joined;
            this.skills = skills;
        }
        //printing the name
        public void Get_name()
        {
            Console.WriteLine(name);
        }
        //printing the salary
        public void Get_salary()
        {
            Console.WriteLine(salary);
        }
        //printing the date he/she joined
        public void Get_date_joined()
        {
            Console.WriteLine(date_joined);
        }
        //method fot raising the salary
        public void Pay_raise(int raise)
        {
            salary += raise;
        }
        //printing the  skills
        public void Get_skills()
        {
            Console.WriteLine("This are the skills:");
            foreach (String i in skills)
            {
                Console.WriteLine(i);
            }
        }
        //printing all the information with ToString()
        public override string ToString()
        {
            return $"Name: {name}\n Salary: {salary}\n Date joined {date_joined}\n Skills: {skills}";
        }
        //method for adding skills
        public void Add_skills(int x, String skill)
        {
            skills[x] = skill;
        }

        // method for removing skills

        // methon for altering skills
        public void Alter_skills(int x, String skill)
        {
            skills[x] = skill;
        }
        //add name
        public void Add_name(String new_name)
        {
            name = new_name;
        }

        //add salary
        public void Add_salary(int new_salary)
        {
            salary = new_salary;
        }
        
        //add date joined
        public void Add_date_jooined(String new_date)
        {
            date_joined = new_date;
        }

        
    }

}
