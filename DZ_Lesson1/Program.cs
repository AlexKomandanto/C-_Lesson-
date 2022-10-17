// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7

//  Console.Write("input numberA: ");
//  int numberA = Convert.ToInt32(Console.ReadLine());
//  Console.Write("input numberB: ");
//  int numberB = Convert.ToInt32(Console.ReadLine());

//  if (numberA > numberB)
//      Console.Write(" a= " + numberA + "; b= " + numberB + " -> " + " max " + numberA);
//  else
//      Console.Write(" a= " + numberA + ",; b= " + numberB + " -> " + " max " + numberB);


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7

// Console.Write("input numberA: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("input numberB: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// Console.Write("input numberC: ");
// int numberC = Convert.ToInt32(Console.ReadLine());

// if (numberA > numberB)
//     Console.Write(" a= " + numberA + "; b= " + numberB + "; c= " + numberC + " -> " + " max " + numberA);
// else if (numberB > numberC)  
//     Console.Write(" a= " + numberA + "; b= " + numberB + "; c= " + numberC + " -> " + " max " + numberB);  
// else
//     Console.Write(" a= " + numberA + "; b= " + numberB + "; c= " + numberC +  " -> " + " max " + numberC);


// number%2 == 0

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).
// 4 -> да

// Console.Write("input number: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// if ( numberA % 2 == 0 )
//     Console.Write(numberA + " -> " + "yes even" );
// else 
//     Console.Write(numberA + " -> " + "no even");    


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.

// Console.Write("input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int current = 2;
// while (current <= num)
// {
//     Console.Write(current + " ");
//     current = current +2;
// }

// Задача та же, с отрицательными числами:

// Console.Write("input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int current;
// if (num > 0)
// {
//     current = 2;
//     while (current <= num)
//     {
//       Console.Write(current + " ");
//       current = current +2;  
//     }
// }
// else
// {
//     current = 0;
//     while (current >= num)
//     {
//         Console.Write(current + " ");
//         current = current -2;
//     }
// }


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = num % 100;
// int num2 = num1 / 10;
// Console.Write(num + " -> " + num2);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
/*
Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 100){
    Console.Write(num + " -> " + "третьей цифры нет");
}
else if (num < 1000){
    int num1 = num % 10;
    Console.Write(num + " -> " + num1);
}
else if (num < 10000){
    int num1 = num % 100;
    int num2 = num1 / 10;
    Console.Write(num + " -> " + num2);
}
else if (num < 100000){
    int num1 = num % 1000;
    int num2 = num1 / 100;
    Console.Write(num + " -> " + num2);
}
else if (num < 1000000){
    int num1 = num % 10000;
    int num2 = num1 / 1000;
    Console.Write(num + " -> " + num2);
}
else if (num < 10000000){
    int num1 = num % 100000;
    int num2 = num1 / 10000;
    Console.Write(num + " -> " + num2);
}
*/

// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
/*
Console.Write("введите день недели, число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
if(day < 1 || day > 7 ){
    Console.Write(day + " -> " + "неправильно введен день, перезапустите программу");
}
else if (day > 5){
    Console.Write(day + " -> " + "выходной день");
}
else{
    Console.Write(day + " -> " + "рабочий день");
}
*/

// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
/*
Console.Write("введите пятизначное число: ");
int X = Convert.ToInt32(Console.ReadLine());
int a1 = X % 10;
int a2 = X / 10 % 10;
int a3 = X / 100 % 10;
int a4 = X / 1000 % 10;
int a5 = X / 10000;
 //   X = a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5;
//Console.Write(X);    
if (a1 == a5 && a2 == a4 ){
    Console.WriteLine(X + " -> " + " да ");
}
else{
    Console.WriteLine(X + " -> " + " нет ");
}
*/
// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53 

