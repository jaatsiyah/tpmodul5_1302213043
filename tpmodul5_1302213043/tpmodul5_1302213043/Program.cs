// See https://aka.ms/new-console-template for more information
public class HaloGeneric
{
    public void SapaUser<T>(T nama)
    {
        Console.WriteLine("Halo User " + nama);
    }
}

public class program
{
    static void Main(string[] args)
    {
        HaloGeneric haloGeneric = new HaloGeneric();
        Console.Write("Masukkan Nama Panggilan Praktikan : ");
        string nama = Console.ReadLine();
        haloGeneric.SapaUser(nama);
    }
}