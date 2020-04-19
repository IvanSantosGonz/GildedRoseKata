namespace csharp {
    public class Conjured : Rose {
        
        public Conjured(int sellIn, int quality) : base("Conjured Mana Cake", sellIn, quality) {
        }

        protected override void DecreaseQuality() {
            Quality = Quality - 2;
        }

    }
}