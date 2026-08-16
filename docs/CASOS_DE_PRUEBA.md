# Casos de prueba — Sistema Hospedaje

## Objetivo

Validar manualmente las principales funciones y validaciones del módulo `RegistroHabitacion` del sistema de hospedaje.

## Entorno de prueba

* Aplicación: Sistema Hospedaje.
* Módulo: `RegistroHabitacion`.
* Tipo de prueba: QA manual / pruebas funcionales.
* Plataforma: .NET.
* Ejecución: consola.

---

## CP-01 — Mostrar resumen sin registros

**Funcionalidad:** Resumen básico.

**Precondición:** Iniciar el programa sin registrar habitaciones ni ingresos.

**Datos de prueba:**

`Opción del menú: 3`

**Resultado esperado:**

* Mostrar `Habitaciones registradas: 0`.
* Indicar que no existen habitaciones registradas.
* Mostrar `Ingresos registrados: 0`.
* Indicar que no existen ingresos registrados.
* Mostrar `Total de ingresos: S/ 0.00`.

**Resultado obtenido:**

El sistema mostró correctamente:

* `Habitaciones registradas: 0`.
* `No hay habitaciones registradas.`
* `Ingresos registrados: 0`.
* `No hay ingresos registrados.`
* `Total de ingresos: S/ 0.00`.

**Estado:** APROBADO ✅

---

## CP-02 — Ingresar texto en el menú principal

**Funcionalidad:** Validación del menú.

**Datos de prueba:**

`Opción del menú: hola`

**Resultado esperado:**

El sistema debe rechazar la entrada e indicar que se debe ingresar una opción numérica.

**Resultado obtenido:**

El sistema mostró:

`Error: debe ingresar una opción numérica.`

Después volvió al menú principal.

**Estado:** APROBADO ✅

---

## CP-03 — Ingresar una opción fuera del rango

**Funcionalidad:** Validación del menú.

**Datos de prueba:**

`Opción del menú: 5`

**Resultado esperado:**

El sistema debe rechazar la opción porque solamente existen las opciones del `1` al `4`.

**Resultado obtenido:**

El sistema mostró:

`Error: seleccione una opción entre 1 y 4.`

Después volvió al menú principal.

**Estado:** APROBADO ✅

---

## CP-04 — Registrar una habitación correctamente

**Funcionalidad:** Registro de habitación.

**Datos de prueba:**

* Número de habitación: `201`.
* Tipo: `3 - Matrimonial`.
* Precio por noche: `35`.
* Estado: `2 - Ocupada`.

**Resultado esperado:**

Registrar correctamente la habitación y aumentar el contador de habitaciones.

**Resultado obtenido:**

El sistema registró:

`Habitación 201 | Tipo: Matrimonial | Precio: S/ 35.00 | Estado: Ocupada`

También mostró:

`Total registrado: 1`

**Estado:** APROBADO ✅

---

## CP-05 — Número de habitación negativo

**Funcionalidad:** Validación del número de habitación.

**Datos de prueba:**

`Número de habitación: -2`

**Resultado esperado:**

El sistema debe rechazar números menores o iguales a cero y no registrar la habitación.

**Resultado obtenido:**

El sistema mostró:

`Error: el número de habitación debe ser mayor que cero.`

La habitación no fue registrada.

**Estado:** APROBADO ✅

---

## CP-06 — Tipo de habitación fuera del rango

**Funcionalidad:** Validación del tipo de habitación.

**Datos de prueba:**

* Número de habitación: `201`.
* Tipo de habitación: `6`.

**Resultado esperado:**

El sistema debe rechazar la selección porque solamente existen opciones entre `1` y `5`.

**Resultado obtenido:**

El sistema mostró:

`Error: seleccione una opción entre 1 y 5.`

La habitación no fue registrada.

**Estado:** APROBADO ✅

---

## CP-07 — Precio de habitación negativo

**Funcionalidad:** Validación del precio por noche.

**Datos de prueba:**

* Número de habitación: `201`.
* Tipo: `3 - Matrimonial`.
* Precio: `-35`.

**Resultado esperado:**

El sistema debe:

1. Mostrar un mensaje indicando que el precio debe ser mayor que cero.
2. Detener el registro de la habitación.
3. Volver al menú principal.
4. No guardar ninguna habitación con precio negativo.

**Resultado obtenido:**

El sistema mostró correctamente:

`Error: el precio debe ser mayor que cero.`

Sin embargo, después continuó con el proceso y solicitó el estado de la habitación.

