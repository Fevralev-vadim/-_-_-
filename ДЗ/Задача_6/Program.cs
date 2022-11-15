//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите первое число : ");
int num1 = int.Parse(Console.ReadLine()!);
if (num1 %2 == 0)
{
    Console.WriteLine("Число чётное "); 
}
else
{
  Console.WriteLine("Число не чётное ");   
}

