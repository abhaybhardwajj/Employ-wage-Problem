// UC7 Employees monthly wage for a given condition

namespace Employee
{
    class EmployeeWageComputaion
    {
        public int empRatePrHr;//constatnt
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public const int numOfDays = 20;
        public const int maxHrs = 100;
        public const int isAbsent = 0;
        public const int workHr = 0;//variable
        public const int totalWrkHr = 0;
        int totalWage;
        int totalWrkDays = 0;

        public EmployeeWageComputaion(int empRatePrHr, int isFullTime, int isPartTime, int numOfDays, int maxHrs)
        {
            this.empRatePrHr = empRatePrHr;
            isFullTime = isFullTime;
            isPartTime = isPartTime;
            numOfDays = numOfDays;
            maxHrs = maxHrs;

        }

        private int IsEmployeePresent()
        {
            Random random = new Random();
            int empStatus = random.Next(0, 3);
            return empStatus;
        }
        public void CalculateWage()
        {
            int dayNumber = 1;
            int workHr = 0;
            int totalWrkHr = 0;



            while (totalWrkHr < maxHrs && totalWrkDays < numOfDays)
            {
                Random random = new Random();
                int employeeStatus = random.Next(0, 3);
                switch (IsEmployeePresent())
                {
                    case isFullTime:
                        workHr = 8;
                        break;
                    case isPartTime:
                        workHr = 4;
                        break;
                    default:
                        workHr = 0;
                        break;
                }
                totalWrkHr += workHr;
                totalWrkDays++;
            }
            totalWage = totalWrkHr * empRatePrHr;
            Console.WriteLine("Employee total wage is " + totalWage
                + " for {0} working Days", totalWrkDays);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage Computtation");
            EmployeeWageComputaion wage = new EmployeeWageComputaion(20, 1, 2, 20, 100);
            wage.CalculateWage();

        }
    }
}
