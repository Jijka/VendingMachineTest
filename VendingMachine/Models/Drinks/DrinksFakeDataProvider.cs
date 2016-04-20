namespace VendingMachine.Models.Drinks
{
    
    public class DrinksFakeDataProvider : DrinksDataProvider
    {

        public DrinksFakeDataProvider()
        {
            List.Add(new Drink(1, "water"));
            List.Add(new Drink(2, "cofee"));
            List.Add(new Drink(3, "tea"));
            List.Add(new Drink(4, "green tea"));
            List.Add(new Drink(5, "milk"));
            List.Add(new Drink(10, "cacao"));
        }
    }
}