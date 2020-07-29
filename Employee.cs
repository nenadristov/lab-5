using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EmployeeManagement
{
    class Employee
    {
        private String name;
        private int salary, num_skills = 0;
        private string date_joined;
        private String[] skills = new String[10];


        private Profile profile;

        public Employee(string name,   string date_joined, Profile profile, int salary = 10000, int total_skills = 10)
        {
            this.name = name;
            this.salary = salary;
            this.date_joined = date_joined;
            this.skills = new string[total_skills];
            this.profile = profile;
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

        public void AddSkills(params string[] new_skills)
        {
            if (num_skills + new_skills.Length >= skills.Length)
            {
                Console.WriteLine($"Error, cannot add {new_skills.Length} skills.");
            }
            else
            {
                foreach (string skill in new_skills)
                    AddSkill(skill);
            }
        }

        //printing all the information with ToString()
        public override string ToString()
         {
            return $"Name: {name}\n Salary: {salary}\n Date joined {date_joined}\n Skills: {skills}";
         }

        //method for adding skills
        public void AddSkill(string skill)
        {
            if (num_skills == skills.Length)
            {
                Console.WriteLine("Error, employee already has 10 skills.");
            }
            else
            {
                skills[num_skills++] = skill;
            }
        }

        // method for removing skills
        public void Remove_skill( String skill)
        {


           // skills.Remove(skill);
        }

        // methon for altering skills
        public void Alter_skills(int x, String skill)
         {
            
            skills[x] = skill;
         }

        public void ChangePassword(string currentPassword, string newPassword)
        {
            profile.ChangePassword(currentPassword, newPassword);
        }





    }

    }

