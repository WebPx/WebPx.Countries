namespace WebPx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var countries = new WebPx.Catalogs.CountriesService();

            Console.WriteLine("World Countries");
            Console.WriteLine();
            Console.WriteLine("Code\t| Name");
            Console.WriteLine("--------------------------------------");
            foreach (var country in countries.GetCountries())
            {
                Console.WriteLine($"{country.Code}\t{country.Name}");
            }
        }
    }
}
