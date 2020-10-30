//Вариант № 19
//1. Из пяти целых ненулевых положительных чисел найти самое наименьшее число.
//2. Дан набор, состоящий из пяти целых ненулевых чисел. Найти количество положительных чисел в этом наборе.
//3. Дано целое положительное число N, лежащее в диапазоне от 1 до 999. Вывести его строку-описание вида «четное двузначное число», «нечетное трехзначное число» и т. д.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR11
{
    class Program
    {
        static void Main(string[] args)
        {
            int min;
            int v = 0;
            int chislo = 0;

            //1. Из пяти целых ненулевых положительных чисел найти самое наименьшее число.

            Console.WriteLine("\n___________________Задание 01___________________\n");
            Console.WriteLine("\nИз пяти целых ненулевых положительных чисел найти самое наименьшее число.\n");
     m01:
            Console.WriteLine("\nВведите целое число:");
            try
            {
                chislo = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Ошибка!Введен некорректный формат числа! \n");
                Console.WriteLine("Пожалуйста попробуйте снова ввести 5 положительный целых чисел");
                v = 0;
                goto m01;
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Ошибка! Переполнение.");
                Console.WriteLine("Пожалуйста попробуйте снова ввести 5 положительный целых чисел.");
                v = 0;
                goto m01;
            }
            if (chislo <= 0)
            {
                Console.WriteLine("Ошибка! Число <= 0");
                Console.WriteLine("Пожалуйста попробуйте снова ввести 5 положительный целых чисел.");
                v = 0;
                goto m01;
            }
            min = chislo;
            while (v < 4)
            {
                Console.WriteLine("Введите целое число:");
                try
                {
                    chislo = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Ошибка! Введен некорректный формат числа");
                    Console.WriteLine("Пожалуйста попробуйте снова ввести 5 положительный целых чисел.");
                    v = 0;
                    goto m01;
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine("Ошибка! Переполнение");
                    Console.WriteLine("Пожалуйста попробуйте снова ввести 5 положительный целых чисел.");
                    v = 0;
                    goto m01;
                }
                if (chislo > 0)
                {
                    goto m03;
                }
                else
                {
                    Console.WriteLine("Ошибка! Число <= 0");
                    Console.WriteLine("Пожалуйста попробуйте снова ввести 5 положительный целых чисел.");
                    v = 0;
                    goto m01;
                }
     m03:
                if (chislo < min)
                {
                    min = chislo;
                }
                ++v;
            }
            try
            {
                Console.WriteLine("Наименьшее число: {0}", min);
            }
            catch (System.ArgumentNullException)
            {
                Console.WriteLine("Отсутствие значений");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("У переменных неправильный формат");
            }

            ////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n___________________Задание 02___________________\n");
            Console.WriteLine("Дан набор, состоящий из пяти целых ненулевых чисел. Найти количество положительных чисел в этом наборе.");

            int chet = 0;
     m04:
            Console.Write("\nВведите размерность массива(5):\t");
            int elementsCount = int.Parse(Console.ReadLine());
            int[] Massiv = new int[elementsCount]; 

            if (elementsCount != 5)
            {
               Console.Write("Пожалуйста введите размерность массива - 5 (по условию задачи). \n");
               goto m04;
            }
     m05:
            for (int i = 0; i < Massiv.Length; i++)
            {
                Console.Write("Введите элемент массива:\t");
                 try 
                {
                Massiv[i] = int.Parse(Console.ReadLine());
                }
                 catch (System.FormatException)
                 {
                     Console.WriteLine("Ошибка! Введен некорректный формат числа");
                     Console.WriteLine("Пожалуйста попробуйте cнова.\n");
                     chet = 0;
                     goto m05;
                 }
                 catch (System.OverflowException)
                 {
                     Console.WriteLine("Ошибка! Переполнение");
                     Console.WriteLine("Пожалуйста попробуйте снова.\n");
                     chet = 0;
                     goto m05;
                 }
                 if (Massiv[i] < 1 && Massiv[i] >= 0)
                 {
                     Console.WriteLine("Ошибка! Элемент массива = 0");
                     Console.WriteLine("Пожалуйста попробуйте снова.\n");
                     chet = 0;
                     goto m05;
                 }

                if (Massiv[i] > 0)
                {
                    chet++;
                }
            }
                {
                    Console.WriteLine("Количество положительных элементов массива: {0}", chet);
                }



                ////////////////////////////////////////////////////////////////////////
                Console.WriteLine("\n___________________Задание 03___________________\n");
                Console.WriteLine("Дано целое положительное число N, лежащее в диапазоне от 1 до 999.\nВывести его строку-описание вида «четное двузначное число»,\n«нечетное трехзначное число» и т. д.");
                int a = 0;
     m06:
                Console.WriteLine("Введите число от 1 до 999:");
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Ошибка!Введен некорректный формат числа");
                    goto m06;
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine("Ошибка!Переполнение переменной");
                    goto m06;
                }
                if ((a > 0) && (a < 1000))
                {
                    goto m07;
                }
                else
                {
                    Console.WriteLine("Ошибка!Число не от 1 до 999!");
                    Console.WriteLine("Попробуйте снова.\n");
                    goto m06;
                }
     m07:
            switch (a % 2) {
                case (0):
                    //чётные
                    switch (Convert.ToString(a).Length)
                    {
                        case (1):
                            Console.WriteLine("Однозначное чётное число.\n");    
                            break;
                        case (2):
                            Console.WriteLine("Двухзначное чётное число.\n");
                            break;
                        case (3):
                            Console.WriteLine("Трёххзначное чётное число.\n");
                            break;
                    }
                    break;
                case (1):
                    //нечётные
                    switch (Convert.ToString(a).Length)
                    {
                        case (1):
                            Console.WriteLine("Однозначное нечётное число.\n");
                            break;
                        case (2):
                            Console.WriteLine("Двухзначное нечётное число.\n");
                            break;
                        case (3):
                            Console.WriteLine("Трёхзначное нечётное число.\n");
                            break;
                    }
                    break;
            }
            }
        }
    }

