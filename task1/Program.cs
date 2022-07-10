/* Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */

/* void GetArray(int siz, int minValue, int maxValue)
{
    {

    }
    return array;
}

void ReverseArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size / 2; i++)
    {
        int temp = array[i];
        array[i] = array[size - i - 1];
        array[size - i - 1] = temp;
    }
}

int[] array = GetArry(10, 0, 20);
Console.WriteLine(string.Join(" ", array));
ReverseArray(array);
Console.WriteLine(string.Join(" ", array)); */

/* int a = 2; */

/* void Foo(int[] array)
{
    array[0] = 1000;

}

/* Foo(a);
Console.WriteLine(a); */

/* int[] arr = new int[1];
arr[0] = 2;

Foo(arr);
System.Console.WriteLine(arr[0]); */

