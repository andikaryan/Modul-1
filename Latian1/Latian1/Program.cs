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

            ////Soal nomer 1
            //IdeaPad laptop2 = new IdeaPad();
            ////Memanggil method
            //laptop2.LaptopDimatikan();
            //laptop2.LaptopDinyalakan();

            ////Soal nomer 2
            //Vivobook laptop1 = new Vivobook();
            ////Memanggil method
            //laptop1.Ngoding();

            ////Soal nomer 3
            //Laptop laptop1 = new Vivobook();
            //laptop1.vga = new Nvidia();
            //laptop1.processor = new CoreI5();
            //Console.WriteLine("Merk Vga: " + laptop1.vga.merk +
            //    "\n" + "Merk Processor: " + laptop1.processor.merk +
            //    "\n" + "Tipe Processor: " + laptop1.processor.tipe);

            ////Soal nomer 4
            //Predator predator1 = new Predator();
            ////Memanggil method
            //predator1.BermainGame();

            ////Soal nomer 5
            //ACER acer = new Predator();
            ////Memanggil method
            //acer.BermainGame();
        }
    }
}