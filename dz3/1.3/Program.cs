void Kubi(int N)
{
   Console.Write($"{N} -> ");
   int i = 0;
   double pere;
   while (i < N )
   {
        i += 1;
        if (i == (N))
        {
            pere = Math.Pow(i,3);
            Console.Write($"{pere}");
        }
        else
        {
        
        pere = Math.Pow(i,3);
        Console.Write($"{pere},");
        }
   }
    
   
}
Console.WriteLine("введите ч");
int chislo = int.Parse(Console.ReadLine());
Kubi(chislo);