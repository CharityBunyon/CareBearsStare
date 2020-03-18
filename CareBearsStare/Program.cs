using System;
using System.Collections.Generic;
using System.Linq;
using CareBearsStare.Bears;

namespace CareBearsStare
{
    class Program
    {
        static void Main(string[] args)
        {

            var definitions = new Dictionary<string, List<string>>();
            definitions.Add("martin", new List<string> { "smart", "strong", "important" });
            Console.WriteLine(string.Join("you is", definitions["martin"]));

            var grumpyBear = new GrumpyBear();
            var tenderHeart = new TenderHeart();
            var tinderHeart = new TinderHeart();

            var careBears = new List<CareBearBase> { grumpyBear, tenderHeart, tinderHeart };

            foreach (var bear in careBears)
            {
                bear.Care("Nathan");
                bear.Stare();
            }

            //LINQ Stuff- library that has a lot of methods in it

            var namesThatStartWithT = careBears.Where(bear => bear.Name.StartsWith('T'));
            var careBearNames = careBears.Select(bear => bear.Name);

            var careBearNamesThatStartWithT = careBears
                .Where(bear => bear.Name.StartsWith('T'))
                .Select(bear => bear.Name);

            var anyTinderHearts = careBears.Any(bear => bear is TinderHeart); //also called lambda expressions or delegates.. is this bear a tinderheart? if so then true
            var allTinderHearts = careBears.All(bear => bear is TinderHeart);

            
            

            var firstBear = careBears.First();
            var firstBearStartWithT = careBears.First(bear => bear.Name.StartsWith('T')); //Can pass in a string. Ex: ("Te")
            // var blowsUp = careBears.First(bear => bear.Name.StartsWith('T')); ... throws an exeption
            var works = careBears.FirstOrDefault(bear => bear.Name.StartsWith('W'));

            var skippedGrumpy = careBears.Skip(1).Take(2); //skip the 1 entry and give me the next to. WIll throw an exception if I have less than 3 items in a list.

            var numberOfCharacters = careBears.Max(bear => bear.Name.Length);

            var orderedBears = careBears.OrderBy(bear => bear.BellyBadge); //will order alphabetically or bydescending with is the opposite

            // Bedtime Bear, Birthday Bear, Cheer Bear, Friend Bear, Funshine Bear, Good Luck Bear, Grumpy Bear, Love-a-lot Bear, Tenderheart Bear, and Wish Bear.

        }
    }
}
