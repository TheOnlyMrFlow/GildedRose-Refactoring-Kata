using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class ConcertTicketAgingStrategy: AgingStrategy
    {
        public override Item AgeByOneDay(Item item)
        {
            var newQuality = item.Quality;
            var newSellin = item.SellIn;

            if (newQuality < 50)
            {
                newQuality++;

                if (newSellin < 11 && newQuality < 50)
                {
                    newQuality++;

                    if (newSellin < 6)
                        newQuality++;
                }

            }

            newSellin--;

            if (newSellin < 0)
                newQuality = 0;

            return new Item(item.Name, newSellin, newQuality);
        }
    }
}
