using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaticDataAPI
{
    public class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public float Salary { get; set; }


        public Employee() { }

        public Employee(int eid, string ename,float sal)
        {
            Eid = eid;
            Ename = ename;
            Salary = sal;

        }

        public static List<Employee> employees = new List<Employee>();

        public static List<Employee> getEmployees()
        {
            employees.Add(new Employee(1, "Ram", 85000));
            employees.Add(new Employee(2, "Sreedhar", 54000));
            employees.Add(new Employee(3, "Vikram", 74000));
            employees.Add(new Employee(4, "Sandhya", 7900));
            return employees;
        }
    }
}
