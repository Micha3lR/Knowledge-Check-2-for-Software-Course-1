using System.Security.Cryptography.X509Certificates;

namespace KnowledgeCheck2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Apple>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var apple = new Apple();

                Console.WriteLine("Enter the value for (Price): ");
                apple.Price = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter the value for (Name): ");
                apple.Name = Console.ReadLine();

                Console.WriteLine("Enter the value for (Weight): ");
                apple.WeightInPounds = double.Parse(Console.ReadLine());

                recordList.Add(apple);
            }

            // Print out the list of records using Console.WriteLine()
            Console.WriteLine("\nApple records:");
            foreach (var apple in recordList)
            {
                Console.WriteLine(apple);
            }
        }
    }
}
