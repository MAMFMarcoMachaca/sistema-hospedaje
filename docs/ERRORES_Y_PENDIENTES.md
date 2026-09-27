# Errores y pendientes — Sistema Hospedaje

## Revisión del 06/08/2026

### Entorno utilizado

- Sistema operativo: Windows.
- Lenguaje: C#.
- Plataforma: .NET.
- Editor: Visual Studio Code.
- Control de versiones: Git y GitHub.

## Proyectos revisados

### IngresoDiarioHospedaje

- Estado de compilación: correcto.
- Estado de ejecución: correcto.
- Objetivo: calcular ingresos, gastos y utilidad diaria.
- Resultado de compilación: sin errores.
- Resultado de ejecución: funcionamiento correcto.

### RegistroHabitacion

- Estado de compilación: correcto.
- Estado de ejecución: correcto.
- Objetivo: registrar habitaciones e ingresos mediante un menú.
- Resultado de compilación: sin errores.
- Resultado de ejecución: funcionamiento correcto.

## Errores encontrados

Registrar aquí cada error utilizando esta estructura:

### Error 1 — Ruta incorrecta al ejecutar el proyecto

**Proyecto:** RegistroHabitacion

**Comandos que produjeron el error:**

```text
dotnet run --project \RegistroHabitacion\RegistroHabitacion.csproj
dotnet run --project .RegistroHabitacion\RegistroHabitacion.csproj
```

**Mensaje recibido:**

```text
La ruta de acceso al archivo proporcionada no existe.
```

**Causa identificada:**

La ruta relativa hacia el archivo `.csproj` estaba escrita incorrectamente.

**Solución aplicada:**

Se utilizó la ruta relativa correcta:

```text
dotnet run --project .\RegistroHabitacion\RegistroHabitacion.csproj
```

**Resultado:**

El proyecto se ejecutó correctamente.

**Estado:** Solucionado.
---

# Errores y pendientes — Sistema Hospedaje

## Revisión del 06/08/2026

### Entorno utilizado

- Sistema operativo: Windows.
- Lenguaje: C#.
- Plataforma: .NET.
- Editor: Visual Studio Code.
- Control de versiones: Git y GitHub.

## Proyectos revisados

### IngresoDiarioHospedaje

- Estado de compilación: correcto.
- Estado de ejecución: correcto.
- Objetivo: calcular ingresos, gastos y utilidad diaria.
- Resultado de compilación: sin errores.
- Resultado de ejecución: funcionamiento correcto.

### RegistroHabitacion

- Estado de compilación: correcto.
- Estado de ejecución: correcto.
- Objetivo: registrar habitaciones e ingresos mediante un menú.
- Resultado de compilación: sin errores.
- Resultado de ejecución: funcionamiento correcto.

## Errores encontrados

### Error 1 — Ruta incorrecta al ejecutar el proyecto

**Proyecto:** RegistroHabitacion

**Comandos que produjeron el error:**

```text
dotnet run --project \RegistroHabitacion\RegistroHabitacion.csproj
dotnet run --project .RegistroHabitacion\RegistroHabitacion.csproj
```

**Mensaje recibido:**

```text
La ruta de acceso al archivo proporcionada no existe.
```

**Causa identificada:**

La ruta relativa hacia el archivo `.csproj` estaba escrita incorrectamente.

**Solución aplicada:**

Se utilizó la ruta relativa correcta:

```text
dotnet run --project .\RegistroHabitacion\RegistroHabitacion.csproj
```

**Resultado:**

El proyecto se ejecutó correctamente.

**Estado:** Solucionado.

---

# Auditoría técnica — 26/09/2026

## Objetivo

Comprobar nuevamente el estado funcional de los dos proyectos de consola antes de iniciar la transición del proyecto hacia programación orientada a objetos y backend .NET.

La auditoría permitió verificar el funcionamiento actual, repetir validaciones importantes, confirmar correcciones anteriores e identificar las principales deudas técnicas que todavía existen.

---

## IngresoDiarioHospedaje

**Compilación y ejecución:** APROBADA con entradas válidas.

Se ejecutó el proyecto mediante:

```text
dotnet run --project .\IngresoDiarioHospedaje\IngresoDiarioHospedaje.csproj
```

### Prueba con datos válidos

Datos utilizados:

