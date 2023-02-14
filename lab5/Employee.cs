using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Employee {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e) {
            Console.WriteLine($"Employee {this.EmployeeID} is laying off bacause {e.Cause}...");
            Console.WriteLine(this);
            EmployeeLayOff?.Invoke(this, e);
        }

        public int EmployeeID { get; set; }
        public DateTime BirthDate { get; set; }
        public int VacationStock { get; set; }

        public bool RequestVacation(DateTime From, DateTime To) {
            VacationStock -= (To.Day - From.Day);
            if (VacationStock >= 0) {
                return true;
            }
            else {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.NoVacationStock });
                return false;
            }
        }
        public void EndOfYearOperation() {
            int age = DateTime.Now.Year - BirthDate.Year;
            if (age >= 60){
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.MasterOfTheGameAge });
            }
        }

        public override string ToString() => $"Employee data::\nid: {EmployeeID}\nbirthdate: {BirthDate}\nVStock: {VacationStock}\n";
    }
}
