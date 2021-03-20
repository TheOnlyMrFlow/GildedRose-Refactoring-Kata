using System;
using System.Collections.Generic;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> Items = new List<Item>{
                new Item ("+5 Dexterity Vest", 10, 20),
                new Item ("Aged Brie", 2, 0, new EarnValueAlongTimeAgingStrategy()),
                new Item ("Elixir of the Mongoose", 5, 7),
                new Item ("Sulfuras, Hand of Ragnaros", 0, 80, new UnperishableAgingStrategy()),
                new Item ("Sulfuras, Hand of Ragnaros", -1, 80, new UnperishableAgingStrategy()),
                new Item("Backstage passes to a TAFKAL80ETC concert", 15, 20, new ConcertTicketAgingStrategy()),
                new Item("Backstage passes to a TAFKAL80ETC concert", 10, 49, new ConcertTicketAgingStrategy()),
                new Item("Backstage passes to a TAFKAL80ETC concert", 5, 49, new ConcertTicketAgingStrategy()),
				// this conjured item does not work properly yet
				new Item ("Conjured Mana Cake", 3, 6)
            };

            var app = new GildedRose(Items);


            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j]);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}
