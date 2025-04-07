class InputValidator
{
    public static int GetValidInteger(string prompt, int min = int.MinValue, int max = int.MaxValue)
    {
        int value;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
                return value;
            Console.WriteLine($"Ошибка! Введите целое число от {min} до {max}.");
        }
    }

    public static double GetValidDouble(string prompt)
    {
        double value;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out value))
                return value;
            Console.WriteLine("Ошибка! Введите число.");
        }
    }
}
