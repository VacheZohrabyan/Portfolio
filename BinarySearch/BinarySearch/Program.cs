List<int> sortedList = new List<int> { 1, 2, 5, 7, 10, 12, 23, 54 };

int index_0 = sortedList.BinarySearch(0);
int index_2 = sortedList.BinarySearch(5);
int index_5 = sortedList.BinarySearch(11);
int index_7 = sortedList.BinarySearch(54);
int index0 = sortedList.BinarySearch(0);
int index5 = sortedList.BinarySearch(12);
int index7 = sortedList.BinarySearch(100);

Console.ReadLine();

public static class Extension
{
    public static int? BinarySearch<T>(this IList<T> items, T itemForSearch) where T : IComparable<T>
    {
        int leftBound = 0;
        int rightBound = items.Count - 1;

        while (leftBound <= rightBound)
        {
            int midBound = (leftBound + rightBound) / 2;
            int compare = itemForSearch.CompareTo(items[midBound]);
            if (compare == 0)
            {
                return midBound;
            }
            else if (compare < 0)
            {
                rightBound = midBound - 1;
            }
            else
            {
                leftBound = midBound + 1;
            }
        }

        return null;
    }
}