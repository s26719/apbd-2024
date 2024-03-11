// See https://aka.ms/new-console-template for more information
class Program
{

    public static void Main(string[] args)
    {
        int[] tablica1 = { 4, 3, 5, 5, 2, 1, 6, 2 };
        Console.WriteLine(AvgOceny(tablica1));
    }

    static double AvgOceny(int[] ocenyTab)
    {
        double srednia;
        int suma = 0;
        int licznik = 0;
        foreach (var n in ocenyTab)
        {
            suma += n;
            licznik++;
        }

        srednia = suma / licznik;
        return srednia;
    }

}