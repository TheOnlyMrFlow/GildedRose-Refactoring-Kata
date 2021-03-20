using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class CommonAgingStrategy: AgingStrategy
    {
        public override Item AgeByOneDay(Item item)
        {
            var newQuality = item.Quality - 1;
            var newSellIn = item.SellIn - 1;
            if (newSellIn < 0 && newQuality > 0)
                newQuality--;

            return new Item(item.Name, newSellIn, newQuality);
        }
    }
}
