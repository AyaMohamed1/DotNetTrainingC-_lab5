using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Club {
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        static List<Employee> Members = new();
        public void AddMember(Employee E) {
            ///Try Register for EmployeeLayOff Event Here //??????????????
            if (Members?.Contains(E) == false)
                Members.Add(E);
            else
                Console.WriteLine($"Employee already exists at club {ClubName}");
        }
        ///CallBackMethod
        public void RemoveMember (object sender, EmployeeLayOffEventArgs e) {
            ///Employee Will not be removed from the Club if Age>60
            ///Employee will be removed from Club if Vacation Stock < 0
            if ((sender is Employee emp) && (Members?.Contains(emp) == true) && e.Cause == LayOffCause.NoVacationStock){
                Members.Remove(emp);
                Console.WriteLine($"This is Club -{ClubName}-");
                Console.WriteLine($"employee {emp.EmployeeID} has been removed from the club\n\n");
            }
        }
    }
}
