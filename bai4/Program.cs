internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhap 1 so nguyen duong a: ");
        int a;      
        do
        {
            a = int.Parse(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine(" Vui lonng nhap lai so lon hon !");
            }
        } while (a <= 0);
        int Giaithua = 1;
        int i = 1;
        do
        {
            Giaithua *= i;
            i++;
            
        }while (i<=a);
        Console.WriteLine($"Giai thua cua so {a} la: " + Giaithua);
    }
}