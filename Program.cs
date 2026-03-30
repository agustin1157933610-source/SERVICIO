using System;
using System.Collections.Generic;

class Program
{
    static List<Personal> personas = new List<Personal>();
    static List<Registro> registros = new List<Registro>();

    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n=== REGISTRO DE GUARDIA ===");
            Console.WriteLine("1. Registrar Personal");
            Console.WriteLine("2. Marcar Entrada");
            Console.WriteLine("3. Marcar Salida");
            Console.WriteLine("4. Mostrar Registros");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    RegistrarPersonal();
                    break;

                case 2:
                    RegistrarEntrada();
                    break;

                case 3:
                    RegistrarSalida();
                    break;

                case 4:
                    MostrarRegistros();
                    break;
                
            }

        } while (opcion != 0);
    }

    static void RegistrarPersonal()
{
    Console.WriteLine("\nSeleccione tipo de personal:");
    Console.WriteLine("1. Soldado");
    Console.WriteLine("2. Suboficial");
    Console.WriteLine("3. Pasante");

    int tipo = int.Parse(Console.ReadLine());

    Personal? p = null;

    switch (tipo)
    {
        case 1:
            p = new Soldado();
            break;

        case 2:
            p = new Suboficial();
            break;

        case 3:
            p = new Pasante();
            break;

        default:
            Console.WriteLine("OPCION INCORRECTA 🤦‍♂️");
            return;
    }

    Console.Write("Grado: ");
    p.grado = Console.ReadLine();

    Console.Write("Nombre: ");
    p.nombre = Console.ReadLine();

    Console.Write("Apellido: ");
    p.apellido = Console.ReadLine();

    personas.Add(p);

    Console.WriteLine("bien te registraste🫡");
    p.presentarse();
     
}

    static void RegistrarEntrada()
    {
        Console.Write("Ingrese nombre: ");
        string nombre = Console.ReadLine();

        foreach (var p in personas)
        {
            if (p.nombre == nombre)
            {
                Registro r = new Registro();
                r.Persona = p;
                r.RegistrarEntrada();

                registros.Add(r);

                Console.WriteLine("INGRESO CORRECTO 😎HACETE CARNE MILICO");
                return;
            }
        }

        Console.WriteLine("❌ USTED NO SE REGISTRO AUN ");
    }

    static void RegistrarSalida()
    {
        Console.Write("Ingrese nombre: ");
        string nombre = Console.ReadLine();

        foreach (var r in registros)
        {
            if (r.Persona.nombre == nombre)
            {
                r.RegistrarSalida();
                Console.WriteLine("BUEN DESCANSO,NO TE OLVIDASTE NADA NO?");
                return;
            }
        }

        Console.WriteLine("❌USTED NO SE REGISTRO AUN");
    }

    static void MostrarRegistros()
    {
        Console.WriteLine("\n=== LISTA DE REGISTROS ===");

        foreach (var r in registros)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Grado: {r.Persona.grado}");
            Console.WriteLine($"Nombre: {r.Persona.nombre} {r.Persona.apellido}");
            Console.WriteLine($"Entrada: {r.horaentrada.ToString("HH:mm:ss")}");
            Console.WriteLine($"Salida: {(r.horasalida == DateTime.MinValue ? "Sin salida" : r.horasalida.ToString("HH:mm:ss"))}");
        }
    }
}