- Habitaciones simples vendidas: 2.
- Precio por habitación simple: S/ 30.
- Habitaciones dobles vendidas: 1.
- Precio por habitación doble: S/ 50.
- Cocheras utilizadas: 3.
- Precio por cochera: S/ 5.
- Gastos del día: S/ 20.

Resultado obtenido:

- Ingreso por habitaciones: S/ 110.00.
- Ingreso por cochera: S/ 15.00.
- Ingreso total del día: S/ 125.00.
- Gastos: S/ 20.00.
- Utilidad estimada: S/ 105.00.

**Resultado:** APROBADO.

Los cálculos obtenidos coinciden con los resultados esperados.

### Prueba con entrada no numérica

Se volvió a ejecutar el proyecto y se ingresó:

```text
hola
```

en el campo correspondiente a la cantidad de habitaciones simples.

El programa terminó mostrando:

```text
Unhandled exception. System.FormatException:
The input string 'hola' was not in a correct format.
```

La excepción se produjo en `Program.cs`, línea 7, al intentar ejecutar:

```csharp
int.Parse(Console.ReadLine()!)
```

**Resultado:** DEUDA TÉCNICA CONFIRMADA.

El módulo funciona correctamente cuando recibe datos válidos, pero todavía no controla adecuadamente entradas con formato incorrecto.

Actualmente utiliza `int.Parse()` y `decimal.Parse()`, por lo que una entrada no numérica puede producir una excepción y finalizar el programa.

---

## RegistroHabitacion

**Compilación y ejecución:** APROBADA.

Se ejecutó mediante:

```text
dotnet run --project .\RegistroHabitacion\RegistroHabitacion.csproj
```

### Validación del menú principal

Se ingresó:

```text
hola
```

El programa mostró:

```text
Error: debe ingresar una opción numérica.
```

Después volvió correctamente al menú principal.

**Resultado:** APROBADO.

También se ingresó una opción fuera del rango permitido:

```text
5
```

El programa mostró:

```text
Error: seleccione una opción entre 1 y 4.
```

**Resultado:** APROBADO.

Durante la ejecución también se dejó una entrada vacía en el menú principal.

El programa la rechazó mediante la validación existente y volvió a mostrar el menú.

**Resultado:** APROBADO.

---

## Registro de habitación válida

Se seleccionó la opción:

```text
1
```

Datos utilizados:

- Número de habitación: 101.
- Tipo: 1 - Simple.
- Precio por noche: S/ 40.
- Estado: 1 - Disponible.

Resultado obtenido:

```text
Habitación 101 | Tipo: Simple | Precio: S/ 40.00 | Estado: Disponible
```

El sistema también mostró:

```text
Total registrado: 1
```

**Resultado:** APROBADO.

---

## Retest BUG-02 — Habitación duplicada

Después de registrar correctamente la habitación `101`, se intentó registrar nuevamente otra habitación utilizando el mismo número.

El sistema mostró:

```text
Error: ya existe una habitación registrada con el número 101.
```

El segundo registro fue cancelado inmediatamente.

El sistema no solicitó nuevamente:

- Tipo.
- Precio.
- Estado.

**Resultado:** APROBADO.

**Estado de BUG-02:** CORREGIDO Y RETESTEADO.

La validación continúa funcionando correctamente.

---

## Retest BUG-01 — Precio negativo

Se intentó registrar una nueva habitación utilizando los siguientes datos:

- Número: 102.
- Tipo: 3 - Matrimonial.
- Precio: S/ -35.

El sistema mostró:

```text
Error: el precio debe ser mayor que cero.
```

Después del mensaje, el registro terminó inmediatamente y el sistema volvió al menú principal.

No se solicitó el estado de la habitación y la habitación no fue registrada.

**Resultado:** APROBADO.

**Estado de BUG-01:** CORREGIDO Y RETESTEADO.

La corrección mediante `return` continúa funcionando correctamente.

---

## Registro de ingreso válido

Se seleccionó la opción:

```text
2
```

Datos utilizados:

- Concepto: Habitacion 101.
- Monto: S/ 40.

Resultado obtenido:

```text
Habitacion 101 | S/ 40.00
Total de ingresos registrados: 1
Monto acumulado: S/ 40.00
```

**Resultado:** APROBADO.

---

## Validación de concepto vacío

Se seleccionó nuevamente el registro de ingreso y se dejó vacío el concepto.

El programa mostró:

```text
Error: el concepto no puede estar vacío.
```

El ingreso no fue registrado.

**Resultado:** APROBADO.

---

## Validación de monto negativo

