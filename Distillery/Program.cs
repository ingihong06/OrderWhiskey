using System;

namespace Distillery
{

    internal class Program
    {
        public static void Main(String[] args)
        {
            Distillery distillery = new WhiskeyFactory();
            Console.Write("위스키 : ");
            string whiskey = Console.ReadLine();

            Distillation whiskey1 = distillery.create(whiskey);
            whiskey1.drink();
        }
    }
}