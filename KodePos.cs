namespace tpmodul4_1302223029;
using System.Collections.Generic;

public class KodePos
{
    private Dictionary<string, string> kodePosDictionary;
    public enum Kelurahan
    {
        Batununggal,
        Kujangsari,
        Mengger,
        Wates,
        Cijaura,
        Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja
    }
    public string GetKodePos(Kelurahan kelurahan)
    {
        String[] kodePos =
        {
             "40266", // Batununggal
             "40287", // Kujangsari
             "40267", // Mengger
             "40256", // Wates
             "40287", // Cijaura
             "40286", // Jatisari
             "40286", // Margasari
             "40286", // Sekejati
             "40272", // Kebonwaru
             "40274", // Maleer
             "40273" // Samoja
         };

        int index = (int)kelurahan;

        if (index >= 0 && index < kodePos.Length)
        {
            return kodePos[index];
        }

        return "Kode Pos Tidak Ditemukan";
    }
}