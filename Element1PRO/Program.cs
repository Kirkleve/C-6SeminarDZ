/*
 Пользователь вводит с клавиатуры M чисел. Посчитайте, 
 сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

                    //Более продвинутая версия


               
Console.WriteLine("Введите длину массива ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[Length];
int count = 0;
int[] b = new int [a];


for ( int i = 0; i <= numbers.Length; i++)
{
    a = InputNumber("как положительное, так и отрицательное: ");
    
}

Console.Write(b);

int InputNumber(string name)
{
    Console.Write($"Введите число в массив {name},  ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

