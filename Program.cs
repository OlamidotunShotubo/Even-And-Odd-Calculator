Console.WriteLine("PLS INPUT THE RANGE OF NUMBER IN THIS FORMAT (X - Y)");
var Range = Console.ReadLine();
var elements = Range.Split(' ');
var x = int.Parse(elements[0]);
var space = elements[1];
var b = int.Parse(elements[2]);
var sum = 0;
if (x > b)
{
    Console.WriteLine("INVALID ENTRY");
}

while (x <= b)
{
    if (x % 2 == 0)
    {
        sum = sum + x;
    }
    else
    {
        sum = sum + 0;
    }
    x += 1;
    if (x % 2 != 0)
    {
        sum = sum + x;
    }
    else
    {
        sum = sum + 1;
    }
    x += 1;
}

Console.WriteLine($"So the Sum Of even Number is = {sum}");
Console.Read();

