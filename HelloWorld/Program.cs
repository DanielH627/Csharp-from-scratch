namespace HelloWorld;

class Program
{
    static void Main()
    {
        DateOnly dateConverted;
        string nameInput;
        string birthdayInput;
        Console.WriteLine("Hola Bienvenido a el calculador de años");
        Console.WriteLine("Escribe tu nombre:");
        nameInput = Console.ReadLine();
        Console.WriteLine($"Un gusto conocerte {nameInput}");
        Console.WriteLine("Escribe tu fecha de nacimiento en formato dd/mm/yy:");
        birthdayInput = Console.ReadLine();
        bool isDateValid = DateOnly.TryParse(birthdayInput, out dateConverted);
        if (!isDateValid)
        {
            Console.WriteLine($"La fecha de nacimiento no es valida, usted ingreso este dato erroneamente {birthdayInput} ");
            return;
        }
        var person = new Person
        {
            Name = nameInput,
            Birthday = dateConverted,
            Age = DateTime.Now.Year - dateConverted.Year
        };
        Console.WriteLine($"Tu nombre es: {person.Name}, tu fecha de nacimiento es: {person.Birthday}, y tu edad es: {person.Age} años");
        Console.WriteLine($"Gracias por usar el programa {person.Name}, hasta pronto!");
        Console.ReadLine();
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public DateOnly Birthday { get; set; }
}