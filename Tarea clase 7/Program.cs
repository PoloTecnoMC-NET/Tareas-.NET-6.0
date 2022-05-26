// See https://aka.ms/new-console-template for more information

/* 
    1) Pida 10 números al usuario.
    2) Obtener la suma de todos los números ingresados.
    3) Obtener cual es el mayor de todos los números.
    4) Obtener cual es el menor de todos los números.
    5) Obtener el promedio de todos los números.
    6) Mostrar todos los números ingresados por pantalla.
    7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5. 
*/
Console.Clear();   

// defino la matriz
int[] numeros = new int[10];
Console.WriteLine("  =============================================");
Console.WriteLine("  Por favor ingrese diez numeros entre 1 y 100 ");
Console.WriteLine("  =============================================");

Console.WriteLine("");
Console.WriteLine("");

// pide los numeros a ingresar
for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"  Por favor ingrese el valor de numero {i + 1}: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
};


int mayor = 0, menor = 100, promedio = 0, p = 0;
// la variable p es la posicion del vector en el menor numero
// la variable j es la posicion del vector en el mayor numero

Console.WriteLine("");
Console.WriteLine("");


// Mostrar los valores
Console.Write($"  Los valores ingresados son: ");
for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"{numeros[i]}, ");
};

Console.WriteLine("");

// suma todos los valores
int suma = 0;
for (int i = 0; i < numeros.Length; i++)
{
    suma += numeros[i];
};
Console.WriteLine($"  La suma de los numeros es: {suma}");

// El numero mayor
while (p < 10)
{
    if (numeros[p] > mayor)
        mayor = numeros[p]; 
    p++;
};

Console.WriteLine($"  El numero mayor es: {mayor}");
p = 0;

// El numero menor
while (p < 10)
{
    if (numeros[p] < menor)
        menor = numeros[p];
    p++;
};
Console.WriteLine($"  El numero menor es: {menor}");

// Promedio
promedio = suma / numeros.Length;
Console.WriteLine($"  El promedio de los numeros es: {promedio}");

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
