Console.Write("Podaj liczbe: ");
var input = Console.ReadLine();
var liczba = Int32.Parse(input);
for (int i = 1; i <= liczba; i++)
{
    if (i % 2 == 0)
        Console.WriteLine(i);
}
