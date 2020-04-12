using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void foo()
        {
            IList<Rose> roses = new List<Rose> { new Rose { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose gildedRose = new GildedRose(roses);
            gildedRose.UpdateQuality();
            Assert.AreEqual("fixme", roses[0].Name);
        }
    }
}
