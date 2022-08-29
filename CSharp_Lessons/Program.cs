// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

// Решение 1
// Console.WriteLine("Ввведите координату X");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ввведите координату y");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x == 0 || y == 0)
// {
//     Console.WriteLine("Точка находиться на оси");
// }
// if (x > 0 && y > 0)
// {
//     Console.WriteLine("Точка находиться в первой четверти");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("Точка находиться в третьей четверти");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("Точка находиться в четвертой четверти");
// }
// else
// {
//       Console.WriteLine("Точка находиться во второй четверти"); 
// }
//  Решение 2
// int[] Input()
// {
//     int[] Array = new int[2];
//     Console.WriteLine("Ввведите координату X");
//     int x = Convert.ToInt32(Console.ReadLine());
//     Array[0] = x;
//     Console.WriteLine("Ввведите координату y");
//     int y = Convert.ToInt32(Console.ReadLine());
//     Array[1] = y;
//     return Array;
// }
// int[] My = Input();
// while (My[0] == 0 || My[1] == 0)
// {
//     Console.WriteLine("Точка находиться на оси");
//     My = Input();
// }
// if (My[0] > 0 && My[1] > 0)
// {
//     Console.WriteLine("Точка находиться в первой четверти");
// }
// else if (My[0] < 0 && My[1] < 0)
// {
//     Console.WriteLine("Точка находиться в третьей четверти");
// }
// else if (My[0] < 0 && My[1] > 0)
// {
//     Console.WriteLine("Точка находиться в четвертой четверти");
// }
// else
// {
//       Console.WriteLine("Точка находиться во второй четверти"); 
// }

// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).
/*
Console.WriteLine("Ввведите номер четверти:");
int field = Convert.ToInt32(Console.ReadLine());
while (field>4 || field<1)
{
    Console.WriteLine("Ввведите номер четверти(это число от 1 до 4): ");
    field = Convert.ToInt32(Console.ReadLine());
}
if (field == 1)
{
    Console.WriteLine("Точка находиться в первой четверти: x > 0 и y > 0 ");
}
else if (field == 2)
{
    Console.WriteLine("Точка находиться во второй четверти: x < 0 и y > 0 ");
}
else if (field == 3)
{
    Console.WriteLine("Точка находиться в третьей четверти: x < 0 и y < 0 ");
}
else
{
    Console.WriteLine("Точка находиться в четвертой четверти: x > 0 и y < 0 ");
}
*/

// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

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

// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
/*
Console.WriteLine("Ввведите число:");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= number; i++){
   Console.WriteLine(i + " -> " + i * i); 
}
*/

// ЗАДАЧА 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
/*
Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= A; i++)
{
    sum = sum + i;
}
Console.WriteLine(sum);*/
/*
Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int i = 1;
while (i<=A)
{
    sum = sum + i;
    i += 1;
}
    Console.WriteLine(sum); */

/*  метод решения через функцию
int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
        {
            sum = sum + i;
        }
    return sum;
}
for (int i = 0; i < 5; i++)
{
    Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(A + " -> " + SumNumbers(A)); 
}*/
/*
void SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
        {
            sum = sum + i;
        }
    Console.WriteLine(num + " -> " + sum); 
}
for (int i = 0; i < 5; i++)
{
    Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
SumNumbers(A); 
}*/
/*
int[] CreateRandomArray(int N, int start, int end)
{
    int[]RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Введите колличество элементов в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число случайного диапозона: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число случайного диапозона: ");
int max = Convert.ToInt32(Console.ReadLine());
 int[] MyRandomArray = CreateRandomArray(num, min, max);
ShowArray(MyRandomArray);
*/ 

int[] CreateRandomArray(int N, int start, int end)
{
    int[]RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

int[] CreateArray()
{
    Console.WriteLine("Введите колличество элементов массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] RandomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Ввeдите {i+1} элемент массива:");
        RandomArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.Clear();
Console.WriteLine("Введите колличество элементов в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число случайного диапозона: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число случайного диапозона: ");
int max = Convert.ToInt32(Console.ReadLine());

 int[] MyRandomArray = CreateRandomArray(num, min, max);
ShowArray(MyRandomArray);
Console.WriteLine("------");
int[] myArray = CreateArray();
ShowArray(myArray);
