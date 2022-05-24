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

int[] ints = new int[5];
Console.WriteLine("Por favor ingrese numeros");

for (int i = 0; i<10; i++)
{
    Console.WriteLine($"Por favor ingrese el numero: {i+1}");
    ints[i] = int.Parse(Console.ReadLine());
};















