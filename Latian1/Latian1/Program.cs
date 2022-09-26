using iniProcessor;
using iniVga;

namespace Latian1
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[SYSTEM] BERHASIL MEMBUAT OBJECT");
            Console.ResetColor();

            Laptop laptop1 = new Vivobook();
            Laptop laptop2 = new IdeaPad();
            Predator predator = new Predator();

            ////soal nomer 1
            ////memanggil method
            //laptop2.LaptopDimatikan();
            //laptop2.LaptopDinyalakan();

            ////Soal nomer 2
            ////Memanggil method
            //laptop1.Ngoding();

            ////Soal nomer 3
            //laptop1.vga = new Nvidia();
            //laptop1.processor = new CoreI5();
            //Console.WriteLine("Merk Vga: " + laptop1.vga.merk +
            //    "\n" + "Merk Processor: " + laptop1.processor.merk +
            //    "\n" + "Tipe Processor: " + laptop1.processor.tipe);

            ////Soal nomer 4
            ////Memanggil method
            //predator.BermainGame();

            ////Soal nomer 5
            //ACER acer = new Predator();
            ////Memanggil method
            //acer.BermainGame();
        }
    }
}