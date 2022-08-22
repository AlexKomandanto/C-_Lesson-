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

Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 100){
    Console.Write(num + " -> " + "третьей цифры нет");
}
else{
    int [] array = {num };
    int n = array.Length;
    int index = 0;
    if (array[index] == 3)
    {
        Console.Write(num + " -> " + num2);
    }
    // int num1 = num % 100;
    // int num2 = num1 / 10;
    // Console.Write(num + " -> " + num2);
}
