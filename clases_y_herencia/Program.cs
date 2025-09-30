
/*Clases*/
var rect = new Rectangulo(); 
rect.Base = 20;
rect.Altura = 40;
Console.WriteLine($"EL area es : {rect.Area()}");
Console.WriteLine($"EL perimetro es : {rect.Perimetro()}");
/*End Clases*/

var cuadr = new Cuadrado(); 

double ladoValor;
do
{
    Console.Write("Ingrese el valor del lado: ");
    string input = Console.ReadLine();
    if (!double.TryParse(input, out ladoValor))
    {
        Console.WriteLine("Ingrese un número válido");
    }
} while (ladoValor <= 0);

cuadr.Lado = ladoValor;

Console.WriteLine($"EL area es : {cuadr.Area()}");
Console.WriteLine($"EL perimetro es : {cuadr.Perimetro()}");
Console.WriteLine($"EL lado es : {cuadr.Lado}");

class Rectangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }
    public double Area() => Base * Altura;
    public double Perimetro() => 2 * Base + 2 * Altura;
}

class Cuadrado : Rectangulo
{
    public double Lado
    {
        set { Base = value; Altura = value; }
        get { return Base; }
    }
}