internal class Program
{
    private static void Main(string[] args)
    {
        //Viết chương trình c# Nhập vào 1 chuỗi bất kỳ sau đó hãy đảo ngược chuổi đó
        Console.WriteLine("Nhap vao mot chuoi: ");
        string chuoi = Console.ReadLine();
        string chuoidaonguoc = string.Empty;
        for (int i = chuoi.Length - 1; i >= 0; i--)
        {
            chuoidaonguoc += chuoi[i];
        }
        Console.WriteLine("Chuoi dao nguoc la: " + chuoidaonguoc);
    }
}