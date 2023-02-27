using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Theory]
        [InlineData("foo",10,10,9,9)]
        [InlineData("foo",0,10,0,8)]
        [InlineData("foo",0,0,0,0)]
        [InlineData("foo",-1,-1,0,0)]
        [InlineData("foo",1,59,0,50)]
        public void standartItemTests(string name, int actualSellin, int actualQuantity, int expectedSellInn, int expectedQuantity)
        {
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = actualSellin, Quality = actualQuantity } };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(name, Items[0].Name);
            Assert.Equal(expectedSellInn, Items[0].SellIn);
            Assert.Equal(expectedQuantity, Items[0].Quality);
        }
        [Theory]
        [InlineData("Sulfuras, Hand of Ragnaros", 10, 10, 0, 80)]
        [InlineData("Sulfuras, Hand of Ragnaros", -1, 10, 0, 80)]
       
        public void legendaryItemTests(string name, int actualSellin, int actualQuantity, int expectedSellInn, int expectedQuantity)
        {
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = actualSellin, Quality = actualQuantity } };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(name, Items[0].Name);
            Assert.Equal(expectedSellInn, Items[0].SellIn);
            Assert.Equal(expectedQuantity, Items[0].Quality);
        }
        [Theory]
        [InlineData("Aged Brie", 10, 10, 9, 11)]
        [InlineData("Aged Brie", 10, 50, 9, 50)]

        public void agedBrieItemTests(string name, int actualSellin, int actualQuantity, int expectedSellInn, int expectedQuantity)
        {
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = actualSellin, Quality = actualQuantity } };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(name, Items[0].Name);
            Assert.Equal(expectedSellInn, Items[0].SellIn);
            Assert.Equal(expectedQuantity, Items[0].Quality);
        }
        [Theory]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", 11, 10, 10, 11)]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", 10, 10, 9, 12)]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", 5, 10, 4, 13)]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", 1, 10, 0, 0)]
        
        public void backstageItemTests(string name, int actualSellin, int actualQuantity, int expectedSellInn, int expectedQuantity)
        {
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = actualSellin, Quality = actualQuantity } };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(name, Items[0].Name);
            Assert.Equal(expectedSellInn, Items[0].SellIn);
            Assert.Equal(expectedQuantity, Items[0].Quality);
        }
        [Theory]
        [InlineData("Conjured Mana Cake", 10, 10, 9, 8)]
        [InlineData("Conjured Mana Cake", 0, 0, 0, 0)]

        public void conjuredItemTests(string name, int actualSellin, int actualQuantity, int expectedSellInn, int expectedQuantity)
        {
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = actualSellin, Quality = actualQuantity } };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(name, Items[0].Name);
            Assert.Equal(expectedSellInn, Items[0].SellIn);
            Assert.Equal(expectedQuantity, Items[0].Quality);
        }
    }
}
