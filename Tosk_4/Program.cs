// See https://aka.ms/new-console-template for more information
 //Напишите программу, которая на вход принимает натуральное число N, а 
 // на выходе показывает его цифры через запятую

Console.Write("Введите натуральное число N: ");
 
int num = int.Parse(Console.ReadLine());

int even = 0;

while (num >= even) // even -возвращает четное целое число
{
    Console.Write(even + ",");
     
     even = even + 1;
}

 