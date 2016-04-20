using System;
using System.Windows;
using System.Windows.Data;
using VendingMachineViewModel = VendingMachine.ViewModel.VendingMachineViewModel;

namespace VendingMachine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                DataContext = new VendingMachineViewModel();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void BuyEvent(object sender, RoutedEventArgs e)
        {
            var vendingMachine = DataContext as VendingMachineViewModel;
            if (vendingMachine != null)
            {
                vendingMachine.Balance -= vendingMachine.SelectedDrink.Price;
                --vendingMachine.SelectedDrink.Count;
                CollectionViewSource.GetDefaultView(vendingMachine.Drinks).Refresh();
            }

            
            e.Handled = true;
        }
    }
}
