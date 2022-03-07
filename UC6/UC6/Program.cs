
namespace Empwage
{
    class program
    {
        public const int IS_PART_TIME = 1; //
        public const int IS_FUll_TIME = 2;
        public const int EMP_HR_PER_RATE = 2;
        public const int MAX_HR_MONTHS = 10;
        public const int NUM_OF_WORKING_DAYS = 20;

        static void Main(String[] args)

        {
            int emphr = 0;
            int empwage = 0;
            int totalworkingdays = 0;
            int totalempwage = 0;
            int totalemphr = 0;
            while (totalemphr <= MAX_HR_MONTHS && totalworkingdays < NUM_OF_WORKING_DAYS)
            {
                totalworkingdays++;
                Random random = new Random();
                int empCheck = new Random().Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        emphr = 4;
                        break;

                    case IS_FUll_TIME:
                        emphr = 8;
                        break;
                    default:
                        emphr = 0;
                        break;
                }
            }
            totalemphr += emphr;
            Console.WriteLine("Day= " + totalworkingdays + "EmpHrs= " + emphr);

            {
                int totalEmpwage = (EMP_HR_PER_RATE * emphr);
                Console.WriteLine("Total Emp Wage " + totalempwage);
            }
        }
    }
}