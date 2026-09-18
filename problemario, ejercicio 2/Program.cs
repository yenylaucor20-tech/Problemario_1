using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("==============================================");
        Console.WriteLine(" PROBLEMARIO #1 - EJERCICIO 2");
        Console.WriteLine(" PROMEDIO DE TEMPERATURA DE MOTOR");
        Console.WriteLine("==============================================");

        Console.WriteLine("Planteamiento:");
        Console.WriteLine("Realizar diez mediciones de temperatura,");
        Console.WriteLine("calcular el promedio y clasificarlo.");
        Console.WriteLine();

        double temperatura;
        double suma = 0;
        double promedio;

        // Ciclo para realizar las 10 mediciones
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Ingrese la temperatura {i} (°C): ");
            temperatura = Convert.ToDouble(Console.ReadLine());

            suma += temperatura;
        }

        // Cálculo del promedio
        promedio = suma / 10;

        Console.WriteLine();
        Console.WriteLine($"Temperatura promedio: {promedio:F2} °C");

        // Clasificación
        if (promedio <= 70)
        {
            Console.WriteLine("TEMPERATURA NORMAL.");
        }
        else
        {
            Console.WriteLine("ALERTA DE TEMPERATURA.");
        }

        Console.WriteLine();
        Console.WriteLine("Presione una tecla para finalizar...");
        Console.ReadKey();
    }
}
