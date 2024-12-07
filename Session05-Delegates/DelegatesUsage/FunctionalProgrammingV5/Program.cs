namespace FunctionalProgrammingV5
{
    //Viết hàm xử lí data theo nhu cầu 
    //Giả sử bạn có 1 mảng data, list data
    //Và bạn sẽ cung cấp cho bên ngoài dịch vụ dữ liệu
    //Nghĩa là ai muốn lấy data theo tiêu chí nào, thì đưa cho hàm này, hàm này sẽ filter data theo nhu cầu

    //hàm nhận vào delegate, hàm nhận vào 1 hàm khác
    //                         hàm chính    hàm đc inject
    //Bên ngoài muốn gì, đưa vào, hàm chính gọi và xử lí 
    //


    internal class Program
    {
        static void Main(string[] args)
        {
            //Challenge 1: In ra các số dương
            //Challenge 2: In ra các số > 1000 và chẵn
            //Challenge 3: In ra các số chia hết cho 5

            //ko sửa hàm chính!!!
            //sửa hàm chính thì viết bao nhiều if cho đủ nhu cầu hỏi của người ta
            //Hãy để người ta đưa tiêu chí lựa chọn từ bên ngoài đưa vào!!!
            //LinQ, Stream API Java

            //c1:
            Console.WriteLine("Challenge 1:");
            GetDataOnDemand(x => x > 0);
            //c2:
            Console.WriteLine();
            Console.WriteLine("Challenge 2:");
            GetDataOnDemand(x => x > 1000 && x % 2 == 0);
            //c3: 
            Console.WriteLine();
            Console.WriteLine("Challenge 3:");
            GetDataOnDemand(x => x % 5 == 0);

            Console.WriteLine();
            Console.WriteLine("=====================");
            Console.WriteLine("Get on demand ver 2:");
            GetDataOnDemand(x =>
            {
                if (x % 2 != 0)
                    Console.Write(x + " ");
            });
        }

        //Mình có data, người ta có lựa chọn, dependency injection
        static void GetDataOnDemand(Predicate<int> f)
        {
            int[] arr = { 5, 10, 15, 20, -100, -1, -2, 16, 63, 68, 39, 79, 101, 333, 555, 6789, 2204, 6868, 6368, 6969 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (f(arr[i]))
                    Console.Write(arr[i] + " ");
            }

        }

        //Cũng vẫn nhận vào hàm F, nhưng để F tự lo, mình ko lo gì khác ngoài việc thảy
        //Data mình đang có cho F
        static void GetDataOnDemand(Action<int> f)
        {
            int[] arr = { 5, 10, 15, 20, -100, -1, -2, 16, 63, 68, 39, 79, 101, 333, 555, 6789, 2204, 6868, 6368, 6969 };
            for (int i = 0; i < arr.Length; i++)
            {
                f(arr[i]);
            }

        }
    }
}
