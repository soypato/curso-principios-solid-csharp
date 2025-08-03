namespace OpenClose
{ 
    public class EmployeeContractor : Employee
    {
        public static decimal HOUR_VALUE = 40000M;

        public EmployeeContractor(string fullname, int hoursWorked) : base(fullname, hoursWorked) {}
        public override decimal CalculateSalaryMonthly()
        {
            return HOUR_VALUE * this.HoursWorked;
        }
    }
}