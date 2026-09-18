using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("==============================================");
        Console.WriteLine(" PROBLEMARIO #1 - EJERCICIO 1");
        Console.WriteLine(" CONSUMO DE POTENCIA DE UN MOTOR CD");
        Console.WriteLine("==============================================");

        Console.WriteLine("Planteamiento:");
        Console.WriteLine("Solicitar el voltaje y la corriente de un motor");
        Console.WriteLine("de corriente directa, calcular P = V * I y");
        Console.WriteLine("clasificar su consumo.");
        Console.WriteLine();

        // Declaración de variables
        double voltaje;
        double corriente;
        double potencia;

        // Entrada de datos
        Console.Write("Ingrese el voltaje del motor (V): ");
        voltaje = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la corriente consumida (A): ");
        corriente = Convert.ToDouble(Console.ReadLine());

        // Cálculo de potencia
        potencia = voltaje * corriente;

        // Mostrar resultado
        Console.WriteLine();
        Console.WriteLine($"Potencia eléctrica: {potencia:F2} W");

        // Clasificación del consumo
        if (potencia <= 120)
        {
            Console.WriteLine("CONSUMO NORMAL.");
        }
        else
        {
            Console.WriteLine("ADVERTENCIA: CONSUMO ELEVADO.");
        }

        Console.WriteLine();
        Console.WriteLine("Presione una tecla para finalizar...");
        Console.ReadKey();
    }
}
