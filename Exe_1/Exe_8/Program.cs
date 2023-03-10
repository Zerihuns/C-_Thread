//Task Chaining
class Program
{
    static void Main(string[] args)
    {
        Task<string> antecedent = Task.Run(() =>
        {
            Task.Delay(2000);
            return DateTime.Today.ToShortDateString();
        });
        Task<string> continuation = antecedent.ContinueWith(x =>
        {
            return "Today is " + antecedent.Result;
        });
        Console.WriteLine("This will display before the result");
        Console.WriteLine(continuation.Result);
    }
}