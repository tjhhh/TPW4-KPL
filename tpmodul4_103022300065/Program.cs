using System;
using tpmodul4_103022300065;

class Program
{
    static void Main()
    {
        KodePos kodePos = new KodePos();

        Console.Write("Masukkan nama kelurahan: ");
        string kelurahan = Console.ReadLine();

        Console.WriteLine("Kode Pos: " + kodePos.getKodePos(kelurahan));
        DoorMachine door = new DoorMachine();

        Console.WriteLine("Perintah: (buka/kunci/keluar)");
        while (true)
        {
            Console.Write("Masukkan perintah: ");
            string perintah = Console.ReadLine();

            if (perintah.ToLower() == "buka")
                door.BukaPintu();
            else if (perintah.ToLower() == "kunci")
                door.KunciPintu();
            else if (perintah.ToLower() == "keluar")
                break;
            else
                Console.WriteLine("Perintah tidak dikenali!");
        }
    }
}
