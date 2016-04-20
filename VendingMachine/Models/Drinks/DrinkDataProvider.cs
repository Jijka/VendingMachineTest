using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace WildBerriesTask.Models.Drinks
{
    [XmlRoot(ElementName = "DrinksData")]
    public class DrinksDataProvider: IDrinksDataProvider
    {
        [XmlArray("Drinks")]
        public ObservableCollection<Drink> List = new ObservableCollection<Drink>();
        ~DrinksDataProvider()
        {
            //List.Clear();
        }
        public ObservableCollection<Drink> GetData()
        {
            return List;
        }
    }
}