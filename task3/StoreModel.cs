


public delegate void StoreAction(string msg, bool isAlert);

public class Product
{
    public string Name { get; set; }
    public int Stock { get; set; }
    public int MaxStock { get; set; }

    public Product(string name, int initial, int max)
    {
        Name = name; Stock = initial; MaxStock = max;
    }
}

public class TradingPoint
{
    public string Name { get; private set; }
    public List<Product> Products { get; private set; }

    public event StoreAction OnEvent;

    public TradingPoint(string name, List<Product> products)
    {
        Name = name;
        Products = products;
    }

    public bool ProcessPurchase(string productName, int amount)
    {
        var p = Products.Find(x => x.Name == productName);
        if (p != null && p.Stock >= amount)
        {
            p.Stock -= amount;
            OnEvent?.Invoke($"Куплено {p.Name} ({amount} шт)", false);
            return true;
        }
        OnEvent?.Invoke($"ТОВАР {productName} ЗАКОНЧИЛСЯ", true);
        return false;
    }
    public void RestockAll()
    {
        foreach (var p in Products)
        {
            p.Stock = p.MaxStock;
        }
        OnEvent?.Invoke("ПОСТАВКА: Все товары восполнены", false);
    }
}
