Console.WriteLine("PLS INPUT THE RANGE OF NUMBER IN THIS FORMAT (X-Y) OR (X Y)");

do
{
    var Range = Console.ReadLine();
    var elements = Range.Split(' ', '-');
    var firstno = int.Parse(elements[0]);
    var lastno = int.Parse(elements[1]);
    var sumeven = 0;
    var sumodd = 0;
    if (firstno > lastno)
    {
        Console.WriteLine("INVALID ENTRY");
    }
    while (firstno <= lastno)
    {
        if (firstno % 2 != 0)
        {
            sumodd += firstno;
        }
        if (firstno % 2 == 0)
        {
            sumeven += firstno;
        }
        firstno += 1;
    }
    Console.WriteLine($"The Sum Of even Number is = {sumeven}");
    Console.WriteLine($"The Sum Of odd Number is = {sumodd}");
    Console.WriteLine("TYPE 'R' TO REVERT");
} while (Console.ReadLine() == "r");



Console.Read();

