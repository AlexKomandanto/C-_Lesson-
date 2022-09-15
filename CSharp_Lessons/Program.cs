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
/*
int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
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
        Console.Write($"Ввeдите {i + 1} элемент массива:");
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
*/

//   Примеры форматирования
/*
string name = "Имя";
int age = 99;
Console.WriteLine("Имя: {0} Возраст: {1}", name, age);
*/
/*
int number = 24;
string result = string.Format("{0:f}", number);
Console.WriteLine(result);
*/
/*
double number2 = 45.08;  // <- можно округлять до 5 символов после ,
string result2 = string.Format("{0:f5}", number2);
Console.WriteLine(number2);
Console.WriteLine(result2);
*/
/*
string name = "Имя";
int age = 99;
Console.WriteLine($"Имя: {name} Возраст: {age}");
*/
/*
int x = 7;
int y = 8;
string result = $"{x} + {y} = {x + y}";
Console.WriteLine(result);

string name = "Алексей";
int age = 34;
Console.WriteLine($"Имя: {name, -10} Возраст: {age}"); // пробелы после
Console.WriteLine($"Имя: {name, 15} Возраст: {age}"); // пробелы до
*/
// Задача 31: Задать массив из 12 эл-ов, заполненный случайными числами [-9,9],
//  найти сумму отрицательных и положителных элементов.
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
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int[] myArray = CreateRandomArray(12, -9, 9);
ShowArray(myArray);

int sum_possitive = 0;
int sum_negative = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i]>0)
        sum_possitive += myArray[i];
    else
        sum_negative += myArray[i];
}
 Console.WriteLine($"Сумма положительных: {sum_possitive}. Сумма отрицательных: {sum_negative}");
*/

// Задача 32: Замена элементов массива: положительные заменить на соответствующие отрицательные
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
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int[] myArray = CreateRandomArray(12, -9, 9);
ShowArray(myArray);

for (int i = 0; i < myArray.Length; i++)
{
    myArray[i]=myArray[i] * (-1);
}
ShowArray(myArray);
*/

// Задача 33: Задать массив и определить присутствует ли в нем заданное число.
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
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int[] myArray = CreateRandomArray(12, -9, 9);
Console.Clear();
Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
string str = "No";
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i]==N)
    {
        str = "Yes";
        break;
    }
}
Console.WriteLine(str);
ShowArray(myArray);
*/
// это как без break реализовать
// bool bool_arg= true
// while (bool_arg && i<arr.Length)
// {....
// i++;
// if (условие на выход)
// bool_arg = false;
// }

// Задача 34 задать одномерный массив из 123 эл-ов. Найти кол-во элементов в диапозоне от 10 до 99
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
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int[] myArray = CreateRandomArray(123, 0, 500);
Console.Clear();
int N = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i]>9 && myArray[i]<99)
    {
        N++;
    }
}
ShowArray(myArray);
Console.WriteLine("Колличество элементов - "+ N);
*/
// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
/*
int[] list = new int[13];
string result = String.Empty;

for (int i = 0; i < list.Length; i++)
{
    list[i] = new Random().Next(1, 20);
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}
PrintArray(list);
Console.WriteLine();
for (int i = 0; i < list.Length / 2; i++)
{
    result += $"{list[i] * list[list.Length - i - 1]}, ";
}
if (list.Length % 2 != 0) result += $"{list[list.Length / 2]}";

Console.WriteLine(result);
*/
// Задача 39: Перевернуть массив(последний элемент на первое место, а первый на последнем)

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ReversArray1(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - i - 1] = k;
    }
}

int[] ReversArray2(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}
Console.Clear();
int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));

int[] reversArray = ReversArray2(array);
Console.WriteLine(String.Join(" ", reversArray));

ReversArray1(array);
Console.WriteLine(String.Join(" ", array));