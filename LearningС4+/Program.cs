using System.Runtime.CompilerServices;
using static System.Console;

int x = 0;
bool right = true;
WriteLine("Введите число в диапазоне от 1 до 100: ");
while (right)
{
    x = Convert.ToInt32(ReadLine());
    if (x > 1 & x < 100)
    {
        if (x % 3 == 0 & x%5 != 0)
        {
            WriteLine("Fizz");
        }
        else if (x % 5 == 0 & x % 3 != 0)
        {
            WriteLine("Buzz");
        }
        else if(x % 5 == 0 & x % 3 == 0)
        {
            WriteLine("Fizz Buzz");
        }
        else
        {
            WriteLine("No Fizz, No Buzz");
        }
            right = false;
    }
    else
    {
        WriteLine("Вы ввели неверное число. Введите снова: ");
    }
}
