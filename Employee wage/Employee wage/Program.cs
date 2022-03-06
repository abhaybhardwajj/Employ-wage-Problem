Console.WriteLine("Employee Wage Computation Problem");
int Present = 1;  //constant
int emp_per_rate = 20; //Constant
int emphr = 0;
int empwage = 0; //variable
int Emp_per_rate = 0; //variable

Random random = new Random(); //computation to create the baszic object
int EmployeeStatus = random.Next(0, 2);
if (EmployeeStatus == Present)
{
    Console.WriteLine("Employee is present");
    emphr = 8;

}
else
{
    Console.WriteLine("Employee is Absent");
    emphr = 0;
}
empwage = (Emp_per_rate * emphr);
Console.WriteLine("Daily wage" + empwage);
