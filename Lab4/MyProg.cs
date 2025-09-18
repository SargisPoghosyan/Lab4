using p1;

namespace Lab4;

public class MyProg
{
    public static void Main(string[] args)
    {
        Company xyz = new Company();
        xyz.sortUtility = new SortUtility<ProductIF>();
        MyProg myProg = new MyProg();
        List<ProductIF> products = myProg.GetProducts();
        xyz.sortUtility.Sort(products);
        xyz.sortUtility.Print(products);
        
    }

    public List<ProductIF> GetProducts()
    {
        List<ProductIF> products = new List<ProductIF>();
        products.Add(new Desk(2, 15.25, "Corner Desk"));
        products.Add(new Desk(1, 20.30, "Writing Desk"));
        products.Add(new Desk(4, 15.85, "Standing Desk"));
        products.Add(new Desk(3, 25.13, "Lap Desk"));
        products.Add(new Desk(5, 22.56, "Floating Desk"));

        return products;
    }
}