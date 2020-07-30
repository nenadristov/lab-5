using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public partial class Telephone_number
    {
        public string prefix { get; set; }
        public string number { get; set; }

        public Telephone_number(string Prefix, string Number)
        {
            prefix = Prefix;
            number = Number;
        }

        public override string ToString()
        {
            Console.WriteLine($"{prefix} {number}");
            return $"{prefix} {number}";
        }
    }
}
