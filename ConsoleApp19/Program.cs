namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TASK8();
        }

        static void TASK1()
        { /*  verilmish 4 reqemli ededin reqemlerinin cemini tap */
            Console.WriteLine("Enter a number");
            int a = Methods.ReadInt32("a: ", 1000, 10000);
            int lastNumb, sum = 0;
            while (a > 0)
            {
                lastNumb = a % 10;
                sum += lastNumb;
                a = a / 10;

            }
            Console.WriteLine($"Sum={sum}");
        }

        static void TASK2()
        {  /*  verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600= 1+2+3 */
            Console.WriteLine("Enter a number");
            int a = Methods.ReadInt32("a: ", 100000, 1000000);
            a = a / 1000;
            
           int sum = Methods.SumOfNumbers(a);   
            Console.WriteLine($"Sum={sum}");
        }

        static void TASK3()
        {  /*  verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi */
            Console.WriteLine("Enter a number");
            int a = Methods.ReadInt32("a: ", 100000000, 1000000000);
            a = (a- a / 1000000*1000000)/1000;

            int sum = Methods.SumOfNumbers(a);
            Console.WriteLine($"Sum={sum}");
        }

        static void TASK4()
        {  /* verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati */
            Console.WriteLine("Enter a number");
            int a = Methods.ReadInt32("a: ", 10000, 100000);
            int a1 = a / 10000;
            int a2=a%10;
            double result = Math.Pow(a1 + a2, 2);

            Console.WriteLine($"Result={result}");
        }

        static void TASK5()
        {  /* verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at. */
            Console.WriteLine("Enter a number");
            int a = Methods.ReadInt32("a: ", 100000, 1000000);
            a = (a - a / 100000 * 100000) *10 + a / 100000;
     

            Console.WriteLine($"Result={a}");
        }

        static void TASK6()
        {  /*  verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et */
            Console.WriteLine("Enter a number");
            int a = Methods.ReadInt32("a: ", 10000000, 100000000);
            a = (a - a / 10000000 * 10000000) / 10;


            Console.WriteLine($"Result={a}");
        }

        static void TASK7()
        {  /*  verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir */
            Console.WriteLine("Enter a number");
            int a = Methods.ReadInt32("a: ", 1000, 10000);
            int reverse=0;

            while (a > 0)
            {
                int n = a % 10;
                reverse = reverse * 10 + n;
                a /= 10;
            }
            a = (80000 + reverse) * 10 + 8;

                Console.WriteLine($"Result={a}");
        }

        static void TASK8()
        {  /*  Verilmis ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap */
            Console.WriteLine("Enter a number");
            int a = int.Parse(Console.ReadLine());
            int lastNumber = a % 10;
            int thirdNumber = a / 100 % 10;

            int sum =lastNumber+ thirdNumber;

            Console.WriteLine($"Result={sum}");
        }

    }
}