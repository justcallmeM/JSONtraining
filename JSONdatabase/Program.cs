using System;
using System.IO;
using Newtonsoft.Json;

namespace trainingJSON
{
    class Program
    {
        static void Main()
        {
            var readings = File.ReadAllText(@"C:\Users\mindaugas.pikelis\source\repos\trainingJSON\trainingJSON\database.json");
            var database = JsonConvert.DeserializeObject<Database>(readings); //object pakeist i top level
        }
    }
}
