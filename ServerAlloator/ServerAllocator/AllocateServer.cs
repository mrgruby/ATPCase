using System;
using System.Text.RegularExpressions;

namespace ServerAllocator
{
    public static class AllocateServer
    {
        public static List<int> BatchPerformanceNumbers = new() { 20, 21, 22, 23, 24 };
        public static List<int> BatchCalculationNumbers = new() { 30, 31, 32, 33, 34 };
        public static List<int> BatchProcessingNumbers = new() { 40, 41, 42, 43, 44 };
        public static string Allocate(string serverType)
        {
            var allocateResult = "";
            BatchPerformanceNumbers.Sort();
            BatchCalculationNumbers.Sort();
            BatchProcessingNumbers.Sort();

            switch (serverType)
            {
                case "BatchPerformance":
                    if (BatchProcessingNumbers.Any())
                    {
                        var batchPerformanceNumber = BatchPerformanceNumbers.First();
                        allocateResult = $"BatchPerformance{batchPerformanceNumber}";
                        BatchPerformanceNumbers.Remove(batchPerformanceNumber);
                    }
                    else
                        allocateResult = "There are no available server numbers";
                    break;
                case "BatchCalculation":
                    if (BatchCalculationNumbers.Any())
                    {
                        var batchCalculationNumber = BatchCalculationNumbers.First();
                        allocateResult = $"BatchCalculationNumbers{batchCalculationNumber}";
                        BatchCalculationNumbers.Remove(batchCalculationNumber);
                    }
                    else
                        allocateResult = "There are no available server numbers";
                    break;
                case "BatchProcessing":
                    if (BatchProcessingNumbers.Any())
                    {
                        var batchProcessingNumber = BatchProcessingNumbers.First();
                        allocateResult = $"BatchProcessingNumbers{batchProcessingNumber}";
                        BatchProcessingNumbers.Remove(batchProcessingNumber);
                    }
                    else
                        allocateResult = "There are no available server numbers";
                    break;
                    //Remove this number from the array.
            }
            return allocateResult;
        }

        public static string DeAllocate(string serverName)
        {
            var values = SplitString(serverName);
            var deallocateResult = "";

            switch (values.name)
            {
                case "BatchPerformance":
                    if (!BatchPerformanceNumbers.Contains(Convert.ToInt32(values.number)))
                    {
                        BatchPerformanceNumbers.Add(Convert.ToInt32(values.number));
                        deallocateResult = "The BatchPerformance server number has been returned to the list";
                    }
                    else
                        deallocateResult = "The BatchPerformance server number already exists in the list";
                    break;
                case "BatchCalculation":
                    if (!BatchCalculationNumbers.Contains(Convert.ToInt32(values.number)))
                    {
                        BatchCalculationNumbers.Add(Convert.ToInt32(values.number));
                        deallocateResult = "The BatchCalculation server number has been returned to the list";
                    }
                    else
                        deallocateResult = "The BatchCalculation server number already exists in the list";
                    break;
                case "BatchProcessing":
                    if (!BatchProcessingNumbers.Contains(Convert.ToInt32(values.number)))
                    {
                        BatchProcessingNumbers.Add(Convert.ToInt32(values.number));
                        deallocateResult = "The BatchProcessing server number has been returned to the list";
                    }
                    else
                        deallocateResult = "The BatchProcessing server number already exists in the list";
                    break;
            }
            return deallocateResult;
        }

        private static (string name, string number) SplitString(string serverName)
        {
            var numAlpha = new Regex("(?<Alpha>[a-zA-Z]*)(?<Numeric>[0-9]*)");
            var match = numAlpha.Match(serverName);

            var alpha = match.Groups["Alpha"].Value;
            var num = match.Groups["Numeric"].Value;

            return (alpha, num);
        }


        private static int[] RemoveItem(int[] array, int number)
        {
            int index = Array.IndexOf(array, number);
            array = array.Where((e, i) => i != index).ToArray();

            return array;
        }
    }
}