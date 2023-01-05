using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManagement
{
    internal class CaseStatement
    {
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        public const int EMP_RATE_PER_HOUR = 20;

        public void Display()
        {
            int empHrs = 0;
            int empWage = 0;
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
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);

        }
    }
}
