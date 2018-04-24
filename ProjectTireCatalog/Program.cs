using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTireCatalog.Properties;

namespace Gałązkiewicz.ProjectTireCatalog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BLC.DataProvider dataProvider = new BLC.DataProvider(Settings.Default.baza);

            foreach ( var producer in dataProvider.Producers)
            {
                Console.WriteLine($"{producer.Name} produkuje opony.");
            }

            Console.WriteLine();
            foreach ( var tire in dataProvider.Tires)
            {
                Console.WriteLine($"{tire.Model}: producer {tire.Producer.Name}, weight {tire.Waga}g");
            }

            Console.ReadKey();
        }
    }
}
