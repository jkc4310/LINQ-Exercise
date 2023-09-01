namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
           

            var myList = new List<string>() { "Halo", "Grand Theft Auto", "Call of Duty", "Gran Turismo", "Fortnite", "Ghost of Tsushima" };

            var sorted = myList.OrderBy(x => x.Length);

            foreach (var x in sorted)
            {
                Console.WriteLine(x);
            }
        }

    }
}
