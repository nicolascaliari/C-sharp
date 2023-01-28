using System;
using Biblioteca;


internal class Program
{
    private static void Main(string[] args)
    {
        Sumador sumador = new Sumador();

        string respuestaString = sumador.Sumar(null, "pepe");
        Console.WriteLine($"Resultado string: {respuestaString}");
        Console.WriteLine($"Resultado string: {sumador.getCantidad()}");


        long respuestaLong = sumador.Sumar(1, 2);
        Console.WriteLine($"Resultado string: {respuestaLong}");
        Console.WriteLine($"Resultado string: {sumador.getCantidad()}");
    }
}