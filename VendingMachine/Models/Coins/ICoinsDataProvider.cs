using System.Collections.ObjectModel;

namespace WildBerriesTask.Models.Coins
{
    internal interface ICoinsDataProvider
    {
        ObservableCollection<Coin> GetData();
    }
}