using System.Collections.Generic;
using PromotionEngine.ApplicationCore.Entities.CartAggregate;
using PromotionEngine.ApplicationCore.Entities.PromotionAggregate;
using PromotionEngine.ApplicationCore.Interfaces;

namespace PromotionEngine.ApplicationCore.Rules
{
    public class PromotionRuleForNQuantitySingleSKU : IPromotionRule
    {
        public (float SavedAmount, List<CartItem> PromotionAppliedItems) ApplyPromotion(List<CartItem> items, Promotion promotion)
        {
            throw new System.NotImplementedException();
        }
    }
}