namespace Liskov
{
    public class EmployeeFullTime : Employee, ISalary
    {
        public static decimal HOUR_VALUE = 50;
        public int ExtraHours { get; set; }

        public EmployeeFullTime(string fullname, int hoursWorked, int extrahours) : base(fullname, hoursWorked)
        {
            this.ExtraHours = extrahours;
        }

        public decimal CalculateSalaryMonthly()
        {
            decimal salary = HOUR_VALUE * this.HoursWorked;
            if (this.ExtraHours > 0)
            {
                decimal extraHourValue = 5000M;
                salary += extraHourValue * this.ExtraHours;
            }
            return salary;
        }
    }
}