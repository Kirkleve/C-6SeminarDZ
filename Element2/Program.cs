/*
Задача 43. Напишите программу, которая найдёт 
точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/
/* k1=-1.b1=1
k2=-1/4  b2=2
имеем 
у=-х+1
у=-1/4х+2
-х+1=-1/4х+2
-3/4х=1
х=-4/3
у=4/3+1=7/3

(-4/3, 7/3)*/

double InputNumber (string name)
{
    Console.Write($"Введите значение {name}  ");
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

double k1 = InputNumber ("k1");
double b1 = InputNumber ("b1");
double k2 = InputNumber ("k2");
double b2 = InputNumber ("b2");


double x = (b2-b1)/(k1-k2);
double y = k2 * ((b2-b1)/(k1-k2)) + b2;


Console.WriteLine($"Координаты пересечения ({x},{y})");


