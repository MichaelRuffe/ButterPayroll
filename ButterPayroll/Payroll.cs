using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButterPayroll
{
    class Payroll
    {
        struct Employee {
            string firstName { get; set; }
            string lastName { get; set; }
            string accountNum { get; set; }
            string routingNum { get; set; }
            string street { get; set; }
            string city { get; set;}

            double hours { get; set; }

            bool fullTime { get; set; }
            bool directDeposit { get; set; }
        }

        List<Employee> employees;

        public Payroll() {
            employees = new List<Employee>();
        }

        private void readEmployeeData(){
            Employee tempEmployee;
        }

    }
}