Se intentó registrar:

- Concepto: Cochera.
- Monto: S/ -5.

El programa mostró:

```text
Error: ingrese un monto mayor que cero.
```

El ingreso no fue registrado y el total acumulado no fue modificado.

**Resultado:** APROBADO.

---

## Verificación del resumen

Se seleccionó la opción:

```text
3
```

El programa mostró correctamente:

```text
Habitaciones registradas: 1
- Habitación 101 | Tipo: Simple | Precio: S/ 40.00 | Estado: Disponible

Ingresos registrados: 1
- Habitacion 101 | S/ 40.00

Total de ingresos: S/ 40.00
```

**Resultado:** APROBADO.

---

## Finalización del programa

Se seleccionó:

```text
4
```

El programa mostró:

```text
Programa finalizado.
```

y terminó correctamente.

**Resultado:** APROBADO.

---

# Resumen de la auditoría del 26/09/2026

## IngresoDiarioHospedaje

- Ejecución con datos válidos: APROBADA.
- Cálculo de ingresos por habitaciones: APROBADO.
- Cálculo de cochera: APROBADO.
- Cálculo de ingreso total: APROBADO.
- Cálculo de gastos: APROBADO.
- Cálculo de utilidad: APROBADO.
- Entrada no numérica: FALLA mediante `System.FormatException`.
- Deuda técnica relacionada con `Parse()`: CONFIRMADA.

## RegistroHabitacion

- Ejecución general: APROBADA.
- Validación de texto en menú: APROBADA.
- Validación de entrada vacía en menú: APROBADA.
- Validación de opción fuera de rango: APROBADA.
- Registro de habitación válida: APROBADO.
- Prevención de habitación duplicada: APROBADA.
- Validación de precio negativo: APROBADA.
- Registro de ingreso válido: APROBADO.
- Validación de concepto vacío: APROBADA.
- Validación de monto negativo: APROBADA.
- Resumen de habitaciones: APROBADO.
- Resumen de ingresos: APROBADO.
- Total acumulado: APROBADO.
- Finalización del programa: APROBADA.
- BUG-01: CORREGIDO Y RETESTEADO.
- BUG-02: CORREGIDO Y RETESTEADO.

---

# Estado funcional actual

Los dos proyectos de consola continúan funcionando dentro del alcance para el que fueron desarrollados.

`IngresoDiarioHospedaje` permite calcular correctamente:

- Ingreso por habitaciones.
- Ingreso por cochera.
- Ingreso total.
- Gastos.
- Utilidad estimada.

Sin embargo, todavía utiliza conversiones mediante `Parse()`, por lo que puede finalizar mediante una excepción cuando el usuario introduce información con un formato incorrecto.

`RegistroHabitacion` presenta validaciones más robustas mediante `TryParse()` y mantiene correctamente las soluciones implementadas anteriormente para los defectos relacionados con precios negativos y habitaciones duplicadas.

Actualmente permite:

- Registrar habitaciones.
- Registrar ingresos.
- Validar diferentes tipos de entradas incorrectas.
- Evitar números de habitación duplicados.
- Mostrar un resumen.
- Mantener un total acumulado de ingresos durante la ejecución.

---

# Deudas técnicas confirmadas

Después de la auditoría se mantienen las siguientes deudas técnicas:

- Los datos se almacenan únicamente en memoria.
- Los datos desaparecen al cerrar los programas.
- Las habitaciones todavía se representan mediante `List<string>`.
- Los ingresos todavía se representan mediante `List<string>`.
- La información de una habitación se almacena como texto en lugar de utilizar un objeto.
- La detección de habitaciones duplicadas depende actualmente de comparar texto mediante `StartsWith()`.
- `IngresoDiarioHospedaje` utiliza `int.Parse()` y `decimal.Parse()` sin controlar adecuadamente entradas inválidas.
- Parte de la lógica del sistema continúa concentrada dentro de `Program.cs`.
- Todavía no existe una estructura basada en modelos de dominio.
- No existe persistencia real.
- El modelo SQL todavía no está conectado con las aplicaciones C#.
- No se utiliza Entity Framework Core.
- No existe un `DbContext`.
- No existen migraciones de Entity Framework Core.
- No existe una aplicación ASP.NET Core Web API.
- Los endpoints REST documentados todavía son conceptuales.
- Las pruebas de Postman todavía son conceptuales.
- No existen pruebas automatizadas.
- No existe todavía una solución `.sln` en la raíz del repositorio.
- No existe integración continua mediante GitHub Actions.

