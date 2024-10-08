using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите первое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите оператор (+, -, *, /, ^, sqrt, sin, cos):");
            string op = Console.ReadLine();

            double result = 0;

            if (op == "sqrt") // Квадратный корень
            {
                result = Sqrt(num1);
            }
            else if (op == "sin") // Синус
            {
                result = Sin(num1);
            }
            else if (op == "cos") // Косинус
            {
                result = Cos(num1);
            }
            else
            {
                Console.WriteLine("Введите второе число:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: Деление на ноль невозможно.");
                            continue;
                        }
                        break;
                    case "^": // Возведение в степень
                        result = Power(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Ошибка: Неверный оператор.");
                        continue;
                }
            }

            Console.WriteLine($"Результат: {result}");

            Console.WriteLine("Хотите выполнить еще одно действие? (да/нет)");
            string response = Console.ReadLine().ToLower();
            if (response != "да")
            {
                break;
            }
        }
    }

    static double Power(double baseNum, double exponent)
    {
        return Math.Pow(baseNum, exponent);
    }

    static double Sqrt(double number)
    {
        return Math.Sqrt(number);
    }

    static double Sin(double angle)
    {
        return Math.Sin(angle);
    }

    static double Cos(double angle)
    {
        return Math.Cos(angle);
    }

    // Логические операции
    static void LogicalOperations(bool x, bool y)
    {
        Console.WriteLine($"x AND y: {x && y}");
        Console.WriteLine($"x OR y: {x || y}");
        Console.WriteLine($"NOT x: {!x}");
        Console.WriteLine($"NOT y: {!y}");
        Console.WriteLine($"x XOR y: {x ^ y}"); // Исключающее ИЛИ
        Console.WriteLine($"x equals y: {x == y}");
    }
}
