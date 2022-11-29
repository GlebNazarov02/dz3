double Coord(int ax, int ay,int az,int bx, int by,int bz)
{
    double result;
    result = Math.Sqrt( Math.Pow(bx - ax,2) + Math.Pow(by - ay,2) + Math.Pow(bz - az,2));
    return result;
}
Console.WriteLine("первая к a");
int ax = int.Parse(Console.ReadLine());
Console.WriteLine("вторая к a");
int ay = int.Parse(Console.ReadLine());
Console.WriteLine("третья к a");
int az = int.Parse(Console.ReadLine());
Console.WriteLine("первая к b");
int bx = int.Parse(Console.ReadLine());
Console.WriteLine("вторая к b");
int by = int.Parse(Console.ReadLine());
Console.WriteLine("третья к b");
int bz = int.Parse(Console.ReadLine());
Console.WriteLine(Coord(ax,ay,az,bx,by,bz));