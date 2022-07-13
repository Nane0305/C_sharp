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

        }
        static void Exercise3()
        {

        }
        static void Exercise4()
        {

        }
        static void Exercise5()
        {

        }
        static void Exercise6()
        {

        }
        static void Exercise7()
        {

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