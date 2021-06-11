namespace PromotionEngine.ApplicationCore.Entities.PromotionAggregate
{
    public class PromotionForNQuantitySingleSKU
    {
        public char SKUId { get; set; }
        public int Quantity { get; set; }
        public float OfferPrice { get; set; }
    }
}