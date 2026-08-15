# Sistema de Gestión para Hospedaje

Proyecto educativo desarrollado en C# y .NET para construir progresivamente un sistema de gestión aplicado a un hospedaje real.

El objetivo es practicar desarrollo backend, bases de datos, QA, soporte de aplicaciones, análisis funcional, Git/GitHub y diseño de APIs utilizando un mismo proyecto como portafolio.

---

## Problema que busca resolver

Muchas operaciones de un hospedaje pueden terminar registrándose en cuadernos, hojas separadas o mensajes, dificultando el control de:

- Habitaciones.
- Clientes.
- Ingresos.
- Pagos.
- Cochera.
- Gastos.
- Ocupación.
- Historial de operaciones.

El proyecto busca centralizar progresivamente esta información en un sistema organizado.

---

# Estado actual

Actualmente el repositorio contiene:

- Dos aplicaciones de consola desarrolladas en C#.
- Registro temporal de habitaciones.
- Registro temporal de ingresos.
- Validaciones de datos mediante `TryParse()`.
- Métodos separados para organizar la lógica.
- Cálculo de ingresos y utilidad diaria.
- Modelo SQL inicial.
- Documentación de QA manual.
- 10 casos de prueba funcionales.
- Registro y seguimiento de una incidencia real.
- Plantilla de incidencias para soporte de aplicaciones.
- Diseño conceptual de una futura API REST.
- Pruebas conceptuales para Postman.

> La base de datos y la API todavía no están conectadas al programa. Actualmente forman parte del diseño y preparación para las siguientes etapas.

---

# Funcionalidad implementada

## 1. Ingreso Diario del Hospedaje

Aplicación de consola que permite registrar:

- Cantidad de habitaciones simples.
- Precio de habitaciones simples.
- Cantidad de habitaciones dobles.
- Precio de habitaciones dobles.
- Cantidad de cocheras.
- Precio de cochera.
- Gastos diarios.

El programa calcula:

- Ingreso por habitaciones.
- Ingreso por cochera.
- Ingreso total.
- Gastos.
- Utilidad estimada.

---

## 2. Registro de Habitaciones e Ingresos

Aplicación de consola con menú principal:

1. Registrar habitación.
2. Registrar ingreso.
3. Ver resumen.
4. Salir.

### Registro de habitación

Permite ingresar:

- Número.
- Tipo.
- Precio por noche.
- Estado.

Tipos disponibles:

- Simple.
- Doble.
- Matrimonial.
- Familiar.
- Triple.

Estados:

- Disponible.
- Ocupada.

### Registro de ingresos

Permite registrar:

- Concepto.
- Monto.

El sistema mantiene un monto acumulado durante la ejecución.

---

# Validaciones implementadas

Actualmente se validan, entre otros casos:

- Opciones no numéricas.
- Opciones fuera del rango permitido.
- Números de habitación menores o iguales a cero.
- Precios no numéricos.
- Precios menores o iguales a cero.
- Conceptos de ingreso vacíos.
- Montos de ingreso inválidos.

Se utiliza principalmente:

```csharp
int.TryParse(...)
decimal.TryParse(...)
```

para evitar que entradas incorrectas interrumpan inesperadamente el programa.

---

# Organización del código

Parte de la lógica del módulo `RegistroHabitacion` fue separada en métodos:

```text
RegistrarHabitacion()
RegistrarIngreso()
MostrarResumen()
```

Esto permite mantener el programa principal más organizado y facilita futuras mejoras.

---

# QA y pruebas

El proyecto incluye documentación de pruebas funcionales manuales.

Se diseñaron y ejecutaron:

- **10 casos de prueba.**
- **9 casos aprobados inicialmente.**
- **1 caso fallido inicialmente.**
- **1 defecto encontrado.**
- **1 defecto corregido.**
- **1 retest aprobado.**

Durante las pruebas se encontró que el sistema podía continuar el registro de una habitación después de detectar un precio negativo.

El defecto fue documentado, corregido y verificado nuevamente mediante un retest.

Documentación relacionada:

```text
docs/CASOS_DE_PRUEBA.md
docs/CHECKLIST_PRUEBAS.md
docs/ERRORES_Y_PENDIENTES.md
```

---

# Soporte de aplicaciones

También se documentó un flujo básico de gestión de incidencias.

El repositorio incluye:

```text
docs/PLANTILLA_INCIDENCIA.md
docs/INC-001_PRECIO_NEGATIVO.md
```

La incidencia `INC-001` documenta:

- Problema reportado.
- Comportamiento esperado.
- Comportamiento obtenido.
- Pasos para reproducir.
- Impacto.
- Análisis.
- Solución aplicada.
- Retest.
- Cierre.

---

# Modelo SQL inicial

Se creó un modelo conceptual inicial en:

```text
database/modelo_inicial.sql
```

Incluye las tablas:

- `Habitaciones`
- `Clientes`
- `Pagos`
- `Cochera`
- `Gastos`

Se practicaron conceptos como:

- `PRIMARY KEY`
- `FOREIGN KEY`
- `IDENTITY`
- `NOT NULL`
- `NULL`
- `UNIQUE`
- `CHECK`
- `INT`
- `NVARCHAR`
- `DECIMAL`
- `DATETIME`

> Actualmente este modelo todavía no está conectado a las aplicaciones de consola.

---

# API REST futura

Se diseñaron conceptualmente endpoints para una futura API.

