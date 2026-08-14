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

## Resumen de ejecución

- Casos diseñados: **10**.
- Casos ejecutados: **10**.
- Casos aprobados inicialmente: **9**.
- Casos fallidos inicialmente: **1**.
- Defectos encontrados: **1**.
- Defectos corregidos: **1**.
- Retests aprobados: **1**.
- Estado final: **10 casos validados correctamente**.

## Resultado general

Las funciones principales y las validaciones evaluadas funcionan correctamente al finalizar la sesión de pruebas.

Durante la ejecución inicial se identificó un defecto en la validación del precio de una habitación: el sistema mostraba el mensaje de error correspondiente, pero continuaba el proceso y permitía almacenar un precio negativo.

El defecto fue documentado, corregido y posteriormente verificado mediante un retest satisfactorio.
