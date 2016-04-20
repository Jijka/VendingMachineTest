using System;
using System.Windows;
using WildBerriesTask.Magic;

namespace WildBerriesTask.Models.Drinks
{
    [Magic]
    public class Drink
    {
        public Drink() { }

        public Drink(int price, string name, int count = 20)
        {
            Price = price;
            Name = name;
            Count = count;
        }
        public int Price { get; set; }

        public string Name { get; set; }

        public int Count { get; set; }

        public event EventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(EventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}