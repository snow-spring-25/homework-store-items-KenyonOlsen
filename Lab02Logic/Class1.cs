using System.ComponentModel;
using System.Dynamic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace Lab02Logic;

public abstract class StoreItem
{
    public decimal Cost = 5.0M;
    public string ProductType { get; set;} 
    public StoreItem(string Type)
    {
        ProductType=Type;
    }
    public StoreItem(string Type, decimal cost): this(Type)
    {
        Cost = cost;
    }
    public static decimal GetCost(decimal c)
    {
        //Cost = c;
        return c;
    }

}

public class Apple : StoreItem
{
    public Apple(string Type) : base(Type)
    {
    }
}

public class Banana : StoreItem
{

    public Banana(string Type) : base(Type)
    {
    }
}

public class Orange : StoreItem
{

    public Orange(string Type, decimal Cost) : base(Type, Cost)
    {
    }
}


public class ShelfItems
{
    public ShelfItems()
    {

    }
    public List<StoreItem> ShelfList = [];
    public void AddItem(string Type)
    {
        if(Type=="Apple")
        {
            StoreItem newApple = new Apple("Apple");
            ShelfList.Add(newApple);
        }

        else if (Type == "Banana")
        {
            StoreItem newBanana = new Banana("Banana");
            ShelfList.Add(newBanana);
        }

        else if (Type == "Orange")
        {
            StoreItem newOrange = new Orange("Orange",4.0m);
            ShelfList.Add(newOrange);
        }
    }
}
