using System.Runtime.CompilerServices;
using static System.Console;

int answ;
double tempC, tempF;
WriteLine("Укажите тип температуры, которую вы будете вводить. 1 - Цельсия 2 - Форенгейт");
answ = Convert.ToInt32(ReadLine());
while (answ != 1 & answ != 2)
{
    WriteLine("Вы ввели некоректный ответ. Попробуйте ещё: ");
    answ = Convert.ToInt32(ReadLine());
}
WriteLine("Что у вас за температура?: ");
if(answ == 1)
{
    tempC = Convert.ToDouble(ReadLine());
    tempF = tempC * ((double)9 / 5) + 32;
    WriteLine($"По цельсию: {tempC}, По фаренгейту: {tempF}");
}
else
{
    tempF = Convert.ToDouble(ReadLine());
    tempC = (tempF - 32) * ((double)5 / 9);
    WriteLine($"По цельсию: {tempC}, По фаренгейту: {tempF}");
}