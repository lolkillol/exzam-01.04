using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Калькулятор скидок ===\n");

        // Шаг 1: запрос суммы
        Console.Write("Введите сумму покупки (в рублях): ");
        string? input = Console.ReadLine();

        // Шаг 2: проверка на null и преобразование в число
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Ошибка: вы ничего не ввели.");
            return;
        }

        if (!decimal.TryParse(input, out decimal sum))
        {
            Console.WriteLine("Ошибка: введите корректную сумму.");
            return;
        }

        if (sum < 0)
        {
            Console.WriteLine("Ошибка: сумма не может быть отрицательной.");
            return;
        }

        // Шаг 3: расчёт скидки
        decimal discountPercent = 0m;
        decimal discountAmount = 0m;
        decimal total = sum;

        if (sum > 1000)
        {
            discountPercent = 10m;
            discountAmount = sum * 0.10m;
            total = sum - discountAmount;
        }
        else if (sum > 500)
        {
            discountPercent = 5m;
            discountAmount = sum * 0.05m;
            total = sum - discountAmount;
        }
        else
        {
            discountPercent = 0m;
            discountAmount = 0m;
        }

        // Шаг 4: вывод результатов
        Console.WriteLine("\n--- Результат ---");
        Console.WriteLine($"Сумма покупки: {sum:F2} руб.");
        Console.WriteLine($"Скидка: {discountPercent:F0}% ({discountAmount:F2} руб.)");
        Console.WriteLine($"Итоговая сумма к оплате: {total:F2} руб.");
    }
}