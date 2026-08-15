# INC-001 — Registro de habitación permite precio negativo

## 1. Identificación

**ID de incidencia:** INC-001

**Título:** Registro de habitación permite guardar un precio negativo.

**Aplicación / módulo:** Sistema Hospedaje / RegistroHabitacion

**Tipo:** Incidencia funcional.

**Estado:** Resuelto.

---

## 2. Descripción del problema

Durante las pruebas funcionales del módulo `RegistroHabitacion`, se detectó que el sistema mostraba un mensaje de error al ingresar un precio negativo, pero continuaba ejecutando el registro.

### Comportamiento esperado

Si el precio es menor o igual a cero, el sistema debe mostrar un error, cancelar el registro de la habitación y volver al menú principal.

### Comportamiento obtenido inicialmente

Al ingresar `-35`, el sistema mostraba:

`Error: el precio debe ser mayor que cero.`

Sin embargo, posteriormente solicitaba el estado de la habitación y permitía guardar:

`Habitación 201 | Tipo: Matrimonial | Precio: S/ -35.00 | Estado: Disponible`

---

## 3. Pasos para reproducir

1. Ejecutar el proyecto `RegistroHabitacion`.
2. Seleccionar `1 - Registrar habitación`.
3. Ingresar `201` como número de habitación.
4. Seleccionar `3 - Matrimonial`.
5. Ingresar `-35` como precio.
6. Observar el comportamiento.

**Reproducible:** Sí.

**Frecuencia:** 2 de 2 intentos.

---

## 4. Impacto

**Severidad:** Media.

**Prioridad:** Alta.

**Impacto en la operación:**

El sistema permitía registrar información económicamente inválida, lo que podía generar inconsistencias en precios, ingresos y futuros reportes.

---

## 5. Análisis inicial

La validación detectaba correctamente que el precio era menor o igual a cero, pero el método continuaba ejecutándose después de mostrar el mensaje de error.

La causa fue la ausencia de una instrucción que finalizara el método después de detectar el valor inválido.

---

## 6. Solución aplicada

Se agregó:

`return;`

después del mensaje de validación del precio.

Esto detiene inmediatamente el método `RegistrarHabitacion()` cuando el precio no cumple la regla establecida.

---

## 7. Validación posterior

Se realizó nuevamente la prueba utilizando:

`Precio: -35`

El sistema mostró:

`Error: el precio debe ser mayor que cero.`

Luego volvió directamente al menú principal sin solicitar el estado y sin registrar la habitación.

**Resultado del retest:** APROBADO ✅

---

## 8. Cierre

**Estado final:** CERRADO ✅

**Conclusión:**

La incidencia fue reproducida, documentada, corregida y verificada mediante un retest satisfactorio.
