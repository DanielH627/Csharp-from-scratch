/*
Console.WriteLine("Ingrese un número:");
int num = int.Parse(Console.ReadLine());
if (num > 0)
{
    Console.WriteLine("El número es positivo");
}
else if (num < 0)
{
    Console.WriteLine("El número es negativo");
}
else
{
    Console.WriteLine("El número es cero");
}   
/*End conditionals_and_operators*/

/*Operators*/
Console.WriteLine("Ingrese el primer número:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número:");
double b = double.Parse(Console.ReadLine());
const string Indeterminado = "Indeterminado";
Console.WriteLine($"Suma: {a + b}, Resta: {a - b}, Multiplicación: {a * b}, División: {(b != 0 ? (a / b).ToString() : Indeterminado)}");


