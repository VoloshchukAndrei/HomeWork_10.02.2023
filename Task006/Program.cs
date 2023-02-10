Console.WriteLine("Является ли число чётным");
Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine()!);

if(numberA % 2 == 0)
{
   Console.Write("Да");
}
else
{
    Console.Write("Нет");
}