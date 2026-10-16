# Diseño del dominio POO — Sistema Hospedaje

## Fecha

16/10/2026

## Objetivo

Definir las principales entidades del dominio del Sistema Hospedaje, sus responsabilidades y relaciones, e iniciar la transición del proyecto desde estructuras basadas en texto hacia programación orientada a objetos.

---

# ¿Qué es el dominio?

El dominio representa las principales cosas y reglas que existen dentro del problema que el sistema busca resolver.

En el Sistema Hospedaje se identificaron inicialmente las siguientes entidades:

- Habitacion.
- Cliente.
- Estadia.
- Pago.
- Cochera.

Estas entidades representan elementos importantes del funcionamiento real de un hospedaje.

---

# Habitacion

## Responsabilidad

Representar una habitación física del hospedaje y almacenar sus características principales.

## Propiedades iniciales

- Numero.
- Tipo.
- PrecioNoche.
- Estado.

Ejemplo:

```text
Habitación 101
Tipo: Simple
Precio: S/ 40.00
Estado: Disponible
```

## Relación

Una habitación puede participar en muchas estadías a lo largo del tiempo.

Una habitación no debería tener más de una estadía activa al mismo tiempo.

---

# Cliente

## Responsabilidad

Representar a una persona que utiliza los servicios del hospedaje.

## Propiedades propuestas

- ClienteId.
- Nombres.
- Apellidos.
- Documento.
- Telefono.

## Relación

Un cliente puede tener varias estadías a lo largo del tiempo.

También puede utilizar el servicio de cochera.

---

# Estadia

## Responsabilidad

Representar la ocupación de una habitación por parte de un cliente durante un periodo determinado.

La entidad `Estadia` permite relacionar correctamente al cliente con la habitación sin asignar permanentemente una habitación al cliente.

## Propiedades propuestas

- EstadiaId.
- Cliente.
- Habitacion.
- FechaIngreso.
- FechaSalida.
- PrecioAcordado.
- Estado.

## Relación

Una estadía pertenece a:

- Un cliente.
- Una habitación.

Una estadía puede tener uno o varios pagos.

Ejemplo conceptual:

```text
Cliente
   |
   v
Estadia
   |
   v
Habitacion
```

---

# Pago

## Responsabilidad

Representar un pago realizado por un servicio relacionado con una estadía.

## Propiedades propuestas

- PagoId.
- Estadia.
- Monto.
- MetodoPago.
- FechaPago.

## Relación

Una estadía puede tener uno o varios pagos.

Ejemplo:

```text
Estadia
   |
   |-- Pago 1
   |
   |-- Pago 2
```

Esto permite posteriormente manejar pagos parciales si fuera necesario.

---

# Cochera

## Responsabilidad

Representar inicialmente el uso del servicio de cochera por parte de un vehículo.

## Propiedades propuestas

- CocheraId.
- Cliente.
- Placa.
- TipoVehiculo.
- FechaIngreso.
- FechaSalida.
- Monto.
- Estado.

## Relación

Un cliente puede utilizar el servicio de cochera varias veces a lo largo del tiempo.

En una futura evolución del sistema se podría separar el espacio físico de cochera del registro de uso del servicio.

---

# Relaciones principales

El diseño conceptual inicial puede representarse así:

```text
Cliente 1 -------- muchas Estadias

Habitacion 1 ----- muchas Estadias
                   a lo largo del tiempo

Estadia 1 -------- muchos Pagos

Cliente 1 -------- muchos usos de Cochera
                   a lo largo del tiempo
```

La entidad `Estadia` funciona como vínculo principal entre `Cliente` y `Habitacion`.

---

# Primer refactor POO realizado

Antes del refactor, las habitaciones se almacenaban como texto:

```csharp
List<string> habitaciones = new List<string>();
```

Cada habitación terminaba representada mediante una cadena similar a:

```text
Habitación 101 | Tipo: Simple | Precio: S/ 40.00 | Estado: Disponible
```

Aunque el texto contenía diferentes datos, para C# todo era solamente un `string`.

Después del refactor se creó:

```text
RegistroHabitacion/
└── Models/
    └── Habitacion.cs
```

La clase implementada fue:

```csharp
namespace RegistroHabitacion.Models;

public class Habitacion
{
    public int Numero { get; set; }

    public string Tipo { get; set; } = "";

    public decimal PrecioNoche { get; set; }

    public string Estado { get; set; } = "";
}
```

La lista pasó de:

```csharp
List<string> habitaciones
```

a:

```csharp
List<Habitacion> habitaciones
```

---

# Mejora en la validación de habitaciones duplicadas

Antes, como una habitación era solamente un texto, la validación necesitaba buscar información dentro de la cadena:

```csharp
habitacion.StartsWith(
    $"Habitación {numeroHabitacion} |"
)
```

Después del refactor se puede trabajar directamente con la propiedad del objeto:

```csharp
habitacion.Numero == numeroHabitacion
```

Esto permite expresar de manera más clara la regla de negocio:

> No pueden existir dos habitaciones registradas con el mismo número.

---

# Comportamiento preservado

El objetivo del refactor fue modificar la estructura interna sin alterar el comportamiento que ya utilizaba el usuario.

Después del cambio se comprobó:

- Compilación correcta.
- Validación de menú incorrecto.
- Registro correcto de habitación.
- Prevención de habitaciones duplicadas.
- Validación de precio negativo.
- Visualización correcta del resumen.
- Registro de ingresos funcionando.
- Finalización normal del programa.

El programa continúa mostrando una habitación en el mismo formato:

```text
Habitación 101 | Tipo: Simple | Precio: S/ 40.00 | Estado: Disponible
```

aunque internamente ahora se almacena mediante un objeto `Habitacion`.

---

# Resultado

Se completó el primer refactor orientado a objetos del proyecto.

El cambio permitió pasar de almacenar una habitación como texto a representarla mediante una clase con propiedades individuales.

No se modificó todavía el almacenamiento de ingresos ni se implementaron las entidades `Cliente`, `Estadia`, `Pago` y `Cochera`.

Estas entidades fueron diseñadas conceptualmente y serán implementadas progresivamente en futuras etapas.

---

# Próximos pasos

La evolución prevista del proyecto será:

```text
Habitacion
↓
Cliente
↓
Estadia
↓
Pago
↓
Cochera
↓
Separación de responsabilidades
↓
Servicios
↓
Persistencia
↓
Entity Framework Core
↓
ASP.NET Core Web API
```

Los siguientes cambios deberán mantenerse pequeños y verificarse mediante pruebas para evitar regresiones.