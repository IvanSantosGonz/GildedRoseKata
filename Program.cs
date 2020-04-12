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
                new Rose {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Rose {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Rose {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Rose {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Rose {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Rose
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Rose
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new Rose
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
				// this conjured item does not work properly yet
				new Rose {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
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
