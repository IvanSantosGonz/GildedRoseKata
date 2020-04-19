using NUnit.Framework;
using System.Collections.Generic;

namespace csharp {
    [TestFixture]
    public class GildedRoseTest {
        [Test]
        public void At_the_end_of_each_day_roses_lowers_quality_and_sell_in() {
            var rose = new Rose("A normal rose", 28, 40);
            IList<Rose> roses = new List<Rose> {rose};
            GildedRose gildedRose = new GildedRose(roses);

            gildedRose.UpdateQuality();

            var roseAfterFiveDays = new Rose("A normal rose", 27, 39);
            Assert.True(roseAfterFiveDays.Equals(rose));
        }

        [Test]
        public void Once_the_sell_by_date_has_passed_Quality_degrades_twice_as_fast() {
            var rose = new Rose("A normal rose", 0, 40);
            IList<Rose> roses = new List<Rose> {rose};
            GildedRose gildedRose = new GildedRose(roses);

            for (var i = 0; i < 5; i++) {
                gildedRose.UpdateQuality();
            }

            var roseAfterFiveDays = new Rose("A normal rose", -5, 30);
            Assert.True(roseAfterFiveDays.Equals(rose));
        }

        [Test]
        public void the_quality_of_a_rose_is_never_negative() {
            var rose = new Rose("Elixir of the Mongoose", 0, 0);
            IList<Rose> roses = new List<Rose> {rose};
            GildedRose gildedRose = new GildedRose(roses);

            for (var i = 0; i < 5; i++) {
                gildedRose.UpdateQuality();
            }

            var roseAfterFiveDays = new Rose("Elixir of the Mongoose", -5, 0);
            Assert.True(roseAfterFiveDays.Equals(rose));
        }

        [Test]
        public void Aged_Brie_rose_actually_increases_in_Quality_the_older_it_gets() {
            var rose = new AgedBrie(5, 35);
            IList<Rose> roses = new List<Rose> {rose};
            GildedRose gildedRose = new GildedRose(roses);

            for (var i = 0; i < 5; i++) {
                gildedRose.UpdateQuality();
            }

            //It is done so to test equality between child and parent
            var roseAfterFiveDays = new Rose("Aged Brie", 0, 40);
            Assert.True(roseAfterFiveDays.Equals(rose));

        }

        [Test]
        public void The_quality_of_a_rose_is_never_more_than_50() {
            var rose = new AgedBrie(0, 50);
            IList<Rose> roses = new List<Rose> {rose};
            GildedRose gildedRose = new GildedRose(roses);

            for (var i = 0; i < 5; i++) {
                gildedRose.UpdateQuality();
            }

            var roseAfterFiveDays = new Rose("Aged Brie", -5, 50);
            Assert.True(roseAfterFiveDays.Equals(rose));
        }

        [Test]
        public void Sulfuras_are_a_legendary_rose_and_never_has_to_be_sold_or_decrease_their_quality() {
            var rose = new Sulfuras(0, 40);
            IList<Rose> roses = new List<Rose> {rose};

            GildedRose gildedRose = new GildedRose(roses);
            for (var i = 0; i < 5; i++) {
                gildedRose.UpdateQuality();
            }

            var roseAfterFiveDays = new Rose("Sulfuras, Hand of Ragnaros", 0, 40);
            Assert.True(roseAfterFiveDays.Equals(rose));
        }

        [Test]
        public void
            Backstage_passes_like_aged_brie_by_2_when_there_are_10_days_or_less_and_by_3_when_there_are_5_days_or_less() {
            var rose = new BackstagePass(10, 20);
            IList<Rose> roses = new List<Rose> {rose};

            GildedRose gildedRose = new GildedRose(roses);
            for (var i = 0; i < 5; i++) {
                gildedRose.UpdateQuality();
            }

            var roseAfterFiveDays = new Rose("Backstage passes to a TAFKAL80ETC concert", 5, 31);
            Assert.True(roseAfterFiveDays.Equals(rose));

            for (var i = 0; i < 5; i++) {
                gildedRose.UpdateQuality();
            }

            roseAfterFiveDays = new Rose("Backstage passes to a TAFKAL80ETC concert", 0, 46);

            Assert.True(roseAfterFiveDays.Equals(rose));
        }

        [Test]
        public void Backstage_passes_like_aged_brie_gets_quality_0_after_concert() {
            var rose = new BackstagePass(10, 20);
            IList<Rose> roses = new List<Rose> {rose};

            GildedRose gildedRose = new GildedRose(roses);
            for (var i = 0; i < 11; i++) {
                gildedRose.UpdateQuality();
            }

            var roseAfterFiveDays = new Rose("Backstage passes to a TAFKAL80ETC concert", -1, 0);
            Assert.True(roseAfterFiveDays.Equals(rose));
        }
    }
}