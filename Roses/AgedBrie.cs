namespace csharp {
    public class AgedBrie : Rose {
        
        public AgedBrie(int sellIn, int quality) : base("Aged Brie", sellIn, quality) {
        }
        
        public override void UpdateStatus() {
            DecreaseSellIn();
            IncreaseQuality();
        }
    }
}