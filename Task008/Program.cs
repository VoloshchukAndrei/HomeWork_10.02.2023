Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine()!);
int i = 1;
while (numberA >= i)
{
    if (i % 2 == 0)
    {
    Console.WriteLine(i);
    }
    i = i + 1;
}   