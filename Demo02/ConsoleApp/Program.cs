using MyLibrary;

Employee Maria = new Secretary();
Maria.Name = "Maria";

Employee Pedro = new Manager();
Pedro.Name = "Pedro";

Developer Miguel = new Developer();

WriteEmployee(Maria);
WriteEmployee(Pedro);
WriteEmployee(Miguel);

void WriteEmployee(Employee employee)
{
	Console.WriteLine($"{employee.Name}: {employee.CalculateMonthlyPayment()}");
	Console.WriteLine($"Days: {employee.GetPaymentDays()}");
}