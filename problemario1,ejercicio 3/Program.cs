using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("==============================================");
        Console.WriteLine(" PROBLEMARIO #1 - EJERCICIO 3");
        Console.WriteLine(" SIMULACIÓN DE CARGA");
        Console.WriteLine("==============================================");

        Console.WriteLine("Planteamiento:");
        Console.WriteLine("Simular la carga de una batería hasta alcanzar");
        Console.WriteLine("12.6 V utilizando un ciclo while.");
        Console.WriteLine();

        double voltaje;
        double incremento;
        double voltajeMaximo = 12.6;
        int ciclo = 0;

        Console.Write("Ingrese el voltaje inicial (V): ");
        voltaje = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el incremento por ciclo (V): ");
        incremento = Convert.ToDouble(Console.ReadLine());

        // Validación del incremento
        if (incremento <= 0)
        {
            Console.WriteLine();
            Console.WriteLine("ERROR: El incremento debe ser mayor que cero.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Simulación de carga:");
            Console.WriteLine("--------------------------------");

            // Ciclo de carga
            while (voltaje < voltajeMaximo)
            {
                voltaje += incremento;
                ciclo++;

                // Evitar superar el límite de 12.6 V
                if (voltaje > voltajeMaximo)
                {
                    voltaje = voltajeMaximo;
                }

                Console.WriteLine(
                    $"Ciclo {ciclo}: {voltaje:F2} V");
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("BATERÍA CARGADA A 12.6 V.");
        }

        Console.WriteLine();
        Console.WriteLine("Presione una tecla para finalizar...");
        Console.ReadKey();
    }
}
