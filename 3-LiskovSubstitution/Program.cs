using Liskov;

CalculateSalaryMonthly(new List<ISalary>() { // sólo las que implementan ISalary, no todos los empleados
    new EmployeeFullTime("Pepito Pérez", 160, 10),
    new EmployeeContractor("Manuel Lopera", 180)
});

void CalculateSalaryMonthly(List<ISalary> employees) 
{
    foreach (var item in employees)
    {
        decimal salary = item.CalculateSalaryMonthly();
        Console.WriteLine($"The {item}'s salary is {salary}");
        
    }
}