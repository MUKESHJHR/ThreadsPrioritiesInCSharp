namespace ThreadsPrioritiesInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread threadObj1 = new Thread(SomeMethod)
            {
                Name = "Thread1"
            };
            threadObj1.Priority = ThreadPriority.Normal;

            Thread threadObj2 = new Thread(SomeMethod)
            {
                Name = "Thread2"
            };
            threadObj2.Priority = ThreadPriority.Lowest;

            Thread threadObj3 = new Thread(SomeMethod)
            {
                Name = "Thread3"
            };
            threadObj3.Priority = ThreadPriority.Highest;

            Console.WriteLine($"Thread 1 Priority :{threadObj1.Priority}");
            Console.WriteLine($"Thread 2 Priority :{threadObj2.Priority}");
            Console.WriteLine($"Thread 3 Priority :{threadObj3.Priority}");

            threadObj1.Start();
            threadObj2.Start();
            threadObj3.Start();

            Console.ReadKey();
        }

        public static void SomeMethod()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Thread Name : {Thread.CurrentThread.Name} Printing {i}");
            }
        }
    }
}