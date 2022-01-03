

using HW6_Generic;
using HW6_Generic.Helper;
using System;
using System.Collections.Generic;
using System.IO;

namespace HW5_Streams_FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Service_txt.StreamWriter_Txt();
            Service_csv.StreamWriter_Csv();
            var result = Helper<Txt>.Deserialization(Service_txt.path_txt);
            var result2 = Helper<Csv>.Deserialization(Service_csv.path_csv);
            List<GenericClass> genericClass = new List<GenericClass>();
            genericClass.Add(result);
            genericClass.Add(result2);
            foreach (var item in genericClass)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Age);
            }
        }

    }
}
