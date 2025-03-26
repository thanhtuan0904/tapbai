using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 3, 5, 1, 7, 2 };
        int minIndex = MinValue(arr); // Gọi hàm MinValue
        Console.WriteLine("Chỉ số của giá trị nhỏ nhất là: " + minIndex);
        Console.WriteLine("Giá trị nhỏ nhất là: " + arr[minIndex]);
    }

    public static int MinValue(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            throw new ArgumentException("Mảng không được rỗng.");
        }

        int min = arr[0];
        int index = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
                index = i;
            }
        }

        return index; // Trả về index của giá trị nhỏ nhất
    }
}
