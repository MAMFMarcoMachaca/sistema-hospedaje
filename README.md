# Sistema de Gestión para Hospedaje

Sistema desarrollado para mejorar el control de habitaciones, clientes, pagos, cochera, servicios adicionales e ingresos diarios de un hospedaje.

## Problema que busca resolver

Actualmente, muchas operaciones del hospedaje pueden registrarse manualmente en cuadernos, hojas separadas o mensajes, lo que puede provocar errores, pérdida de información y dificultades para conocer los ingresos reales del negocio.

Este proyecto busca centralizar la información y facilitar el control diario del hospedaje.

## Objetivo

Desarrollar progresivamente un sistema que permita registrar y consultar las principales operaciones del hospedaje de manera ordenada, segura y sencilla.

## Funciones planificadas

- Registro de habitaciones.
- Control de habitaciones disponibles y ocupadas.
- Registro de clientes.
- Registro de entradas y salidas.
- Registro de pagos.
- Control de cochera.
- Registro de servicios adicionales.
- Reportes de ingresos.
- Dashboard de ocupación.
- Historial de operaciones.

## Funcionalidad implementada

### Cálculo de ingreso diario

- Registro de cantidades y precios de habitaciones simples y dobles.
- Registro de ingresos por cochera.
- Registro de gastos del día.
- Cálculo del ingreso por habitaciones.
- Cálculo del ingreso total.
- Cálculo de la utilidad estimada.

### Menú inicial del sistema

- Menú principal con cuatro opciones.
- Registro temporal de habitaciones.
- Selección del tipo de habitación.
- Registro del precio y estado de la habitación.
- Registro de ingresos económicos mediante concepto y monto.
- Resumen de habitaciones e ingresos registrados.
- Cálculo del monto total acumulado.
- Validación básica de datos ingresados.
- Salida controlada del programa.

## Tecnologías utilizadas

- C# para la lógica de la aplicación.
- .NET para crear, compilar y ejecutar el proyecto.
- Visual Studio Code como editor de código.
- Git para el control de versiones.
- GitHub para almacenar y publicar los avances.

## Tecnologías planificadas

- Base de datos para almacenar habitaciones, clientes, pagos y operaciones.
- ASP.NET Core para desarrollar servicios y aplicaciones web.
- Tecnologías de interfaz para crear un dashboard de gestión.

## Primer módulo completado: Ingreso Diario del Hospedaje

Aplicación de consola desarrollada en C# para calcular los ingresos y la utilidad estimada de un día de trabajo en el hospedaje.

### Datos de entrada

El programa solicita:

- Cantidad de habitaciones simples vendidas.
- Precio por habitación simple.
- Cantidad de habitaciones dobles vendidas.
- Precio por habitación doble.
- Cantidad de cocheras utilizadas.
- Precio por cochera.
- Gastos del día.

### Cálculos realizados

El programa calcula:

- Ingreso por habitaciones.
- Ingreso por cochera.
- Ingreso total del día.
- Gastos registrados.
- Utilidad estimada.

### Conceptos practicados

- Variables.
- Tipos de datos `int` y `decimal`.
- Entrada de datos con `Console.ReadLine()`.
- Salida de información con `Console.Write()` y `Console.WriteLine()`.
- Conversión de texto con `int.Parse()` y `decimal.Parse()`.
- Operaciones de suma, resta y multiplicación.
- Interpolación de cadenas.
- Formato de valores monetarios con dos decimales.

### Ejecución

Desde la carpeta del proyecto:

```bash
cd IngresoDiarioHospedaje
dotnet run
```

## Segundo módulo completado: Menú Inicial del Sistema

Aplicación de consola desarrollada en C# para realizar operaciones básicas del hospedaje mediante un menú repetitivo.

### Opciones del menú

1. Registrar una habitación.
2. Registrar un ingreso económico.
3. Ver un resumen básico.
4. Salir del programa.

### Datos de la habitación

El programa permite registrar:

- Número de habitación.
- Tipo de habitación.
- Precio por noche.
- Estado disponible u ocupada.

### Datos del ingreso

El programa permite registrar:

- Concepto del ingreso.
- Monto recibido.

### Resumen básico

El sistema muestra:

- Cantidad de habitaciones registradas.
- Información de cada habitación.
- Cantidad de ingresos registrados.
- Información de cada ingreso.
- Monto total acumulado.

### Conceptos practicados

- Menús mediante `switch`.
- Repetición del programa mediante `while`.
- Listas temporales con `List<string>`.
- Validación de números con `TryParse()`.
- Condiciones con `if` y `else`.
- Operadores lógicos.
- Conteo de elementos mediante `Count`.
- Recorrido de listas mediante `foreach`.
- Acumulación de montos.
- Uso de `break` y `continue`.

### Limitaciones actuales

- Los datos se conservan solamente mientras el programa permanece abierto.
- Al cerrar la aplicación, las listas se vacían.
- Todavía no se utiliza una base de datos.
- Todavía no se registran clientes, fechas de ingreso o fechas de salida.

### Ejecución

Desde la carpeta principal del repositorio:

```bash
cd RegistroHabitacion
dotnet run
```

### Estructura actual

```text
sistema-hospedaje/
├── IngresoDiarioHospedaje/
│   ├── Program.cs
│   └── IngresoDiarioHospedaje.csproj
├── RegistroHabitacion/
│   ├── Program.cs
│   └── RegistroHabitacion.csproj
├── .gitignore
└── README.md
```
## Etapas del proyecto

1. ✅ Desarrollo de ejercicios básicos de programación.
2. ✅ Cálculo de ingresos diarios.
3. ✅ Menú inicial y registro temporal de habitaciones.
4. ✅ Registro temporal de ingresos económicos.
5. ⏳ Registro de clientes, entradas y salidas.
6. ⏳ Implementación de una base de datos.
7. ⏳ Creación de reportes.
8. ⏳ Desarrollo de una interfaz.
9. ⏳ Construcción de un sistema completo de gestión.

## Estado actual

Dos aplicaciones de consola completadas y funcionando.

Avances realizados:

- Entorno de desarrollo configurado.
- Repositorio creado y publicado en GitHub.
- Primera aplicación para calcular ingresos y utilidad diaria.
- Menú principal repetitivo con cuatro opciones.
- Registro temporal de habitaciones.
- Registro temporal de ingresos económicos.
- Validación básica de datos mediante `TryParse()`.
- Almacenamiento temporal mediante `List<string>`.
- Resumen de habitaciones e ingresos registrados.
- Cálculo del total de ingresos acumulados.

Actualmente, la información se almacena únicamente durante la ejecución del programa. El siguiente crecimiento del proyecto incorporará una estructura más organizada y, posteriormente, almacenamiento permanente.

## Autor

Marco Antonio Machaca