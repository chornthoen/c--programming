

internal class Program
{
    public static void Main(string[] args)
    {
        //variable declaration and initialization in C#
        int a = 10;
        double b = 20.5;
        char c = 'A';
        string d = "Hello";
        bool e = true;
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);
        Console.WriteLine("d = " + d);
        Console.WriteLine("e = " + e);
        
        //input from user in C#
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Hello " + name);
        Console.WriteLine("You are " + age + " years old");
        Console.WriteLine("Your salary is " + salary);
    }
}