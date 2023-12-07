// See https://aka.ms/new-console-template for more information
 //Напишите программу, которая принимает на вход целое
  //число из отрезка [10, 99] и показывает наибольшую цифру числа

 Console.WriteLine("Введите число из отреза [10, 99]:");
 
  int number = Convert.ToInt32(Console.ReadLine());
 
  int digit1 = number / 10;
 
  int digit2 = number % 10;
 
  int maxdigit = digit1 > digit2 ? digit1 : digit2;
 
  Console.WriteLine(maxdigit);

  



