using HW6_Generic;
using System;
using System.IO;
using System.Text.Json;

namespace HW5_Streams_FileSystem
{
    public static class Service_csv 
    {
        public const string path_csv = @"D:\VS2019\HW6_Generic\HW6_Generic\File_csv\File.csv";

        public static void StreamWriter_Csv()
        {
            Csv csv = new Csv();
            StreamWriter sw = File.CreateText(path_csv);
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            csv.Name = name;
            Console.WriteLine("Enter age");
            int age = int.Parse(Console.ReadLine());
            csv.Age = age;
            Console.WriteLine("Done");
            string csvJson = JsonSerializer.Serialize(csv, typeof(Csv));
            //  file.WriteLine(txtJson);
            sw.WriteLine(csvJson);
            // file.Close();
            sw.Close();
        }


     

    }
}

      