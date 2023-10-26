namespace Conventor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number converter");
            Console.WriteLine("binary to decimal");
            Console.WriteLine("decimal to binary");
            Console.WriteLine("enter your choice");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("enter binary number");
                    int n = int.Parse(Console.ReadLine());
                    int curr = 0;
                    int answer = 0;
                    int i = 0;
                    while (n != 0)
                    {
                        curr = n % 10;
                        answer += curr * (int)Math.Pow(2, i);
                        n /= 10;
                        i++;
                    }
                    Console.WriteLine($"decimal: {answer}");
                    break;


                case 2:
                    {
                        Console.WriteLine("enter decimal number");
                        int n2 = int.Parse(Console.ReadLine());
                        int curr2 = 0;
                        int answer2 = 0;
                        int i2 = 0;
                        while (n2 != 0)
                        {
                            curr2 = n2 % 2;
                            answer2 += curr2 * (int)Math.Pow(10, i2);
                            n2 /= 2;
                            i2++;
                        }
                        Console.WriteLine($"binary: {answer2}");
                        break;
                    }
            }
        }
    }
}