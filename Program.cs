using System.Text;

namespace C_sharp
{
    internal class Program
    {
        static void Exercise1()
        {
            Console.WriteLine("a:");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a > 0 || a < 101)
            {
                if (a % 3 == 0 && a % 5 != 0)
                {
                    Console.WriteLine("Fizz!");
                }
                else if (a % 5 == 0 && a % 3 != 0)
                {
                    Console.WriteLine("Buzz!");
                }
                else if (a % 3 == 0 && a % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else
                {
                    Console.WriteLine($"{a}");
                }
            }

            else
            {
                Console.WriteLine("Error! The number is out of range!");
            }
        }
        static void Exercise2()
        {
            Console.WriteLine("Enter a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter percent:");
            double b = Convert.ToDouble(Console.ReadLine());

            double res;
            res = a * b / 100;
            Console.WriteLine(res);
        }
        static void Exercise3()
        {
            Console.WriteLine("Еnter the digits of the number!");

            Console.WriteLine("Enter a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter c:");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter d:");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.Write($"{a}{b}{c}{d}\n");
        }
        static void Exercise4()
        {
            Console.WriteLine("Enter the numbers!");
            int digets = Convert.ToInt32(Console.ReadLine());

            if (digets >= 100000 && digets <= 999999)
            {
                StringBuilder numbers = new StringBuilder(digets.ToString());
                Console.WriteLine("Enter begin index:");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter end index:");
                int b = Convert.ToInt32(Console.ReadLine());

                var temp = numbers[a];
                numbers[a] = numbers[b];
                numbers[b] = temp;

                Console.WriteLine(numbers);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
        static void Exercise5()
        {
            Console.WriteLine("Enter data!");

            DateTime dateTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(dateTime.DayOfWeek.ToString());


            if (dateTime.Month == 3 || dateTime.Month == 4 || dateTime.Month == 5)
            {
                Console.WriteLine("Spring");
            }

            else if (dateTime.Month == 6 || dateTime.Month == 7 || dateTime.Month == 8)
            {
                Console.WriteLine("Summer");
            }

            else if (dateTime.Month == 9 || dateTime.Month == 10 || dateTime.Month == 11)
            {
                Console.WriteLine("Autumn");
            }

            else if (dateTime.Month == 12 || dateTime.Month == 1 || dateTime.Month == 2)
            {
                Console.WriteLine("Winter");
            }
        }
        static void Exercise6()
        {
            double temper;
            Console.WriteLine("Select the degrees to which you want to translate:\n" +
                "1. Celsius.\n" + "2. Fahrenheit.\n");
            int switch_on = Convert.ToInt32(Console.ReadLine());
            switch (switch_on)
            {
                case 1:
                    {
                        Console.Write("Еnter the F temperature: ");
                        temper = Convert.ToDouble(Console.ReadLine());
                        double resC = (temper - 32) / 1.8;
                        Console.WriteLine($"C = {resC}");
                    }
                    break;
                case 2:
                    {
                        Console.Write("Еnter the C temperature: ");
                        temper = Convert.ToDouble(Console.ReadLine());
                        double resF = temper * 1.8 + 32;
                        Console.WriteLine($"F = {resF}");
                    }
                    break;
            }
        }
        static void Exercise7()
        {
            Console.WriteLine("Enter a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b:");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                int tmp = a;
                a = b;
                b = tmp;
                Console.WriteLine($"Range: {a} - {b}");
            }

            for (int i = a; i < b; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($" {i} ");
                }
            }
        }
        static void Main(string[] args)
        {
            Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            //Exercise5();
            //Exercise6();
            //Exercise7();
        }
    }
}