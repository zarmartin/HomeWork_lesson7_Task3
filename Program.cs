using System.Collections;

ArrayList sitiesOfBelarus = new ArrayList() { "Minsk", "Grodno", "Mogilev", "Gomel", "Vitebsk"};

foreach(object o in sitiesOfBelarus)
{
    Console.WriteLine(o);
}

Console.WriteLine(Environment.NewLine);


sitiesOfBelarus.AddRange(new string[] { "Gorki", "Borisov" });

foreach(object o in sitiesOfBelarus)
{
    Console.WriteLine(o);
}

Console.WriteLine(Environment.NewLine);

sitiesOfBelarus.RemoveAt(3);

foreach(object o in sitiesOfBelarus)
{
    Console.WriteLine(o);
}

sitiesOfBelarus.Remove("Gorki");
Console.WriteLine(Environment.NewLine);
foreach (object o in sitiesOfBelarus)
{
    Console.WriteLine(o);
}

sitiesOfBelarus.Sort();
Console.WriteLine(Environment.NewLine);
foreach(object o in sitiesOfBelarus)
{
    Console.WriteLine(o);
}
