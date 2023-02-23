using System;
using ServerAllocator;
namespace ServerProcessorApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Allocate a BatchPerformance server with the lowest available number.");
            Console.WriteLine(AllocateServer.Allocate("BatchPerformance"));
            Console.WriteLine(AllocateServer.Allocate("BatchPerformance"));
            Console.WriteLine("These are the remaining available servernumbers");
            foreach (var item in AllocateServer.BatchPerformanceNumbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("De-allocate a BatchPerformance and put the number back in the list.");
            AllocateServer.DeAllocate("BatchPerformance20");
            Console.WriteLine("These are the remaining available servernumbers");
            foreach (var item in AllocateServer.BatchPerformanceNumbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Re-Allocate a BatchPerformance server with the lowest available number.");
            Console.WriteLine(AllocateServer.Allocate("BatchPerformance"));
            Console.WriteLine("These are the remaining available servernumbers");
            foreach (var item in AllocateServer.BatchPerformanceNumbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //BatchProcessing
            //Console.WriteLine("Allocate a BatchProcessing server with the lowest available number.");
            //Console.WriteLine(Allocate("BatchProcessing"));
            //foreach (var item in BatchProcessingNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //Console.WriteLine("De-allocate a BatchProcessing and put the number back in the list.");
            //Console.WriteLine(AllocateServer.DeAllocate("BatchProcessing40"));
            //foreach (var item in AllocateServer.BatchProcessingNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //Console.WriteLine("Re-Allocate a BatchProcessing server with the lowest available number.");
            //Console.WriteLine(Allocate("BatchProcessing"));
            //foreach (var item in BatchProcessingNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            Console.ReadLine();
        }
    }
}