---

# Elementos que sí existen actualmente

El proyecto cuenta actualmente con:

- Dos aplicaciones de consola desarrolladas en C#.
- Uso de .NET 10.
- Menú interactivo.
- Uso de `while`.
- Uso de `switch`.
- Uso de `if`.
- Uso de `TryParse()`.
- Uso de `List<string>`.
- Uso de `.Add()`.
- Uso de `.Count`.
- Uso de `foreach`.
- Métodos separados.
- Parámetros.
- Valores de retorno.
- Validaciones de entrada.
- Registro temporal de habitaciones.
- Registro temporal de ingresos.
- Cálculo de ingresos y utilidad.
- QA manual.
- Casos de prueba documentados.
- Dos defectos documentados, corregidos y retesteados.
- Modelo SQL inicial.
- Práctica SQL.
- Diseño conceptual de una API REST.
- Diseño conceptual de pruebas mediante Postman.
- Uso de Git.
- Uso de ramas.
- Commits.
- Push.
- Pull Requests.
- Merge hacia `main`.

---

# Estado de SQL

Actualmente existe un modelo SQL inicial que incluye las tablas:

- Habitaciones.
- Clientes.
- Pagos.
- Cochera.
- Gastos.

Se han trabajado conceptos como:

- `PRIMARY KEY`.
- `FOREIGN KEY`.
- `IDENTITY`.
- `NOT NULL`.
- `NULL`.
- `UNIQUE`.
- `CHECK`.
- `INT`.
- `NVARCHAR`.
- `DECIMAL`.
- `DATETIME`.

Sin embargo, el modelo SQL todavía no está conectado con el código C#.

Actualmente:

```text
C# -> datos en memoria
```

Todavía no existe:

```text
C# -> base de datos SQL
```

---

# Estado de la API REST

Existe documentación conceptual de una futura API REST con endpoints como:

```text
GET /api/habitaciones
POST /api/habitaciones
PUT /api/habitaciones/{id}
DELETE /api/habitaciones/{id}
```

Sin embargo, estos endpoints todavía no están implementados.

Actualmente no existe:

- Proyecto ASP.NET Core Web API.
- Controllers.
- Endpoints ejecutables.
- Servidor HTTP del proyecto.
- Comunicación real mediante JSON.
- Pruebas reales mediante Postman.

Por lo tanto, la API REST continúa en etapa conceptual.

---

# Conclusión de la auditoría

La revisión del 26/09/2026 confirma que el proyecto constituye una base funcional de consola sobre la cual se puede continuar construyendo el futuro backend.

No se encontraron regresiones en las validaciones críticas del módulo `RegistroHabitacion`.

Los defectos relacionados con:

- Precio negativo.
- Número de habitación duplicado.

continúan corregidos después de realizar nuevamente las pruebas correspondientes.

También se confirmó una deuda técnica en `IngresoDiarioHospedaje`: el uso de `Parse()` provoca una excepción cuando se introduce texto en un campo numérico.

El proyecto todavía no debe considerarse una aplicación backend completa.

Actualmente representa una etapa previa formada por:

```text
C# de consola
+
validaciones
+
listas
+
métodos
+
QA
+
Git/GitHub
+
modelo SQL
+
diseño conceptual de API
```

La siguiente etapa consistirá en evolucionar progresivamente esta base sin eliminar el trabajo anterior.

---

# Próximo paso

Iniciar la transición hacia programación orientada a objetos manteniendo inicialmente el comportamiento funcional existente.

El primer refactor será representar una habitación mediante una clase:

```text
Habitacion
```

y sustituir progresivamente:

```text
List<string>
```

por:

```text
List<Habitacion>
```

La información dejará de almacenarse como un único texto y pasará a representarse mediante propiedades como:

```text
Numero
Tipo
PrecioNoche
Estado
```

Después del refactor se repetirán las pruebas funcionales para comprobar que los cambios no hayan introducido regresiones.

Posteriormente se continuará de manera progresiva con:

```text
Programación orientada a objetos
↓
Separación de responsabilidades
↓
Modelos y servicios
↓
SQL real
↓
Entity Framework Core
↓
ASP.NET Core
↓
API REST funcional
↓
Pruebas reales con Postman
↓
Pruebas automatizadas
```

**Estado de la auditoría del 26/09/2026:** COMPLETADA.