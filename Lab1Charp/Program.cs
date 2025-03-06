// See https://aka.ms/new-console-template for more information
static void Task1()
{
    Console.WriteLine("Завдання 1: Обчислення ребра куба за об'ємом.");
    Console.Write("Введіть об'єм куба (v): ");
    double v = Convert.ToDouble(Console.ReadLine());

    if (v <= 0)
    {
        Console.WriteLine("Об'єм має бути додатнім числом!");
        return;
    }

    double edge = Math.Pow(v, 1.0 / 3.0); // Обчислюємо ребро: edge = v^(1/3)
    Console.WriteLine($"Ребро куба: {edge:F2}");
}