// paso 1
Console.Clear();
int SecretNumber = new
Random(DateTime.Now.Millisecond).Next(1, 11);
int NumeroUser = 0;
int N = 0;

while (NumeroUser != SecretNumber)
{
    // paso 2
    Console.Write("Introduzca un número e Intente adivinar el número secreto : ");
    NumeroUser = int.Parse(Console.ReadLine());

    // paso 3
    if (NumeroUser > SecretNumber)
    {
        Console.WriteLine("El número que seleccionaste es muy grande, intenta de nuevo");
    }
    else if (NumeroUser < SecretNumber)
    {
        Console.WriteLine("El número que seleccionaste es menor al número secreto, intenta de nuevo");
    }
    N++;

};

Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: {SecretNumber} Lo has logrado en {N} intentos!!");







