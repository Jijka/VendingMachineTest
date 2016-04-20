using System.Windows.Data;
using GalaSoft.MvvmLight.CommandWpf;

namespace WildBerriesTask.ViewModel
{
    internal partial class VendingMachineViewModel
    {
        #region Commands

        public RelayCommand AddToBalanceCommand { get; set; }

        public RelayCommand ChangeCommand { get; set; }

        public RelayCommand BuyCommand { get; set; }

        #endregion

        private void CommandInitialize()
        {
            AddToBalanceCommand = new RelayCommand(ExecuteAddToBalance, () => CanExecuteAddToBalance);
            ChangeCommand = new RelayCommand(ExecuteChange, () => CanExecuteChange);
            BuyCommand = new RelayCommand(ExecuteBuy,()=> CanExecuteBuy);
        }

        public bool CanExecuteBuy => SelectedDrink?.Count > 0 && Balance >= SelectedDrink?.Price;
        private void ExecuteBuy()
        {
            Balance -= SelectedDrink.Price;
            --SelectedDrink.Count;
            CollectionViewSource.GetDefaultView(Drinks).Refresh();
        }

        private bool CanExecuteAddToBalance
        {
            get
            {
                if (SelectedCoin == null) return false;
                return !SelectedCoin.IsBlocked;
            }
        }
        private void ExecuteAddToBalance() => Balance += SelectedCoin.Rating;

        private bool CanExecuteChange => Balance > 0;
        private void ExecuteChange() => Balance = 0;

    }
}
