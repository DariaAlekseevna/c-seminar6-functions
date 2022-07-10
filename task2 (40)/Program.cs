/* Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
 */

int A;
int B;
int C;

Console.WriteLine("Введите число A, B и С:");
while ((!int.TryParse(Console.ReadLine(), out A)) || (!int.TryParse(Console.ReadLine(), out B) || (!int.TryParse(Console.ReadLine(), out C))))
{
    System.Console.WriteLine("Введите корректное значение А, В или С заново:");
}


    if (A < B+C && B < A+C && C < B+C)
    {
        System.Console.WriteLine("треугольник существует");
    }
    else 
    {
        System.Console.WriteLine("такого треугольника нет");
    }

