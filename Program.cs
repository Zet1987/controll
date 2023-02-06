// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите массив из слов");
string one = Console.ReadLine()!;

Console.WriteLine("Введите массив из слов");
string two = Console.ReadLine()!;

Console.WriteLine("Введите массив из слов");
string three = Console.ReadLine()!;

Console.WriteLine("Введите массив из слов");
string four = Console.ReadLine()!;

string [] Array  = {one, two, three, four};
int count=0;
for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
                count++;
        }
    }

string [] Arrayfind = new string[Array.Length];
Console.WriteLine($"количество слов с символами меньше или равным 3 равно {count}");
Console.WriteLine(String.Join("+ ", Arrayfind));
Console.WriteLine("Первый массив");

Console.WriteLine(String.Join(", ", Array));
for (int j = 0; j < Array.Length; j++)
    {
        if (Array[j].Length <= 3)
        {
                Arrayfind[j] = Array[j];
        }
   else
   {
    Arrayfind[j] = "";
   }
    }
Console.WriteLine("Второй массив");
Console.WriteLine(String.Join(" ", Arrayfind));