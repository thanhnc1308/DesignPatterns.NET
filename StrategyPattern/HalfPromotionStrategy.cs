namespace StrategyPattern
{
    public class HalfPromotionStrategy : IPromotionStrategy
    {
        public double DoPromotion(double price)
        {
            return price * 0.5;
        }
    }
}