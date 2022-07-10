/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

int N;

Console.WriteLine("Введите число N:");
while (!int.TryParse(Console.ReadLine(), out N))
{
    System.Console.WriteLine("Введите корректное значение N заново:");
}

int i = 1;


while (N >= 0) 
{
    int[] array = new int [i];
    array[i-1] = N % 2;
    N /= 2;
    i++;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(array[position] + " ");
        position++;
    }
}



PrintArray(array);