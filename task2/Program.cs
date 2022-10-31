int Number = 32679;

if (Number / 10 < 10)
{
    Console.WriteLine("Третьей цифры нет");
}

else
{
    while (Number / 10 > 99)
    {
        Number = Number / 10;
    }
    Console.WriteLine(Number % 10);
}