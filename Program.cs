using System;

namespace VsCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var doc = new Document("Hello");
            doc.Print();
            Console.ReadLine();
        }
    }
}
