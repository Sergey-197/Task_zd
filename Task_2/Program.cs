// See https://aka.ms/new-console-template for more information
// Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт 
// номер координатной четверти плоскости, в которой находится эта точка



Console.WriteLine("Введите x: ");

int x = Convert.ToInt32(Console.ReadLine());
 
Console.WriteLine("Введите y: ");
            
int y = Convert.ToInt32(Console.ReadLine());
 
 if (x > 0 && y > 0)
             
 Console.WriteLine("I четверть");
           
else

if (x < 0 && y > 0)

 Console.WriteLine("II четверть");
               
else


if (x < 0 && y < 0)

 Console.WriteLine("III четверть");
                  
else


if (x > 0 && y < 0)
 Console.WriteLine("IV четверть");
                    
else

 Console.WriteLine("Точка лежит на оси");
{

}
 

