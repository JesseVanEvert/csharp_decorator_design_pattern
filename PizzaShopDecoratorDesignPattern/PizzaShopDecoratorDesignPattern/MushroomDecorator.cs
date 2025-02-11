using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopDecoratorDesignPattern
{
    public class MushroomDecorator(IPizza pizza) : PizzaDecorator(pizza)
    {
        public override double GetCost()
        {
            return _pizza.GetCost() + 1.5;
        }

        public override List<string> GetToppingList()
        {
            List<string> toppings = new List<string>(_pizza.GetToppingList());
            toppings.Add("Mushrooms");
            return toppings;
        }
       
    }
}
