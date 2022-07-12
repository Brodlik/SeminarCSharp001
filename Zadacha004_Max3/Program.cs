Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число C: ");
int C = Convert.ToInt32(Console.ReadLine());

if (A > B)
{
    if (A > C)
    {
        Console.Write("max= ");
        Console.WriteLine(A);
    }
    else if (C>A)
    {
        Console.Write("max= ");
        Console.WriteLine(C);
    }
}
if (B > A)
{
    if (B > C)
    {
        Console.Write("max= ");
        Console.WriteLine(B);
    }
    else if (C>B)
    {
        Console.Write("max= ");
        Console.WriteLine(C);
    }
}