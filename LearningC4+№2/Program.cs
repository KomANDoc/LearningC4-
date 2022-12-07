using System.Runtime.CompilerServices;
using static System.Console;

double x, y;
WriteLine("Введите 2 числа. 1 число, от которого нужно вычеслить процент. 2 число - процент: ");
Write("Число: "); x = Convert.ToInt32(ReadLine());
Write("Процент: "); y = Convert.ToInt32(ReadLine());
WriteLine($"Вот получившееся число: {x * (y / 100)}");