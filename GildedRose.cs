using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private readonly IList<Rose> Roses;
        public GildedRose(IList<Rose> roses)
        {
            this.Roses = roses;
        }

        public void UpdateQuality()
        {
        const string BACKSTAGE_PASSES = "Backstage passes to a TAFKAL80ETC concert";
            for (var i = 0; i < Roses.Count; i++)
            {
                if (Roses[i].Name != "Aged Brie" && Roses[i].Name != BACKSTAGE_PASSES)
                {
                    if (Roses[i].Quality > 0)
                    {
                        if (Roses[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            Roses[i].DecreaseQuality();
                        }
                    }
                }
                else
                {
                    if (Roses[i].Quality < 50)
                    {
                        Roses[i].IncreaseQuality();

                        if (Roses[i].Name == BACKSTAGE_PASSES)
                        {
                            if (Roses[i].SellIn < 11)
                            {
                                if (Roses[i].Quality < 50)
                                {
                                    Roses[i].IncreaseQuality();
                                }
                            }

                            if (Roses[i].SellIn < 6)
                            {
                                if (Roses[i].Quality < 50)
                                {
                                    Roses[i].IncreaseQuality();
                                }
                            }
                        }
                    }
                }

                if (Roses[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Roses[i].DecreaseSellIn();
                }

                if (Roses[i].SellIn < 0)
                {
                    if (Roses[i].Name != "Aged Brie")
                    {
                        if (Roses[i].Name != BACKSTAGE_PASSES)
                        {
                            if (Roses[i].Quality > 0)
                            {
                                if (Roses[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    Roses[i].DecreaseQuality();
                                }
                            }
                        }
                        else
                        {
                            Roses[i].Quality = Roses[i].Quality - Roses[i].Quality;
                        }
                    }
                    else
                    {
                        if (Roses[i].Quality < 50)
                        {
                            Roses[i].IncreaseQuality();
                        }
                    }
                }
            }
        }
    }
}
