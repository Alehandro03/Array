using System;

namespace ВoubleАrray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Поменять знак на противоположный у всех элементов, расположенных по краям двумерного массива NxM.
            //Изменяющиеся элементы должны образовать "рамочку" толщиной в 1 элемент.
            //Примечание: здесь "NxM" означает, что массив прямоугольный, произвольного размера.
            //Наиболее наглядно такие задачи показывают себя на массивах, например, 5x8.


            //Console.WriteLine("Введит длинну массива и толшену массива");

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //int[,] mas = new int[b, a];


            //Random rnd = new Random();

            //for (int i = 0; i < mas.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mas.GetLength(1); j++)
            //    {
            //        mas[i, j] = rnd.Next(100);
            //        Console.Write("{0,4}", mas[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("---------------------------------");

            //for (int i = 0; i < mas.GetLength(0); i++)
            //{

            //    for (int j = 0; j < mas.GetLength(1); j++)
            //    {
            //        if ((i != 0 && j == 0) || (i == 0 && j != 0) || (i ==0 && j ==0) || (i == b-1 && j == a-1) || (i ==b-1 && j!= a-1) || (i != b-1) && (j == a-1))
            //        {
            //            mas[i, j] *= -1;

            //        }
            //        Console.Write("{0,4}", mas[i, j]);


            //    }
            //    Console.WriteLine();
            //}


            //Задание 2
            //Заполнить матрицу 9x9 таблицей умножения:

            //int[,] mas = new int[10, 10];

            //for ( int i = 1; i < 10; i++)
            //{
            //    for(int j = 1; j < 10; j++)
            //    {

            //            mas[i, j] = i* j;

            //        Console.Write("{0,4}", mas[i, j]);
            //    }
            //    Console.WriteLine();

            //}


            // Задание 3
            //Заполнить квадратную матрицу NxN (произвольного размера) нулями и единицами так,
            //как расположены клетки на шахматной доске, где 0 - "черное", 1 - "белое".
            //Левое нижнее поле на шахматной доске всегда черное.
            //Обратите внимание - нумерация элементов массива идет сверху вниз, и слева направо.
            //То есть, левое нижнее поле - это поле в последней строке и 0-м столбце.

            //Console.WriteLine("Введит длинну массива и тошену массива");

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //int[,] mas = new int[b, a];

            //if(a % 2!= 0 && b % 2 != 0)
            //{
            //    for (int i = 0; i < mas.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < mas.GetLength(1); j++)
            //        {
            //            if (i % 2 != 0 && j % 2 == 0 ||i % 2 ==0 && j % 2 !=0)
            //            {
            //                mas[i, j] = 1;
            //            }
            //            else
            //            {
            //                mas[i, j] = 0;
            //            }
            //            Console.Write("{0,4} " , mas[i, j]);
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < mas.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < mas.GetLength(1); j++)
            //        {
            //            if ( i % 2 != 0 && j % 2 == 0 || i % 2 == 0 && j % 2 != 0)
            //            {
            //                mas[i, j] = 0;
            //            }
            //            else
            //            {
            //                mas[i, j] = 1;
            //            }
            //            Console.Write("{0,4} ", mas[i, j]);
            //        }
            //        Console.WriteLine();
            //    }

            //}

            //Задание 4 
            //Зрительный зал театра имеет N рядов по M мест в каждом ряду.
            //Их можно представить в виде двумерного массива NxM.
            //Если место занято - в массиве стоит значение "1". Если свободно - "0".
            //Образец массива задать вручную, инициализацией в момент создания.
            //На готовом массиве проверить соблюдение "антиковидного правила"
            //(нет двух занятых мест в одном ряду, расположенных рядом, но пропусков может быть сколько угодно).
            //Сделать по оптимальному алгоритму (если нашли два занятых кресла рядом в одном ряду - прервать циклы обхода матрицы)



            //int[,] mas = new int[4, 5]
            //{
            //   { 0 , 0 , 0 , 1 , 0 },
            //   { 0 , 0 , 0 , 0 , 1 },
            //   { 0 , 0 , 1 , 0 , 1 },
            //   { 0 , 1 , 0 , 0 , 0 }
            //};




            //Console.WriteLine("---------------------------------");

            //Console.WriteLine("Введите ряд: ");
            //int x = int.Parse(Console.ReadLine());

            //Console.WriteLine("Введите место: ");
            //int y = int.Parse(Console.ReadLine());

            //bool is_rule = true;
            //for (int i = 0; i < mas.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mas.GetLength(1) ; j++)
            //    {
            //        if (mas[i,j] == 1 && mas[x, y+1] == 1 || mas[x, y-1] == 1)
            //        {
            //            is_rule = false;
            //            break;
            //        }

            //    }
            //    if (!is_rule) break;

            //}
            //if (is_rule) Console.WriteLine("Рассадка не нарушает ковидных мер");
            //else Console.WriteLine("Рассадка не по правилам");


            //Задание 5
            //Фирма имеет 10 магазинов.
            //Доходы каждого магазина за полугодие (6 месяцев с номерами 0-5) хранятся в двумерном вещественном массиве.
            //Заполнить массив случайными вещественными числами. Высчитать:
            //а) суммарный доход по каждому магазину;
            //б) средний доход по каждому месяцу;
            //в) мин.и макс. доход за весь период.

            int[,] magazine = new int[10, 6];

            Random rnd = new Random();


            for (int i = 0; i < magazine.GetLength(0); i++)
            {

                for (int j = 0; j < magazine.GetLength(1); j++)
                {
                    magazine[i, j] = rnd.Next(10000);

                    Console.Write("{0,4}    ", magazine[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("___________________________________");

            int sum = 0;
            int[] sums_by_monts = new int[6] { 0, 0, 0, 0, 0, 0 };
            int min = magazine[0, 0];
            int max = magazine[0, 0];
            Console.WriteLine("Сумма доход по каждому магазин:");
            for (int i = 0; i < magazine.GetLength(0); i++)
            {

                for (int j = 0; j < magazine.GetLength(1); j++)
                {

                    sum += magazine[i, j];
                    sums_by_monts[j] += magazine[i, j];
                    if (magazine[i, j] < min)
                    {
                        min = magazine[i, j];
                    }
                    if (magazine[i, j] > max)
                    {
                        max = magazine[i, j];
                    }
                }

                Console.Write($"{i + 1} - {sum}");
                Console.WriteLine();
            }

            Console.WriteLine("Средний доход по каждому магазин:");
            for (int i = 0; i < sums_by_monts.Length; i++)
            {
                Console.WriteLine($"{i + 1} - й магазин: {(sums_by_monts[i] / magazine.GetLength(0))}");
            }
            Console.WriteLine($"Мин. доход = {min} , Макс. доход = {max}");


            //Задание 6 
            //Найти количество элементов массива, которые больше всех своих соседей одновременно. 
            //Примечание: соседями элемента считать только 4 потенциальных соседа:
            //на 1 выше, на 1 ниже, на 1 левее и на 1 правее.
            //Обязательно учесть выход за границы массива!
            //При определении критерия, считать сумму соседей для каждого элемента, даже для элемента [0;0]
            //(у него, кстати, будет всего два соседа - [0; 1] и [1; 0]).

            //Console.WriteLine("Введите длинну массива");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите ширину массива");
            //int b = int.Parse(Console.ReadLine());

            //int[,] mas = new int[b, a];

            //Random rnd = new Random();

            //for (int i = 0; i < mas.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mas.GetLength(1); j++)
            //    {
            //        mas[i, j] = rnd.Next(50);
            //        Console.Write("{0,4}  ", mas[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("_____________________________________");
            //int count = 0;
            //int sum = 0;
            //for (int i = 0; i < mas.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mas.GetLength(1); j++)
            //    {
            //        sum = (i > 0 ? mas[i - 1, j] : 0)
            //            + (i < mas.GetLength(0) - 1 ? mas[i + 1, j] : 0)
            //            + (j > 0 ? mas[i, j - 1] : 0)
            //            + (j < mas.GetLength(1) - 1 ? mas[i, j + 1] : 0);

            //        if (mas[i, j] > sum) count++;
            //    }

            //}
            //Console.WriteLine($"Колличество элементов массива, которые больше всех своих соседей одновременно {count}");

            //Задача 7 
            //Заполнить массив из символов (char) указанным образом

            //int[,] mas = new int[7, 7];

            //for (int i = 0; i < mas.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mas.GetLength(1); j++)
            //    {
            //        mas[i, j] = (i <= j && i <= mas.GetLength(0) - j - 1) || (i >= j && i >= mas.GetLength(0) - j - 1) ? 1 : 0;

            //        Console.Write($"{mas[i, j]}  ");

            //    }
            //    Console.WriteLine();
            //}

            //Задание 8
            //Реализовать перемножение матриц целых чисел.
            //Примеры не сложно найти в сети.
            //Важно их понять и адаптировать для ваших двух произвольных массивов. Проверить входное условие перемножения
            //(число столбцов 1-го массива == числу строк 2-го массива)

            //int[,] mas_a = new int[3, 4]{
            //        { 2, 4, 5, 7 },
            //        { 7, 3, 7, 8 },
            //        { 7, 8, 9, 4 }};
            //int[,] mas_b = new int[4, 2]{
            //        { 2, 4 },
            //        { 3, 4 },
            //        { 5, 6 },
            //        { 3, 6 } };
            //int[,] mas_c = new int[mas_a.GetLength(0), mas_b.GetLength(1)];

            //for (int i = 0; i < mas_a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mas_b.GetLength(1); j++)
            //    {
            //        mas_c[i, j] = 0;

            //        for (int k = 0; k < mas_a.GetLength(1); k++)
            //        {
            //            mas_c[i, j] += mas_a[i, k] * mas_b[k, j];
            //        }
            //    }
            //}

            //for (int i = 0; i < mas_c.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mas_c.GetLength(1); j++)
            //    {
            //        Console.Write($"{mas_c[i, j]} \t");
            //    }
            //    Console.WriteLine();
            //}









        }

    }
}
