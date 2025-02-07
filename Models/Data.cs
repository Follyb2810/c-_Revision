using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revision.Models
{
    public static class Data
    {
        public static List<Employee> GetEmployee()
        {
            List<Employee> employees = new List<Employee>();
            Employee employee = new Employee { Id = 1, FirstName = "folly", LastName = "babs", AnnualSalary = 200m, IsManager = false, DepartmentId = 1 };
            employees.Add(employee);
            employee = new Employee { Id = 2, FirstName = "Akin", LastName = "Tunde", AnnualSalary = 100m, IsManager = true, DepartmentId = 2 };
            employees.Add(employee);
            employee = new Employee { Id = 3, FirstName = "ola", LastName = "folly", AnnualSalary = 300.4m, IsManager = false, DepartmentId = 1 };
            employees.Add(employee);
            employee = new Employee { Id = 4, FirstName = "sam", LastName = "ade", AnnualSalary = 700.4m, IsManager = true, DepartmentId = 1 };
            employees.Add(employee);

            return employees;
        }
        public static List<Department> GetDepartment()
        {
            List<Department> departments = new List<Department>();
            
            Department department = new Department {Id=1,ShortName="HR",LongName="Human Resources"};
            departments.Add(department);
            department = new Department{Id=2,ShortName="FN",LongName="Finance"};
            departments.Add(department);
            department = new Department{Id=3,ShortName="TE",LongName="Technology"};
            departments.Add(department);
            return departments;
        }
    }
}