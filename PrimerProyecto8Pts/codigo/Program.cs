using System;

class Program
{
    static string tipoCuenta;
    static string nombrePersona;
    static string dpi;
    static string direccion;
    static string numeroTelefono;
    static double saldoInicial = 2500.00;
    static double saldoActual;
    static int contadorAbonos = 0;

    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al Banco Country Bank");

        // Solicitar información de la cuenta bancaria
        SolicitarInformacionCuenta();

        bool salir = false;
        do
        {
            // Mostrar menú de opciones
            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1. Ver información de la cuenta");
            Console.WriteLine("2. Comprar producto financiero");
            Console.WriteLine("3. Vender producto financiero");
            Console.WriteLine("4. Abonar a cuenta");
            Console.WriteLine("5. Simular paso del tiempo");
            Console.WriteLine("6. Salir");

            // Leer la opción del usuario
            string opcion = Console.ReadLine();

            // Ejecutar la opción seleccionada
            switch (opcion)
            {
                case "1":
                    VerInformacionCuenta();
                    break;
                case "2":
                    ComprarProductoFinanciero();
                    break;
                case "3":
                    VenderProductoFinanciero();
                    break;
                case "4":
                    AbonarACuenta();
                    break;
                case "5":
                    SimularPasoDelTiempo();
                    break;
                case "6":
                    salir = true;
                    Console.WriteLine("¡Gracias por utilizar nuestros servicios!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
        } while (!salir);
    }

    static void SolicitarInformacionCuenta()
    {
        Console.WriteLine("\nPor favor ingrese la información de su cuenta bancaria:");
        Console.Write("Tipo de cuenta (monetaria quetzales, monetaria dólares, ahorro quetzales, ahorro dólares): ");
        tipoCuenta = Console.ReadLine();
        Console.Write("Nombre de la persona: ");
        nombrePersona = Console.ReadLine();
        Console.Write("DPI (5 caracteres): ");
        dpi = Console.ReadLine();
        Console.Write("Dirección: ");
        direccion = Console.ReadLine();
        Console.Write("Número de teléfono: ");
        numeroTelefono = Console.ReadLine();
        saldoActual = saldoInicial;
    }

    static void VerInformacionCuenta()
    {
        Console.WriteLine("\nInformación de la cuenta:");
        Console.WriteLine($"Tipo de cuenta: {tipoCuenta}");
        Console.WriteLine($"Nombre: {nombrePersona}");
        Console.WriteLine($"DPI: {dpi}");
        Console.WriteLine($"Dirección: {direccion}");
        Console.WriteLine($"Número de teléfono: {numeroTelefono}");
        Console.WriteLine($"Saldo actual: Q {saldoActual:F2}");
    }

    static void ComprarProductoFinanciero()
    {
        saldoActual -= saldoActual * 0.10;
        Console.WriteLine($"\nCompra exitosa. Saldo actual: Q {saldoActual:F2}");
    }

    static void VenderProductoFinanciero()
    {
        if (saldoActual > 500.00)
        {
            saldoActual += saldoActual * 0.11;
            Console.WriteLine($"\nVenta exitosa. Saldo actual: Q {saldoActual:F2}");
        }
        else
        {
            decimal porcentajeGanancia = (0.11m - 1) * 100;
            Console.WriteLine($"\nNo es posible realizar la transacción. Se recomienda no vender debido al porcentaje del saldo actual. Porcentaje de ganancia: {porcentajeGanancia}%");
        }
    }

    static void AbonarACuenta()
    {
        if (contadorAbonos < 2 && saldoActual < 500.00)
        {
            saldoActual *= 2;
            contadorAbonos++;
            Console.WriteLine($"\nAbono exitoso. Saldo actual: Q {saldoActual:F2}");
        }
        else
        {
            Console.WriteLine("\nNo es posible realizar más abonos en este momento.");
        }
    }
    public int AddTwoNumbers(int a, int b)
    {
        return a + b;
    }


    static void SimularPasoDelTiempo()
    {
        Console.WriteLine("\nIngrese el periodo de capitalización:");
        Console.WriteLine("1. Una vez al mes");
        Console.WriteLine("2. Dos veces al mes");
        string opcion = Console.ReadLine();

        double interes = 0.02; // tasa de interés del 2%

        switch (opcion)
        {
            case "1":
                saldoActual += saldoActual * interes;
                Console.WriteLine($"\nSimulación exitosa. Saldo actual: Q {saldoActual:F2}");
                break;
            case "2":
                saldoActual += saldoActual * interes * 2;
                Console.WriteLine($"\nSimulación exitosa. Saldo actual: Q {saldoActual:F2}");
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                break;
        }
    }
}
