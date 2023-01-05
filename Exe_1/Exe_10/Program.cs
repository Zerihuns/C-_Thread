//NestedLocks

class Program
{
    static object caztonLock = new object();
    static void Main(string[] args)
    {
        lock (caztonLock)
        {
            DoSth();
        }
    }

    private static void DoSth()
    {
        lock (caztonLock)
        {
            Task.Delay(2000);
            AnotherMethod();
        }
    }

    private static void AnotherMethod()
    {
        lock (caztonLock)
        {

        }
    }
}