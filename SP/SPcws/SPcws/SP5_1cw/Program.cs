// See https://aka.ms/new-console-template for more information
namespace SP5_1cw;
class MyProgram
{
    private const int Threads = 4;
    private IList<int> numbers = new List<int>();
    private CountdownEvent @event = new (Threads);
    static void Main(string[] args)
    {
        new MyProgram().Run();
    }
    private void Run()
    {
        for (int i = 0; i < Threads; i++)
            new Thread(Fill).Start();
        @event.Wait();
        foreach (var number in numbers)
            Console.WriteLine(number);
    }
    private void Fill()
    {
        Random random = new Random();
        for (int i = 0; i < 100; i++)
            lock (numbers)
            {
                numbers.Add(random.Next(100));
            }
        @event.Signal();
    }

}