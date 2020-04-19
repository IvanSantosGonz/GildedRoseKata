namespace csharp
{
    public class Rose
    {
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

        public void DecreaseQuality() {
            Quality--;
        }
        
        public void DecreaseSellIn() {
            SellIn--;
        }
        
    }
}
