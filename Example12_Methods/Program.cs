// Вид 1
// void Method1()
// {
//     Console.WriteLine("Автор АЮ");
// }
// Method1();




// Вид 2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: " Сообщение ");

// void Method21(string msg, int count){
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "Текст",count: 4);
// Method21(count: 3, msg: " New msg ");



// Вид 3
// int Method3(){
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);





// Вид 4
// string Method4(int count, string text){
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "WV ");
// Console.WriteLine(res);

// string Method4(int count, string text){

//  string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(5, "VW ");
// Console.WriteLine(res);

// Таблица умножения --->
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?
 
//  string text = "— Я думаю, — сказал князь, улыбаясь, — что, ”
//              + "ежели бы вас послали вместо нашего милого Винценгероде, ”
//              + "вы бы взяли приступом согласие прусского короля. ”
//              + "Вы так красноречивы. Вы дадите мне чаю?”;


//         // string s = "qwert"
//         //             012
//         // s[3] // r    

//  string Replace(string text, char oldValue, char newValue)
//         {
//             string result = string.Empty;

//             int length = text.Length;
//             for (int i = 0; i < length; i++)
//             {
//                 if (text[i] == oldValue) result = result + $"{newValue}";
//                 else result = result + $"{text[i]}";
//             }

//             return result;
//         }
        
//         string newText = Replace(text, ' ', '|');
//         Console.WriteLine(newText);


// string Replase(string text, char oldValue, char newValue)
// {
// string result = String.Empty;
// int length = text.Length;
// for (int i = 0; i < length; i++)
// {
// if(text[i] == oldValue) result = result + $”{NewValue}”;
// else result + result $"{text[i]}";
// }
// return result;
// }
// string newText = Replace(text, " " , " | ");
// Console.WriteLine(newText);
