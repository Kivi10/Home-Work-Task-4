// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

System.Console.Write("Введите число -> ");
int number_A = Convert.ToInt32(Console.ReadLine());

int result = number_A;
number_A = number_A % 2;

if (number_A == 1)
{
    result = result - 1;
    while (result > 0)
    {
        Console.Write(result + " ");
        result -= 2;
    }
}
else
    while (result > 0)
    {
        Console.Write(result + " ");
        result -= 2;
    }
