string[] array1 = new string[6] {"1234", "1567", "-2", "computer science", ":-)","123"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);

// Второй вариант
/*
Console.Clear();
Console.WriteLine("Введите текст из набора разных символов через пробел: ");
string text = Console.ReadLine();
string [] array = text.Split(" ");
Console.WriteLine("Наборы из трехсимвольных строк таков: ");

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        Console.Write($"{array[i]} ");
    }
}
*/