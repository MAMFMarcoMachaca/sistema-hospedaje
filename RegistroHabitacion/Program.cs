List<string> habitaciones = new List<string>();
List<string> ingresos = new List<string>();

decimal totalIngresos = 0m;
bool programaActivo = true;

while (programaActivo)
{
    Console.WriteLine();
    Console.WriteLine("=== SISTEMA DE HOSPEDAJE ===");
    Console.WriteLine("1. Registrar habitación");
    Console.WriteLine("2. Registrar ingreso");
    Console.WriteLine("3. Ver resumen");
    Console.WriteLine("4. Salir");
    Console.Write("Seleccione una opción: ");
    
    bool opcionMenuValida = int.TryParse(
        Console.ReadLine(),
        out int opcionMenu
    );
    
    if(!opcionMenuValida)
    {
        Console.WriteLine();
        Console.WriteLine("Error: debe ingresar una opción numérica. ");
        continue;
    }

    switch(opcionMenu)
    {
        case 1:
            Console.WriteLine("=== REGISTRO DE HABITACIÓN ===");
            Console.WriteLine();

            Console.Write("Número de habitación: ");

        bool numeroValido = int.TryParse(
            Console.ReadLine(),
            out int numeroHabitacion
        );

        if (numeroValido && numeroHabitacion > 0)
        {
            Console.WriteLine();
            Console.WriteLine("Seleccione el tipo de habitación:");
            Console.WriteLine("1. Simple");
            Console.WriteLine("2. Doble");
            Console.WriteLine("3. Matrimonial");
            Console.WriteLine("4. Familiar");
            Console.WriteLine("5. Triple");
            Console.Write("Opción: ");

            bool opcionConvertida = int.TryParse(
                Console.ReadLine(),
                out int opcionTipo
            );

            string tipoHabitacion = "";
            bool tipoValido = true;

            switch (opcionTipo)
            {
                case 1:
                    tipoHabitacion = "Simple";
                    break;

                case 2:
                    tipoHabitacion = "Doble";
                    break;

                case 3:
                    tipoHabitacion = "Matrimonial";
                    break;

                case 4:
                    tipoHabitacion = "Familiar";
                    break;

                case 5:
                    tipoHabitacion = "Triple";
                    break;

                default:
                    tipoValido = false;
                    break;
            }

            if (opcionConvertida && tipoValido)
            {
                Console.WriteLine();
                Console.Write("Precio por noche: S/ ");

                bool precioConvertido = decimal.TryParse(
                    Console.ReadLine(),
                    out decimal precioNoche
                );

                if (precioConvertido && precioNoche > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Seleccione el estado de la habitación:");
                    Console.WriteLine("1. Disponible");
                    Console.WriteLine("2. Ocupada");
                    Console.Write("Opción: ");

                    bool opcionEstadoConvertida = int.TryParse(
                        Console.ReadLine(),
                        out int opcionEstado
                    );

                    string estadoHabitacion ="";
                    bool estadoValido = true;

                    switch (opcionEstado)
                    {
                        case 1:
                            estadoHabitacion = "Disponible";
                            break;
                        case 2:
                            estadoHabitacion= "Ocupada";
                            break;
                        default:
                            estadoValido = false;
                            break;            
                    }

                    if(opcionEstadoConvertida && estadoValido)
                    {

                    string habitacionRegistrada =
                        $"Habitación {numeroHabitacion} | " +
                        $"Tipo: {tipoHabitacion} | " +
                        $"Precio: S/ {precioNoche:F2} | " +
                        $"Estado: {estadoHabitacion}";

                        habitaciones.Add(habitacionRegistrada);

                        Console.WriteLine();
                        Console.WriteLine("=== HABITACIÓN REGISTRADA ===");
                        Console.WriteLine(habitacionRegistrada);
                        Console.WriteLine($"Total registrado: {habitaciones.Count}");
                        
                    }
                    else{
                        Console.WriteLine();
                        Console.WriteLine(
                        "Error: seleccione 1 para Disponible o 2 para Ocupada."
                    );
                    }

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(
                        "Error: ingrese un precio mayor que cero."
                    );
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(
                    "Error: seleccione una opción entre 1 y 5."
                );
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine(
                "Error: ingrese un número de habitación mayor que cero."
            );
        }
            break;
        case 2:
            Console.WriteLine();
            Console.WriteLine("=== REGISTRO DE INGRESO ===");

            Console.WriteLine("Concepto del ingreso: ");
            string conceptoIngreso = Console.ReadLine() ?? "";

            if(string.IsNullOrWhiteSpace(conceptoIngreso))
            {
                Console.WriteLine();
                Console.WriteLine(
                    "Error: el concepto no puede estar vacío."
                );

                break;

            }

            Console.Write("Monto del ingreso: S/ ");

            bool montoConvertido = decimal.TryParse(
                Console.ReadLine(),
                out decimal montoIngreso
            );

            if (montoConvertido && montoIngreso > 0)
            {
                string ingresoRegistrado = 
                    $"{conceptoIngreso} | S/ {montoIngreso:F2}";

                ingresos.Add(ingresoRegistrado);
                totalIngresos += montoIngreso;

                Console.WriteLine();
                Console.WriteLine("=== INGRESO REGISTRADO ===");
                Console.WriteLine(ingresoRegistrado);
                Console.WriteLine(
                    $"Total de ingresos registrados: {ingresos.Count}"
                );
                Console.WriteLine(
                    $"Monto acumulado: S/ {totalIngresos:F2}"
                );
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(
                    "Error: ingrese un monto mayor que cero."
                );
            }

            break;
        case 3:
            Console.WriteLine();
            Console.WriteLine("=== RESUMEN BÁSICO ===");

            Console.WriteLine();
            Console.WriteLine(
                $"Habitaciones registradas: {habitaciones.Count}"
            );

            if(habitaciones.Count == 0)
            {
                Console.WriteLine(
                    "No hay habitaciones registradas."
                );
            }
            else
            {
                foreach (string habitacion in habitaciones)
                {
                    Console.WriteLine($"- {habitacion}");
                }
            }

            Console.WriteLine();
            Console.WriteLine(
                $"Ingresos registrados: {ingresos.Count}"
            );

            if (ingresos.Count == 0)
            {
                Console.WriteLine(
                    "No hay ingresos registrados."
                );
            }
            else
            {
                foreach(string ingreso in ingresos)
                {
                    Console.WriteLine($" -{ingreso}");
                }
            }

            Console.WriteLine();
            Console.WriteLine(
                $"Total de igresos: S/ {totalIngresos:F2}"
            );
            break;
        case 4:
            programaActivo = false;

            Console.WriteLine();
            Console.WriteLine("Programa finalizado. ");
            break;
        
        default:
            Console.WriteLine();
            Console.WriteLine("Error: selecione una opción entre 1 y 4.");
            break;
    }
}


