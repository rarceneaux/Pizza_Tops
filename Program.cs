using System;
using Newtonsoft.Json;
using System.IO;
namespace Pizza_Tops
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonConvert.DeserializeObject<>(File.ReadAllText(@"c:\movie.json"));

        }
    }
}
