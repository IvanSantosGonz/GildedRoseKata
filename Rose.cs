namespace csharp
{
    public class Rose {
        private int MAXIMUM_ROSE_QUALITY = 50;
        protected string Name { get; set; }

        protected int SellIn { get; set; }
        protected int Quality { get; set; }

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

    }
}
