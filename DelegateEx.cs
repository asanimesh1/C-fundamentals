using System;
using System.Collections.Generic;

namespace Delegate
{
    class DelegateEx
    {
        static void Main(string[] args)
        {
            var employeeList= new List <Employee>();
            employeeList.Add(new Employee("Ani",1,8000,3));
            employeeList.Add(new Employee("Sunny",2,4000,1));
            employeeList.Add(new Employee("Jhonny",3,5000,2));
            employeeList.Add(new Employee("Money",4,9000,4));
            employeeList.Add(new Employee("Honey",5,7500,5));
            Console.WriteLine("Bonus is to be given if\non salary basis press 1 \non experience basis press 2");
            int decision=Convert.ToInt32(Console.ReadLine());
            IsForBonus isForBonus;
            if(decision==1)
            {
                isForBonus=new IsForBonus(BonusSal);
            }
            else
            {
                isForBonus=new IsForBonus(BonusExp);
            }
            Employee.GiveBonus(employeeList,isForBonus);
            
        }
        

       
        public static bool BonusSal(Employee emp)
        {
            if(emp.salary>=7600)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool BonusExp(Employee emp)
        {
            if(emp.experience>=3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
