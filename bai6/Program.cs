internal class Program
{
    private static void Main(string[] args)
    {
        string password;
        bool hople = false;

        do
        {
            Console.WriteLine("\nNhap mat khau gom (6-12 ky tu va chua ky tu @): ");
            password = Console.ReadLine();

            if (password.Length >= 6 && password.Length <= 12 && password.Contains("@"))
            {
                hople = true;
                Console.WriteLine("\nPassword hop le !.");
            }
            else
            {
                Console.WriteLine("\nPassword khong hop le ! Nhap lai.");
            }
        } while (!hople);

        Console.WriteLine("\t\tXac nhan password.");
    }
}