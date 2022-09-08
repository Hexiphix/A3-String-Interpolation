namespace String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            var pi = Math.PI;

            Console.WriteLine("\n");

            Console.WriteLine($"{today,40:MMMM dd, yyyy}");
            Console.WriteLine($"{today:yyyy.MM.dd}");
            Console.WriteLine($"Day {today:dd' of 'MMMM, yyyy}");
            Console.WriteLine($"Year: {today:yyyy}, Month: {today:MM}, Day: {today:dd}");
            Console.WriteLine($"{today,10:dddd}");
            Console.WriteLine($"{today,-10:hh:mm tt}{today,10:dddd}");
            Console.WriteLine($"h:{today:hh}, m:{today:mm}, s:{today:ss}");
            Console.WriteLine($"{today:yyyy.MM.dd.hh.mm.ss}");

            Console.WriteLine("\n");

            Console.WriteLine($"{pi:C}");
            Console.WriteLine($"{pi,10:n3}");
        }
    }
}