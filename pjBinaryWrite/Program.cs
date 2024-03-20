// ejemplo de escritura y lectura de datos en un archivo de texto

string texto = "Ejemplo de texto";
File.WriteAllText("ejemplo.txt", texto);

// leer datos desde un archivo de texto 

string texto2 = File.ReadAllText("ejemplo.txt");
Console.WriteLine($"Texto leído desde el archivo: {texto2}");

// Escribir datos en un archivo binario

int[] numeros = { 1, 2, 3, 4, 5 };

using (BinaryWriter bw = new BinaryWriter(File.Open("numeros.txt", FileMode.Create)))

    foreach (int numero in numeros) 
    {
        bw.Write(numero);
    }

// leer datos desde un archivo binario 

int[] numerosLeidos; 
using (BinaryReader br = new BinaryReader(File.Open("numeros.txt", FileMode.Open))) 
{
    numerosLeidos = new int[5];

    for (int i = 0; i < numerosLeidos.Length; i++) 
    {
        numerosLeidos[i] = br.ReadInt32();
    }

    Console.WriteLine("Números leídos desde el archivo bonario");

    foreach (int numero in numerosLeidos) 
    {
        Console.WriteLine(numero);
    }
}