/*
double SystemCoor( int x1, int y1, int x2, int y2, int x3, int y3){
    return Math.Sqrt((x1 - x2 - x3) * (x1 - x2 - x3) + (y1 - y2 - y3) * (y1 - y2 - y3));
}
Console.WriteLine("Ввведите координату x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите координату y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите координату x2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите координату y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите координату x3:");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите координату y3:");
int y3 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(Math.Round(SystemCoor(x1, y1, x2, y2, x3, y3), 3));
*/

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
/*
Console.WriteLine("Ввведите число:");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= number; i++){
   Console.WriteLine(i + " -> " + i * i *i); 
}
*/

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
 /*
Console.WriteLine("Ввведите число A:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите число B:");
int B = Convert.ToInt32(Console.ReadLine());
int i = Convert.ToInt32(Math.Pow(A, B));
Console.WriteLine($"{A}, {B} -> {i} ");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
Console.WriteLine("Ввведите число N:");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int x = N;
while (x > 0)
{
    sum = sum + (x % 10);
    x = x / 10;
}
Console.WriteLine($"{N} -> {sum} ");
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
/*
int[] CreateRandomArray( int start, int end)
{
    int[]RandomArray = new int[8];
    for (int i = 0; i < 8; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
        Console.Write(RandomArray[i] + ",");

    }
    return RandomArray;
}

void ShowArray(int[] array)
{   Console.Write(" -> [");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.Write("]");
    Console.WriteLine();
}
Console.Clear();
Console.WriteLine("Введите первое число случайного диапозона 8 элементов: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число случайного диапозона 8 элементов: ");
int max = Convert.ToInt32(Console.ReadLine());

 int[] MyRandomArray = CreateRandomArray(min, max);
ShowArray(MyRandomArray);
*/

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] RandomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        RandomArray[i] = new Random().Next(min, max + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}
int[] myArray = CreateRandomArray(99, 101, 200);
Console.Clear();
int N = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i]% 2 == 0)
    {
        N++;
    }
}
ShowArray(myArray);
Console.WriteLine("Колличество элементов - "+ N);
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] RandomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        RandomArray[i] = new Random().Next(min, max + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}
int[] myArray = CreateRandomArray(10, 1, 5);
Console.Clear();

// int sum = 0;

// for (int i = 1; i < myArray.Length; i=i+2)
// {
//     sum += myArray[i];
// }
// ShowArray(myArray);
// Console.WriteLine("Сумма нечетных элементов - "+ sum);

int sum_odd_index_nums = 0;
for (int i = 1; i < myArray.Length; i=i+2)
{
    sum_odd_index_nums += myArray[i];
}
   ShowArray(myArray); 
Console.WriteLine(sum_odd_index_nums);
*/

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
/*
int[] CreateRandomArray(int size, int start, int end)
{
      int[] array = new int[size];
      for (int i = 0; i < size; i++)
         {
            array[i] = new Random().Next(start, end + 1);
         }
      return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int[] myArray = CreateRandomArray(15, 10, 99);
ShowArray(myArray);
int max = myArray[0];
int min = myArray[0];
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] >= max)
    {max = myArray[i];}   
}
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] <= min)
    {min = myArray[i];}
}
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine(max-min);
*/
// ЗАдача: на разворот массива
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] RandomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        RandomArray[i] = new Random().Next(min, max + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write( array[i] + "  " );
    }
    Console.WriteLine();
}
int[] myArray = CreateRandomArray(10, 1, 5);
Console.Clear();
ShowArray(myArray);

void ReversArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - i - 1] = k;
    }
}
ReversArray(myArray);
Console.WriteLine(String.Join("  ", myArray));
*/
//Задача 44: Не используя рекурсию,
//  выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.


//Задача 45: Напишите программу, 
// которая будет создавать копию заданного массива с помощью поэлементного копирования.


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, -567, 89, 223-> 3
/*
int[] CreateArray()
{
Console.WriteLine("Введите количество элементов массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[size];
for (int i = 0; i < size; i++)
{
Console.WriteLine($"Введите {i+1} элемент массива");
Array[i] = Convert.ToInt32(Console.ReadLine());
}
return Array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++){
        Console.Write(array[i]);
        if (i<array.Length-1) {
        Console.Write(", ");
        }
    }
Console.WriteLine();
}
Console.Clear();
Console.WriteLine("-------");
int[] myArray = CreateArray();
ShowArray(myArray);
int positiv_count = 0;
for (int i = 0; i<myArray.Length; i++)
{
if (myArray[i] > 0){
    positiv_count += 1;
    }    
}
Console.WriteLine($"Количество положительных элементов: -> {positiv_count}");
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
Console.Clear();
Console.WriteLine("Введите k1 для прямой, заданной уравнением y = k1*x + b1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1 для прямой, заданной уравнением y = k1*x + b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2 для прямой, заданной уравнением y = k2*x + b2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2 для прямой, заданной уравнением y = k2*x + b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
if  (k1==k2 && b1 == b2) {
    Console.WriteLine("Прямые совпадают");
    }
else if (k1==k2 && b1 != b2){
    Console.WriteLine("Прямые параллельны, точек пересечения нет");
    }
else{
    double x = (b2-b1)/(k1-k2);
    double y = x*k1 + b1;
Console.WriteLine ($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} -> ({x}; {y})");
}
*/


// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
Console.Clear();

double[,] GetArray(int m, int n, int minValue, int maxValue)  
{
    double[,] res = new double[m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
             res[i,j] = new Random().NextDouble()*((maxValue - minValue)+minValue) ;
        }
           
    }
    return res;
}
void PrintArray(double[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)      
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write($"{array[row, column]:f1}  ");     
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите колличество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колличество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());

double [,] array = GetArray(row, column, -7, 7);

PrintArray(array);
*/


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
/*
Console.Clear();

int[,] GetArray(int m, int n, int minValue, int maxValue)  
{
    int[,] res = new int[m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
             res[i,j] = new Random().Next(minValue, maxValue + 1);
        }
           
    }
    return res;
}
void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)      
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write( $"{array[row,column]} " );     
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите колличество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колличество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());

int [,] array = GetArray(row, column, 0, 50);
PrintArray(array);

Console.WriteLine("Введите индекс строки массива: ");
int ind_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс столбца массива: ");
int ind_b = Convert.ToInt32(Console.ReadLine());

if (ind_a < row && ind_b < column){
    int N = array[ind_a, ind_b];
    Console.WriteLine($"Значение запрашиваемого элемента: {N}");
}
else {
    Console.WriteLine("Такой элемент отсутствует");
}
*/

// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
int[,] GetArray(int m, int n, int minValue, int maxValue)  
{
    int[,] res = new int[m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
             res[i,j] = new Random().Next(minValue, maxValue + 1);
        }
           
    }
    return res;
}
void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)      
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write( $"{array[row,column]} " );     
        }
        Console.WriteLine();
    }
}
Console.Clear();

