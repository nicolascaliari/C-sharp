// See https://aka.ms/new-console-template for more information
using SobreCarga;


public class Program
{
     static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        //metodos
      int resultado = SobreCarga.SobreCarga.Sumar(1,2);

      int resultado_dos = SobreCarga.SobreCarga.Sumar(1,2,3);

        Console.WriteLine(resultado);
        Console.WriteLine(resultado_dos);

        //constructores

        Persona p = new Persona();
        Persona p1 = new Persona("Nicolas", new DateTime(1,2,3), 111111111111);
    
        Console.WriteLine(p.Mostrar());
        Console.WriteLine(p1.Mostrar());

    }
}