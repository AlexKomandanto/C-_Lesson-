Console.Write("input numberA: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("input numberB: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
    Console.Write(" a= " + numberA + "; b= " + numberB + " -> " + " max " + numberA);
else
    Console.Write(" a= " + numberA + ",; b= " + numberB + " -> " + " max " + numberB);

    
// a = 5; b = 7 -> max = 7