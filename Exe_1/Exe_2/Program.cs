class Program
{
    private static bool isCompleted;
    static readonly object lockCompleted = new object();

    static void Main(string[] args)
    {
        Thread thread = new Thread(HelloWorld);
        //Worked Thread
        thread.Start();
        //Main Thread
        HelloWorld();
    }

    private static void HelloWorld()
    {
        lock (lockCompleted)
        {
            if (!isCompleted)
            {
                isCompleted = true;
                Console.WriteLine("Hello World should print only once");

            }
        }


    }
}