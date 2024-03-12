// See https://aka.ms/new-console-template for more information
using tpmodul4_1302223029;
using static tpmodul4_1302223029.KodePos;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nomor 3 A-C : \n");
        KodePos kodePos = new KodePos();
        Console.WriteLine("Kode pos Batununggal\t: " +
        kodePos.GetKodePos(Kelurahan.Batununggal));
        Console.WriteLine("Kode pos Kujangsari\t: " +
        kodePos.GetKodePos(Kelurahan.Kujangsari));
        Console.WriteLine("Kode pos Mengger\t: " + kodePos.GetKodePos(Kelurahan.Mengger));
        Console.WriteLine("Kode pos Wates\t\t: " + kodePos.GetKodePos(Kelurahan.Wates));
        Console.WriteLine("Kode pos Cijaura\t: " + kodePos.GetKodePos(Kelurahan.Cijaura));
        Console.WriteLine("Kode pos Jatisari\t: " + kodePos.GetKodePos(Kelurahan.Jatisari));
        Console.WriteLine("Kode pos Margasari\t: " +
        kodePos.GetKodePos(Kelurahan.Margasari));
        Console.WriteLine("Kode pos Sekejati\t: " + kodePos.GetKodePos(Kelurahan.Sekejati));
        Console.WriteLine("Kode pos Kebonwaru\t: " +
        kodePos.GetKodePos(Kelurahan.Kebonwaru));
        Console.WriteLine("Kode pos Maleer\t\t: " + kodePos.GetKodePos(Kelurahan.Maleer));
        Console.WriteLine("Kode pos Samoja\t\t: " + kodePos.GetKodePos(Kelurahan.Samoja));

    }
}
