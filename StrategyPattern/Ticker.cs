namespace StrategyPattern
{
    public class Ticker
    {
        public IPromotionStrategy _promotionStrategy { get; set; }
        public string _name { get; set; }
        public double _price { get; set; }

        public Ticker()
        {
            this._promotionStrategy = new NoPromotionStrategy();
        }

        public Ticker(IPromotionStrategy promotionStrategy)
        {
            this._promotionStrategy = promotionStrategy;
        }

        #region Public
        public void SetPromotionStrategy(IPromotionStrategy promotionStrategy)
        {
            this._promotionStrategy = promotionStrategy;
        }

        public double GetPromotionPrice()
        {
            return this._promotionStrategy.DoPromotion(this._price);
        }
        #endregion Public
    }
}