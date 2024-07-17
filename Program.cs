internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Ứng dụng giai PT Bac 1");
        double a, b;
        double x;
        Console.WriteLine("Nhập vào số a: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập vào số b: ");
        b = Convert.ToDouble(Console.ReadLine());
        string ketqua = GPTBac1_1(a, b);
        Console.WriteLine($"Chương trình bạn vừa nhập là {a}x + {b} = 0.");
        Console.WriteLine(ketqua);
        GPTBac1(a, b);
    }

    private static void GPTBac1(double a, double b)
    {
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Phương trình vô số nghiệm");
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm");
            }
        }
        else
        {
            Console.WriteLine($"Phương trình có 1 nghiệm là " + Math.Round((-b/a),2));
        }
    }
    private static string GPTBac1_1(double a, double b)
    {
        if (a == 0)
        {
            if (b == 0) return "Phương trình vô số nghiệm";
            else return "Phương trình vô nghiệm";
        }
        else return "Phương trình có 1 nghiệm là "  + Math.Round((-b / a), 2).ToString();       
    }

}