using System;

namespace Massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1 
            // Посчитать количества нечетных и четных элементов массива.
            // Не путать с нечетными и четными индексами.

            //Console.WriteLine("Введите колличетсво ячеек массива: ");

            //int b = int.Parse(Console.ReadLine());

            //int[] a = new int[b];
            //Random rnd = new Random();

            //int sum_a = 0;
            //int sum_b = 0;



            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = rnd.Next(10,101) ;
            //    Console.WriteLine(a[i]);
            //}


            //for (int i = 0; i < a.Length; i++)
            //{
            //    if(a[i] % 2 == 0 )
            //    {
            //        sum_a += 1;
            //    }

            //    else
            //    {
            //        sum_b += 1;
            //    }
            //}
            //Console.WriteLine($"Колличество четных элементов массива: {sum_a}. Колличество нечетных: {sum_b} ");

            // Задание 2
            // Каждый третий элемент массива заменить суммой двух предыдущих элементов.

            //Console.Write("Введите колличетсво ячеек массива:   ");

            //int b = int.Parse(Console.ReadLine());

            //int[] a = new int[b];
            //Random rnd = new Random();


            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = rnd.Next(10, 101);
            //    Console.WriteLine(a[i]);
            //}
            //Console.WriteLine();
            //for (int i = 2; i < a.Length; i+=3)
            //{
            //   
            //   
            //        a[i] = a[i - 1] + a[i - 2];
            //        Console.WriteLine(a[i]);
            //   
            //   
            //
            //}
            //Console.WriteLine();

            // Задание 3 
            // Слить два целочисленных массива в один (должен получиться третий массив).

            //Console.Write("Введите колличетсво ячеек для первого массива:   ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Введите колличетсво ячеек для второго массива:   ");
            //int b = int.Parse(Console.ReadLine());

            //int[] mas_a = new int[a];
            //int[] mas_b = new int[b];

            //int[] mas_c = new int[a + b];

            //Random rnd = new Random();

            //for (int i = 0; i < mas_a.Length; i++)
            //{
            //    mas_a[i] = rnd.Next(10, 101);
            //    Console.WriteLine(mas_a[i]);
            //}
            //Console.WriteLine("----------------------------------");
            //for (int i = 0; i < mas_b.Length; i++)
            //{
            //    mas_b[i] = rnd.Next(10, 101);
            //    Console.WriteLine(mas_b[i]);
            //}
            //Console.WriteLine("----------------------------------");           

            //    for (int i = 0; i < mas_a.Length; i++)
            //    {
            //        mas_c[i] = mas_a[i];
            //    }
            //    for (int i = 0; i < mas_b.Length; i++)
            //    {
            //        mas_c[mas_a.Length + i] = mas_b[i];
            //    }
            //Console.WriteLine(String.Join(" ", mas_c));
            //Задание 4!!! Не работает на массив из 3-х ячеек
            //Поменять местами первую и вторую половину массива.
            //например, для массива 1 2 3 4, результат 3 4 1 2,  или для 1 2 3 4 5 - 4 5 3 1 2.

            //Console.Write("Введите колличетсво ячеек массива:   ");
            //int a = int.Parse(Console.ReadLine());

            //int[] mas_a = new int[a];

            //Random rnd = new Random();
            //for (int i = 0; i < mas_a.Length; i++)
            //{
            //    mas_a[i] = rnd.Next(10, 101);

            //}
            //Console.WriteLine(string.Join(' ', mas_a));



            //for (int i = 0; i <= (mas_a.Length) / 2; i++)
            //{
            //    int tmp = mas_a[i];
            //    mas_a[i] = mas_a[mas_a.Length / 2 + (1 + i)];
            //    mas_a[mas_a.Length / 2 + (1 + i)] = tmp;
            //}
            //Console.WriteLine(string.Join(' ', mas_a));



            // Задача 5 //Почитать!!!
            //Циклически двинуть массив вправо на 1 элемент.
            //Например: 1 2 3 4 5 -> 2 3 4 5 1. А после этого сделать циклический сдвиг вправо на N элементов.

            //Console.Write("Введите колличетсво ячеек массива:   ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите N");
            //int k = int.Parse(Console.ReadLine());
            //int[] mas_a = new int[a];

            //Random rnd = new Random();
            //for (int i = 0; i < mas_a.Length; i++)
            //{
            //    mas_a[i] = rnd.Next(10, 101);
            //    Console.Write("\t" + mas_a[i]);
            //}

            //for (int i = 0; i < k; ++i)
            //{

            //    int aLast = mas_a[a - 1];
            //    for (int j = a - 1; j > 0; j--)
            //        mas_a[j] = mas_a[j - 1];
            //    mas_a[0] = aLast;
            //}

            //Console.WriteLine("Новый массив: ");
            //for (int i = 0; i < a; ++i)
            //{
            //    Console.Write("\t" + mas_a[i]);
            //    {
            //        Console.WriteLine();
            //    }
            //}

            //Задача 6
            //Преобразовать массив так, чтобы на четных позициях стояли элементы с нечетных позиций, и наоборот.
            //Сделать за O(N/2).

            //Console.Write("Введите колличетсво ячеек массива:   ");
            //int a = int.Parse(Console.ReadLine());

            //int[] mas_a = new int[a];

            //Random rnd = new Random();
            //for (int i = 0; i < mas_a.Length; i++)
            //{
            //    mas_a[i] = rnd.Next(10, 101);
            //    Console.WriteLine(mas_a[i]);
            //}

            //Console.WriteLine("----------------------");

            //for (int i = 1; i < mas_a.Length; i+=2)
            //{
            //    int tmp = 0;
            //    tmp = mas_a[i - 1];
            //    mas_a[i - 1] = mas_a[i];
            //    mas_a[i] = tmp;

            //}
            //Console.WriteLine(string.Join(' ', mas_a));

            //Задание 7
            //В массиве из целочисленных элементов (включая отрицательные) вычислить:
            //а) минимальный по модулю элемент массива;
            //б) сумму элементов, расположенных после первого нулевого элемента (элемента, равного нулю).
            //Сделать одним проходом цикла

            //Console.Write("Введите колличетсво ячеек массива:   ");
            ////int a = int.Parse(Console.ReadLine());
            //int i = 0;
            //int[] mas_a = new int[a] ;
            //int num = mas_a[1];
            //bool b = mas_a[i] == 0;
            //Random rnd = new Random();
            //for (i = 0; i < mas_a.Length; i++)
            //{
            //    mas_a[i] = rnd.Next(-10, 10);
            //    Console.WriteLine(mas_a[i]);
            //}

            //Console.WriteLine("----------------------");

            
            //int sum = 0;

            //for (i = 0; i < mas_a.Length; i++)
            //{
                
            //    if (Math.Abs(mas_a[i]) < Math.Abs(num))
            //    {
            //        num = mas_a[i];
            //    }

            //    if (b==true)
            //    {
            //        sum += mas_a[i];
            //        b = mas_a[i] != 0;
            //    }
            //}
            //Console.WriteLine($"Минимальный по модулю элемент {num}\t " +
            //    $"Cумма элементов, расположенных после первого нулевого элемента {sum}");





            //Задание 8 !!! Не верно...
            //Отсортировать массив по возрастанию алгоритмом вставок (insert).
            //Определить для себя вариацию алгоритма для сортировки по убыванию (реализовывать не обязательно).

            //Console.Write("Введите колличетсво ячеек массива:   ");
            //int a = int.Parse(Console.ReadLine());

            //int[] mas_a = new int[a];
            //int i = 0;
            //Random rnd = new Random();
            //for (i = 0; i < mas_a.Length; i++)
            //{
            //    mas_a[i] = rnd.Next(10, 101);
            //    Console.WriteLine(mas_a[i]);
            //}

            //Console.WriteLine("----------------------");



            //for (i = 0; i < mas_a.Length ; i++)
            //{ 

            //    for (int j = i + 1; j < mas_a.Length; j++)
            //    {
            //        if(mas_a[i] > mas_a[j])
            //        {
            //            int tmp = mas_a[i];
            //            mas_a[i] = mas_a[j];
            //            mas_a[j] = tmp;
            //        }

            //    }

            //    Console.WriteLine(mas_a[i]);
            //}





            //Задание 9 В данном примере отсортировал по убыванию.
            // Отсортировать массив по возрастанию алгоритмом выборки (select).
            // Определить для себя вариацию алгоритма для сортировки по убыванию (реализовывать не обязательно).

            //Console.Write("Введите колличетсво ячеек массива:   ");
            //int a = int.Parse(Console.ReadLine());

            //int[] mas_a = new int[a];

            //Random rnd = new Random();
            //for (int i = 0; i < mas_a.Length; i++)
            //{
            //    mas_a[i] = rnd.Next(-10, 101);
            //    Console.WriteLine(mas_a[i]);
            //}

            //Console.WriteLine("----------------------");


            //for (int i = 0; i < mas_a.Length; i++)
            //{
            //    int indx = i;
            //    for (int j = i; j < mas_a.Length; j++)
            //    {
            //        if (mas_a[j] > mas_a[indx])
            //        {
            //            indx = j;
            //        }
            //    }
            //    if (mas_a[indx] > mas_a[i])
            //    {
            //        int temp = mas_a[i];
            //        mas_a[i] = mas_a[indx];
            //        mas_a[indx] = temp;
            //    }

            //    Console.WriteLine(mas_a[i]);
            //}

        }        

    }
}
