namespace csharp
{
    public class Rose {
        private int MAXIMUM_ROSE_QUALITY = 50;
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

        public bool Equals(Rose other) {
            return Name == other.Name && SellIn == other.SellIn && Quality == other.Quality;
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Rose) obj);
        }

        public override int GetHashCode() {
            unchecked {
                var hashCode = (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ SellIn;
                hashCode = (hashCode * 397) ^ Quality;
                return hashCode;
            }
        }

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }

        public virtual void IncreaseQuality() {
            if (Quality < MAXIMUM_ROSE_QUALITY) {
                Quality++;
            }
        }

        public virtual void DecreaseQuality() {
            if (Quality > 0) {
                Quality--;
                if (SellIn < 0) {
                    Quality--;
                }
            }
        }
        
        public virtual void DecreaseSellIn() {
            SellIn--;
        }

        public virtual void UpdateStatus() {
            DecreaseSellIn();
            DecreaseQuality();
        }
        
    }

    public class Sulfuras : Rose {
        
        public Sulfuras(int sellIn, int quality) : base("Sulfuras, Hand of Ragnaros", sellIn, quality) {
        }

        public override void DecreaseQuality() {
        }
        
        public override void DecreaseSellIn() {
        }
    }
    
    public class BackstagePass : Rose {
        
        public BackstagePass(int sellIn, int quality) : base("Backstage passes to a TAFKAL80ETC concert", sellIn, quality) {
        }

        public override void IncreaseQuality() {
            if (SellIn < 0) {
                Quality = 0;
            }
            else if (SellIn < 6) {
                Quality = Quality + 3;
            }
            else if (SellIn < 11) {
                Quality = Quality + 2;
            }
            else {
                Quality++;
            }
        }

        public override void UpdateStatus() {
            DecreaseSellIn();
            IncreaseQuality();
        }
    }
    
    public class AgedBrie : Rose {
        
        public AgedBrie(int sellIn, int quality) : base("Aged Brie", sellIn, quality) {
        }
        
        public override void UpdateStatus() {
            DecreaseSellIn();
            IncreaseQuality();
        }
    }
}
