using System;
using System.Threading;

class Program
{
    static Random random = new Random();

    static void ff()
    {
        while (true)
        {
            int n = random.Next();
            if (n % 2025 == 0)
            {
                break;
            }
            Console.WriteLine(n);
            Thread.Sleep(100);
        }
    }

    static void Main(string[] args)
    {
        Thread thread = new Thread(new ThreadStart(ff));
        thread.Start();
        thread.Join();  
        Console.WriteLine("Đã thực hiện xong.");
    }
}
