namespace HelloWorld;

internal class NewBaseType
{
    // Clase base vacía
}

class Program : NewBaseType
{
    static void Main(string[] args)
    {
        const string name = "Daniel";
        string value = $"Hello, World! {name}";
        Console.WriteLine(value);
        Console.WriteLine();
    }
}