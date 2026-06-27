
using DesignPatternsApp.src.DesignPatterns.Behavioral.IteratorPattern.GoodExample;

ShoppingList shoppingList = new ShoppingList();
shoppingList.AddItem("Milk");
shoppingList.AddItem("Eggs");
shoppingList.AddItem("Bread");

var iterator = shoppingList.CreateIterator();

while(iterator.HasNext())
{
    Console.WriteLine(iterator.Current());
    iterator.Next();
}

