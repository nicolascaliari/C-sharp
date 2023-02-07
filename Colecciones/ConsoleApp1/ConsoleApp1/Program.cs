internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        //LISTAS

        //Asi se instancia una lista
        //List<string> nombres = new List<string>();

        //nombres.Add("Nicolas");
        //nombres.Add("Malena");
        //nombres.Add("Juan");


        //foreach (var item in nombres)
        //{
        //  Console.WriteLine(item);
        //}


        List<int> numeros = new List<int>();

        numeros.Add(10);
        numeros.Add(13);
        numeros.Add(14);
        numeros.Add(16);
        numeros.Add(1);


        foreach (var item in numeros)
        {
            Console.WriteLine(item);
        }


        numeros.Sort(Comparacion);

        foreach (var item in numeros)
        {
            Console.WriteLine(item);
        }


        //DICCIONARIOS

        Dictionary<string, int> agenda = new Dictionary<string, int>();


        agenda.Add("Nicolas", 1234);
        agenda.Add("Pepe", 12345);
        agenda.Add("Malena", 12346);
        agenda.Add("Juan", 12348);


        foreach(KeyValuePair<string, int> item in agenda)
        {
            Console.WriteLine($"El nombre es{item.Key} y su numero es {item.Value}");
        }

    }


    public static int Comparacion(int a, int b)
    {
        return a - b;
    }
}


