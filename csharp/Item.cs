namespace csharp
{
    public readonly struct Item
    {
        public Item(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
            agingStrategy = new CommonAgingStrategy();
        }

        public Item(string name, int sellIn, int quality, AgingStrategy strategy)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
            agingStrategy = strategy;
        }

        public string Name { get; }
        public int SellIn { get; }
        public int Quality { get; }

        private AgingStrategy agingStrategy { get; }

        public override string ToString()
        {
            return Name + ", " + SellIn + ", " + Quality;
        }

        public Item AgeByOneDay()
        {
            return agingStrategy.AgeByOneDay(this);
        }
    }
}
