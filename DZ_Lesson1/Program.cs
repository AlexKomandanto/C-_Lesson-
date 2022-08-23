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