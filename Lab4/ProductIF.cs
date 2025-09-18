namespace Lab4;

public interface ProductIF : IComparable<ProductIF>
{
    public int GetId();
    public double GetPrice();
    public string GetName();
    public void SetPrice(double newPrice);
    public void SetName(string newName);

    public int CompareTo(ProductIF other)
    {
        return this.GetPrice().CompareTo(other.GetPrice());  
    }

}