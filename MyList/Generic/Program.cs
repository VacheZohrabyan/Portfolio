// SimpleList<int> listOfInts = new SimpleList<int>();
//
// listOfInts.Add(10);
// listOfInts.Add(20);
// listOfInts.Add(30);
// listOfInts.Add(40);
// listOfInts.Add(50);
// listOfInts.Add(60);
//
// listOfInts.RemoveAt(3);
// SimpleList<string> listOfStrings = new SimpleList<string>();
// listOfStrings.Add("sjdmkacdm");
// listOfStrings.Add("sjdmkacdm");
// listOfStrings.Add("sjdmkacdm");
// listOfStrings.Add("sjdmkacdm");
// listOfStrings.Add("sjdmkacdm");
// listOfStrings.Add("sjdmkacdm");
//
// Console.ReadKey();
//
// class SimpleList<T>
// {
//     private T[] _item;
//     private int _size;
//
//     public SimpleList(int size = 4)
//     {
//         _item = new T[size];
//         _size = 0;
//     }
//
//     public void Add(T value)
//     {
//         if (_size >= _item.Length)
//         {
//             T[] newItem = new T[_item.Length * 2];
//             for (int i = 0; i < _item.Length; ++i)
//             {
//                 newItem[i] = _item[i];
//             }
//
//             _item = newItem;
//         }
//
//         _item[_size] = value;
//         _size++;
//     }
//
//     public void RemoveAt(int index)
//     {
//         if (index < 0 && index >= _size)
//         {
//             throw new IndexOutOfRangeException($"Index {index} is outside the bounds of the list.");
//         }
//
//         _size--;
//         for (int i = index; i < _size; ++i)
//         {
//             _item[i] = _item[i + 1];
//         }
//
//         _item[_size] = default(T);
//     }
//
//     public T GetAtIndex(int index)
//     {
//         if (index < 0 && index >= _size)
//         {
//             throw new IndexOutOfRangeException($"Index {index} is outside the bounds of the list.");
//         }
//
//         return _item[index];
//     }
// }
// List<int> array = new List<int> { 1, 2, 5, 7, 5, 3, 0 };
// MyTuple<int, int> result = GetMinAndMax(array);
//
// Console.WriteLine("Largest number is: " + result.Item1);
// Console.WriteLine("Smallest number is: " + result.Item2);
//
// Console.ReadKey();
//
// MyTuple<int, int> GetMinAndMax(IEnumerable<int> numbers)
// {
//     if (!numbers.Any())
//     {
//         throw new InvalidOperationException(
//             $"The input collection cannot be empty.");
//     }
//
//     int min = numbers.First();
//     int max = numbers.First();
//     foreach (int number in numbers)
//     {
//         if (min > number)
//         {
//             min = number;
//         }
//
//         if (max < number)
//         {
//             max = number;
//         }
//     }
//
//     return new MyTuple<int, int>(max, min);
// }
//
// public class MyTuple<T1, T2>
// {
//     public T1 Item1 { get; }
//     public T2 Item2 { get;}
//     public MyTuple(T1 item1, T2 item2)
//     {
//         Item1 = item1;
//         Item2 = item2;
//     }
// }
// List<decimal> decimals = new List<decimal> { 1.0m, 3.1m, 2.3m, 3.5m, 8.1m, 7.3m, 5.6m };
// List<int> otherInts = new List<int>();
//
// otherInts = decimals.ConvertTo<decimal, int>();
// Type type = 1.GetType();
// Type typeInt = int.Get
// List<int> ints = new List<int>{1,2,3,4};
// ints.AddToFront(23);
//
// Console.ReadKey();
//
// public static class ListExtensions
// {
//     public static List<TTarget> ConvertTo<TSource, TTarget>(this List<TSource> decimals)
//     {
//         List<TTarget> ints = new List<TTarget>();
//         foreach (TSource @decimal in decimals)
//         {
//             TTarget itemAfterCasting = (TTarget)Convert.ChangeType(@decimal, typeof(TTarget));
//             ints.Add(itemAfterCasting);
//         }
//
//         return ints;
//     }
//     
//     public static void AddToFront<T>(this List<T> ints, T items)
//     {
//         
//     }
// }
//
// List<int> numbers = new List<int> { 1, 23, 4, 5, 6, 7, 3, 3, 2, 212 };
// List<int> numbers1 = new List<int> { 1, -1, 5, 9, 7, 3, 3, 3 };
//
// Console.WriteLine("Is large than ten: " + IsAny(numbers1, IsLargeThanTen));
// Console.WriteLine("Is Even: " + IsAny(numbers1, IsEven));
//
// Console.ReadKey();
//
// bool IsLargeThanTen(int number)
// {
//     return number > 10;
// }
//
// bool IsEven(int number)
// {
//     return number % 2 == 0;
// }
//
// bool IsAny(IEnumerable<int> numbers, Func<int, bool> predicate)
// {
//     foreach (int number in numbers)
//     {
//         if (predicate(number))
//         {
//             return true;
//         }
//     }
//
//     return false;
// }
//
// Dictionary<string, string> countryToCurrencyMapping = new Dictionary<string, string>();
//
// countryToCurrencyMapping.Add("USA", "USD");
// countryToCurrencyMapping.Add("India", "INR");
// countryToCurrencyMapping.Add("Spain", "EUR");
//
// Console.ReadKey();
//
// using System.IO.MemoryMappedFiles;
// using System.Runtime.InteropServices;
//
// FilteringStrategySelector filteringStrategySelector = new FilteringStrategySelector();
// Console.WriteLine("Select Filter:");
// Console.WriteLine(string.Join(Environment.NewLine, filteringStrategySelector.FilterStrategyName));
//
// string filterType = Console.ReadLine();
// List<int> numbers = new List<int> { 1, 2, 4, 5, -5, -54, 4, 3323, -2, 54, -6, -633 };
//
// Filter numbersFilter = new Filter();
// var result = numbersFilter.FilterBy(filteringStrategySelector.Select(filterType), numbers);
//
// if (result.Count() == 0)
// {
//     Console.WriteLine("yes");
// }
// Print<int>(result);
// Console.ReadKey();
//
// void Print<T>(IEnumerable<T> result)
// {
//     foreach (T number in result)
//     {
//         Console.WriteLine(number);
//     }   
// }
//
// public class FilteringStrategySelector
// {
//     private readonly Dictionary<string, Func<int, bool>> _filterStrategy =
//         new Dictionary<string, Func<int, bool>>
//         {
//             ["Even"] = number => (number % 2) == 0,
//             ["Odd"] = number => (number % 2) == 1,
//             ["Positive"] = number => (number > 0)
//         };
//
//     public IEnumerable<string> FilterStrategyName => _filterStrategy.Keys;
//
//     public Func<int, bool> Select(string filterByType)
//     {
//         if (!_filterStrategy.ContainsKey(filterByType))
//         {
//             throw new NotSupportedException(
//                 $"{filterByType} is not a valid filter");
//         }
//
//         return _filterStrategy[filterByType];
//     }
// }
//
// public class Filter
// {
//     public IEnumerable<T> FilterBy<T>(Func<T, bool> predicate, IEnumerable<T> numbers)
//     {
//         List<T> result = new List<T>();
//         foreach (T number in numbers)
//         {
//             if (predicate(number))
//             {
//                 result.Add(number);
//             }
//         }
//
//         return result;
//     }
}