using System;
using System.IO;
using Newtonsoft.Json;

namespace trainingJSON
{
    class Program
    {
        static void Main()
        {
            var readings = File.ReadAllText(@"C:\Users\mindaugas.pikelis\Source\Repos\JSONtraining\JSONdatabase\database.json");
            var database = JsonConvert.DeserializeObject<ProductList>(readings);

            foreach(var a in database.productList)
            {
                if (a.id.Contains("scarf"))
                {
                    Console.WriteLine(a.name + "\n" + a.description + "\n" + a.price);
                }
            }
        }
    }
}
