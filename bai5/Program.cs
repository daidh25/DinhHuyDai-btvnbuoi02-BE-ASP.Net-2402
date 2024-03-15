internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(1,10); 
        int sodudoan;
        int count = 0;
        bool doandung = false;

        Console.WriteLine("=====================RANDOM TU 1 DEN 10================");

        do
        {
            Console.Write("Nhap so ban doan: ");
            sodudoan = int.Parse(Console.ReadLine());
            count++;

            if (sodudoan != randomNumber)
            {
                doandung = false;
                Console.WriteLine("So ban doan chua dung! Thu lai.");
               
            }
            else
            {
                doandung = true;
                Console.WriteLine($" Exactly! Ban doan dung so {randomNumber} trong {count} lan doan.");
            }
        } while (!doandung);

        Console.WriteLine("================== KET THUC RANDOM ==================");
    }
}