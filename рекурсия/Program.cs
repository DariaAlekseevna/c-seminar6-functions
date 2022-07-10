
void SomeFunc(int a)
{
    System.Console.WriteLine($"на входе {a}");
    if (a<0)
    return;

    System.Console.WriteLine(a);
    SomeFunc(a-1);
    System.Console.WriteLine($"на выходе{a}");
}

SomeFunc(5);