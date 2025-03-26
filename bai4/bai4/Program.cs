using System;

class program
{
    public static int[] xoaPhanTu(int[] arr, int m){
         if(m < 0 || m >= arr.Length)
        {
            Console.WriteLine("khong hop le!!");
            return arr;
        }
        int[] newArr = new int[arr.Length - 1];
        for (int i = 0 , j = 0; j < newArr.Length; i++)
        {
            if (i == m) continue;
            newArr[j++] = arr[i];
        }
        return newArr;
        }
    public static void Main(string[] args)
    {
        Console.Write("nhap so phan tu cua mang: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        for(int i =0; i< arr.Length; i++)
        {
            Console.Write("phan tu thu "+(i+1)+" la:");
            arr[i] = Convert.ToInt32(Console.ReadLine());

        }
        Console.WriteLine();
        Console.Write("mang cua ban la :");
        foreach(var i in arr)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
        Console.WriteLine("nhap vi tri ban muon xoa :");
        int m = Convert.ToInt32(Console.ReadLine());

        arr = xoaPhanTu(arr, m);

        Console.Write("mang sau khi xoa la:");
        foreach (var item in arr)
        {
            Console.Write(item+" ");
        }


    }
}