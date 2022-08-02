int [] arrray = {1, 12,31, 4, 15,16,17,19 }; 

int n = arrray.Length;
int find = 4;

int index = 0;
while (index < n)
{

    if(arrray[index] == find)
    {
        Console.WriteLine(index);
    }
    // index = index + 1
   index++; 
}

