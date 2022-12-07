using System.Runtime.CompilerServices;
using static System.Console;

int first,second, buf;
WriteLine("Укажите от какого числа до какого будем выполнять задание: ");
Write("От: "); first = Convert.ToInt32(Console.ReadLine());
Write("До: "); second = Convert.ToInt32(Console.ReadLine());
if(first > second)
{
    WriteLine("Вы ввели не совсем коректно диапазон, но мы сами всё исправили:3 ");
    buf = first; 
    first = second; 
    second = buf;
}

int[] even_numbers = new int[256];
Write("Вот все четные числа в этом диапазоне: ");
for(int i = 0; i <= second - first; i++)
{
    if((first+i) % 2 == 0)
    {
        even_numbers[i] = first + i;
        Write($"{even_numbers[i]} ") ;
    }
}