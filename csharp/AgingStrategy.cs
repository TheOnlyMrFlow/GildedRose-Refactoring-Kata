﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public abstract class AgingStrategy
    {
        public abstract Item AgeByOneDay(Item item);
    }
}
