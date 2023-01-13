// See https://aka.ms/new-console-template for more information
using PizzaCost;
using PizzaCost.PizzaBase;
using PizzaCost.Toppings;

Console.WriteLine("Hello, World!");
Pizza p = new Paneer(new Cheese(new Tomato(new BBQChicken())));
Console.WriteLine(p.GetCost()); // should output 370
Console.WriteLine(p.GetDescription()); // should output BBChicken + Tomato + Cheese + Paneer