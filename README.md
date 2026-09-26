# Sistema de Gestión para Hospedaje

Proyecto educativo desarrollado en C# y .NET para construir progresivamente un sistema de gestión aplicado a un hospedaje.

El proyecto comenzó con aplicaciones de consola para practicar fundamentos de programación y actualmente se encuentra en transición hacia un proyecto backend con programación orientada a objetos, base de datos y posteriormente ASP.NET Core.

---

## Objetivo

Construir progresivamente un sistema que permita manejar información relacionada con:

- Habitaciones.
- Clientes.
- Ingresos y pagos.
- Cochera.
- Gastos.
- Ocupación.
- Historial de operaciones.

Además del desarrollo, el repositorio se utiliza para practicar Git/GitHub, SQL, QA, documentación técnica, análisis de incidencias y diseño de APIs.

---

# Estado técnico actual

**Última auditoría del repositorio:** 25/09/2026.

Actualmente existen dos aplicaciones de consola independientes desarrolladas en C# con `.NET 10`.

## Implementado

### IngresoDiarioHospedaje

Permite ingresar:

- Cantidad y precio de habitaciones simples.
- Cantidad y precio de habitaciones dobles.
- Cantidad y precio de cocheras.
- Gastos diarios.

Calcula:

- Ingreso por habitaciones.
- Ingreso por cochera.
- Ingreso total.
- Gastos.
- Utilidad estimada.

Este módulo todavía utiliza `int.Parse()` y `decimal.Parse()`, por lo que una entrada con formato incorrecto puede producir una excepción.

### RegistroHabitacion

Incluye un menú que permite:

1. Registrar una habitación.
2. Registrar un ingreso.
3. Mostrar un resumen.
4. Salir.

Actualmente valida:

- Opciones no numéricas.
- Opciones fuera de rango.
- Número de habitación inválido.
- Número de habitación menor o igual a cero.
- Habitaciones duplicadas.
- Tipo de habitación inválido.
- Precio no numérico.
- Precio menor o igual a cero.
- Estado inválido.
- Concepto de ingreso vacío.
- Monto de ingreso inválido o menor o igual a cero.

Este módulo utiliza principalmente `TryParse()` para controlar entradas incorrectas.

---

# Limitación principal actual

Los datos se almacenan únicamente en memoria utilizando estructuras como:

```csharp
List<string> habitaciones
List<string> ingresos
```

Por ello:

- La información desaparece al cerrar el programa.
- Las habitaciones todavía no están representadas mediante objetos.
- No existe persistencia en SQL.
- Los dos programas de consola no comparten información.

La siguiente etapa del proyecto consiste en comenzar la transición desde estructuras basadas en texto hacia programación orientada a objetos.

---

# QA y defectos corregidos

El repositorio contiene **11 casos de prueba funcionales documentados**.

Durante las pruebas se identificaron dos defectos:

### BUG-01 / INC-001 — Precio negativo

El sistema mostraba el error correspondiente pero continuaba el registro de la habitación.

La corrección agregó la finalización del método mediante `return`.

**Estado:** corregido y retesteado.

### BUG-02 / INC-002 — Habitación duplicada

El sistema permitía registrar más de una habitación utilizando el mismo número.

Se agregó una validación para detectar números ya registrados.

**Estado:** corregido y retesteado.

Documentación:

```text
docs/CASOS_DE_PRUEBA.md
docs/CHECKLIST_PRUEBAS.md
docs/ERRORES_Y_PENDIENTES.md
docs/INC-001_PRECIO_NEGATIVO.md
docs/INC-002_HABITACION_DUPLICADA.md
docs/PLANTILLA_INCIDENCIA.md
```

---

# Base de datos

Existe un modelo SQL inicial en:

```text
database/modelo_inicial.sql
```

Actualmente define:

- `Habitaciones`
- `Clientes`
- `Pagos`
- `Cochera`
- `Gastos`

El modelo utiliza conceptos como:

```text
PRIMARY KEY
FOREIGN KEY
IDENTITY
UNIQUE
NOT NULL
CHECK
DECIMAL
NVARCHAR
DATETIME
```

También existe práctica SQL en:

```text
docs/SQL_PRACTICO.md
```

## Estado

El modelo SQL está diseñado, pero todavía **no está conectado a las aplicaciones C#**.

No existe todavía Entity Framework Core ni persistencia real.

---

# API REST

Existe un diseño conceptual en:

```text
docs/API_FUTURA.md
```

Se han propuesto endpoints como:

```http
GET /api/habitaciones
POST /api/habitaciones
PUT /api/habitaciones/{id}
DELETE /api/habitaciones/{id}
```

También existen propuestas para clientes, pagos, cochera y reportes.

## Estado

La API REST todavía **no está implementada**.

Actualmente no existe un proyecto ASP.NET Core Web API.

---

# Postman

Existe documentación conceptual en:

```text
docs/POSTMAN_CONCEPTUAL.md
```

Se han trabajado conceptos de:

- GET.
- POST.
- JSON.
- Body.
- HTTP.
- 200 OK.
- 201 Created.
- 400 Bad Request.

