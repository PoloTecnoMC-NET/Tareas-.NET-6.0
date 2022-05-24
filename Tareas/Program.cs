// See https://aka.ms/new-console-template for more information
Console.Clear();

string Respuesta;
Respuesta = "S";



    while (Respuesta.ToUpper() == "S")
    {
        string Name;
        Console.WriteLine("Por favor indique su nombre: ");
        Name = Console.ReadLine();
        Console.WriteLine($"¡Hola {Name}!");
        Console.WriteLine("Deseas continuar (S/N)");
        Respuesta = Console.ReadLine();

        if (Respuesta.ToUpper() != "N" && Respuesta.ToUpper() != "S")
        {
            Console.WriteLine("¡ Opción no valida, reinicie el programa !");
            break;
        }
    }