Ejemplos:

```http
GET /api/habitaciones
POST /api/habitaciones
PUT /api/habitaciones/{id}
DELETE /api/habitaciones/{id}
```

También se propusieron endpoints para:

- Clientes.
- Pagos.
- Cochera.
- Reportes.

La documentación se encuentra en:

```text
docs/API_FUTURA.md
```

La API todavía no está implementada.

---

# Postman conceptual

Se prepararon casos conceptuales para futuras pruebas de la API mediante Postman.

Ejemplos trabajados:

```text
GET  /api/habitaciones
→ 200 OK
```

```text
POST /api/habitaciones
→ 201 Created
```

```text
POST /api/habitaciones
precio negativo
→ 400 Bad Request
```

También se introdujeron conceptos básicos de:

- HTTP.
- GET.
- POST.
- Body.
- JSON.
- Códigos de estado HTTP.

Documentación:

```text
docs/POSTMAN_CONCEPTUAL.md
```

---

# Tecnologías utilizadas actualmente

- C#
- .NET
- Visual Studio Code
- Git
- GitHub
- Markdown

---

# Tecnologías y conceptos en preparación

- SQL.
- Bases de datos relacionales.
- API REST.
- HTTP.
- JSON.
- Postman.
- ASP.NET Core.

SQL, API REST y Postman se encuentran actualmente en una etapa conceptual o de diseño y todavía no forman parte de una integración funcional completa.

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
│   ├── PLANTILLA_INCIDENCIA.md
│   └── POSTMAN_CONCEPTUAL.md
│
├── .gitignore
└── README.md
```

---

# Ejecución

## Ingreso Diario

Desde la raíz del repositorio:

```bash
dotnet run --project .\IngresoDiarioHospedaje\IngresoDiarioHospedaje.csproj
```

## Registro de Habitaciones

```bash
dotnet run --project .\RegistroHabitacion\RegistroHabitacion.csproj
```

Para comprobar la compilación:

```bash
dotnet build
```

---

# Conceptos practicados

## C#

- Variables.
- `int`.
- `decimal`.
- Strings.
- Condicionales.
- `if` / `else`.
- `switch`.
- `while`.
- `List<string>`.
- `Add()`.
- `Count`.
- `foreach`.
- Métodos.
- Parámetros.
- `return`.
- `TryParse()`.
- Interpolación de cadenas.

## Git y GitHub

- Repositorios.
- Branches.
- `git status`.
- `git add`.
- `git commit`.
- `git push`.
- `git pull`.
- Pull Requests.
- Merge.

## QA

- Casos de prueba.
- Resultado esperado.
- Resultado obtenido.
- Pruebas positivas.
- Pruebas negativas.
- Defectos.
- Reproducibilidad.
- Retest.

## Soporte de aplicaciones

- Incidencias.
- Severidad.
- Prioridad.
- Impacto.
- Análisis inicial.
- Workaround.
- Escalamiento.
- Resolución.
- Cierre.

---

# Etapas del proyecto

1. ✅ Fundamentos de C#.
2. ✅ Cálculo de ingresos diarios.
3. ✅ Menú de consola.
4. ✅ Registro temporal de habitaciones.
5. ✅ Registro temporal de ingresos.
6. ✅ Mejora de validaciones.
7. ✅ Separación básica de lógica mediante métodos.
8. ✅ QA manual y casos de prueba.
9. ✅ Documentación de incidencias.
10. ✅ Modelo SQL inicial.
11. ✅ Diseño conceptual de API REST y Postman.
12. ⏳ Registro de clientes.
13. ⏳ Persistencia real en base de datos.
14. ⏳ ASP.NET Core.
15. ⏳ API REST funcional.
16. ⏳ Pruebas reales con Postman.
17. ⏳ Reportes.
18. ⏳ Interfaz de usuario.

---

# Sprint 06–14 de agosto de 2026

## Trabajo realizado

- [x] Revisar y ejecutar los proyectos existentes.
- [x] Compilar ambos proyectos.
- [x] Probar entradas válidas e inválidas.
- [x] Mejorar validaciones.
- [x] Separar lógica en métodos.
- [x] Crear checklist de pruebas.
- [x] Diseñar y ejecutar 10 casos de prueba.
- [x] Detectar y documentar un defecto.
- [x] Corregir el defecto.
- [x] Realizar un retest.
- [x] Crear plantilla de incidencia.
- [x] Documentar una incidencia real.
- [x] Crear modelo SQL inicial.
- [x] Diseñar endpoints futuros.
- [x] Documentar pruebas conceptuales de Postman.

## Resultado del sprint

El proyecto pasó de contener únicamente ejercicios de consola a incorporar prácticas básicas de desarrollo, QA, soporte de aplicaciones, diseño de base de datos y arquitectura backend.

La siguiente etapa continuará desarrollando funcionalidades progresivamente sin perder el enfoque en comprensión, pruebas y documentación.

---

# Limitaciones actuales

- Los datos de las aplicaciones de consola son temporales.
- Los datos desaparecen al cerrar el programa.
- La base de datos todavía no está conectada al código C#.
- La API REST todavía no está implementada.
- Los casos de Postman son conceptuales.
- Todavía no existe una interfaz gráfica.

---

# Autor

**Marco Antonio Machaca**

Proyecto desarrollado como parte de un proceso progresivo de aprendizaje y construcción de portafolio en Ingeniería de Sistemas.