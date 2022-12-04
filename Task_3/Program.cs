// Напишите программу, которая задаёт массив из 8 элементов, предоставить возможность пользователю ввести числа и вывести их на экран.
Console.Clear();
System.Console.WriteLine("Введите количество элементов массива:\t");
int amount = Convert.ToInt32(Console.ReadLine());
int [] newArray = new int [amount];

for (int i = 0; i < newArray.Length; i++)
{
    System.Console.Write($"введите число {i} :\t");
    newArray[i]=Convert.ToInt32(Console.ReadLine());
}
    Console.WriteLine($"[{string.Join(", ", newArray)}]");