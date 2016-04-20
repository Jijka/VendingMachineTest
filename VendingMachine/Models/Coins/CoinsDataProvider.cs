using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace WildBerriesTask.Models.Coins
{
    [XmlRoot(ElementName = "CoinsData")]
    public class CoinsDataProvider: ICoinsDataProvider
    {
        [XmlArray("Coins")]
        public ObservableCollection<Coin> List = new ObservableCollection<Coin>();

        ~ CoinsDataProvider()
        {
           //List.Clear();
        }

        public ObservableCollection<Coin> GetData()
        {
            return List;
        }
    }
}