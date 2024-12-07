namespace PredicateDelegate
{
    //Viết hàm nhận vào con số, kiểm tra có đúng nó lẻ hay ko?
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> fOdd = n => n % 2 != 0;
            Console.WriteLine("The number 103 is Odd? Answer: " + fOdd(103));

            //xài var
            var fVar = (int n) => n % 2 != 0;
            Console.WriteLine("The number 208 is Odd? Answer: " + fVar(208));
        }
    }
}
