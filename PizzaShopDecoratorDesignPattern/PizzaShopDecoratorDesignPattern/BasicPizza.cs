using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopDecoratorDesignPattern
{
    public class BasicPizza : IPizza
    {
        private double _cost = 5.5;
        private List<string> _toppings = new List<string> { "Tomato sauce" };

        public double GetCost()
        {
            return _cost;
        }

        public List<string> GetToppingList()
        {
            return _toppings;
        }
    }
}
