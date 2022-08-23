//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int x = num*-1; x < num + 1; x++)       
    if (x<num+1)
    {
        Console.Write(x);
        Console.Write(". " );

    }