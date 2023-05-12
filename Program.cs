using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_oop
{
    using System;
    using System.Collections.Generic;


    namespace TabletGallery
    {
        public class Device
        {
            public string Name { get; set; }
            public string Brand { get; set; }
            public decimal Price { get; set; }

            public Device(string name, string brand, decimal price)
            {
                Name = name;
                Brand = brand;
                Price = price;
            }

            public Device(Device device)
            {
                Name = device.Name;
                Brand = device.Brand;
                Price = device.Price;
            }

            public override string ToString()
            {
                return $"Device Name: {Name}, Brand: {Brand}, Price: {Price} USD";
            }
        }

        public class Tablet : Device
        {
            public int Storage { get; set; }
            public double DisplaySize { get; set; }

            public Tablet(string name, string brand, decimal price, int storage, double displaySize)
                : base(name, brand, price)
            {
                Storage = storage;
                DisplaySize = displaySize;
            }

            public Tablet(Tablet tablet)
                : base(tablet)
            {
                Storage = tablet.Storage;
                DisplaySize = tablet.DisplaySize;
            }

            public override string ToString()
            {
                return $"Tablet Name: {Name}, Brand: {Brand}, Price: {Price} $, Storage: {Storage} GB, Display Size: {DisplaySize} inches";
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Tablet ipad = new Tablet("iPad Pro", "Apple", 350, 128, 12.9);
                Tablet galaxyTab = new Tablet("Galaxy Tab S7", "Samsung", 150, 256, 11);
                Tablet galaxy = new Tablet("GALAXY tab s5", "samsung", 120, 256, 9);

                Console.WriteLine(ipad);
                Console.WriteLine(galaxyTab);
                Console.WriteLine(galaxy);
            }
        }
    }

}




        

        
    

