public class hinhChuNhat
{
    double chieudai;
    double chieurong;
    public hinhChuNhat()
    {

    }
    public hinhChuNhat(double chieudai , double chieurong)
    {
        this.chieurong = chieurong;
        this.chieudai = chieudai;

    }

    public double chuViHCN(double chieudai , double chieurong)
    {
        return (chieudai + chieurong) * 2;
    }
    public double dienTichHCN(double chieudai, double chieurong)
    {
        return chieudai * chieurong;
    }
    public static void Main(string[] args)
    {
       Console.WriteLine("nhap chieu dai");
        double chieudai = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("nhap chieu rong:");
        double chieurong = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("nhap 1 tinh chu vi , nhap 2 tinh dien tich");
        int n = Convert.ToInt32(Console.ReadLine());
        hinhChuNhat hcn = new hinhChuNhat(chieudai, chieurong);
        if (n == 1)
        {
            double chuvi = hcn.chuViHCN(chieudai, chieurong);
            Console.WriteLine("chu vi hcn:"+chuvi);
        }
        else if (n == 2)
        {
            double dientich = hcn.dienTichHCN(chieudai, chieurong);
            Console.WriteLine("dien tich hcn:"+dientich);
        }
        else
        {
            Console.WriteLine("loi");
        }
    }
} 