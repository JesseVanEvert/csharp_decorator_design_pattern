# CSharp decorator design pattern assignment

Assignment 1: Create the Pizza Base Class

    Objective: Implement a Pizza interface and a basic Pizza class.
        Define a IPizza interface with a method GetCost() to calculate the cost of the pizza.
        Implement the BasicPizza class that implements IPizza and returns a fixed cost for a basic pizza (e.g., $5).

Assignment 2: Create the Pizza Decorator Class

    Objective: Implement the PizzaDecorator class.
        Create an abstract class PizzaDecorator that implements IPizza and holds a reference to another IPizza object.
        Ensure that the decorator class delegates the GetCost() method to the wrapped pizza object.
        The decorator class should be flexible to allow different types of pizza decorations.

Assignment 3: Implement Concrete Decorators

    Objective: Create concrete decorators for pizza toppings.
        Implement decorators for different pizza toppings like:
            CheeseDecorator: Adds a fixed cost for cheese (e.g., $2).
            PepperoniDecorator: Adds a fixed cost for pepperoni (e.g., $3).
            MushroomDecorator: Adds a fixed cost for mushrooms (e.g., $1.50).
        Each decorator should add its specific cost and update the description of the pizza.

Assignment 4: Testing the Decorators

    Objective: Write test code to create pizzas with different combinations of toppings.
        Start by creating a basic pizza object.
        Dynamically decorate the pizza with various toppings (e.g., cheese, pepperoni, and mushrooms).
        Print the description and cost of each pizza variant.

Assignment 5: Enhance with Discount Decorator (Advanced)

    Objective: Add a discount decorator to apply a discount if the total cost of the pizza exceeds a certain threshold.
        Create a DiscountDecorator class that checks if the pizza cost exceeds a certain value (e.g., $20).
        Apply a 10% discount if the threshold is exceeded, and update the pizza cost accordingly.

Assignment 6: Refactor for Multiple Toppings in One Go

    Objective: Refactor your decorators to allow adding multiple toppings in a single decorator.
        Instead of chaining individual decorators for each topping, create a single decorator that accepts a list of toppings and applies their costs dynamically.
        This will allow for more flexible ordering, where multiple toppings can be added in a single step.

Bonus Assignment: Pizza Size as a Decorator

    Objective: Implement a decorator that changes the size of the pizza.
        Create a SizeDecorator class that allows the pizza to be "small", "medium", or "large", with varying costs (e.g., small = $5, medium = $7, large = $10).
        Decorate the pizza with a chosen size and reflect the cost in the GetCost() method.

Submission Requirements:

    Code Implementation: Submit your C# files for each assignment.
    Documentation: Provide brief documentation on how your decorators work, including examples of pizza combinations.
    Test Cases: Demonstrate the functionality of your decorators through different test cases.

Let me know if you need more clarification on any of the assignments!
