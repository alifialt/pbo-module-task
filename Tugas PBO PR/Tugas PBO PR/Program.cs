using System;
using System.Runtime.ConstrainedExecution;

namespace pbo_pr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Vivobook();
            laptop1.vga = new Nvidia();
            laptop1.processor = new CoreI5();

            Laptop laptop2 = new IdeaPad();
            laptop2.vga = new AMD();
            laptop2.processor = new Ryzen();

            Predator predator = new Predator();
            predator.vga = new AMD();
            predator.processor = new CoreI7();

            Console.WriteLine("1.");
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();

            Console.WriteLine("\n2.");
            //laptop1.Ngoding();

            Console.WriteLine("\n3.");
            Console.WriteLine(laptop1.vga.merk);
            Console.WriteLine(laptop1.processor.merk);
            Console.WriteLine(laptop1.processor.tipe);

            Console.WriteLine("\n4.");
            predator.BermainGame();

            Console.WriteLine("\n5.");
            ACER acer = new ACER();
            acer.vga = new AMD();
            acer.processor = new CoreI7();
            //acer.BermainGame();

        }
    }

    class Processor
    {
        public string merk, tipe;
    }

    class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }

    class CoreI3 : Intel
    {
        public CoreI3()
        {
            base.tipe = "Core i3";
        }
    }

    class CoreI5 : Intel
    {
        public CoreI5()
        {
            base.tipe = "Core i5";
        }
    }

    class CoreI7 : Intel
    {
        public CoreI7()
        {
            base.tipe = "Core i7";
        }
    }

    class amd : Processor
    {
        public amd()
        {
            base.merk = "AMD";
        }
    }

    class Ryzen : amd
    {
        public Ryzen()
        {
            base.tipe = "RAYZEN";
        }
    }

    class Athlon : amd
    {
        public Athlon()
        {
            base.tipe = "ATHLON";
        }
    }
    class Laptop
    {
        public string merk, tipe;
        public Vga vga;
        public Processor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }
    }

    class ASUS : Laptop
    {
        public ASUS()
        {
            base.merk = "ASUS";
        }
    }

    class ROG : ASUS
    {
        public ROG()
        {
            base.tipe = "ROG";
        }
    }

    class Vivobook : ASUS
    {
        public Vivobook()
        {
            base.tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    class ACER : Laptop
    {
        public ACER()
        {
            base.merk = "ACER";
        }
    }

    class Predator : ACER
    {
        public Predator()
        {
            base.tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }

    class Swift : ACER
    {
        public Swift()
        {
            base.tipe = "Swift";
        }
    }

    class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.merk = "Lenovo";
        }
    }

    class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            base.tipe = "IdeaPad";
        }
    }

    class Legion : Lenovo
    {
        public Legion()
        {
            base.tipe = "Legion";
        }
    }

    class Vga
    {
        public string merk;
    }

    class Nvidia : Vga
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }

    class AMD : Vga
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }


}