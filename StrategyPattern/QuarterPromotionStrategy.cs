namespace StrategyPattern
{
    public class QuarterPromotionStrategy : IPromotionStrategy
    {
        public double DoPromotion(double price)
        {
            return price * 0.75;
        }
    }
}