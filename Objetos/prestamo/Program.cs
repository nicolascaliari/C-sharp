// See https://aka.ms/new-console-template for more information
using prestamo;

//new reserva espacio en memoria
Cuenta cuenta = new Cuenta("utn", 7000);

Console.WriteLine(cuenta.mostrar());

cuenta.ingresar(3000);

Console.WriteLine(cuenta.mostrar());

cuenta.retirar(1000);

Console.WriteLine(cuenta.mostrar());