## Estado

Las pruebas son conceptuales porque todavía no existe una API funcional que pueda ejecutarse desde Postman.

---

# Estructura actual

```text
sistema-hospedaje/
│
├── IngresoDiarioHospedaje/
│   ├── Program.cs
│   └── IngresoDiarioHospedaje.csproj
│
├── RegistroHabitacion/
│   ├── Program.cs
│   └── RegistroHabitacion.csproj
│
├── database/
│   └── modelo_inicial.sql
│
├── docs/
│   ├── API_FUTURA.md
│   ├── CASOS_DE_PRUEBA.md
│   ├── CHECKLIST_PRUEBAS.md
│   ├── ERRORES_Y_PENDIENTES.md
│   ├── INC-001_PRECIO_NEGATIVO.md
│   ├── INC-002_HABITACION_DUPLICADA.md
│   ├── PLANTILLA_INCIDENCIA.md
│   ├── POSTMAN_CONCEPTUAL.md
│   ├── REQUISITOS_VACANTES.md
│   └── SQL_PRACTICO.md
│
├── .gitignore
└── README.md
```

---

# Cómo compilar

Los dos proyectos utilizan:

```xml
<TargetFramework>net10.0</TargetFramework>
```

Por ello se necesita un SDK compatible con .NET 10.

Desde la raíz del repositorio:

```bash
dotnet build ./IngresoDiarioHospedaje/IngresoDiarioHospedaje.csproj
dotnet build ./RegistroHabitacion/RegistroHabitacion.csproj
```

Actualmente no existe una solución `.sln` en la raíz.

---

# Cómo ejecutar

## Ingreso diario

```bash
dotnet run --project ./IngresoDiarioHospedaje/IngresoDiarioHospedaje.csproj
```

## Registro de habitaciones

```bash
dotnet run --project ./RegistroHabitacion/RegistroHabitacion.csproj
```

---

# Deuda técnica identificada

La auditoría del 25/09/2026 identificó como principales pendientes:

| Prioridad | Deuda |
|---|---|
| Alta | Reemplazar `List<string>` por modelos de dominio |
| Alta | Crear la clase `Habitacion` |
| Alta | Separar reglas de negocio de la interacción por consola |
| Alta | Fortalecer validaciones de `IngresoDiarioHospedaje` |
| Alta | Ejecutar y conectar una base de datos real |
| Alta | Implementar persistencia |
| Media | Crear solución `.sln` |
| Media | Crear pruebas automatizadas |
| Media | Implementar Entity Framework Core |
| Media | Implementar ASP.NET Core Web API |
| Media | Ejecutar pruebas reales con Postman |
| Media | Agregar manejo estructurado de errores |
| Media | Incorporar `async/await` cuando exista acceso a datos |
| Baja | Agregar integración continua con GitHub Actions |

---

# Roadmap backend

La transición se realizará progresivamente.

### Etapa 1 — Programación orientada a objetos

Crear modelos de dominio comenzando con:

```text
Habitacion
```

y posteriormente:

```text
Cliente
Pago
Cochera
Gasto
```

El primer refactor será sustituir:

```csharp
List<string> habitaciones
```

por:

```csharp
List<Habitacion> habitaciones
```

sin cambiar todavía el comportamiento funcional existente.

### Etapa 2 — Separación de responsabilidades

Separar progresivamente:

```text
Models
Services
Program.cs
```

### Etapa 3 — Base de datos real

Ejecutar el modelo SQL y practicar operaciones reales:

```text
SELECT
INSERT
UPDATE
DELETE
JOIN
COUNT
SUM
GROUP BY
```

### Etapa 4 — Entity Framework Core

Conectar C# con SQL mediante:

```text
DbContext
DbSet
LINQ
Migrations
SaveChangesAsync
```

### Etapa 5 — ASP.NET Core Web API

Implementar los endpoints actualmente documentados de forma conceptual.

### Etapa 6 — Pruebas reales

Ejecutar la API mediante Postman y posteriormente incorporar pruebas automatizadas.

---

# Próxima implementación

El siguiente cambio de código será pequeño y controlado:

```text
RegistroHabitacion/
│
├── Models/
│   └── Habitacion.cs
│
├── Program.cs
└── RegistroHabitacion.csproj
```

Objetivo:

Convertir el almacenamiento actual de habitaciones desde texto hacia objetos sin perder las validaciones y comportamientos que ya funcionan.

Antes y después del refactor se deberán repetir los casos funcionales existentes para comprobar que no se introdujeron regresiones.

---

# Tecnologías actuales

```text
C#
.NET 10
Git
GitHub
SQL (diseño y práctica)
Markdown
QA manual
```

# Tecnologías siguientes

```text
Programación orientada a objetos
SQL Server
Entity Framework Core
ASP.NET Core
REST
JSON
Postman
Pruebas automatizadas
```

---

# Autor

**Marco Antonio Machaca**

Proyecto desarrollado como parte de un proceso progresivo de aprendizaje y construcción de portafolio en Ingeniería de Sistemas.