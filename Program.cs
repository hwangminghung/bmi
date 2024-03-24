using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhập cân nặng của bạn (kg):");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine("Nhập chiều cao của bạn (m):");
        double height = double.Parse(Console.ReadLine());

        double bmi = weight / (height * height);

        Console.WriteLine("Chỉ số BMI của bạn là: " + bmi);

        if (bmi < 18.5)
        {
            Console.WriteLine("Dưới chuẩn - Gầy");
        }
        else if (bmi >= 18.5 && bmi < 25)
        {
            Console.WriteLine("Bình thường");
        }
        else if (bmi >= 25 && bmi < 30)
        {
            Console.WriteLine("Thừa cân");
        }
        else
        {
            Console.WriteLine("Béo phì");
        }
    }
}