using System.ComponentModel;
using Lab4;

namespace p1;

public class SortUtility<T> where T : ProductIF
{
    private string sortName = "bubblesort";

    public SortUtility(string sortName)
    {
        this.sortName = sortName;
    }

    public SortUtility() {}
    
    public string GetName()
    {
        return sortName;
    }

    public List<T> Sort(List<T> data)
    {
        if (data == null) throw new ArgumentNullException(nameof(data));
        
        if (data.Count < 2)
        {
            return data;
        }

        if (sortName == "bubblesort")
        {
            return new BubblesortUtility<T>().Sort(data);
        }
        else if (sortName == "quicksort")
        {
            return new QuicksortUtility<T>().Sort(data);
        }

        return data;
    }

    public void Print(List<T> data)
    {
        if (data == null) throw new ArgumentNullException(nameof(data));
        if (sortName == "bubblesort")
            new BubblesortUtility<T>().Print(data);
        else if (sortName == "quicksort")
            new QuicksortUtility<T>().Print(data);
    }
}