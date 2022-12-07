using System.Runtime.CompilerServices;
using static System.Console;

int first, ten, hundreds, thousands, verdict;
first = ten = hundreds = thousands = verdict = 0;
bool right = true;
WriteLine("Поиграем игру. Вам нужно нажимать ЦИФРУ по ходу повествования");

WriteLine("Вы идете по лесу и видите грибы, их там целых... ");
first = Convert.ToInt32(Console.ReadLine());
while (right)
{
    if( first >= 0 & first < 10)
    {
        WriteLine($"Вы собрали грибы в количестве: {first}");
        right = false;
    }
    else
    {
        WriteLine("Кажется вы что-то перепутали, Попробуйте написать ещё раз вашу цифру: ");
        first = Convert.ToInt32(Console.ReadLine());
    }
}
right = true;

WriteLine("Вы так же нашли пещеру. В ней есть ящик с рыбой. Этих рыб там... ");
ten = Convert.ToInt32(Console.ReadLine());
while (right)
{
    if (ten >= 0 & ten < 10)
    {
        WriteLine($"Вы собрали рыбу в количестве: {ten}");
        right = false;
    }
    else
    {
        WriteLine("Кажется вы что-то перепутали, Попробуйте написать ещё раз вашу цифру: ");
        ten = Convert.ToInt32(Console.ReadLine());
    }
}
right = true;

WriteLine("По пути домой вам встретился старик. Он отдал вам мешок с клубками проводом. Этих клубков было... ");
hundreds = Convert.ToInt32(Console.ReadLine());
while (right)
{
    if (hundreds >= 0 & hundreds < 10)
    {
        WriteLine($"Вам повезло собрать клубки в количестве: {hundreds}");
        right = false;
    }
    else
    {
        WriteLine("Кажется вы что-то перепутали, Попробуйте написать ещё раз вашу цифру: ");
        hundreds = Convert.ToInt32(Console.ReadLine());
    }
}
right = true;

WriteLine("Почти дойдя домой, на вас почти упал горшок. Он разбился, а там красивые кольца. Этих колец было... ");
thousands = Convert.ToInt32(Console.ReadLine());
while (right)
{
    if (thousands >= 0 & thousands < 10)
    {
        WriteLine($"Вы набрали колец в количестве: {thousands}");
        right = false;
    }
    else
    {
        WriteLine("Кажется вы что-то перепутали, Попробуйте написать ещё раз вашу цифру: ");
        thousands = Convert.ToInt32(Console.ReadLine());
    }
}

verdict = first + ten * 10 + hundreds * 100 + thousands * 1000;
WriteLine($"Вам удалось выручить с этого: {verdict} рублей");