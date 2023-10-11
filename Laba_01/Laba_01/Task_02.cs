using System;

public class Employee
{
    private string _lastName;
    private string _firstName;
    private string _position;

    public Employee(string lastName, string firstName)
    {
        _lastName = lastName;
        _firstName = firstName;
    }

    public void SetPosition(string position)
    {
        _position = position;
    }

    public void CalculateSalary(int experience)
    {
        double baseSalary = 1000; 
        double salary = baseSalary + (experience * 100); 
        double tax = salary * 0.15; 

        Console.WriteLine($"Прізвище: {_lastName}");
        Console.WriteLine($"Ім'я: {_firstName}");
        Console.WriteLine($"Посада: {_position}");
        Console.WriteLine($"Оклад: {salary} USD");
        Console.WriteLine($"Податковий збір: {tax} USD");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть прізвище співробітника:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Введіть ім'я співробітника:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Введіть посаду співробітника:");
        string position = Console.ReadLine();

        Console.WriteLine("Введіть стаж співробітника (роки):");
        int experience = Convert.ToInt32(Console.ReadLine());

        Employee employee = new Employee(lastName, firstName);
        employee.SetPosition(position);
        employee.CalculateSalary(experience);

        Console.ReadLine();
    }
}