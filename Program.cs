using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication48
{
    class Program
    {
        static void Main(string[] args)
        {
            char s = 'a';
            string a="This is a lab T";
            string b = "ali";
            Console.WriteLine(String.Concat(a,b));
            Console.WriteLine(String.Compare(a,b,true));
            Console.WriteLine(a.Contains('a')  );
            Console.WriteLine(a.StartsWith("T"));
            Console.WriteLine(a.Equals(b));
            string [] arr=a.Split('a');
            Console.WriteLine(a.TrimStart('T'));
            Console.WriteLine(a.ToLower());
            Console.WriteLine(a.Substring(5));
            Console.WriteLine(a.Substring(0,9));
            Console.WriteLine(a.IndexOf('i',3,2));
            Console.WriteLine(a.IndexOf("lab"));
            Console.WriteLine(a.LastIndexOf('l',9));

            Console.Read();

            Employee e = new PEmployee(1, "x");
            e = new CEmployee(2,"y");
        }
    }



}


abstract class Employee
{
    int EmployeeId;
    string EmployeeName;

    public Employee(int id, string name)
    {
        this.EmployeeId = id; this.EmployeeName = name;
    }

    public abstract decimal CalculateBonus(decimal Salary);
}

class PEmployee : Employee
{
    public PEmployee(int id, string name)
        : base(id, name)
    { }
    public override decimal CalculateBonus(decimal Salary)
    { 
        return 0.5M * Salary;
    }
}

class CEmployee : Employee
{
    public CEmployee(int id, string name)
        : base(id, name)
    { }
    public override decimal CalculateBonus(decimal Salary)
    { 
        return 0.25M * Salary;
    }
}