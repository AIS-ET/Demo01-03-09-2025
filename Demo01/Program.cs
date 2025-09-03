using System;

class Ejercicio1
{
    static void Main()
    {
        // Ejercicio 1
        // Pago total por alquiler de una casa
        // Desarrollar un programa que calcule el pago total por alquilar una casa.
        // El costo del alquiler se basa en los siguientes precios unitarios:
        // S/.30.00 por cada habitación,
        // S/.10.00 por cada baño,
        // S/.15.00 por cada patio.
        // El usuario debe ingresar la cantidad de habitaciones, baños y patios,
        // y el programa debe mostrar el pago total.

        int habitaciones, baños, patios;
        double pagoTotal;

        Console.WriteLine("Ingrese la cantidad de habitaciones:");
        habitaciones = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la cantidad de baños:");
        baños = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la cantidad de patios:");
        patios = Convert.ToInt32(Console.ReadLine());

        pagoTotal = (habitaciones * 30) + (baños * 10) + (patios * 15);

        Console.WriteLine("El pago total por el alquiler es: S/. " + pagoTotal);
    }
}
