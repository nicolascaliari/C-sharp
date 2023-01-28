// See https://aka.ms/new-console-template for more information
using Objetos;
using System;


Gato Nicolas = new Gato("pepe" , "largo" ,  new DateTime(12,02,23));
Gato Malena = new Gato( null ,"lala" , new DateTime(23,03,20));

Nicolas.AsignarPeso(10);
Malena.AsignarPeso(5);
double pesoNicolas = Nicolas.ObtenerPeso();
double pesoMalena = Malena.ObtenerPeso();

Console.WriteLine(Nicolas.ObtenerDato());
Console.WriteLine(Malena.ObtenerDato());