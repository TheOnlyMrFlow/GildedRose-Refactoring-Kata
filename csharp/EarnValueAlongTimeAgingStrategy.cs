using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class EarnValueAlongTimeAgingStrategy: AgingStrategy
    {
        public override Item AgeByOneDay(Item item)
        {
            var newQuality = Math.Min(item.Quality + 1, 50);
            var newSellIn = item.SellIn - 1;
            if (newSellIn < 0 && newQuality < 50)
                newQuality++;

            return new Item(item.Name, newSellIn, newQuality);
        }
    }
}
