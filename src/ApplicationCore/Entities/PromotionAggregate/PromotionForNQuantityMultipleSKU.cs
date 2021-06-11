using System.Collections.Generic;

namespace PromotionEngine.ApplicationCore.Entities.PromotionAggregate
{
    public class PromotionForNQuantityMultipleSKU
    {
        public List<PromotionCriterion> Criteria { get; set; }
        public float OfferPrice { get; set; }
    }
    
    public abstract class PromotionCriterion
    {
        public char SKUId { get; set; }
        public int Quantity { get; set; }
    }
    
}