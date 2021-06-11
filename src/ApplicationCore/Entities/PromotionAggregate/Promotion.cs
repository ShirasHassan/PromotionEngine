using System;
using Newtonsoft.Json.Linq;

namespace PromotionEngine.ApplicationCore.Entities.PromotionAggregate
{
    public class Promotion
    {
        public string PromotionName { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string ApplicableRuleName { get; set; }
        public JObject DataPoints { get; set; } 
    }
}