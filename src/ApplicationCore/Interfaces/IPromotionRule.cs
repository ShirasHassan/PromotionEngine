using System.Collections.Generic;
using PromotionEngine.ApplicationCore.Entities.CartAggregate;
using PromotionEngine.ApplicationCore.Entities.PromotionAggregate;

namespace PromotionEngine.ApplicationCore.Interfaces
{
    public interface IPromotionRule
    {
        (float SavedAmount, List<CartItem> PromotionAppliedItems) ApplyPromotion(List<CartItem> items,
            Promotion promotion);
    }
}