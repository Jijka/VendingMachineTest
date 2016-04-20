using System.Collections.ObjectModel;

namespace WildBerriesTask.Models.Drinks
{
    internal interface IDrinksDataProvider
    {
        ObservableCollection<Drink> GetData();
    }
}