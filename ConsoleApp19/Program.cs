namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TASK13();
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

        static void TASK9()
        {  /*  9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389=12439 */
            int a = Methods.ReadInt32("a: ", 100000000, 1000000000);

            int reverse = 0;
            int lastNumber;

            while (a > 0)
            {
                lastNumber = a % 10;
                reverse = reverse * 10 + lastNumber;
                a /= 10;
            }
            a = reverse;
            reverse = 0;
            int i = 1;
            int oddNumber = 0;
           

            while (a > 0)
            {
                lastNumber = a % 10;
                a /= 10;
                if (i % 2 != 0)
                {
                    oddNumber = oddNumber * 10 + lastNumber;
                }
                i++;
            }
            Console.WriteLine($"OddNumber={oddNumber}");
            }

        static void TASK10()
        {  /*  9 reqemli ededdi tek yerde dayananlardan bir eded duzlet, 
            sonra cut yerde dayanlarinda bir eded duzlet, sonra onlari topla */
            int a = Methods.ReadInt32("a: ", 100000000, 1000000000);
            
            int reverse = 0;
            int lastNumber;

            while (a > 0)
            {
                lastNumber = a % 10;
                reverse = reverse * 10 + lastNumber;
                a /= 10;
            }
            a = reverse;
            reverse = 0;
            int i = 1;
            int oddNumber = 0;
            int evenNumber = 0;

            while (a > 0)
            {
                lastNumber = a % 10;
                a /= 10;
                if (i % 2 == 0)
                {
                    evenNumber = evenNumber * 10 + lastNumber;
                }
                else
                {
                    oddNumber = oddNumber * 10 + lastNumber;
                }
                i++;
            }
            Console.WriteLine($"Sum=evenNumber+oddNumber={evenNumber}+{oddNumber}={evenNumber + oddNumber}");
                 

        }

        static void TASK11()
        { /*  8 reqemli ededin reqemlerini iki -iki qruplashdir.
    Qruplarin cemini tap. Alinan cavabin axirina 99 artir. Sonra cavabin ozunden onun 18% ni cix; */
            Console.WriteLine("Enter a number");
            int a = Methods.ReadInt32("a: ", 10000000, 100000000);
            int lastNumb, sum = 0;
            while (a > 0)
            {
                lastNumb = a % 100;
                sum += lastNumb;
                a = a / 100;

            }
            double result = (sum * 100 + 99)-((double)(sum*100+99)*18/100);

            Console.WriteLine($"Sum={result}");
        }

        static void TASK12()
        { /*  2 dene 5 reqemli eded daxil et.I ededin reqemleri ceminin usutne 
           II ededin reqemleri hasilini gel. Neticenin axirina I ededin en axiinci reqemini artir. */
            Console.WriteLine("Enter numbers");
            int a = Methods.ReadInt32("a: ", 10000, 100000);
            int b = Methods.ReadInt32("b: ", 10000, 100000);

            int sum = Methods.SumOfNumbers(a);

            int product = 1, lastNumb;
            
            while (b > 0)
            {
                lastNumb = b % 10;
                product *= lastNumb;
                b = b / 10;
            }

            int result = (sum + product) * 10 + a % 10;

            Console.WriteLine($"Result={result}");
        }

        static void TASK13()
        { /*  3 dene 5 reqemli eded var.Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet. 
         Alinan neticeleri topla. Yekunda alian cavabin 50%-ni hemin ededin uzerine gel. */
            Console.WriteLine("Enter numbers");
            int a = Methods.ReadInt32("a: ", 10000, 100000);
            int b = Methods.ReadInt32("b: ", 10000, 100000);
            int c = Methods.ReadInt32("c: ", 10000, 100000);

            a = a / 10000 * 10 + a % 10;
            b = b / 10000 * 10 + b % 10;
            c = c / 10000 * 10 + c % 10;

            double result = (a + b + c) + ((double)(a + b + c) * 50 / 100);

            Console.WriteLine($"Result={result}");
        }


    }

    }
