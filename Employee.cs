using System;
using System.Collections.Generic;

namespace Delegate
{
    public  delegate bool IsForBonus(Employee emp);

    public class Employee
    {
        public string name{get; set;}
        public int empId{get; set;}
        public int salary{get; set;}
        public int experience{get; set;}

        public Employee(string name, int empId, int salary, int experience)
        {
            this.name = name;
            this.empId = empId;
            this.salary = salary;
            this.experience = experience;
        }

        public static void GiveBonus(List <Employee> employeeList,IsForBonus IsElligilbleB)
        {
        foreach (var employee in employeeList)
        {
            if(IsElligilbleB(employee))
            {
                Console.WriteLine($"Bonus is granted to {employee.name}");
            }
        }
       
        }

    }
    
}