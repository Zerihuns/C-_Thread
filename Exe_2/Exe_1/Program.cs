//ThreadSafety
    class Program
{
    static Dictionary<int, string> items = new();
    static void Main()
    {
        var task1 = Task.Factory.StartNew(AddItem);
        var task2 = Task.Factory.StartNew(AddItem);
        var task3 = Task.Factory.StartNew(AddItem);
        var task4 = Task.Factory.StartNew(AddItem);
        var task5 = Task.Factory.StartNew(AddItem);
        Task.WaitAll(task3, task2, task1, task4, task5);
    }

    private static void AddItem()
    {
        lock (items)
        {
            Console.WriteLine("Lock acquired by " + Task.CurrentId);
            items.Add(items.Count, "Cazton " + items.Count);
        }

        Dictionary<int, string> dictionary;
        lock (items)
        {
            Console.WriteLine("Lock 2 acquired by " + Task.CurrentId);
            dictionary = items;
        }
        lock (dictionary)
        {
            foreach (var kvp in dictionary)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
        }
        //int key = 1;
        //if (!dictionary.ContainsKey(key))
        //{
        //    dictionary.Add(key, "Cazton");
        //}
    }
}
