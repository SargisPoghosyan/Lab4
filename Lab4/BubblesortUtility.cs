using p1;

namespace Lab4;

public class BubblesortUtility<T> : SortUtility<T> where T : ProductIF
{
    public new List<T> Sort(List<T> data)
    {
        
        for (int i = 0; i < data.Count - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < data.Count - i - 1; j++)
            {
                if (data[j].GetPrice() > data[j + 1].GetPrice())
                {
                    T temp = data[j];
                    data[j] = data[j + 1];
                    data[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }

        return data;
    }

    public new void Print(List<T> data)
    {
        foreach (T item in data)
        {
            Console.WriteLine("ID: " + item.GetId() + ", Name: " + item.GetName() + ", Price: " + item.GetPrice() + ".");
        }    }
}