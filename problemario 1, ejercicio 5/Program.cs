using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("==============================================");
        Console.WriteLine(" PROBLEMARIO #1 - EJERCICIO 5");
        Console.WriteLine(" ANÁLISIS DE VIBRACIÓN DE MOTORES");
        Console.WriteLine("==============================================");

        Console.WriteLine("Planteamiento:");
        Console.WriteLine("Analizar cuatro mediciones de vibración para");
        Console.WriteLine("cada motor y determinar su estado.");
        Console.WriteLine();

        string nombreMotor;
        string respuesta = "S";

        int totalMotores = 0;
        int motoresNormales = 0;
        int motoresMantenimiento = 0;

        // El ciclo while permite analizar varios motores
        while (respuesta.ToUpper() == "S")
        {
            double suma = 0;
            double vibracion;
            double promedio;

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");

            // Identificador del motor
            Console.Write(
                "Ingrese el nombre o identificador del motor: ");

            nombreMotor = Console.ReadLine();

            // Cuatro mediciones mediante ciclo for
            for (int i = 1; i <= 4; i++)
            {
                Console.Write(
                    $"Ingrese la medición {i} de vibración (mm/s): ");

                vibracion = Convert.ToDouble(Console.ReadLine());

                suma += vibracion;
            }

            // Cálculo del promedio
            promedio = suma / 4;

            Console.WriteLine();
            Console.WriteLine($"Motor: {nombreMotor}");
            Console.WriteLine(
                $"Vibración promedio: {promedio:F2} mm/s");

            // Clasificación
            if (promedio <= 4.5)
            {
                Console.WriteLine(
                    "FUNCIONAMIENTO NORMAL DEL MOTOR.");

                motoresNormales++;
            }
            else
            {
                Console.WriteLine(
                    "EL MOTOR REQUIERE MANTENIMIENTO.");

                motoresMantenimiento++;
            }

            totalMotores++;

            // Preguntar si se desea analizar otro motor
            Console.WriteLine();
            Console.Write(
                "¿Desea analizar otro motor? (S/N): ");

            respuesta = Console.ReadLine();
        }

        // Resultados finales
        Console.WriteLine();
        Console.WriteLine("==============================================");
        Console.WriteLine(" RESULTADOS FINALES");
        Console.WriteLine("==============================================");

        Console.WriteLine(
            $"Total de motores evaluados: {totalMotores}");

        Console.WriteLine(
            $"Motores con funcionamiento normal: {motoresNormales}");

        Console.WriteLine(
            $"Motores que requieren mantenimiento: {motoresMantenimiento}");

        Console.WriteLine();
        Console.WriteLine("Presione una tecla para finalizar...");
        Console.ReadKey();
    }
}
