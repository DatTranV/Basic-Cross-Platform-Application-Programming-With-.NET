namespace FunctionalProgrammingV4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C1:
            //có sẵn data 1-100, đưa điều kiện bên ngoài vào
            //in số chẵn
            //PrintOnDemand(x => x % 2 == 0); //điều kiện sỗ chẵn

            ////in số lẻ
            //Console.WriteLine();
            //PrintOnDemand(x => x % 2 != 0); //điều kiện số lẻ

            //C2:
            //Console.WriteLine("Khách tự phục vụ");
            //PrintOnDemand(x =>
            //{
            //    Console.Write(x + " ");
            //});
            //Console.WriteLine();
            //Console.WriteLine("Chia het cho 5: ");
            //PrintOnDemand(x =>
            //{
            //    if (x % 5 == 0)
            //        Console.Write(x + " ");
            //});

            //Challenge: in ra các số lớn hơn 50 và chia hết cho 2 
            //bắt buộc phải gọi PrintOnDemand(hàm bool)
            //Viết dễ hiểu trước, tạo 1 hàm bool nhận vào x và return true nếu
            Func<int, bool> fEven50 = x => x >= 50 && x % 2 == 0;
            PrintOnDemand(fEven50);

            //Viết gộp luôn
            //thêm điều kiện nếu chia hết cho 3 cũng ok
            Console.WriteLine();
            PrintOnDemand(x => (x >= 50 && x % 2 == 0) || (x % 3 == 0));
        }

        //cách tiếp cận với quán ăn:
        //C1: Quý khách muốn gì, mời quý khách đưa ra yêu cầu
        //      Hàm nhận vào một Func<x, bool>, quán sẽ làm cho

        //C2: Tôi đưa cho quý khách gia vị, nước dùng, quý khách tự nêm nếm

        //static void PrintOnDemand(Action<int> f)
        //{
        //    //chị chủ có nhiều data, đưa cho F tự lo
        //    for (int i = 1; i <= 100; i++)
        //    {
        //        f(i);
        //    }
        //}


        static void PrintOnDemand(Func<int, bool> f)
        {
            //Chủ quán có nhiều đồ ăn, gia vị, chế biến theo yêu cầu bên ngoài đưa vào
            //chủ quán có 1 2 3 4 5 6...
            //gửi nó cho thằng f(?) true chẵn thì in ra
            for (int i = 1; i <= 100; i++)
            {
                if (f(i) == true)
                    Console.Write(i + " ");
            }
        }
        //Viết hàm in ra các số chẵn từ 1 đến 100, dùng print on demand nhưng phải xài func
        //static void PrintOnDemand(Action f) // = () => {in số chẵn lẻ}
        //{
        //    f();
        //}

        //Math.sqrt(100); cùng là hàm chính gọi 1 hàm khác trong body của nó, nhưng nếu gọi delegate, thì ta chưa biết delegate này làm xử lí gì
        //Còn gọi hàm truyền thống ví dụ căn bậc 2, hay tính giai thừa
        //Thì mãi mãi vẫn là 1 logic biết trước, 1 xử lí biết trước
    }
}
