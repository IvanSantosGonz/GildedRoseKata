﻿namespace csharp
{
    public class Rose {
        protected int MAXIMUM_ROSE_QUALITY = 50;
        public string Name { get; set; }

        public int SellIn { get; set; }
        public int Quality { get; set; }

        public Rose() {
        }

        public Rose(string name, int sellIn, int quality) {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }

        public void IncreaseQuality() {
            if (Quality < MAXIMUM_ROSE_QUALITY) {
                Quality++;
            }
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
     
        
        public Sulfuras(int sellIn, int quality) : base("Sulfuras, Hand of Ragnaros", 0, 40) {
        }

        public override void DecreaseQuality() {
        }
    }
}
