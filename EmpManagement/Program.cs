namespace EmpManagement
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
            //UC_2
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.FullTimeEmployeeWage();
            Console.WriteLine("-------------------------");
            //UC_3
            AddPartTime addPartTime = new AddPartTime();
            addPartTime.PartTimeEmpWage();
            Console.WriteLine("-------------------------");
            //UC_4
            CaseStatement caseStatement = new CaseStatement();
            caseStatement.Display();
            Console.WriteLine("-------------------------");
            //UC_5
            EmpWagePerMonth empWagePerMonth = new EmpWagePerMonth();
            empWagePerMonth.Display();
            Console.WriteLine("-------------------------");
        }
    }
}