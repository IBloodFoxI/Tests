using System;

class Calculator
{
    static void Main()
    {
        int choice;
        double n1, n2;
        bool exit = false;

        //первый цикл - while
        while (!exit)
        {
            //Выбор операции 
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложить 2 числа");
            Console.WriteLine("2. Вычесть 1-ое из 2-го");
            Console.WriteLine("3. Перемножить 2 числа");
            Console.WriteLine("4. Разделить 1-ое на 2-ое");
            Console.WriteLine("5. Возвести в степень N 1-ое число");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1% от числа");
            Console.WriteLine("8. Найти факториал числа");
            Console.WriteLine("9. Выйти из программы");

            choice = Convert.ToInt32(Console.ReadLine());

            //Операции
            switch (choice)
            {
                //Сложение
                case 1:
                    Console.WriteLine("Введите первое число:");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ответ: " + (n1 + n2));
                    break;
                //Разность
                case 2:
                    Console.WriteLine("Введите первое число:");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ответ: " + (n1 - n2));
                    break;
                //Умножение
                case 3:
                    Console.WriteLine("Введите первое число:");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ответ: " + (n1 * n2));
                    break;
                //Деление
                case 4:
                    Console.WriteLine("Введите первое число:");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    if (n2 != 0)
                    {
                        Console.WriteLine("Ответ: " + (n1 / n2));
                    }
                    else
                    {
                        Console.WriteLine("На ноль делить нельзя!");
                    }

                    break;
                //Степень
                case 5:
                    Console.WriteLine("Введите число:");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите степень:");
                    int stepen = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(n1 + " в степени " + stepen + " равно " + Math.Pow(n1, stepen));
                    break;
                //Корень
                case 6:
                    Console.WriteLine("Введите число:");
                    n1 = Convert.ToDouble(Console.ReadLine());

                    if (n1 >= 0)
                    {
                        Console.WriteLine("Ответ: " + Math.Sqrt(n1));
                    }
                    else
                    {
                        Console.WriteLine("Из отрицательного числа нельзя извлекать корень!");
                    }

                    break;
                //Поиск 1% от числа
                case 7:
                    Console.WriteLine("Введите число:");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ответ: " + (n1 / 100));
                    break;
                //Факториал
                case 8:
                    Console.WriteLine("Введите число:");
                    int factorialNum = Convert.ToInt32(Console.ReadLine());
                    int factorial = 1;

                    if (factorialNum >= 0)
                    {
                        //второй цикл - for
                        for (int i = 1; i <= factorialNum; i++)
                        {
                            factorial *= i;
                        }

                        Console.WriteLine("Ответ: " + factorial);
                    }
                    else
                    {
                        Console.WriteLine("Факториал отрицательного числа не определен!");
                    }

                    break;
                //Выход из программы
                case 9:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Некорректный ввод, попробуйте снова.");
                    break;
            }

            Console.WriteLine();
        }
    }
}