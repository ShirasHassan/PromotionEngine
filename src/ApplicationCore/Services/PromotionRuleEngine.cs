using System.Collections.Generic;
using PromotionEngine.ApplicationCore.Entities.CartAggregate;
using PromotionEngine.ApplicationCore.Entities.OrderAggregate;
using PromotionEngine.ApplicationCore.Interfaces;

namespace PromotionEngine.ApplicationCore.Services
{
    public class PromotionRuleEngine : IPromotionRuleEngine
    {
        private IPromotionRepository _promotionRepository;
        private List<IPromotionRule> _promotionRules;
        public PromotionRuleEngine(IPromotionRepository promotionRepository, List<IPromotionRule> promotionRules)
        {
            _promotionRepository = promotionRepository;
            _promotionRules = promotionRules;
        }
        
        public Order ExecuteRules(Cart cart)
        {
            throw new System.NotImplementedException();
        }
    }
}