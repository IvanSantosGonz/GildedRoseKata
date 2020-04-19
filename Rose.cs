namespace csharp
{
    public class Rose
    {
        public Rose(string name, int sellIn, int quality) {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public Rose() {
        }

        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }

        public void IncreaseQuality() {
            Quality++;
        }

        public virtual void DecreaseQuality() {
            if (Quality > 0)
                Quality--;
        }
        
        public void DecreaseSellIn() {
            SellIn--;
        }
        
    }

    public class Sulfuras : Rose {
     
        public Sulfuras(int sellIn, int quality) : base("Sulfuras, Hand of Ragnaros", 0, 40){
        }

        public override void DecreaseQuality() {
        }
    }
}
