namespace HelloWorld;

internal class NewBaseType
{
    // Clase base vacía
}

class Program : NewBaseType
{
    static void Main() {
        var Name = "Daniel Henao";
        Console.WriteLine($"Hello, World! {Name}");
        Console.WriteLine($"Thanks for coming {Name}");
        Console.WriteLine();
    }
}