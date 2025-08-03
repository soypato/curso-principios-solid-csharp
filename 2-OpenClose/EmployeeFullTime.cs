namespace OpenClose
{
    public class EmployeeFullTime : Employee, ISalary
    {
        public static decimal HOUR_VALUE = 30000M;
        public EmployeeFullTime(string fullname, int hoursWorked) : base(fullname, hoursWorked) {}

        public decimal CalculateSalaryMonthly()
        {
            return HOUR_VALUE * this.HoursWorked;
        }

    }
}