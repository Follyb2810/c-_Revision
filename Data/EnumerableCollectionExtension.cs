using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using revision.Models;

namespace revision.Data
{
    public static class EnumerableCollectionExtension
    {
        public static  IEnumerable<Employee> GetHighSalariedEmployee(this IEnumerable<Employee> enumerable){
            foreach(Employee emp in enumerable){
                System.Console.WriteLine($"Accessing employee:{emp.FirstName +" "+ emp.AnnualSalary +" "+ emp.LastName}");
                if(emp.AnnualSalary >= 100){
                 yield return    emp;
                }
            }
        }
    }
}   