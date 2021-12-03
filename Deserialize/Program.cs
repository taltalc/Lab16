using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Deserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            string path = "C:\\Автоматизация bim проектирования\\С#\\Домашка 16\\Lab16\\Serialize\\bin\\Debug\\Lab\\Product.json";
            StreamReader streamReader = new StreamReader(path, false);

            line = streamReader.ReadToEnd();
            streamReader.Close();
            Product[] products2 = JsonSerializer.Deserialize<Product[]>(line);

            double max = products2[0].Price;
            int maxIndex = 0;
            for (int i = 0; i < 5; i++)
            {
                if (products2[i].Price > max)
                {
                    max = products2[i].Price;
                    maxIndex = i;
                }
            }
            Console.WriteLine("Товар с максимальной ценой:");
            Console.WriteLine("Код:" + products2[maxIndex].Code);
            Console.WriteLine("Наименование:" + products2[maxIndex].Name);
            Console.WriteLine("Цена:" + products2[maxIndex].Price + "руб.");
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
