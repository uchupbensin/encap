using System;

public class Mahasiswa
{
    public string nama;
    private string nim;
    protected string matakuliah;
    internal string prodi;
    protected internal string kampus;


    public string Nama
    {
        get { return nama; }
        set { nama = value; }
    }

    public string Nim
    {
        get { return nim; }
        set { nim = value; }
    }

    public string Matakuliah
    {
        get { return matakuliah ; }
        set { matakuliah = value; }
    }

    public string Prodi
    {
        get { return prodi; }
        set { prodi = value; }
    }

    public string Kampus
    {
        get { return kampus; }
        set { kampus = value; }
    }

    public void info()
    {
        Console.WriteLine("Nama : {0}", Nama);
        Console.WriteLine("Nim : {0}", Nim);
        Console.WriteLine("Mata Kuliah: {0}", Matakuliah);
        Console.WriteLine("Program Studi : {0}", Prodi);
        Console.WriteLine("Nama Universitas : {0}", Kampus);
        Console.WriteLine();
    }
}