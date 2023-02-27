using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                switch (item.Name)
                {
                    case { } s when s.StartsWith("Sulfuras"):
                        item.SellIn = 0;
                        item.Quality = 80;
                        break;
                    case "Aged Brie":
                        item.SellIn -= 1;
                        item.Quality += 1;
                        validate(item);
                        break;
                    case { } s when s.StartsWith("Backstage passes"):
                        item.Quality += defineTicketStep(item.SellIn);
                        item.SellIn -= 1;
                        validate(item);
                        if (item.SellIn == 0) item.Quality = 0;
                        break;
                    case { } s when s.StartsWith("Conjured"):
                        item.Quality -= 1;
                        standartLowering(item);
                        break;
                    default:
                        standartLowering(item);
                        break;
                }
            }
        }

        private int defineTicketStep(int sellIn)
        {
            var qualityStep = 1;
            if (sellIn <= 10 && sellIn > 0) qualityStep += 1;
            if (sellIn <= 5 && sellIn > 0) qualityStep += 1;
            return qualityStep;
        }

        private void standartLowering(Item item)
        {
            if (item.SellIn == 0) item.Quality -= 1;
            item.Quality -= 1;
            item.SellIn -= 1;
            validate(item);
        }

        private void validate(Item item)
        {
            if (item.SellIn < 0) item.SellIn = 0;
            if (item.Quality < 0) item.Quality = 0;
            if (item.Quality > 50) item.Quality = 50;
        }
    }
}
