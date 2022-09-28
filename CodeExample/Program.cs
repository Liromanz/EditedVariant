using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("**********************************\r");
            Console.WriteLine("*  Консольный калькулятор на C#  *\r");
            Console.WriteLine("**********************************\r");

            do
            {
                Console.WriteLine("\nВыберите операцию из списка:");
                Console.WriteLine("\t1 - Сложение двух чисел");
                Console.WriteLine("\t2 - Вычесть из первого второе");
                Console.WriteLine("\t3 - Перемножить два числа");
                Console.WriteLine("\t4 - Разделить первое на второе");
                Console.WriteLine("\t5 - Возвести первое число в степень N - (второе число)");
                Console.WriteLine("\t6 - Найти квадратный корень из числа");
                Console.WriteLine("\t7 - Найти 1% от числа");
                Console.WriteLine("\t8 - Найти факториал числа");
                Console.WriteLine("\t9 - Выйти из программы");
                Console.WriteLine("\nВведите свой выбор: ");

                int op;
                while (!int.TryParse(Console.ReadLine(), out op))
                {
                    Console.WriteLine("Ошибка ввода! Введите номер операции:");
                }
                if (op > 0 && op < 9) // см. пункт 1 в дополнении
                {
                    //сразу создам две переменные здесь, чтобы в будущем с ними работать в жтом if
                    //см. пункт 2 в дополнении
                    double cleanNum1 = 0;
                    double cleanNum2 = 0;

                    Console.WriteLine("\nВведите число и нажмите enter: ");
                    string numInput1 = Console.ReadLine();

                    while (!double.TryParse(numInput1, out cleanNum1))
                    {
                        Console.WriteLine("\nОшибка ввода! введите число: ");
                        numInput1 = Console.ReadLine();
                    }


                    if (op == 1 || op == 2 || op == 3 || op == 4 || op == 5) //см. пункт 2 в дополнении
                    {
                        Console.WriteLine("\nВведите число и нажмите enter: ");
                        string numInput2 = Console.ReadLine();

                        while (!double.TryParse(numInput2, out cleanNum2))
                        {
                            Console.WriteLine("\nОшибка ввода! введите число: ");
                            numInput2 = Console.ReadLine();
                        }
                    }

                    switch (op) //см. пункт 3 в дополнении
                    {
                        case 1:
                            Console.WriteLine($"\n{cleanNum1} + {cleanNum2} = " + (cleanNum1 + cleanNum2));
                            Console.WriteLine("----------------------------\n");
                            break;
                        case 2:
                            Console.WriteLine($"\n{cleanNum1} - {cleanNum2} = " + (cleanNum1 - cleanNum2));
                            Console.WriteLine("----------------------------\n");
                            break;
                        case 3:
                            Console.WriteLine($"\n{cleanNum1} * {cleanNum2} = " + (cleanNum1 * cleanNum2));
                            Console.WriteLine("----------------------------\n");
                            break;
                        case 4:
                            while (cleanNum2 == 0)
                            {
                                Console.WriteLine("\nДеление на ноль запрещено!");

                                Console.WriteLine("\nВведите второе число и нажмите enter: \n");
                                cleanNum2 = Convert.ToDouble(Console.ReadLine());
                            }
                            Console.WriteLine($"\n{cleanNum1} / {cleanNum2} = " + (cleanNum1 / cleanNum2));
                            Console.WriteLine("----------------------------\n");
                            break;
                        case 5:
                            Console.WriteLine($"\n{cleanNum1} ^ {cleanNum2} = " + Math.Pow(cleanNum1, cleanNum2));
                            Console.WriteLine("----------------------------\n");
                            break;
                        case 6:
                            Console.WriteLine($"\nКвадратный корень из {cleanNum1} = " + Math.Sqrt(cleanNum1));
                            Console.WriteLine("----------------------------\n");
                            break;
                        case 7:
                            Console.WriteLine($"\n1% от {cleanNum1} = " + (cleanNum1 / 100));
                            Console.WriteLine("----------------------------\n");
                            break;
                        case 8:
                            long fact = 1;
                            if (fact == 0)
                            {
                                Console.WriteLine($"\nФакториал числа 0 = 1");
                            }
                            else
                            {
                                for (int i = 1; i <= cleanNum1; i++)
                                {
                                    fact *= i;
                                }
                                Console.WriteLine($"\nФакториал числа {cleanNum1} = " + (fact));
                            }
                            break;
                        default:
                            Console.WriteLine("\nОшибка, невозможно произвести вычисление!\n");
                            op = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
                else if (op == 9)
                {
                    endApp = true;
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("Такой операции не существует!");
                }
            } while (!endApp);
        }
    }
}