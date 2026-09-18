using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("==============================================");
        Console.WriteLine(" PROBLEMARIO #1 - EJERCICIO 4");
        Console.WriteLine(" ANÁLISIS DE CORRIENTE DE ACTUADOR");
        Console.WriteLine("==============================================");

        Console.WriteLine("Planteamiento:");
        Console.WriteLine("Analizar ocho mediciones de corriente de un");
        Console.WriteLine("actuador y detectar posibles sobrecorrientes.");
        Console.WriteLine();

        double corriente;
        double suma = 0;
        double promedio;
        int normales = 0;
        int sobrecorrientes = 0;

        // Ciclo para las ocho mediciones
        for (int i = 1; i <= 8; i++)
        {
            Console.Write(
                $"Ingrese la medición {i} de corriente (A): ");

            corriente = Convert.ToDouble(Console.ReadLine());

            suma += corriente;

            // Clasificación de la medición
            if (corriente <= 5)
            {
                Console.WriteLine("MEDICIÓN NORMAL.");
                normales++;
            }
            else
            {
                Console.WriteLine("SOBRECORRIENTE DETECTADA.");
                sobrecorrientes++;
            }

            Console.WriteLine();
        }

        // Cálculo del promedio
        promedio = suma / 8;

        Console.WriteLine("==============================================");
        Console.WriteLine(" RESULTADOS FINALES");
        Console.WriteLine("==============================================");

        Console.WriteLine($"Corriente promedio: {promedio:F2} A");
        Console.WriteLine($"Mediciones normales: {normales}");
        Console.WriteLine($"Sobrecorrientes: {sobrecorrientes}");

        // Resultado general
        if (sobrecorrientes == 0)
        {
            Console.WriteLine("ACTUADOR APROBADO.");
        }
        else
        {
            Console.WriteLine("EL ACTUADOR REQUIERE REVISIÓN.");
        }

        Console.WriteLine();
        Console.WriteLine("Presione una tecla para finalizar...");
        Console.ReadKey();
    }
}
