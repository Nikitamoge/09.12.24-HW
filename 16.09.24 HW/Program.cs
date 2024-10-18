//Task 1
class Product
{
    protected string name;
    protected string? nameplace;
    protected int price;

    public string Name { get => name; set => name = value; }

    public string Nameplace
    {
        get => nameplace ?? "Unknown nameplace";
        set => nameplace = value;
    }

    public int Price
    {
        get => price;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Error, the value can't be lower than 0");
            }
            else
            {
                price = value;
            }
        }
    }

    public Product(string name, string nameplace, int price)
    {
        this.name = name;
        this.nameplace = nameplace;
        Price = price;
    }
}

class Toy : Product
{
    public int Agerating { get; set; }
    public string Creatingplace { get; set; }

    public Toy(int agerating, string creatingplace, string name, string nameplace, int price)
        : base(name, nameplace, price)
    {
        Agerating = agerating;
        Creatingplace = creatingplace;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}, NamePlace: {Nameplace}, Price: {Price}, Age rating: {Agerating}, Creation Place: {Creatingplace}");
    }
}


//Task 2
class Animal
{
    public int Age { get; set; }
    public double Weight { get; set; }
    public double Speed { get; set; }
    public double Height { get; set; }
    public string Place { get; set; }

    public Animal(int age, double weight, double speed, double height, string place)
    {
        Age = age;
        Weight = weight;
        Speed = speed;
        Height = height;
        Place = place;
    }

    public virtual void Output()
    {
        Console.WriteLine($"Age: {Age}, Weight: {Weight}, Speed: {Speed}, Height: {Height}, Place: {Place}");
    }
}

class Tiger : Animal
{
    public string Strength { get; set; }

    public Tiger(string strength, int age, double weight, double speed, double height, string place)
        : base(age, weight, speed, height, place)
    {
        Strength = strength;
    }

    public override void Output()
    {
        base.Output();
        Console.WriteLine($"Strength: {Strength}");
    }
}

class Crocodile : Animal
{
    public int CountOfTeeth { get; set; }

    public Crocodile(int countOfTeeth, int age, double weight, double speed, double height, string place)
        : base(age, weight, speed, height, place)
    {
        CountOfTeeth = countOfTeeth;
    }

    public override void Output()
    {
        base.Output();
        Console.WriteLine($"Count of Teeth: {CountOfTeeth}");
    }
}

class Kangaroo : Animal
{
    public double JumpDistance { get; set; }

    public Kangaroo(double jumpDistance, int age, double weight, double speed, double height, string place)
        : base(age, weight, speed, height, place)
    {
        JumpDistance = jumpDistance;
    }

    public override void Output()
    {
        base.Output();
        Console.WriteLine($"Jump Distance: {JumpDistance} m");
    }
}


//Task 3
public abstract class Figure
{
    public abstract double Result();
}

class Rectangle : Figure
{
    public int Length { get; set; }
    public int Width { get; set; }

    public Rectangle(int length, int width)
    {
        Length = length;
        Width = width;
    }

    public override double Result()
    {
        return Length * Width;
    }
}

class Circle : Figure
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Result()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

class RightTriangle : Figure
{
    public int A { get; set; }
    public int B { get; set; }

    public RightTriangle(int a, int b)
    {
        A = a;
        B = b;
    }

    public override double Result()
    {
        return 0.5 * A * B;
    }
}

class Trapezoid : Figure
{
    public int A { get; set; }
    public int B { get; set; }
    public int H { get; set; }

    public Trapezoid(int a, int b, int h)
    {
        A = a;
        B = b;
        H = h;
    }

    public override double Result()
    {
        return ((A + B) * H) / 2.0;
    }
}

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Toy toy = new Toy(6, "Europe", "Bear", "ToyMarket", 399);
            toy.Print();

            // Task 2
            Tiger tiger = new Tiger("Crazy", 13, 34, 67, 65, "Africa");
            tiger.Output();

            Crocodile crocodile = new Crocodile(86, 8, 34, 89, 56, "Africa");
            crocodile.Output();

            Kangaroo kangaroo = new Kangaroo(5, 23, 35, 65, 23, "Australia");
            kangaroo.Output();

            // Task 3
            Figure[] figures = new Figure[]
            {
                new Rectangle(4, 6),
                new Circle(6),
                new RightTriangle(3, 4),
                new Trapezoid(1, 2, 3)
            };

            foreach (var figure in figures)
            {
                Console.WriteLine($"Result: {figure.Result()}");
            }
        }
    }
}
