using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class UnperishableAgingStrategy: AgingStrategy
    {
        public override Item AgeByOneDay(Item item)
        {
            return new Item(item.Name, item.SellIn, item.Quality);
        }
    }
}
