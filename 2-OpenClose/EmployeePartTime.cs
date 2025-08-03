namespace OpenClose
{
    public class EmployeePartTime : Employee
    {
        public static decimal HOUR_VALUE = 20000M;
        public EmployeePartTime(string fullname, int hoursWorked) : base(fullname, hoursWorked) {}

        public override decimal CalculateSalaryMonthly()
        {
            decimal salary = HOUR_VALUE * this.HoursWorked;
            if (this.HoursWorked > 160)
            {
                decimal effortCompensation = 5000M;
                int extraDays = this.HoursWorked - 160;
                salary += effortCompensation * extraDays;
            }
            return salary;
    }


    }
}