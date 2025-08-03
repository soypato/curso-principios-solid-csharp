namespace Liskov
{
    public class EmployeeContractor : Employee, ISalary
    {
        public static decimal HOUR_VALUE = 40;
        public EmployeeContractor(string fullname, int hoursWorked) : base(fullname, hoursWorked) { }
        public decimal CalculateSalaryMonthly()
        {
            return HOUR_VALUE * this.HoursWorked;
        }
    }
}
