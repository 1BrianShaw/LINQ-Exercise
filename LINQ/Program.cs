using System.Collections.Generic;
using System.Linq;
namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>() 
            {
                "Duck Hunt 5",
                "Frogger",
                "Halos",
                "FF 11",
                "Road Rash"
            };

           var lengthOf = videoGames.OrderBy(x => x.Length).ToList();

            foreach( var game in lengthOf) 
            {
                Console.WriteLine(game);
            }

           


        }
    }
}
