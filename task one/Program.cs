namespace task_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estimate for carpet cleaning service");
            Console.WriteLine("Number of small carpets:");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of large carpets:");
            int value2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price per small room: $25");
            Console.WriteLine("Price per large room: $35");
            Console.WriteLine($"cost={(value1 * 25) + (value2 * 35)}");
            // int cost = (value1 * 25) + (value2 * 35);

            Console.WriteLine($"Tax={(0.06) * ((value1 * 25) + (value2 * 35))}");
            // double tax = 0.06 * cost;
            Console.WriteLine($"Totalcost:{((value1 * 25) + (value2 * 35)) + ((0.06) * ((value1 * 25) + (value2 * 35)))}");
            // Console.WriteLine($"Total cost: {cost + tax}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
