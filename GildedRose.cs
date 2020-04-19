﻿using System.Collections.Generic;

namespace csharp {
    public class GildedRose {
        private readonly IList<Rose> Roses;

        public GildedRose(IList<Rose> roses) {
            this.Roses = roses;
        }

        public void UpdateQuality() {
            const string BACKSTAGE_PASSES = "Backstage passes to a TAFKAL80ETC concert";
            for (var i = 0; i < Roses.Count; i++) {
                /*if (Roses[i].Name != "Aged Brie" && Roses[i].Name != BACKSTAGE_PASSES) {
                    Roses[i].DecreaseQuality();
                }
                else {
                    Roses[i].IncreaseQuality();
                }

                Roses[i].DecreaseSellIn();

                if (Roses[i].SellIn < 0) {
                    if (Roses[i].Name != "Aged Brie") {
                        Roses[i].DecreaseQuality();
                    }
                    else {
                        Roses[i].IncreaseQuality();
                    }
                }*/
                Roses[i].UpdateStatus();
            }
        }
    }
}