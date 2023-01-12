using System;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TASK15();
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

        static void TASK14()
        { /*   4 dene eded daxil et. Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
           6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
           Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel.
           Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
           Neticenin 60 % tap. Cavabin axirina 60 artir. Neticeden 18% cix. */
            Console.WriteLine("Enter numbers");
            int a = Methods.ReadInt32("a: ", 100000, 1000000);
            int b = Methods.ReadInt32("b: ", 100000, 1000000);
            int c = Methods.ReadInt32("c: ", 100000, 1000000);
            int d = Methods.ReadInt32("d: ", 1000000, 10000000);

            int sum = a / 1000 + b / 1000 + c / 1000 + d % 1000;

            d = d / 10000;
            d = (d % 10) * (d / 10 % 10) * (d / 100);
            double result = (double)((sum - d) * 60 / 100)*100+60;
            result = result - result * 18 / 100;

            Console.WriteLine($"Result={result}");
        }

        static void TASK15()
        { /*   5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli . 
          1 denesi 7 reqemli olsun. 3 reqemli ededlerin cemini tap ve 
          cavabin axirdan 2 denesini kvadratini tap. Sonra alinan cavabin ustune 
          3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.
          Cavabdan 7 reqemli ededin son 5 reqemini cix. Alinan neticenin uzerine 
          6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.
          Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.
          Cavabin axirina 11 artir. Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.
          Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et. */
            Console.WriteLine("Enter numbers");
            int a = Methods.ReadInt32("a: ", 100, 1000);
            int b = Methods.ReadInt32("b: ", 100, 1000);
            int c = Methods.ReadInt32("c: ", 100000, 1000000);
            int d = Methods.ReadInt32("d: ", 100000, 1000000);
            int e = Methods.ReadInt32("e: ", 1000000, 10000000);
           
            int number = (a + b) % 100;
            number = number * number + (a*1000+b)-e%100000+((c+d)%1000);

            int temp = e;
            temp = Methods.SumOfNumbers(temp);
            temp = Methods.RevrseOfNumber(temp);

            number = (number + temp) *100+11;

            int reverse_e = Methods.RevrseOfNumber(e);

            int i = 1;
            int oddNumber = 0;

            while (reverse_e > 0)
            {
                int lastNumber = reverse_e % 10;
                reverse_e /= 10;
                if (i % 2 != 0)
                {
                    oddNumber = oddNumber * 10 + lastNumber;
                }
                i++;
            }

            number = number - oddNumber;

            Console.WriteLine(number);

            int numberLast = number % 10;
            number = (number / 10 * 100 + 88)*10 + numberLast;

            Console.WriteLine($"Result={number}");


        }


    }

    }
