using System;

namespace _01._02._2023HM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            //1
            /*Console.WriteLine("Введите число в диопазоне от 0 до 100");
            int A = int.Parse(Console.ReadLine());
            if (A>100 || A<0)
            {
                Console.WriteLine("Вы ввели число не того диапозона");
            }
            if (A % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (A % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (A % 3 == 0 && A % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (A%3!=0 && A%5!=0)
            {
                Console.WriteLine("Не кратное число " + A);
            }*/

            //2
            /*Console.WriteLine("Введите первое число(значение)");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число(процент)");
            int C = int.Parse(Console.ReadLine());
            int Res = B % C;
            Console.WriteLine("Результат = " + Res);*/

            //3
            /*Console.WriteLine("Введите 4 цифры");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            Console.WriteLine("Сборное число" + A + B + C + D);*/

            //4
            /*Console.WriteLine("Введите шестизначное число");
            int A = int.Parse(Console.ReadLine());
            if (A > 999999)
            {
                Console.WriteLine("Это не шестизначное число");
            }*/
            ///////////////////////////
            ///


            //5
            /* Console.WriteLine("Введите дату месяца ");
            int A = int.Parse(Console.ReadLine());

            switch (A)
            {
                case 1:
                    {
                       Console.WriteLine("Январь месяц");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Февраль месяц");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Март месяц");
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Апрель месяц");
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Май месяц");
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("Июнь месяц");
                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("Июль месяц");
                    }
                    break;
                case 8:
                    {
                        Console.WriteLine("Август месяц");
                    }
                    break;
                case 9:
                    {
                        Console.WriteLine("Сентябрь месяц");
                    }
                    break;
                case 10:
                    {
                        Console.WriteLine("Октябрь месяц");
                    }
                    break;
                case 11:
                    {
                        Console.WriteLine("Ноябрь месяц");
                    }
                    break;
                case 12:
                    {
                        Console.WriteLine("Декабрь месяц");
                    }
                    break;



            }*/

            //7
            Console.WriteLine("Введите два числа");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int Count = 0;
            if (A % 2 == 0 )
            {
                Count++;
                //Console.WriteLine("Кол-во целых чисел = " + Count);
            }
            if (B%2==0)
            {
                Count++;
                Console.WriteLine("Кол-во целых чисел = " + Count);
            }
            
            //6
            /*Console.WriteLine("Введите температуру");
            int temp = int.Parse(Console.ReadLine());
            Console.WriteLine("1)Перевести из Фаренгейта в Градусы Цельсия, 2) Перевести из Градусы Цельсия в Фаренгейта");
            int b = int.Parse(Console.ReadLine());
            int Result_1 = 0;
            if (b==1)
            {
              Result_1 = (temp - 32) * 5 / 9;// формула перевода
            }
            Console.WriteLine("Резульатат в Цельсиях = " + Result_1);
            int Result = 0;
            if (b==2)
            {
                Result = (temp * 9 / 5)+32;// формула перевода
            }
            Console.WriteLine("Результат в Фаренгейтах = " + Result);*/





        }

    }
    /*enum Season
    {
            Январь = 1,
            Февраль =2,
            Март =3,
            Апрель = 4,
            Май = 5,
            Юинь =6,
            Июль = 7,
            Август = 8,
            Сентябрь = 9,
            Октябрь = 10,
            Ноябрь = 11,
            Декабрь = 12
    }*/
}

