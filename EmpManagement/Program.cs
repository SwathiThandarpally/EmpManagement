﻿namespace EmpManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Displaying Employee Wage Computation Program");
            //UC_1
            EmployeeCheck.EmployeeAttandance();
            Console.ReadKey();
            Console.WriteLine("-------------------------");
            ////UC_2
            //EmployeeWage employeeWage = new EmployeeWage();
            //employeeWage.FullTimeEmployeeWage();
            //Console.WriteLine("-------------------------");
            ////UC_3
            //AddPartTime addPartTime = new AddPartTime();
            //addPartTime.PartTimeEmpWage();
            //Console.WriteLine("-------------------------");
            ////UC_4
            //CaseStatement caseStatement = new CaseStatement();
            //caseStatement.Display();
            //Console.WriteLine("-------------------------");
            ////UC_5
            //EmpWagePerMonth empWagePerMonth = new EmpWagePerMonth();
            //empWagePerMonth.Display();
            //Console.WriteLine("-------------------------");
            ////UC_6
            //EmpMaxHrs empMaxHrs = new EmpMaxHrs();
            //empMaxHrs.Display();
            ////UC_7
            //RefactorCode calculation = new RefactorCode();
            //calculation.EmployeeAttendence();
            //RefactorCode calculation2 = new RefactorCode();
            //calculation2.EmpWageCalculation();
            ////UC_8
            //MultipleCompanyWage ComputeMultipleCompanies = new MultipleCompanyWage();
            //ComputeMultipleCompanies.ComputeEmpWage("Amazon", 20, 30, 40);
            //ComputeMultipleCompanies.ComputeEmpWage("DMart", 10, 15, 20);
            //ComputeMultipleCompanies.ComputeEmpWage("Vodafone", 5, 15, 20);

            //UC_9
            EachCompanyWage eachCompanyWage = new EachCompanyWage("Samsung", 50, 20,100);
            eachCompanyWage.ComputeEmpWage();
            eachCompanyWage.ToString();
            
        }
    }
    
}