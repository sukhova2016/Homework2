Console.Write("Введите день недели: ");
string days = Console.ReadLine();

if (days.ToLower() == "6" || days.ToLower() == "7")
{
    Console.WriteLine("День является выходным");
}

if (days.ToLower() == "1" || days.ToLower() == "2"|| days.ToLower() == "3"|| days.ToLower() == "4"|| days.ToLower() == "5")
{
    Console.WriteLine("День не является выходным");
}