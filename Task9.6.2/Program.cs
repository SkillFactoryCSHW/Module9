using MyException;

ConsoleKeyInfo key;
List<string> ListNames = new List<string>() { "Ivanov", "Petreov", "Sidorov", "Po", "Price" };

Console.WriteLine("Our list of the names without sort:");
foreach (var item in ListNames)
{
    Console.WriteLine(item);
}
try
{
    Console.WriteLine("Choose 1 or 2");
    key = Console.ReadKey(true);

    Sorter SorterM = new Sorter(ListNames, key);
    SorterM.Ascsort += SorterM.SortingAscend;
    SorterM.Descsort += SorterM.SortingDescend;

    SorterM.MethodSort(key);
}
catch (Exception ex)
{
    if (ex is InputException) Console.WriteLine("Choose '1' or '2', please");
    else Console.WriteLine("Something else");
}


