// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] Array;
Console.WriteLine("Данная программа вернет массив слов, состоящий из трех и менее символов");
Console.WriteLine("Введите через  пробел, слова или набор символов");
Console.WriteLine("По окончании ввода нажмите Enter");
string str = Console.ReadLine();
if (str != "")
{
    Array = str.Split(' ');
    
    var newArray = new string[Array.Length];

    var j = 0;
    
    foreach (var value in Array)
    {
        if (value.Length < 4)
        {
           newArray[j] = value; 
           j++;
        }    
    }
    if (j == 0) Console.WriteLine("В данном массиве отсутствуют требуемые элементы!");
    Console.Write("Результат -> ");
    PrintArray(newArray);
}
else Console.WriteLine("Нужно было, что-то написать!");

void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} ");
    }
}