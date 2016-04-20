namespace VendingMachine.Models.Coins
{
    internal class CoinsFakeDataProvider : CoinsDataProvider
    {
        public CoinsFakeDataProvider()
        {
            List.Add(new Coin(5));
            List.Add(new Coin(2));
            List.Add(new Coin(15, true));
            List.Add(new Coin(1));
            List.Add(new Coin(10));
            List.Add(new Coin(3, true));
        }
    }
}