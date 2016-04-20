using System.Collections.ObjectModel;

namespace VendingMachine.Models.Coins
{
    internal interface ICoinsDataProvider
    {
        ObservableCollection<Coin> GetData();
    }
}