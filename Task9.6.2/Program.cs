ConsoleKeyInfo key;
List<string> ListNames = new List<string>() { "Ivanov", "Petreov", "Sidorov", "Po", "Price" };

Console.WriteLine("Our list of the names without sort:");
foreach (var item in ListNames)
{
    Console.WriteLine(item);
}

Console.WriteLine("Choose 1 or 2");
key = Console.ReadKey(true);

if (key.Key != ConsoleKey.D1 && key.Key != ConsoleKey.D2)
{
    throw new InputException("Choose '1' or '2', please");
}

Sorter SorterM = new Sorter(ListNames, key);
SorterM.Ascsort += SorterM.SortingAscend;
SorterM.Descsort += SorterM.SortingDescend;

SorterM.MethodSort(key);
