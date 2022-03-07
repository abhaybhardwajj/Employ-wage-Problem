 
namespace Employeewage
{
    class program
    {
        public const int IS_PART_TIME = 1; //
        public const int IS_FUll_TIME = 2;
        public const int EMP_HR_PER_RATE = 20;
        public const int NUM_OF_WORKING_DAYS = 20;

        static void Main(String[] args)
        {
            int emphr = 0;
            int empwage = 0;
            int totalEmpwage = 0;
            for (int days = 0; days < NUM_OF_WORKING_DAYS; days++)
            {
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

                empwage = (EMP_HR_PER_RATE * emphr);
                totalEmpwage += empwage;
                Console.WriteLine("Daily employee wage " + empwage);
            }
            Console.WriteLine("Total Emp wage: " + totalEmpwage);
        }
    }
}