Console.WriteLine("Введите колличество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колличество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());

int [,] array = GetArray(row, column, 0, 9);
PrintArray(array);

for (int j = 0; j < array.GetLength(1); j++)
    {double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {sum = sum + array[i,j];
        }
    Console.Write($"{(sum/row):f1}  ");
    }
*/

// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:             В итоге получается вот такой массив:
// 1 4 7 2                             1 2 4 7
// 5 9 2 3                             2 3 5 9
// 8 4 2 4                             2 4 4 8
/*
Console.Clear();

int[,] GetArray(int m, int n, int minValue, int maxValue)  
{
    int[,] res = new int[m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
             res[i,j] = new Random().Next(minValue, maxValue + 1);
        }
           
    }
    return res;
}
void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)      
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write( $"{array[row,column]} " );     
        }
        Console.WriteLine();
    }
}
void SortArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int t = j + 1; t < array.GetLength(1); t++)
            {
                if (array[i,t]>array[i,j])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,t];
                    array[i,t] = temp;
                }
            }
        }
    }
}


Console.WriteLine("Введите колличество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колличество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());

int [,] array = GetArray(row, column, 0, 9);
PrintArray(array);
SortArray(array);
System.Console.WriteLine("------------");
PrintArray(array);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и
//  выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
Console.Clear();

int[,] GetArray(int m, int n, int minValue, int maxValue)  
{
    int[,] res = new int[m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
             res[i,j] = new Random().Next(minValue, maxValue + 1);
        }
           
    }
    return res;
}
void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)      
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write( $"{array[row,column]} " );     
        }
        Console.WriteLine();
    }
}
int GetRowNumber(int [,] array)
{
   int row = 0;
   int minsum = 0;
   for (int i = 0; i < array.GetLength(1); i++)
   {
        minsum = minsum + array[0,i];
   }
   for (int i = 0; i < array.GetLength(0); i++)
   {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        if (minsum>sum)
        {
            minsum = sum;
            row = i;
        }
           Console.WriteLine(minsum);
   }
   return row;
}
Console.WriteLine("Введите колличество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колличество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());

int [,] array = GetArray(row, column, 0, 9);
PrintArray(array);
System.Console.WriteLine($"Строка с наименьшей суммой - {GetRowNumber(array)}");
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:                 Их произведение будет равно следующему массиву:
// 1 4 7 2                                             1 20 56 10
// 5 9 2 3                                             20 81 8 6
// 8 4 2 4                                             56 8 4 24
// 5 2 6 7                                             10 6 24 49
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
/*
Console.Clear();
Console.WriteLine("Введите колличество строк массива A: ");
int rowA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колличество столбцов массива A: ");
int columnA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колличество строк массива B: ");
int rowB  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колличество столбцов массива B: ");
int columnB = Convert.ToInt32(Console.ReadLine());
if (columnA != rowB)
{
    System.Console.WriteLine("Такие матрицы умнажать нельзя");
    return;
}
int [,] A = GetArray(rowA, columnA, 0, 9);
int [,] B = GetArray(rowB, columnB, 0, 9);

PrintArray(A);
System.Console.WriteLine();
PrintArray(B);
System.Console.WriteLine();
PrintArray(GetMultiplicationMatrix(A,B));


int[,] GetArray(int m, int n, int minValue, int maxValue)  
{
    int[,] res = new int[m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
             res[i,j] = new Random().Next(minValue, maxValue + 1);
        }
           
    }
    return res;
}
void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)      
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write( $"{array[row,column]} " );     
        }
        Console.WriteLine();
    }
}

int [,] GetMultiplicationMatrix(int [,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayC[i,j] += arrayA[i,k] * arrayB[k,j];
            }
        }
    }
    return arrayC;
}
*/

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)
/*
void FillMassive(int[,,] array, int min, int max)
{
    var rand = new Random();
    int num = rand.Next(min, max+1);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++) 
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                while (true) 
                {
                    if (!IsNumInArray(array, num)) 
                    {
                        array[i, j, k] = num;
                        break;
                    }
                    num = rand.Next(min, max+1);
                } 
            }
        }
    }
}
void PrintMatrix(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++) 
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} - [{i}, {j}, {k}]");
                Console.WriteLine();
            } 
            
        }
    }
}
bool IsNumInArray(int[, ,] matrix, int num)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <  matrix.GetLength(1); j++) 
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i, j, k] == num)
                    return true;
            } 
        }
    }
    return false;
}
Console.Clear();
Console.Write("Enter 0 demension: ");
var n = int.Parse(Console.ReadLine());
Console.Write("Enter 1 demension: ");
var m = int.Parse(Console.ReadLine());
Console.Write("Enter 2 demension: ");
var b = int.Parse(Console.ReadLine());
int[,,] massive = new int[m, n, b];
FillMassive(massive, 10, 99);
Console.WriteLine("Матрица: ");
PrintMatrix(massive);
Console.WriteLine();
*/
/*
Console.Clear();
Console.Write("Введите размеры массива через пробел: ");
string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,,] array = GetArray(new int[] { int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]) }, 10, 99);
PrintArray(array);

int[,,] GetArray(int[] size, int min, int max)  
{
    int[,,] result = new int[sizes[0], sizes[1], sizes[2]];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int k = 0;
            while (k < result.GetLength(2))
            {
                int element = new Random().Next(min, max + 1);
                if (FindElement(result, element)) continue;
                result[i, j, k] = element;
                k ++;
            }
        }
           
    }
    return result;
}
bool FindElement(int[,,] arrae, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == el) return true;
            }
        }
    }
    return false;
}


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)      
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write( $"{array[i, j, k]} ({i},{j},{k})  " );     
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
*/

// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7




/*
//Задача 64: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8
int PowNumbers(int A, int B)
{
    if (B == 0) return 1;
    else return PowNumbers(A, B - 1) * A;
}
Console.Clear();
Console.WriteLine("Input A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PowNumbers(A, B));
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
int SumNumbersRec(int M, int N)
{
    if (M == N)
    {
        return M;
    }
    else
    {
        return M + SumNumbersRec(M + 1, N - 1) + N;
    }
}
Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{SumNumbersRec(M, N)}");
//Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n (m = 2, n = 3 -> A(m,n) = 9).
int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}
Console.Clear();
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int functionAkkerman = Ack(m, n);
Console.Write($"Ack(m,n) = {functionAkkerman} ");
*/