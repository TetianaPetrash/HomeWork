using HW6_Generic;
using HW6_Generic.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;


namespace HW5_Streams_FileSystem
{
    public static class Helper<T>
    {
        public static T Deserialization(string path)
        {
            //if (File.Exists(path))

            string data = File.ReadAllText(path);
            T info = JsonSerializer.Deserialize<T>(data);
            return info;
        }


        //public static void Display_Txt()
        //{
        //    try
        //    {
        //        using (StreamReader sr = new StreamReader(@"D:\VS2019\HW5_Streams_FileSystem\HW5_Streams_FileSystem\File_txt\File.txt"))
        //        {
        //            String line = sr.ReadToEnd();
        //            Console.WriteLine(line);
        //            sr.Close();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Exception: " + e.Message);
        //    }

        //    Console.ReadKey();
        //}


        //public static void Display_Csv()
        //{
        //    try
        //    {
        //        using (StreamReader sr = new StreamReader(@"D:\VS2019\HW5_Streams_FileSystem\HW5_Streams_FileSystem\File_csv\File.csv"))
        //        {
        //            String line = sr.ReadToEnd();
        //            Console.WriteLine(line);
        //            sr.Close();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Exception: " + e.Message);
        //    }

        //    Console.ReadKey();
        //}

        //public static GenericClass DeserializeFile(T item) //не уверена,что сработает
        //{
        //    GenericClass genericClass = new GenericClass();
        //    byte[] jsonUtf8Bytes = System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(item);
        //    var utf8Reader = new Utf8JsonReader(jsonUtf8Bytes);
        //    var deserializedWeatherForecast= System.Text.Json.JsonSerializer.Deserialize<GenericClass>(ref utf8Reader);
        //    return deserializedWeatherForecast;
        //}



        //public static GenericClass Deserialize (FileStream serializationStream)
        //    {
        //        BinaryFormatter formatter = new BinaryFormatter();

        //        using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
        //        {
        //            GenericClass deserilizePeople = (GenericClass)formatter.Deserialize(fs);
        //        }
        //        var x = (GenericClass)formatter.Deserialize(serializationStream);
        //        return x;
        //    }

        //public GenericClass Deserialization(T genericClass) // GenericClass наш класс,мы его возвращаем
        //{
        //    GenericClass user = JsonConvert.DeserializeObject<T>(genericClass);
        //}
    }

}
