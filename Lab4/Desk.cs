using Lab4;

namespace p1;

public class Desk : ProductIF
{
    private int id;
    private double price;
    private string name;

    public Desk(int id, double price, string name)
    {
        this.id = id;
        this.price = price;
        this.name = name;
    }
    
    public int GetId()
    {
        return id;
    }
    
    public double GetPrice()
    {
        return price;
    }
    
    public string GetName()
    {
        return name;
    }

    public int CompareTo(ProductIF other)
    {
        return this.GetPrice().CompareTo(other.GetPrice());
    }
    public void SetPrice(double newPrice)
    {
        price = newPrice;
    }
    
    public void SetName(string newName)
    {
        name = newName;
    }
}