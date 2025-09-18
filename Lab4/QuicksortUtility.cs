using p1;

namespace Lab4;

public class QuicksortUtility<T> : SortUtility<T> where T : ProductIF
{
    public new List<T> Sort(List<T> data)
    {
        //use quicksort
        data.Sort();
        return data;
    }

    public new void Print(List<T> data)
    {
        foreach (T item in data)
        {
            Console.WriteLine("Price: " + item.GetPrice() + ", Name: " + item.GetName() + ", ID: " + item.GetId() + ".");
        }
    }
}