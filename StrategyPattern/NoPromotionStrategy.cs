namespace StrategyPattern
{
    public class NoPromotionStrategy : IPromotionStrategy
    {
        public double DoPromotion(double price)
        {
            return price;
        }
    }
}