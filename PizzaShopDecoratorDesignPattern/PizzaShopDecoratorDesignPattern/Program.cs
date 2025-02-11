using PizzaShopDecoratorDesignPattern;

IPizza pizza = new BasicPizza();

pizza = new CheeseDecorator(pizza);
pizza = new MushroomDecorator(pizza);
pizza = new PepperoniDecorator(pizza);
pizza = new DiscountDecorator(pizza);

foreach (var topping in pizza.GetToppingList())
{
    Console.WriteLine(topping);
}

Console.WriteLine($"Cost: {pizza.GetCost()};");
