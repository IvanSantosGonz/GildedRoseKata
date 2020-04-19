using System;
using System.Collections.Generic;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Rose> roses = new List<Rose>{
                new Rose ("+5 Dexterity Vest", 10, 20),
                new AgedBrie(2, 0),
                new Rose ("Elixir of the Mongoose", 5, 7),
                new Sulfuras(0, 80),
                new Sulfuras(-1, 80),
                new BackstagePass(15, 20),
                new BackstagePass(10,49),
                new BackstagePass(5,49),
				// this conjured item does not work properly yet
				new Conjured(3, 6)
            };

            var app = new GildedRose(roses);
            
            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < roses.Count; j++)
                {
                    System.Console.WriteLine(roses[j]);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}
