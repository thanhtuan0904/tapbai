using System;
using System.Collections.Specialized;

public class program {

    public static int demPhanTu<T>(List<T> list , T value)
    {
        int count = 0;
        foreach(T item in list){
            if (item.Equals(value)){
                count++;
            }
        }
        return count;
    }
    
    public  static void Main(string[] args)
    {
        Console.WriteLine("nhap so phan tu cua chuoi:");
        int n = Convert.ToInt32(Console.ReadLine());
        List<int> list = new List<int>(n);
        for(int i = 0; i< n; i++)
        {
            Console.Write("nhap phan tu thu "+(i+1)+" la:");
            int element = Convert.ToInt32(Console.ReadLine());
            list.Add(element);
        }
        Console.WriteLine("cac phan tu trong danh sanh la:");
        foreach(int i in list)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
        Console.Write("nhap gia tri can dem:");
        int m = Convert.ToInt32(Console.ReadLine());

        int count = demPhanTu(list, m);
        Console.WriteLine($"Giá trị {m} xuất hiện {count} lần trong danh sách.");
    }
}
