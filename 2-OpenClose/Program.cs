using OpenClose;

CalculateSalaryMonthly(new List<object>() {
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeePartTime("Manuel Lopera", 180)
});


void CalculateSalaryMonthly(List<object> employees) 
{
    foreach (var employee in employees)
    {
        if(employee is EmployeeFullTime fullTimeEmployee)
        {
            decimal salary = fullTimeEmployee.CalculateSalaryMonthly();
            Console.WriteLine($"El salario mensual de {fullTimeEmployee} es: {salary}");
        }
        else if(employee is EmployeePartTime partTimeEmployee)
        {
            decimal salary = partTimeEmployee.CalculateSalaryMonthly();
            Console.WriteLine($"El salario mensual de {partTimeEmployee} es: {salary}");
        }
        else
        {
            Console.WriteLine("Tipo de empleado desconocido.");
        }
    }

}