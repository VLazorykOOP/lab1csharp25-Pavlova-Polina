// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Task1: ");
        Task1();
        Console.WriteLine();

        Console.Write("Task2: ");
        Task2();
        Console.WriteLine();

        Console.Write("Task3: ");
        Task3();
        Console.WriteLine();

        Console.Write("Task4: ");
        Task4();
        Console.WriteLine();

        Console.Write("Task5: ");
        Task5();
        Console.WriteLine();

        Console.Write("Task6: ");
        Task6();
    }

    // Завдання 1: Обчислення ребра куба
    static void Task1()
    {
        Console.WriteLine("Введіть об'єм куба (v):");
        double volume;
        while (!double.TryParse(Console.ReadLine(), out volume) || volume <= 0)
        {
            Console.WriteLine("Будь ласка, введіть додатне число:");
        }
        double edge = Math.Pow(volume, 1.0 / 3.0);
        Console.WriteLine($"Ребро куба з об'ємом {volume} дорівнює {edge:F2}");
    }

    // Завдання 2: Перевірка суми цифр двозначного числа
    static void Task2()
    {
        Console.WriteLine("Введіть двозначне число (10-99):");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number) || number < 10 || number > 99)
        {
            Console.WriteLine("Будь ласка, введіть коректне двозначне число (10-99):");
        }
        int tens = number / 10;
        int ones = number % 10;
        int sum = tens + ones;
        bool isOdd = sum % 2 != 0;
        Console.WriteLine($"Сума цифр числа {number} дорівнює {sum}");
        Console.WriteLine($"Сума цифр є {(isOdd ? "непарною" : "парною")}");
    }

    // Завдання 3: Перевірка положення точки в заштрихованій області
    static void Task3()
    {
        Console.WriteLine("Введіть координати точки (x y):");
        double x, y;
        string[] input = Console.ReadLine().Split(' ');
        while (input.Length != 2 || !double.TryParse(input[0], out x) || !double.TryParse(input[1], out y))
        {
            Console.WriteLine("Будь ласка, введіть два числа через пробіл (x y):");
            input = Console.ReadLine().Split(' ');
        }
        if ((x == -100 || x == 0 || y == 0 || Math.Abs(y - (-x)) < 0.0001) &&
            x >= -100 && x <= 0 && y >= 0 && y <= -x)
        {
            Console.WriteLine("На межі");
        }
        else if (x >= -100 && x <= 0 && y >= 0 && y <= -x)
        {
            Console.WriteLine("Так");
        }
        else
        {
            Console.WriteLine("Ні");
        }
    }

    // Завдання 4: Знайти дату n днів тому
    static void Task4()
    {
        Console.WriteLine("Введіть кількість днів n (n > 0):");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Будь ласка, введіть додатне ціле число:");
        }
        DateTime currentDate = new DateTime(2025, 3, 13);
        DateTime unknownDate = currentDate.AddDays(-n);
        Console.WriteLine($"Дата {n} днів тому від 13 березня 2025 року: {unknownDate:dd.MM.yyyy}");
    }

    // Завдання 5: Піднесення до квадрата суми двох цілих чисел
    static void Task5()
    {
        Console.WriteLine("Введіть два цілих числа (a b):");
        int a, b;
        string[] input = Console.ReadLine().Split(' ');
        while (input.Length != 2 || !int.TryParse(input[0], out a) || !int.TryParse(input[1], out b))
        {
            Console.WriteLine("Будь ласка, введіть два цілих числа через пробіл (a b):");
            input = Console.ReadLine().Split(' ');
        }
        long result = SquareOfSum(a, b);
        Console.WriteLine($"Квадрат суми чисел {a} і {b} дорівнює {result}");
    }

    // Функція для обчислення (a + b)^2
    static long SquareOfSum(int a, int b)
    {
        long sum = (long)a + b;
        return sum * sum;
    }

    // Завдання 6: Обчислення значення виразу
    static void Task6()
    {
        Console.WriteLine("Введіть два числа (a b):");

        // Зчитуємо два числа
        double a, b;
        string[] input = Console.ReadLine().Split(' ');
        while (input.Length != 2 || !double.TryParse(input[0], out a) || !double.TryParse(input[1], out b))
        {
            Console.WriteLine("Будь ласка, введіть два числа через пробіл (a b):");
            input = Console.ReadLine().Split(' ');
        }

        // Додаємо відлагоджувальний вивід
        Console.WriteLine($"Введено: a = {a}, b = {b}");

        // Перевірка на ділення на нуль
        if (Math.Abs(a + b) < 0.0001)
        {
            Console.WriteLine("Помилка: ділення на нуль (a + b не може дорівнювати 0)!");
            return;
        }

        // Обчислюємо значення виразу
        double term1 = 5;
        double term2 = b / (b * b + 1); // Перевірка на b^2 + 1 завжди > 0
        double term3 = (a - b) / (a + b);

        double result = term1 + term2 + term3;

        // Виводимо результат
        Console.WriteLine($"Значення виразу для a = {a} і b = {b} дорівнює {result:F4}");
    }
}