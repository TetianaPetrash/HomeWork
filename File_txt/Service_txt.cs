using HW6_Generic;
using System;
using System.IO;
using System.Text.Json;

namespace HW5_Streams_FileSystem
{
    public static class Service_txt
    {
        public const string path_txt = @"D:\VS2019\HW6_Generic\HW6_Generic\File_txt\File.txt";
        public static void StreamWriter_Txt()
        {
            Txt txt = new Txt();
            StreamWriter sw = File.CreateText(path_txt);
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            txt.Name = name;
            Console.WriteLine("Enter age");
            int age = int.Parse(Console.ReadLine());
            txt.Age = age;
            Console.WriteLine("Done");
            string txtJson = JsonSerializer.Serialize(txt, typeof(Txt));
            //  file.WriteLine(txtJson);
            sw.WriteLine(txtJson);
            // file.Close();
            sw.Close();
        }

        


    }
}
