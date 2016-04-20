using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using GalaSoft.MvvmLight;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using VendingMachine.Models.Coins;
using VendingMachine.Magic;
using VendingMachine.Models.Drinks;

namespace VendingMachine.ViewModel
{
    internal partial class VendingMachineViewModel : ViewModelBase, IDataErrorInfo
    {
        #region Properties

        [Magic]
        public IOrderedEnumerable<Coin> Coins { get; set; }

        [Magic]
        public IOrderedEnumerable<Drink> Drinks { get; set; }

        [Magic]
        public Coin SelectedCoin { get; set; }

        [Magic]
        public Drink SelectedDrink { get; set; }

        [Magic]
        public int Balance { get; set; }

        #endregion

        public VendingMachineViewModel()
        {
            #region Commands

            CommandInitialize();

            #endregion

            using (var container = new UnityContainer())
            {
                try
                {
                    container.LoadConfiguration();
                    var coinsProvider = container.Resolve<ICoinsDataProvider>();
                    var drinksProvider = container.Resolve<IDrinksDataProvider>();
                    Coins = coinsProvider
                        .GetData()
                        .OrderBy(c => c.Rating);
                    Drinks = drinksProvider
                        .GetData()
                        .Where(d => d.Count > 0)
                        .OrderBy(d => d.Price);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        #region Validation

        public string this[string columnName]
        {
            get
            {
                string msg = null;
                switch (columnName)
                {
                    case "Balance":
                        if (Balance < 0)
                            msg = "Сумма баланса не может быть отрицательной";
                        Error = "Balance";
                        break;
                    default:
                        throw new ArgumentException(
                            "Unrecognized property: " + columnName);
                }
                return msg;
            }

        }

        public string Error { get; set; }

        #endregion
    }
}