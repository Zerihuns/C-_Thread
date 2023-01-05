using System.Diagnostics;

//TplIntro
    class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Time taken" + stopwatch.ElapsedMilliseconds);
        stopwatch.Stop();
        stopwatch.Start();

        Parallel.For(0, 10, i =>
        {
            Console.WriteLine(i);
        });
        Console.WriteLine("Time taken" + stopwatch.ElapsedMilliseconds);
    }
}