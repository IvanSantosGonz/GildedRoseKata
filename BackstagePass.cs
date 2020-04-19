namespace csharp {
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
}