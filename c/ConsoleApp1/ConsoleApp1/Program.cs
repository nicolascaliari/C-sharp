// See https://aka.ms/new-console-template for more information
//string miNombre;
//miNombre = "Niclas";
//int numero = 10;

//Console.WriteLine(miNombre);



//Console.WriteLine("Ingrese un nombre: ");
//string nombre = Console.ReadLine();

//Console.WriteLine("Ingrese la edad de la persona: ");
//string edad = Console.ReadLine();

using ConsoleApp1;

decimal numeroMayor = 0;
decimal numeroMenor = 0;
decimal promedio = 0;
decimal acumulador = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ingrese la edad de la persona: ");
    string edadString = Console.ReadLine();


   // tryParse devuelve true o false.
    if (decimal.TryParse(edadString, out decimal edad) && i == 0)
    {
        numeroMayor = edad;
        numeroMenor = edad;

    }
    else
    {
        if (decimal.TryParse(edadString, out decimal edad2) && numeroMenor > edad)
        {
            numeroMenor = edad2;
        }
        else
        {
            if (decimal.TryParse(edadString, out decimal edad3) && numeroMayor < edad)
            {
                numeroMayor = edad3;
            }
        }
    }
    acumulador += edad;
}

promedio = acumulador / 5;
Console.WriteLine("La edad mas grande es: {0}", numeroMayor);
Console.WriteLine("El numero menor es: {0}", numeroMenor);
Console.WriteLine("El promedio es: {0}", promedio);



funciones.miFuncion();


//Manera de hacer arrays


string[] array = new string[5];

string[] array2 = {"pepe", "juan", "mario"};