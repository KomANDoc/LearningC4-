using System.Runtime.CompilerServices;
using static System.Console;

int num = 0;
bool right = true;
WriteLine("Введите число из 6 знаков: ");
num = Convert.ToInt32(Console.ReadLine());
while (right)
{
    if ((int)(num/100000) > 0 & (int)(num / 100000) < 10)
    {
        right = false;
    }
    else
    {
        WriteLine("Введите число ИЗ 6 ЗНАКОВ: ");
        num = Convert.ToInt32(Console.ReadLine());
    }
}
right = true;

int[] number = new int[6];
int j = 100000;

for (int i = 0; i < 6; i++)
{
    number[i] = (int)(num / j) - (((int)(num / (j*10)))*10);
    j /= 10;
}

int first, second;
WriteLine("Введите номера разрядов, которые вы хотите поменять местами: ");
Write("1 номер: "); first = Convert.ToInt32(Console.ReadLine());
while (right)
{
    if (first > 0 & first < 7)
    {
        right = false;
    }
    else
    {
        WriteLine("Введите верный номер разрядов: ");
        first = Convert.ToInt32(Console.ReadLine());
    }
}
right = true;
Write("2 номер: "); second = Convert.ToInt32(Console.ReadLine());
while (right)
{
    if (second > 0 & second < 7 & second != first)
    {
        right = false;
    }
    else if (second > 0 & second < 7 & second == first)
    {
        WriteLine("Эта операция не имеет смысла:) Введите другой 2 номер: ");
        second = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        WriteLine("Введите верный номер разрядов: ");
        second = Convert.ToInt32(Console.ReadLine());
    }
}

int buf = number[first - 1];
number[first - 1] = number[second - 1];
number[second - 1] = buf;

j = 100000;
num = 0;
for (int i = 0; i < 6; i++)
{
    num += number[i]*j;
    j /= 10;
}

WriteLine($"Вот полученное число: {num}");