using Upcasting__Downcasting;

internal class Program
{
    static void Main(string[] args)
    {
        Fruit[] basket = new Fruit[]
        {
            new Apple { Price = 2, Sort = "Quba almasi", VitaminA = 10, VitaminB = 100 },
            new Pineapple { Price = 7.9m, Sort = "Ela nov ananas", VitaminE = 8, VitaminD = 12 },
            new Orange { Price = 3.5m, Sort = "Astara portagali", VitaminC = 40 }
        };

        foreach (var fruit in basket)
        {
            if (fruit is Apple apple)
            {
                Console.WriteLine("Bu alma novundedi");
                Console.WriteLine($"Price: {apple.Price}, Sort: {apple.Sort}, Vitamin A: {apple.VitaminA}, Vitamin B: {apple.VitaminB}");
            }
            else if (fruit is Pineapple pineapple)
            {
                Console.WriteLine("Bu ananas novundedi");
                Console.WriteLine($"Price: {pineapple.Price}, Sort: {pineapple.Sort}, Vitamin E: {pineapple.VitaminE}, Vitamin D: {pineapple.VitaminD}");
            }
            else if (fruit is Orange orange)
            {
                Console.WriteLine("Bu portagal novundedi");
                Console.WriteLine($"Price: {orange.Price}, Sort: {orange.Sort}, Vitamin C: {orange.VitaminC}");
            }

            Console.WriteLine();
        }
    }
}
