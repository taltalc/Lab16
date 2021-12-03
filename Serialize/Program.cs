using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;


namespace Serialize
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Lab/Product.json";

            if (!File.Exists(path))
            {
                File.Create(path);

            }
            Console.WriteLine("Введите параметры пяти товаров в указанной форме:");
            Console.WriteLine("код");
            Console.WriteLine("наименование");
            Console.WriteLine("цена, руб.");
            Product[] products = new Product[]
            {
                new Product
                {

                    Code=Convert.ToInt32(Console.ReadLine()),
                    Name=Convert.ToString(Console.ReadLine()),
                    Price=Convert.ToDouble(Console.ReadLine())
                },
                new Product
                {
                    Code=Convert.ToInt32(Console.ReadLine()),
                    Name=Convert.ToString(Console.ReadLine()),
                    Price=Convert.ToDouble(Console.ReadLine())
                },
                new Product
                {
                    Code=Convert.ToInt32(Console.ReadLine()),
                    Name=Convert.ToString(Console.ReadLine()),
                    Price=Convert.ToDouble(Console.ReadLine())
                },
                new Product
                {
                    Code=Convert.ToInt32(Console.ReadLine()),
                    Name=Convert.ToString(Console.ReadLine()),
                    Price=Convert.ToDouble(Console.ReadLine())
                },
                new Product
                {
                    Code=Convert.ToInt32(Console.ReadLine()),
                    Name=Convert.ToString(Console.ReadLine()),
                    Price=Convert.ToDouble(Console.ReadLine())
                },

            };
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };

            string jsstring = JsonSerializer.Serialize(products, options);
            using (StreamWriter stream = new StreamWriter(path, false))
            {
                stream.WriteLine(jsstring);
            }

            Console.WriteLine(jsstring);
            Console.ReadKey();
        }
    }
    public class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }



    }
}
