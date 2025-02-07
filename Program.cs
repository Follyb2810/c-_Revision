using System;
using System.Collections.Generic;
using System.Linq;
using revision.Models;
using revision.Data;

static class Program
{
    static void Main(string[] args)
    {

        //? using linq queries
        List<Employee> employeesList = Data.GetEmployee();
        List<Department> departmentList = Data.GetDepartment();
        // var result = employeesList.Select(e => new
        // {
        //     FullName = e.FirstName + " " + e.LastName,
        //     // LastName= e.LastName,
        //     AnnualSalary = e.AnnualSalary,
        //     IsManager = e.IsManager,
        //     DepartmentId = e.DepartmentId

        // }).Where(e =>e.AnnualSalary >=200);
        // foreach (var employee in result)
        // {
        //     System.Console.WriteLine("firstName {0}", employee.FullName);
        //     System.Console.WriteLine("AnnualSalary {0}", employee.AnnualSalary);
        //     System.Console.WriteLine("firstName {0}", employee.DepartmentId);
        //     System.Console.WriteLine($"{employee.FullName,-20}{employee.AnnualSalary,10}");
        // }
        //? query synthax
        // var result = from emp in employeesList
        //              select new
        //              {
        //                  FullName = emp.FirstName + " " + emp.LastName,
        //                  // LastName= emp.LastName,
        //                  AnnualSalary = emp.AnnualSalary,
        //                  IsManager = emp.IsManager,
        //                  DepartmentId = emp.DepartmentId
        //              };
        // foreach (var employee in result)
        // {
        //     System.Console.WriteLine("firstName {0}", employee.FullName);
        //     System.Console.WriteLine("AnnualSalary {0}", employee.AnnualSalary);
        //     System.Console.WriteLine("firstName {0}", employee.DepartmentId);
        //     System.Console.WriteLine($"{employee.FullName,-20}{employee.AnnualSalary,10}");
        // }
        // adding extension
        // //? defferd execution
        //     var result = from emp in employeesList.GetHighSalariedEmployee()
        //                  select new
        //                  {
        //                      FullName = emp.FirstName + " " + emp.LastName,
        //                      // LastName= emp.LastName,
        //                      AnnualSalary = emp.AnnualSalary,
        //                      IsManager = emp.IsManager,
        //                      DepartmentId = emp.DepartmentId
        //                  };
        //                  employeesList.Add(new Employee{ Id = 5, FirstName = "defered", LastName = "methid", AnnualSalary = 700.43m, IsManager = true, DepartmentId = 1 });
        //     foreach (var employee in result)
        //     {
        //         System.Console.WriteLine("firstName {0}", employee.FullName);
        //         System.Console.WriteLine("AnnualSalary {0}", employee.AnnualSalary);
        //         System.Console.WriteLine("firstName {0}", employee.DepartmentId);
        //         System.Console.WriteLine($"{employee.FullName,-20}{employee.AnnualSalary,10}");
        //     }
        //? immediate execution
        // var result = (from emp in employeesList.GetHighSalariedEmployee()
        //              select new
        //              {
        //                  FullName = emp.FirstName + " " + emp.LastName,
        //                  // LastName= emp.LastName,
        //                  AnnualSalary = emp.AnnualSalary,
        //                  IsManager = emp.IsManager,
        //                  DepartmentId = emp.DepartmentId
        //              }).ToList();
        //              employeesList.Add(new Employee{ Id = 5, FirstName = "defered", LastName = "methid", AnnualSalary = 700.43m, IsManager = true, DepartmentId = 1 });
        // foreach (var employee in result)
        // {
        //     System.Console.WriteLine("firstName {0}", employee.FullName);
        //     System.Console.WriteLine("AnnualSalary {0}", employee.AnnualSalary);
        //     System.Console.WriteLine("firstName {0}", employee.DepartmentId);
        //     System.Console.WriteLine($"{employee.FullName,-20}{employee.AnnualSalary,10}");
        // }
        //? Join
        // var result = departmentList.Join(employeesList,
        //                 department => department.Id,
        //                 employee =>employee.Id,
        //                 (department,employee) =>new {
        //                     FullName=employee.FirstName +" "+ employee.LastName,
        //                     AnnualSalary = employee.AnnualSalary,
        //                     DepartmentName= department.LongName
        //                 }
        // );
        //   foreach (var employee in result)
        // {
        //     System.Console.WriteLine("firstName {0} and department is {1} with anuuly salary of {2}", employee.FullName,employee.AnnualSalary,employee.DepartmentName);
        // }

        //? join Quey syntax

        // var result = from dept in departmentList
        //              join emp in employeesList
        //              on dept.Id equals emp.DepartmentId
        //              select new {
        //                  FullName=emp.FirstName +" "+ emp.LastName,
        //                     AnnualSalary = emp.AnnualSalary,
        //                     DepartmentName= dept.LongName
        //              };
        //   foreach (var employee in result)
        // {
        //     System.Console.WriteLine("firstName {0} and department is {1} with anuuly salary of {2}", employee.FullName,employee.AnnualSalary,employee.DepartmentName);
        // }                  


        // //? query groupjoin
        // var result = departmentList.GroupJoin(employeesList,
        //                                        emp => emp.Id,
        //                                        dept => dept.DepartmentId,
        //                                        (dept, employeeGroup) => new
        //                                        {
        //                                            Employee = employeeGroup,
        //                                            DepartmentName = dept.LongName

        //                                        }
        //                                         );
        // foreach (var employee in result)
        // {
        //     System.Console.WriteLine("firstName {0} and department is with anuuly salary of ",  employee.DepartmentName);
        //     foreach(var item in employee.Employee){
        //         System.Console.WriteLine(item.FirstName);
        //     }
        // }
        
        //? query syntax left join
        // var result =from dept in departmentList
        //             join emp in employeesList
        //             on dept.Id equals emp.DepartmentId
        //             into employeeGroup
        //             select new{
        //                 Employee=employeeGroup,
        //                 DepartmentName = dept.LongName
        //             };
        //      foreach (var employee in result)
        // {
        //     System.Console.WriteLine("firstName {0} and department is with anuuly salary of ",  employee.DepartmentName);
        //     foreach(var item in employee.Employee){
        //         System.Console.WriteLine(item.FirstName);
        //     }
        // }
        
        //? Orderby
        
        // var result = employeesList.Join(departmentList,
        //                                 e=>e.DepartmentId,
        //                                 d=>d.Id,
        //                                 (emp,dept)=> new {
                                            // Id=emp.Id,
                                            // FirstName = emp.FirstName,
                                            // LastName=emp.LastName,
                                            // AnnualSalary=emp.AnnualSalary,
                                            // DepartmentId=emp.DepartmentId,
                                            // DepartmentName=dept.LongName
        //                                 }
        //                                 ).OrderBy(o=>o.DepartmentId).ThenBy(o=>o.AnnualSalary);
        //            foreach (var employee in result)
        // {
        //     System.Console.WriteLine("firstName {0} and department is {1} with anuuly salary of {2}", employee.FirstName,employee.AnnualSalary,employee.DepartmentName);
        // } 
        
        //? OrderBy
        // var result = from emp in employeesList
        //              join dept in departmentList
        //              on emp.DepartmentId equals dept.Id
        //              orderby emp.DepartmentId,emp.AnnualSalary descending
        //              select new{
        //                     Id=emp.Id,
        //                                     FirstName = emp.FirstName,
        //                                     LastName=emp.LastName,
        //                                     AnnualSalary=emp.AnnualSalary,
        //                                     DepartmentId=emp.DepartmentId,
        //                                     DepartmentName=dept.LongName
        //              };
        //             foreach (var employee in result)
        // {
        //     System.Console.WriteLine("firstName {0} and department is {1} with anuuly salary of {2}", employee.FirstName,employee.AnnualSalary,employee.DepartmentName);
        // } 
        
        //? group by
        // var groupResult = from emp in employeesList
        //                 group emp  by emp.DepartmentId;
        //     foreach (var empGroup in groupResult)
        //     {
        //         System.Console.WriteLine($"deparmernt id {empGroup.Key}");
        //         foreach(Employee emp in empGroup){
        //             System.Console.WriteLine($"full name {emp.FirstName} {emp.LastName}");
        //         }
        //     }
        //? ToLookup
        // var groupResult = employeesList.ToLookup(e =>e.DepartmentId);
        // foreach (var empGroup in groupResult)
        //     {
        //         System.Console.WriteLine($"deparmernt id {empGroup.Key}");
        //         foreach(Employee emp in empGroup){
        //             System.Console.WriteLine($"full name {emp.FirstName} {emp.LastName}");
        //         }
        //     }
        
        //? All or Any
        // bool isAny = employeesList.Any(e => e.AnnualSalary > 200);
        // bool isAll = employeesList.All(e => e.AnnualSalary > 200);
        // System.Console.WriteLine(isAll);
        // System.Console.WriteLine(isAny);
        
        //? contains
        bool isContainEmployee = employeesList.Contains(new Employee{FirstName="folly"});
        var emp =new Employee{FirstName="folly"};
        bool isContainEmploye = employeesList.Contains(emp);
        
        //? using extensiom

        // List<Employee> employeesList = Data.GetEmployee();
        // // List<Employee> employeesList = new List<Employee>();
        // var filterList = employeesList.FilterExtension(emp=>emp.IsManager == true);
        // foreach(var employee in filterList){
        //     System.Console.WriteLine("{0} FirstName",employee.FirstName);
        //     System.Console.WriteLine("{0} LastName",employee.LastName);
        //     System.Console.WriteLine("{0} IsManager",employee.IsManager);
        //     System.Console.WriteLine("{0} AnnualSalary",employee.AnnualSalary);
        //     System.Console.WriteLine("{0} DepartmentId",employee.DepartmentId);
        // }
        // // Console.ReadKey();
        // List<Department> departmentList = Data.GetDepartment();
        // var filterDeparment = departmentList.FilterExtension(dept =>dept.ShortName == "FN");
        // // var filterDeparment = departmentList.FilterExtension(dept =>dept.ShortName == "FN" || dept.ShortName== ""HR);
        // foreach(var department in filterDeparment){
        //     System.Console.WriteLine($"ShortName {department.ShortName}");
        //     System.Console.WriteLine($"LongName {department.LongName}");
        //     System.Console.WriteLine("this is deparment");
        // }
        // Console.WriteLine("Hello, World!");
        // Console.Write("Congratulations!");
        // Console.Write(" ");
        // Console.Write("You wrote your first lines of code.");
        // Console.Write(" ");

        // Random dice = new Random();

        // double roll = 1 + dice.NextDouble() * 5;
        // int roll2 = dice.Next(1, 7);


        // Console.WriteLine($"roll: {roll}");
        // Console.WriteLine($"roll2: {roll2}");
        // int firstValue = 500;
        // int secondValue = 600;
        // int largerValue;
        // largerValue = Math.Max(firstValue, secondValue);
        // Console.WriteLine(largerValue);
        // System.Console.WriteLine(Math.Min(firstValue, secondValue));
        // //! exceptions
        // string[] names = { "Dog", "Cat", "Fish" };
        // Object[] objs = (Object[])names;

        // Object obj = (Object)13;
        // System.Console.WriteLine(obj);
        // System.Console.WriteLine(objs);
        // objs[2] = obj; 
        //
        // int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
        // int[] values2 = new int[6];

        // values2[values1.Length - 1] = values1[values1.Length - 1];
        // System.Console.WriteLine(values1.Length);
        // object obj = "22";
        // int num = (int)obj;
        // int num = int.Parse((string)obj);
        // System.Console.WriteLine(num);
        // object obj = "22";
        // if (int.TryParse((string)obj, out int num))
        // {
        //     Console.WriteLine(num); // Output: 22
        // }
        // else
        // {
        //     Console.WriteLine("Invalid number");
        // }
        //     string firstName = "Babs";
        //     string lastName = "folly";
        //     string message = "Hello " + firstName + " " + lastName;
        //     string messages = $"hello {lastName} {firstName}!";
        //     Console.WriteLine(message);
        //     Console.WriteLine(messages);
        //     string projectName = "First-Project";
        //     Console.WriteLine($@"C:\Output\{projectName}\Data");
        //     System.Console.WriteLine($@"this is the hpuse \");
        //     System.Console.WriteLine($@"this is the hpuse \");
        //     string projectNames = "ACME";

        //     string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c  \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
        //     System.Console.WriteLine(projectNames);
        //     System.Console.WriteLine(russianMessage);
        //     double decimalQuotient = 7.0d / 5;
        //     Console.WriteLine($"Decimal quotient: {decimalQuotient}");
        //     int first = 7;
        //     double second = 5.3f;
        //     decimal quotient = (decimal)first / (decimal)second;
        //     Console.WriteLine(quotient);
        //     System.Console.WriteLine((decimal)second);
        //     System.Console.WriteLine(second);
        //     string input = "Pad this";
        //     Console.WriteLine(input.PadLeft(12));
        //     string paymentId = "769C";

        //     var formattedLine = paymentId.PadRight(6);

        //     Console.WriteLine(formattedLine);
        //     string value = "abc123";
        //     char[] valueArray = value.ToCharArray();
        //     Array.Reverse(valueArray);
        //     System.Console.WriteLine(valueArray);
        //     string result = new string(valueArray);
        //     Console.WriteLine(result);
        //     string folly = new string("folly");
        //     System.Console.WriteLine(folly);
        //     // char[] folltC = new char[]{'a','b'};
        //     char[] folltC = new char[] { 'a', 'b' };
        //   char follD = 'b';
        // string pangram = "The quick brown fox jumps over the lazy dog";
        // // Step 1: Split the string into words
        // string[] message = pangram.Split(' ');
        // Console.WriteLine("Message array: " + string.Join(", ", message));

        // // Step 2: Create a new array of the same length
        // string[] newMessage = new string[message.Length];
        // Console.WriteLine("NewMessage array: " + string.Join(", ", newMessage));
        // string result = string.Join(" ", pangram
        //     .Split(' ')
        //     .Select(word => new string(word.Reverse().ToArray())));

        // Console.WriteLine(result);
        // System.Console.WriteLine(string.Join(" ",pangram.Split(' ')));
        // System.Console.WriteLine(string.Join(" ",pangram.Split(' ').Select(w=>new string(w.Reverse().ToArray()))));
        // string text = "folly";
        // System.Console.WriteLine(string.Join(" ",text.ToArray()));
        // string[] textArray = {"A","B","C"};
        // System.Console.WriteLine(string.Join("",text.ToArray()));
        //         int first = 2;
        // string second = "4";
        // int result = first + second;
        // Console.WriteLine(result);
        // int first = 2;
        // string second = "4";
        // string result = first + second;
        // Console.WriteLine(result);
        // string data = "12345John Smith          5000  3  ";
        // string updatedData = data.Remove(5, 2);
        // string updatedEReplace = data.Replace(" ", "");
        // Console.WriteLine(updatedData);
        // Console.WriteLine(updatedEReplace);
        // const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

        // string quantity = "";
        // string output = "";

        // Your work here

        // Extract the "quantity"
        // const string openSpan = "<span>";
        // const string closeSpan = "</span>";

        // int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
        // Console.WriteLine(" quantityStart {0}", quantityStart);
        // int quantityEnd = input.IndexOf(closeSpan);
        // Console.WriteLine(" quantityEnd {0}", quantityEnd);
        // int quantityLength = quantityEnd - quantityStart;
        // Console.WriteLine(" quantityLength {0}", quantityLength);
        // quantity = input.Substring(quantityStart, quantityLength);
        // quantity = $"Quantity: {quantity}";
        // Console.WriteLine(" quantity {0}", quantity);

        // // Set output to input, replacing the trademark symbol with the registered trademark symbol
        // const string tradeSymbol = "&trade;";
        // const string regSymbol = "&reg;";
        // output = input.Replace(tradeSymbol, regSymbol);
        // Console.WriteLine(" output replacing {0}", output);

        // // Remove the opening <div> tag
        // const string openDiv = "<div>";
        // int divStart = output.IndexOf(openDiv);
        // output = output.Remove(divStart, openDiv.Length);
        // Console.WriteLine(" output opening {0}", output);

        // // Remove the closing </div> tag and add "Output:" to the beginning
        // const string closeDiv = "</div>";
        // int divCloseStart = output.IndexOf(closeDiv);
        // output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);
        // Console.WriteLine(" output closing {0}", output);

        // Console.WriteLine(quantity);
        // Console.WriteLine(output);
        // Console.WriteLine($"quantityStart {quantityStart}");
        // Console.WriteLine($"quantityEnd {quantityEnd}");
        // Console.WriteLine($"quantityLength {quantityLength}");
        // Console.WriteLine($"quantity {quantity}");
        // Console.WriteLine($"output replacing {output}");
        // Console.WriteLine($"output opening {output}");
        // Console.WriteLine($"output closing {output}");
        // Console.WriteLine("quantityStart {0}", quantityStart);
        // Console.WriteLine("quantityEnd {0}", quantityEnd);
        // Console.WriteLine("quantityLength {0}", quantityLength);
        // Console.WriteLine("quantity {0}", quantity);
        // Console.WriteLine("output replacing {0}", output);
        // Console.WriteLine("output opening {0}", output);
        // Console.WriteLine("output closing {0}", output);
        // Code sample 1
        // bool flag = true;
        // int value;

        // if (flag)
        // {
        //     value = 10;
        //     Console.WriteLine($"Inside the code block: {value}");
        // }

        // Console.WriteLine($"Outside the code block: {value}");

        // int[] numbers = { 4, 8, 15, 16, 23, 42 };

        // int total = 0;


        // foreach (int number in numbers)
        // {
        //     total += number;
        //     Console.WriteLine("number: {0}, total so far: {1}", number, total);
        // }

        // // Print the total after the loop
        // Console.WriteLine("Final total: " + total);
        // Random coin = new Random();
        // int flip = coin.Next(0, 2);
        // Console.WriteLine((flip == 0) ? "heads" : "tails");



    }
}
