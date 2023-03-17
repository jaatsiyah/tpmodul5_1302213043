// See https://aka.ms/new-console-template for more information
public class DataGeneric<T>
{
    private T data { get; set; }

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void printData()
    {
        Console.WriteLine("Data yang tesimpan adalah : "+ data);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Masukkan NIM anda : ");
        string NIM = Console.ReadLine();
        DataGeneric<string> data = new DataGeneric<string>(NIM);
        data.printData();
    }
}
