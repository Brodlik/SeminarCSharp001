Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

if (A > B)
{
    Console.Write ("max= ");
    Console.WriteLine(A);
    Console.Write ("min= ");
    Console.WriteLine(B);
}
else
{
    Console.Write ("max= ");
    Console.WriteLine(B);
    Console.Write ("min= ");
    Console.WriteLine(A);
}