using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate bool PromotionDelegate(Employee employee);

    class Program
    {
      static void Main(string[] args)
        {
            
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee { ID = 101, Name = "Sathish", Salary = 20000, Experience = 6 });
            employeeList.Add(new Employee { ID = 102, Name = "Navin", Salary = 20000, Experience = 6 });
            employeeList.Add(new Employee { ID = 103, Name = "Sathya", Salary = 20000, Experience = 4 });
            employeeList.Add(new Employee { ID = 104, Name = "Prabha", Salary = 20000, Experience = 4 });


            PromotionDelegate promotionDelegate = new PromotionDelegate(isEligibleMethod);


            Employee employee = new Employee();
            employee.PromoteEmployee(employeeList,promotionDelegate);
        }
        public static bool isEligibleMethod(Employee employee)
        {
            if (employee.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        
        public void PromoteEmployee(List<Employee> empList,PromotionDelegate promotionDelegate)
        {
            foreach(Employee data in empList)
            {
                if(promotionDelegate(data))
                {
                    Console.WriteLine(data.Name + "  Can be Promoted");
                }
            }
        }
    }
}
//public delegate void PrintFunctionDelegate(string message);
//PrintFunctionDelegate delegateObj = new PrintFunctionDelegate(PrintMethod);
//delegateObj("This is from delegate");
//public static void PrintMethod(string message)
//{
//    Console.WriteLine(message);
//}