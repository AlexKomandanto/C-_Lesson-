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

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да

Console.Write("input number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
double number = numberA / 2;
if ( number%2 == 0 )
    Console.Write(numberA + " -> " + "no even" );
else 
    Console.Write(numberA + " -> " + "yes even");    
