using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Department
    {
        public int DeptID { get; set; }
        public string ?DeptName { get; set; }
        static List<Employee> Staff = new();

        /*static List<Employee> Staff { get; set; } // where should i instialize it?

        Department()
        {
            Staff = new List<Employee>();
        }*/

        public void AddStaff(Employee E) {
            if (Staff?.Contains(E) == false)
                Staff.Add(E);
            else
                Console.WriteLine($"Employee already exists at department {DeptName}");
        }
        ///CallBackMethod
        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e) {
            if ((sender is Employee emp) && (Staff?.Contains(emp) == true)){
                Staff.Remove(emp);
                Console.WriteLine($"This is employee department --{DeptName}--");
                Console.WriteLine($"employee {emp.EmployeeID} has been removed from the department staff\n\n");
            }
        }
    }
}
