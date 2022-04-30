/*
 Пользователь вводит с клавиатуры M чисел. Посчитайте, 
 сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Введите длину массива ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] arrayMass = new int [Length];
int count = 0;
Console.WriteLine("Введите как положительные, так и отрицательные числа: ");
FillArray(arrayMass);
WriteArray(arrayMass);

for (int i = 0; i < arrayMass.Length; i++)
{
    if ( arrayMass[i] > 0 )
    {
        count++;
    }
}

Console.WriteLine($"Чисел больше нуля " + count);



void WriteArray(int[] array)
{
    for (int i = 0; i< array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}

void FillArray(int[] array)
{
    for (int i = 0; i< array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}