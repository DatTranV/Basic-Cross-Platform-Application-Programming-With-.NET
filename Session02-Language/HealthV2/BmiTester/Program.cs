using Bmi; //~import java.util... ben java

namespace BmiTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bmi = BmiCalculator.GetBmi(1.7, 70);
            Console.WriteLine($"BMI: {bmi}");
        }
    }
}
