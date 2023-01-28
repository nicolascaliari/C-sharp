// See https://aka.ms/new-console-template for more information
using programacion_objetos1;
using System;

Console.WriteLine("Hello, World!");


    Gato Nicolas = new Gato();
    Gato Malena = new Gato();

    Nicolas.AsignarPeso(5);
    double pesoNicolas = Nicolas.ObtenerPeso();

    Console.WriteLine($"El peso de Nicolas es de: {pesoNicolas} ");