Finalmente registró:

`Habitación 201 | Tipo: Matrimonial | Precio: S/ -35.00 | Estado: Disponible`

El comportamiento se reprodujo nuevamente ejecutando los mismos datos de prueba.

**Estado:** FALLIDO ❌

**Defecto relacionado:** BUG-01.

---

### Retest

Después de corregir la validación se volvió a ejecutar el caso con un precio de `-35`.

**Resultado obtenido:**

El sistema mostró:

`Error: el precio debe ser mayor que cero.`

El método finalizó el registro y volvió al menú principal sin solicitar el estado ni guardar la habitación.

**Resultado del retest:** APROBADO ✅

**Estado del defecto:** CORREGIDO ✅

## CP-08 — Registrar un ingreso correctamente

**Funcionalidad:** Registro de ingresos.

**Datos de prueba:**

* Concepto: `Habitación 201`.
* Monto: `35`.

**Resultado esperado:**

El sistema debe registrar el ingreso, incrementar el contador y actualizar el monto acumulado.

**Resultado obtenido:**

El sistema mostró:

`Habitación 201 | S/ 35.00`

`Total de ingresos registrados: 1`

`Monto acumulado: S/ 35.00`

**Estado:** APROBADO ✅

---

## CP-09 — Concepto de ingreso vacío

**Funcionalidad:** Validación del concepto de ingreso.

**Datos de prueba:**

* Concepto: vacío.

**Resultado esperado:**

El sistema debe rechazar el registro porque el concepto es obligatorio.

**Resultado obtenido:**

El sistema mostró:

`Error: el concepto no puede estar vacío.`

El ingreso no fue registrado.

**Estado:** APROBADO ✅

---

## CP-10 — Monto de ingreso negativo

**Funcionalidad:** Validación del monto de ingreso.

**Datos de prueba:**

* Concepto: `Habitación 201`.
* Monto: `-10`.

**Resultado esperado:**

El sistema debe rechazar el monto y no modificar el total acumulado.

**Resultado obtenido:**

El sistema mostró:

`Error: ingrese un monto mayor que cero.`

El ingreso no fue registrado.

**Estado:** APROBADO ✅

---


## CP-11 — Intentar registrar una habitación con un número duplicado

**Funcionalidad:** Validación del número de habitación.

**Precondición:**

Debe existir previamente una habitación registrada con el número `101`.

**Datos del primer registro:**

- Número de habitación: `101`.
- Tipo: `1 - Simple`.
- Precio: `40`.
- Estado: `1 - Disponible`.

**Datos del segundo registro:**

- Número de habitación: `101`.
- Tipo: `2 - Doble`.
- Precio: `60`.
- Estado: `2 - Ocupada`.

**Resultado esperado:**

El sistema debe:

1. Detectar que ya existe una habitación con el número `101`.
2. Mostrar un mensaje de error.
3. Cancelar inmediatamente el segundo registro.
4. Mantener una sola habitación registrada con el número `101`.

**Resultado obtenido inicialmente:**

El sistema permitió completar el segundo registro y mostró:

`Habitación 101 | Tipo: Doble | Precio: S/ 60.00 | Estado: Ocupada`

El resumen mostró dos registros con el mismo número:

`Habitaciones registradas: 2`

- `Habitación 101 | Tipo: Simple | Precio: S/ 40.00 | Estado: Disponible`
- `Habitación 101 | Tipo: Doble | Precio: S/ 60.00 | Estado: Ocupada`

**Reproducibilidad:** 1 de 1 intento.

**Estado inicial:** FALLIDO ❌

**Defecto relacionado:** BUG-02.

### Retest

Después de aplicar la corrección, se ejecutaron dos pruebas de números duplicados.

### Primera prueba

1. Se registró correctamente la habitación `101`.
2. Se intentó registrar nuevamente la habitación `101`.

El sistema mostró:

`Error: ya existe una habitación registrada con el número 101.`

### Segunda prueba

1. Se registró correctamente la habitación `102`.
2. Se intentó registrar nuevamente la habitación `102`.

El sistema mostró:

`Error: ya existe una habitación registrada con el número 102.`

En ambos intentos, el sistema canceló inmediatamente el registro y volvió al menú principal sin solicitar tipo, precio ni estado.

El resumen conservó únicamente las dos habitaciones originales:

- Habitación `101`.
- Habitación `102`.

**Reproducibilidad del retest:** 2 de 2 intentos.

**Resultado del retest:** APROBADO ✅

