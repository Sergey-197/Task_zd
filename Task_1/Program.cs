// See https://aka.ms/new-console-template for more information
 
// проверка кратности чисел 7 и 23

Console.Write("Введите число number: ");

int x = Convert.ToInt32(Console.ReadLine());

if (x % 7 == 0 || x % 23 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
