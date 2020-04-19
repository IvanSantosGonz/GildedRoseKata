using System.Collections.Generic;

namespace csharp {
    public class GildedRose {
        private readonly IList<Rose> Roses;

        public GildedRose(IList<Rose> roses) {
            this.Roses = roses;
        }

        public void UpdateQuality() {
            foreach (var rose in Roses) {
                rose.UpdateStatus();
            }
        }
    }
}