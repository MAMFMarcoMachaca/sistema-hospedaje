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