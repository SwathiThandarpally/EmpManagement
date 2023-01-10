using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManagement
{
    internal class MultipleCompanyWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public void ComputeEmpWage(string company, int empRateHour, int numberOfWorkingDays, int maxHoursPerMonth)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numberOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {

                    case 1:
                    IS_PART_TIME:
                        empHrs = 16;
                        break;
                    case 2:
                    IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRateHour;
            Console.WriteLine("Total Emp Wage for company :" + company + " is " + totalEmpWage);
            return;
        }
    }

}
