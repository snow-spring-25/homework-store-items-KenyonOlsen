using System.ComponentModel;
using System.Dynamic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace Lab02Logic;

public class StoreItem
{
    public decimal Cost;
    public StoreItem()
    {

    }
    public static decimal GetCost()
    {
        return 1.2m;
    }
    private int itemCost = 1;
}

public class Apple : StoreItem
{
    public decimal Cost = GetCost();

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
            Apple newApple = new Apple();
            ShelfList.Add(newApple);
        }
    }
}