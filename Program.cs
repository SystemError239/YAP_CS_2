using System;


// Класс квадратного уравнения


class Program
{
    static void Main()
    {
        QuadraticEquation equation = null;

        while (true)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Ввести уравнение");
            Console.WriteLine("2. Найти корни уравнения");
            Console.WriteLine("3. Увеличить коэффициенты (++))");
            Console.WriteLine("4. Уменьшить коэффициенты (--))");
            Console.WriteLine("5. Посчитать дискриминант");
            Console.WriteLine("6. Есть ли корни?");
            Console.WriteLine("7. Сравнить с другим уравнением");
            Console.WriteLine("8. Выход");

            int choice = InputValidator.GetValidInteger("Выберите пункт: ", 1, 8);

            switch (choice)
            {
                case 1:
                    equation = ReadEquation();
                    Console.WriteLine("Уравнение: " + equation.ToString());
                    break;
                case 2:
                    if (equation != null)
                    {
                        var roots = equation.GetRoots();
                        if (roots.Length == 0)
                            Console.WriteLine("Корней нет");
                        else
                            Console.WriteLine("Корни: " + string.Join(", ", roots));
                    }
                    else Console.WriteLine("Сначала введите уравнение");
                    break;
                case 3:
                    if (equation != null)
                    {
                        equation = ++equation;
                        Console.WriteLine("Теперь: " + equation.ToString());
                    }
                    else Console.WriteLine("Сначала введите уравнение");
                    break;
                case 4:
                    if (equation != null)
                    {
                        equation = --equation;
                        Console.WriteLine("Теперь: " + equation.ToString());
                    }
                    else Console.WriteLine("Сначала введите уравнение");
                    break;
                case 5:
                    if (equation != null)
                    {
                        double d = equation;
                        Console.WriteLine("Дискриминант: " + d.ToString());
                    }
                    else Console.WriteLine("Сначала введите уравнение");
                    break;
                case 6:
                    if (equation != null)
                    {
                        bool hasRoots = (bool)equation;
                        Console.WriteLine(hasRoots ? "Корни есть" : "Корней нет");
                    }
                    else Console.WriteLine("Сначала введите уравнение");
                    break;
                case 7:
                    if (equation != null)
                    {
                        Console.WriteLine("Введите второе уравнение:");
                        var other = ReadEquation();
                        if (equation == other) Console.WriteLine("Уравнения равны");
                        if (equation != other) Console.WriteLine("Уравнения не равны");

                    }
                    else Console.WriteLine("Сначала введите уравнение");
                    break;
                case 8:
                    return;
            }
        }
    }

    static QuadraticEquation ReadEquation()
    {
        double a = InputValidator.GetValidDouble("Введите a: ");
        double b = InputValidator.GetValidDouble("Введите b: ");
        double c = InputValidator.GetValidDouble("Введите c: ");
        return new QuadraticEquation(a, b, c);
    }
}
