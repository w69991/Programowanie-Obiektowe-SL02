Console.Write("Podaj liczbe: ");
var input = Console.ReadLine();
var liczba = Int32.Parse(input);

if  (liczba%2==0)
{
    Console.WriteLine("Liczba parzysta");
}
else
{
    Console.WriteLine("Liczba nieparzysta");
}
