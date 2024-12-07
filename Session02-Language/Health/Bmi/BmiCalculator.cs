namespace Bmi
{
    //internal, partial, public, private có thể ráp vào với tên class liên quan đến quyền gọi truy xuất hàm trong class này khi đang đứng ở class khác!!!
    //mặc định ta hay xài public
    public class BmiCalculator
    {
        //trong đây có chứa biến, hàm -> members
        //hàm, biến có quyền có từ khóa static
        //hàm, biến có thêm từ khóa private, public, protected
        //tùy vào thiết kế của cái class
        public static void GetBmi()
        {
            //BMI: body mass index chỉ số khối của cơ thể nói về độ mập ốm của ai đó dựa trên chiều cao và cân nặng
            //bmi = cân nặng (kg) / chiều cao bình phương (m)
            //bmi < 18.5 -> ốm quá so với chiều cao
            //18.5 <= bmi <= 30 -> chuẩn form
            //bmi > 30 ->mập, béo phì (vượt 33)
            double height = 1.7;
            double weight = 70;
            double bmi = weight / (height * height);
            Console.WriteLine($"Your bmi is {bmi}");
        }
        //hàm trên là hàm chưa tốt vì ko mang tính re-use
        //Hàm ok là hàm nhận đầu vào qua tham số và trả đầu ra qua return sẽ giúp hàm được tái sử dụng linh hoạt ở nhiều nơi !
        public static double GetBmi(double height, double weight)
        {
            return weight / (height * height);
        }
        //overload, overloading là hiện tượng nhiều hàm trong cùng 1 class xài chung 1 tên, nhưng khác phần tham số hàm ở góc độ data type
        //tên hàm + tham số hàm phải là duy nhất trong 1 class
        //Nếu trùng tên mà khác tham số vẫn ok, vì vẫn làm nên tính duy nhất của tên hàm, tên hàm + tham số là duy nhất trong 1 class
        //tên hàm + tham số gọi là: signature of a method

        //overiding chỉ xảy ra trong mỗi quan hệ cha con, còn overload ở class nào cũng có
    }
}
