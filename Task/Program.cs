// Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно 
// массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] CreatArray(int Length)
{
    string[] array = new string[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

int ReadInt(string argument)
{
    System.Console.WriteLine(argument);
    return int.Parse(System.Console.ReadLine());
}


void PrintArray(string[]array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        System.Console.Write(array[i] + "; ");
    }
    System.Console.WriteLine(array[array.Length-1]+ "]");
}

string [] NewArray(string[]Array)
{
    int n = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length<=3)
        {
            n++;
        }
    }
    
    int m = 0;
    string [] Array1 = new string [n];
    if (n==0)
    {
        System.Console.WriteLine("[]");
    }
    else if (n!= 0)
    {
    for (int i = 0; i < Array.Length; i++)
    {
       if (Array[i].Length<=3)
       {
        Array1[m] = Array[i];
        m++;
       } 
    }
    }
    return Array1;
    
}

int Length = ReadInt("Сколько строк вы собираетесь ввести?");
string[] Array = CreatArray(Length);
PrintArray(Array);
string [] ArrayNew = NewArray(Array);
PrintArray(ArrayNew);