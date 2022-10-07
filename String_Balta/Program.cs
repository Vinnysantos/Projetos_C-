using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
           var id = Guid.NewGuid();
            id.ToString();

            id = new Guid("56b70774-b70c-4181-8eed-cfdc865cce72");
            Console.WriteLine(id);
        }
    }
}