using System;
using System.Runtime.CompilerServices;

public abstract class Animal
{
    protected string tiengKeu { get; set; }
    public Animal(string tiengKeu)
    {
        this.tiengKeu = tiengKeu;
    }
    public abstract void PrintInfo(); // pham vi truy cap la cong khai :


}
class Cat : Animal
{
    private string giongMeo { get; set; }
    public Cat(string tiengKeu, string giongMeo) : base(tiengKeu)
    {
        this.giongMeo = giongMeo;
    }
    public override void PrintInfo()
    {
        Console.WriteLine($"Tiếng kêu: {tiengKeu}");
        Console.WriteLine($"Giống mèo: {giongMeo}");
    }
    static void Main(string[] args)
    {
        Cat cat = new Cat("meo meo", "meo cong nghiep");
        cat.PrintInfo();

    }
}


