using System.Threading;

namespace _Thread
{
    internal class Program
    {

        public static void PrintLoop(object start_end) {
            int[] arr = start_end as int[];
            for (int i = arr[0]; i < arr[1]; i++)
            {
                Console.WriteLine($"\t{i} - thread");
                Thread.Sleep(50);
            }
        }
        static void Main(string[] args)
        {
            ParameterizedThreadStart pts = new ParameterizedThreadStart(PrintLoop); 
            Thread t = new Thread(PrintLoop);
            int[] arr = { 11, 56 };
            t.Start(arr);

        }
    }
}