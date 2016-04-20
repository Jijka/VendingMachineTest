using System.Collections.ObjectModel;

namespace VendingMachine.Models.Drinks
{
    internal interface IDrinksDataProvider
    {
        ObservableCollection<Drink> GetData();
    }
}