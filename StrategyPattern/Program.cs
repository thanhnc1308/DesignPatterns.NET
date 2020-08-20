using StrategyPattern;

class Program
{
    static void Main(string[] args)
    {
        Ticker ticker = new Ticker();
        ticker._name = "Ticker 1";
        ticker._price = 100;
        System.Console.WriteLine($"{ticker._promotionStrategy.GetType().Name} : {ticker.GetPromotionPrice()}");
        ticker.SetPromotionStrategy(new QuarterPromotionStrategy());
        System.Console.WriteLine($"{ticker._promotionStrategy.GetType().Name} : {ticker.GetPromotionPrice()}");
        ticker.SetPromotionStrategy(new HalfPromotionStrategy());
        System.Console.WriteLine($"{ticker._promotionStrategy.GetType().Name} : {ticker.GetPromotionPrice()}");
    }
}