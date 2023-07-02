var point = new Point(3, 4);
System.Console.WriteLine(point.GetX());
point.SetX(6);

System.Console.WriteLine(point.GetY());
point.SetY(7);
System.Console.WriteLine(point.ToString());

System.Console.Write("(");
foreach (var item in point.GetXY())
{
    System.Console.Write($"{item},");
}
System.Console.WriteLine(")");
point.SetXY(1, 3);

System.Console.WriteLine(point.Distance());
System.Console.WriteLine(point.Distance(5, 6));
var point2 = new Point(4, 7);
System.Console.WriteLine(point.Distance(point2));

System.Console.WriteLine("line:");
var line = new Line(point, point2);
System.Console.WriteLine();
foreach (var item in line.GetBeginXY())
{
    System.Console.Write($"{item},");
}
System.Console.WriteLine();
foreach (var item in line.GetEndXY())
{
    System.Console.Write($"{item},");
}
System.Console.WriteLine();
System.Console.WriteLine(line.GetLenght());