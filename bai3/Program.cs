internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap chuoi:");
        string chuoi = Console.ReadLine();
        Console.WriteLine("Nhap ky tu can dem:");
        char kytu = Console.ReadKey().KeyChar;
        Console.WriteLine();
        int count = demsokytu(chuoi, kytu);
        static int demsokytu (string str, char sokytu)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == sokytu)
                {
                    count++;
                }
            }
            return count;
        }
        Console.WriteLine($"So lan xuat hien cua '{kytu}' trong chuoi ky tu là: {count} lan");

    }
}