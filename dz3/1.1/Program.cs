void Paliandr(string num,int len)
{
    if (len == 5)
    {
        if (num[0] == num[4] && num[1] == num[3])
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }
    else
    {
        Console.WriteLine($"{num} не пятизначное");
    }
}
Console.WriteLine("Ввелите число");
string сhislo = Console.ReadLine();
int dlina = сhislo.Length;
Paliandr(сhislo,dlina);