**Estado del defecto:** CORREGIDO ✅

# Defectos encontrados

## BUG-01 — El sistema registra habitaciones con precio negativo

**Módulo:** Registro de habitaciones.

**Severidad estimada:** Media.

**Prioridad recomendada:** Alta.

### Pasos para reproducir

1. Ejecutar `RegistroHabitacion`.
2. Seleccionar `1 - Registrar habitación`.
3. Ingresar `201` como número.
4. Seleccionar `3 - Matrimonial`.
5. Ingresar `-35` como precio.
6. Observar el comportamiento.

### Resultado esperado

El sistema debe mostrar el error de validación y cancelar inmediatamente el registro.

### Resultado real inicial

El sistema mostraba:

`Error: el precio debe ser mayor que cero.`

pero cotinuaba solicitando el estado y permitía guardar la habitación con un precio negativo.


### Reproducibilidad

`2 de 2 intentos`.

El defecto pudo reproducirse de manera consistente.


### Corrección aplicada

Se agregó la finalización del método mediante `return`; después de detectar un precio menor o igual a cero.

### Verificación

Se volvió a ejercutar el caso con un precio de `-35`.

El sistema mostró el mensaje de error y regresó directamente al menú principal sin registrar la habitación.

### Estado

Corregido y verificado mediante retest.

---

## BUG-02 — El sistema permite registrar habitaciones con números duplicados

**Módulo:** Registro de habitaciones.

**Severidad estimada:** Alta.

**Prioridad recomendada:** Alta.

### Regla de negocio afectada

Cada habitación física debe identificarse mediante un número único.

El modelo SQL también establece esta restricción mediante:

`Numero INT NOT NULL UNIQUE`

### Pasos para reproducir

1. Ejecutar `RegistroHabitacion`.
2. Seleccionar `1 - Registrar habitación`.
3. Registrar la habitación `101` como Simple, con precio `40` y estado Disponible.
4. Volver a seleccionar `1 - Registrar habitación`.
5. Registrar nuevamente la habitación `101`, esta vez como Doble, con precio `60` y estado Ocupada.
6. Seleccionar `3 - Ver resumen`.
7. Observar los registros mostrados.

### Resultado esperado

El sistema debe rechazar el segundo registro porque ya existe una habitación con el número `101`.

### Resultado real inicial

El sistema aceptó ambos registros y mostró dos habitaciones con el mismo número, pero con diferente tipo, precio y estado.

### Impacto

El defecto puede provocar:

- Duplicación de habitaciones.
- Inconsistencias en el tipo y precio.
- Estados contradictorios.
- Errores en disponibilidad.
- Posibles problemas de sobreventa.
- Reportes incorrectos.

### Reproducibilidad

`1 de 1 intento`.

### Corrección aplicada

Después de validar que el número ingresado es mayor que cero, se agregó un ciclo `foreach` que revisa las habitaciones almacenadas.

La validación comprueba si alguna habitación comienza con el mismo número:

`Habitación {numeroHabitacion} |`

Si encuentra una coincidencia, muestra un mensaje de error y ejecuta `return` para cancelar el registro.

### Verificación

Se realizaron las siguientes pruebas:

- Se intentó registrar dos veces la habitación `101`.
- Se intentó registrar dos veces la habitación `102`.

El sistema rechazó correctamente ambos registros duplicados.

No solicitó tipo, precio ni estado después de detectar el número repetido.

### Resultado del retest

APROBADO ✅

### Estado

Corregido y verificado mediante retest.

## Resumen de ejecución

- Casos diseñados: **11**.
- Casos ejecutados: **11**.
- Casos aprobados inicialmente: **9**.
- Casos fallidos inicialmente: **2**.
- Defectos encontrados: **2**.
- Defectos corregidos: **2**.
- Retests aprobados: **2**.
- Estado final: **11 casos validados correctamente**.

## Resultado general

Las funciones y validaciones evaluadas funcionan correctamente al finalizar las sesiones de prueba.

Durante las ejecuciones iniciales se identificaron dos defectos:

1. El sistema mostraba un error al ingresar un precio negativo, pero continuaba el proceso y permitía registrar la habitación.
2. El sistema permitía registrar varias habitaciones utilizando el mismo número.

Ambos defectos fueron reproducidos, documentados y corregidos.

Las correcciones se verificaron posteriormente mediante retests satisfactorios.

El sistema actualmente rechaza precios menores o iguales a cero y evita el registro de números de habitación duplicados.