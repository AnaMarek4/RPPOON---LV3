using System;

namespace LV3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset dataset = new Dataset("csv.txt");
            Dataset copy = (Dataset)dataset.Clone();

            ConsoleNotification notification = new ConsoleNotification("Ana", "LV3", "Razvoj programske podrške objektno orijentiranim načelima", DateTime.Now, Category.ALERT, ConsoleColor.Blue);
            NotificationManager manager = new NotificationManager();
            manager.Display(notification);
        }
    }
}
