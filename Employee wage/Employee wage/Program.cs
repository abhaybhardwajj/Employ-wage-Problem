Console.WriteLine("Employee Wage Computation Problem");

//uc3
int Present = 1;  //constant
int emp_per_rate = 20; //Constant
int emphr = 0;
int empwage = 0; //variable
int empfull = 1;

Random random = new Random(); //computation to create the baszic object
Random random1 = new Random();
int Employeetime = random1.Next(0, 2);
int EmployeeStatus = random.Next(0, 2);
if (EmployeeStatus == Present)
{

    if (Employeetime == empfull)
    {
        emphr = 8;
        Console.WriteLine("Full time Employee");
    }
    else
    {
        emphr = 4;
        Console.WriteLine("Half time Employee");
    }

}
else
{
    Console.WriteLine("Employee is Absent");
    emphr = 0;
}
empwage = (emp_per_rate * emphr);
Console.WriteLine("Daily wage " + empwage);