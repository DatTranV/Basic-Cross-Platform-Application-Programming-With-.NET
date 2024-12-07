namespace Bmi
{
    /// <summary>
    /// This class offers methods to evaluate the health status of a person. Class này cung cấp các hàm dùng để đánh giá tình trạng mập ốm của ai đó!
    /// </summary>
    public class BmiCalculator
    {
        /// <summary>
        /// This method returns the bmi of a person based on height and weight
        /// </summary>
        /// <param name="height">Height based on (m)</param>
        /// <param name="weight">Weight based on (kg)</param>
        /// <returns></returns>
        public static double GetBmi(double height, double weight)
        {
            return weight / (height * height);
        }
    }
}

//SWAGGER UI là chuẩn document dướng dẫn sử dụng web api = hàm gọi qua url
//Class library của chúng ta đang làm cx được xem là 1 api nhưng không gọi qua web
//Nếu chúng ta tặng cái class này cho bà con xài, làm sao biết cách gọi hàm, truyền tham số gì???
//Ta làm 1 cái document hướng dẫn sử dụng hàm của class thư viện của chúng ta, để dân dev khác biết cách xài class/ hàm của chúng ta
//Document cho hàm/class của chúng ta thì được gọi tên là api document.
//Trong c# ta dùng dấu /// để làm ra cái document hdsd hàm
