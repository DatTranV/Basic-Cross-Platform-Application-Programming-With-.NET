namespace Bmi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //GetBmi();
            BmiCalculator.GetBmi(); //hàm static thì gọi trực tiếp không cần new
            double bmi = BmiCalculator.GetBmi(1.7, 70);
            double canSo = Math.Sqrt(100); //Căn bậc 2 của 100
            Console.WriteLine("BMI: " + bmi);
            Console.WriteLine("Can so cua 100: " + canSo);
            //nó có khả năng đc dùng lại ở nhiều nơi, với các đầu vào khác nhau re-use
            //nó có thể tham gia vào các biểu thức tính toán, tăng độ linh hoạt

            //ví dụ tính tổng bmi của 2 bạn : {1.7 - 70} và {1.8 - 80}
            //ví dụ: tính tổng căn của 100 cộng với căn của 64
            double sumBmi = BmiCalculator.GetBmi(1.7, 70) + BmiCalculator.GetBmi(1.8, 80);
            double sumCanSo = Math.Sqrt(100) + Math.Sqrt(64);

            //In lẻ giá trị cx được, gom biểu thức ok luôn
            //for (int i = 1; i <= Math.Sqrt(n); i++) -> kiểm tra n nguyên tố
            Console.WriteLine("Sum bmi: {0}", sumBmi);
            Console.WriteLine($"Sum căn bac 2: {sumCanSo}");
            Console.ReadKey();

        }
        //có câu: static chơi với static

    }
}
