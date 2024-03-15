internal class Program
{
    private static void Main(string[] args)
    {
        //In ra số nguyên tố nhỏ hơn số nhập từ bàn phím 
        Console.WriteLine("Nhap 1 so nguyen duong: ");
        int a;
        a = int.Parse(Console.ReadLine());
        if (a >= 2)
        {
            Console.WriteLine("Cac so nguyen to nho hon so nhap tu ban phim la: ");
            for (int i = 2; i < a; i++)
            {
                if (i % 2 != 0 && i % i == 0 && i % 3 != 0 || i == 2)
                {
                    Console.WriteLine(" " + i);
                }
            }
        }
        else
        {
            Console.WriteLine("Vui long nhap so lon hon !");
        }
    }
}