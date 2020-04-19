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
                new Rose ("Aged Brie", 2, 0),
                new Rose ("Elixir of the Mongoose", 5, 7),
                new Rose ("Sulfuras, Hand of Ragnaros", 0, 80),
                new Rose ("Sulfuras, Hand of Ragnaros", -1, 80),
                new Rose("Backstage passes to a TAFKAL80ETC concert", 15, 20),
                new Rose("Backstage passes to a TAFKAL80ETC concert",10,49),
                new Rose("Backstage passes to a TAFKAL80ETC concert",5,49),
				// this conjured item does not work properly yet
				new Rose ("Conjured Mana Cake", 3, 6)
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
