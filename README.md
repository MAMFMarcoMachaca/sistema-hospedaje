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

- Aplicación de consola para calcular ingresos diarios.
- Registro de habitaciones simples y dobles vendidas.
- Registro de ingresos por cochera.
- Registro de gastos del día.
- Cálculo del ingreso total.
- Cálculo de la utilidad estimada.

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
### Estructura actual

```text
sistema-hospedaje/
├── IngresoDiarioHospedaje/
│   ├── Program.cs
│   └── IngresoDiarioHospedaje.csproj
└── README.md
```
## Etapas del proyecto

1. ✅ Desarrollo de ejercicios básicos de programación.
2. ✅ Cálculo de ingresos diarios.
3. ⏳ Registro de habitaciones y clientes.
4. ⏳ Registro de pagos y cochera.
5. ⏳ Implementación de una base de datos.
6. ⏳ Creación de reportes.
7. ⏳ Desarrollo de una interfaz gráfica.
8. ⏳ Construcción de un sistema completo de gestión.

## Estado actual

Primera aplicación de consola completada y funcionando.

Avances realizados:

- Entorno de desarrollo configurado.
- Repositorio creado en GitHub.
- Git y GitHub configurados.
- Proyecto de consola creado con C# y .NET.
- Entrada de datos desde la consola.
- Cálculo de ingresos y utilidad diaria.
- Presentación de resultados monetarios.

El proyecto continuará creciendo de manera progresiva conforme se desarrollen nuevos conocimientos de programación, bases de datos y desarrollo web.

## Autor

Marco Antonio Machaca