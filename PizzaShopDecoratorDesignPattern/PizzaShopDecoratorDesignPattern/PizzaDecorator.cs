using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopDecoratorDesignPattern
{
    public abstract class PizzaDecorator(IPizza pizza) : IPizza
    {
        protected readonly IPizza _pizza = pizza;

        public virtual double GetCost()
        {
            return _pizza.GetCost();
        }

        public virtual List<string> GetToppingList()
        {
            return _pizza.GetToppingList();
        }
    }
}
