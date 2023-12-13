// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Operaciones con Variables y Operadores");
            Console.WriteLine("2. Estructuras de Control");
            Console.WriteLine("3. Programación Orientada a Objetos - Clases y Objetos");
            Console.WriteLine("4. Programación Orientada a Objetos - Métodos");
            Console.WriteLine("5. Programación Orientada a Objetos - Herencia");
            Console.WriteLine("6. Salir");
            Console.Write("Ingresa el número de la opción deseada: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RealizarOperacionesConVariables();
                    break;
                case "2":
                    EstructurasDeControl();
                    break;
                case "3":
                    ProgramacionOrientadaAObjetosClasesYObjetos();
                    break;
                case "4":
                    ProgramacionOrientadaAObjetosMetodos();
                    break;
                case "5":
                    ProgramacionOrientadaAObjetosHerencia();
                    break;
                case "6":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, ingresa un número válido.");
                    break;
            }

            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void RealizarOperacionesConVariables()
    {
        int numero1 = 5;
        int numero2 = 10;
        int resultado = numero1 + numero2;

        Console.WriteLine($"La suma de {numero1} y {numero2} es: {resultado}");
    }

    static void EstructurasDeControl()
    {
        int edad = 20;

        if (edad >= 18)
        {
            Console.WriteLine("La persona es mayor de edad.");
        }
        else
        {
            Console.WriteLine("La persona no es mayor de edad.");
        }
    }

    static void ProgramacionOrientadaAObjetosClasesYObjetos()
    {
        Estudiante estudiante1 = new Estudiante
        {
            Nombre = "Juan",
            Edad = 22,
            Calificacion = 85.5
        };

        Console.WriteLine("Información del estudiante:");
        Console.WriteLine($"Nombre: {estudiante1.Nombre}");
        Console.WriteLine($"Edad: {estudiante1.Edad} años");
        Console.WriteLine($"Calificación: {estudiante1.Calificacion}");
    }

    static void ProgramacionOrientadaAObjetosMetodos()
    {
        Estudiante estudiante1 = new Estudiante
        {
            Nombre = "Juan",
            Edad = 22,
            Calificacion = 85.5
        };

        estudiante1.MostrarInformacion();
    }

    static void ProgramacionOrientadaAObjetosHerencia()
    {
        EstudianteGraduado graduado1 = new EstudianteGraduado
        {
            Nombre = "Ana",
            Edad = 25,
            Calificacion = 92.0,
            Titulo = "Licenciatura en Informática"
        };

        graduado1.MostrarInformacion();
        Console.WriteLine($"Título obtenido: {graduado1.Titulo}");
    }
}

class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Calificacion { get; set; }

    public void MostrarInformacion()
    {
        Console.WriteLine("Información del estudiante:");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad} años");
        Console.WriteLine($"Calificación: {Calificacion}");
    }
}

class EstudianteGraduado : Estudiante
{
    public string Titulo { get; set; }
}

