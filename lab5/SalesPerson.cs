using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }

        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e) {
            Console.WriteLine("SalesPerson laying off");
            if(e.Cause == LayOffCause.MasterOfTheGameAge || e.Cause == LayOffCause.DidntAchieveTarget) {
                Console.WriteLine($"Employee {this.EmployeeID} is laying off bacause {e.Cause}...");
                Console.WriteLine(this);
                base.OnEmployeeLayOff(e);
            }
        }
        public bool CheckTarget(int Quota) {
            if(AchievedTarget < Quota) {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.DidntAchieveTarget });
                return false;
            }
            return true;
        }
    }
}
