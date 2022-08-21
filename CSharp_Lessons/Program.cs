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

