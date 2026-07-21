Console.WriteLine("=== INGRESO DIARIO DEL HOSPEDAJE ===");
Console.WriteLine();

// ENTRADA DE DATOS

Console.Write("Cantidad de habitaciones simples vendidas: ");
int cantidadSimples = int.Parse(Console.ReadLine()!);

Console.Write("Precio por habitación simple: S/ ");
decimal precioSimple = decimal.Parse(Console.ReadLine()!);

Console.Write("Cantidad de habitaciones dobles vendidas: ");
int cantidadDobles = int.Parse(Console.ReadLine()!);

Console.Write("Precio por habitación doble: S/ ");
decimal precioDoble = decimal.Parse(Console.ReadLine()!);

Console.Write("Cantidad de cocheras utilizadas: ");
int cantidadCocheras = int.Parse(Console.ReadLine()!);

Console.Write("Precio por cochera: S/ ");
decimal precioCochera = decimal.Parse(Console.ReadLine()!);

Console.Write("Gastos del día: S/ ");
decimal gastosDia = decimal.Parse(Console.ReadLine()!);

// CÁLCULOS

decimal ingresoHabitaciones =
    cantidadSimples * precioSimple +
    cantidadDobles * precioDoble;

decimal ingresoCochera =
    cantidadCocheras * precioCochera;

decimal ingresoTotal =
    ingresoHabitaciones + ingresoCochera;

decimal utilidad =
    ingresoTotal - gastosDia;

// SALIDA DE RESULTADOS

Console.WriteLine();
Console.WriteLine("=== RESULTADOS DEL DÍA ===");

Console.WriteLine($"Ingreso por habitaciones: S/ {ingresoHabitaciones:F2}");
Console.WriteLine($"Ingreso por cochera: S/ {ingresoCochera:F2}");
Console.WriteLine($"Ingreso total del día: S/ {ingresoTotal:F2}");
Console.WriteLine($"Gastos: S/ {gastosDia:F2}");
Console.WriteLine($"Utilidad estimada: S/ {utilidad:F2}");