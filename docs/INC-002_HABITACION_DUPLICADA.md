# INC-002 — Registro duplicado de número de habitación

## 1. Identificación

**ID de incidencia:** INC-002

**Título:** El sistema permite registrar más de una habitación con el mismo número.

**Fecha del reporte:** 16 de agosto de 2026.

**Reportado por:** Marco Antonio Machaca.

**Aplicación / módulo:** Sistema Hospedaje / RegistroHabitacion.

**Tipo:** Incidencia funcional y de integridad de datos.

**Estado:** Resuelto.

---

## 2. Descripción del problema

Durante las pruebas funcionales del módulo `RegistroHabitacion`, se detectó que el sistema permite registrar varias habitaciones utilizando el mismo número.

En la prueba se registró dos veces la habitación `101`, pero utilizando diferente tipo, precio y estado.

### Comportamiento esperado

Después de ingresar el número de una habitación, el sistema debe comprobar si ese número ya está registrado.

Si el número existe, debe mostrar un error, cancelar el nuevo registro y volver al menú principal.

### Comportamiento obtenido

El sistema permitió registrar:

`Habitación 101 | Tipo: Simple | Precio: S/ 40.00 | Estado: Disponible`

y posteriormente:

`Habitación 101 | Tipo: Doble | Precio: S/ 60.00 | Estado: Ocupada`

El resumen indicó:

`Habitaciones registradas: 2`

---

## 3. Pasos para reproducir

1. Ejecutar el proyecto `RegistroHabitacion`.
2. Seleccionar `1 - Registrar habitación`.
3. Registrar la habitación `101` como Simple, con precio `40` y estado Disponible.
4. Volver al menú principal.
5. Seleccionar nuevamente `1 - Registrar habitación`.
6. Registrar la habitación `101` como Doble, con precio `60` y estado Ocupada.
7. Seleccionar `3 - Ver resumen`.
8. Comprobar que aparecen dos habitaciones con el número `101`.

**Reproducible:** Sí.

**Frecuencia:** 1 de 1 intento.

---

## 4. Entorno

**Sistema operativo:** Windows.

**Plataforma:** .NET.

**Tipo de aplicación:** Aplicación de consola en C#.

**Ambiente:** Pruebas.

---

## 5. Impacto

**Severidad:** Alta.

**Prioridad:** Alta.

**Usuarios afectados:** Personal de recepción y administración.

**Impacto en la operación:**

El sistema puede representar una misma habitación física mediante varios registros contradictorios.

Esto puede ocasionar errores de disponibilidad, precios incorrectos, sobreventa de habitaciones y resultados equivocados en futuros reportes.

---

## 6. Evidencia

Durante la prueba, el resumen mostró:

```text
Habitaciones registradas: 2
- Habitación 101 | Tipo: Simple | Precio: S/ 40.00 | Estado: Disponible
- Habitación 101 | Tipo: Doble | Precio: S/ 60.00 | Estado: Ocupada
```

**Caso de prueba relacionado:** CP-11.

**Defecto relacionado:** BUG-02.

---

## 7. Análisis inicial

**Causa identificada:**

El método `RegistrarHabitacion()` validaba que el número fuera numérico y mayor que cero, pero no verificaba si ese número ya existía dentro de la lista `habitaciones`.

Después de recopilar los datos, el programa ejecutaba directamente:

`habitaciones.Add(habitacionRegistrada);`

**¿Es posible reproducir el problema?:** Sí.

**¿Requiere escalar a desarrollo?:** Sí.

---

## 8. Solución temporal

**Workaround disponible:** Sí.

Antes de registrar una habitación, el usuario podía consultar manualmente el resumen para comprobar si el número ya existía.

Esta solución no era confiable porque dependía completamente del usuario.

---

## 9. Resolución

**Solución aplicada:**

Se agregó una validación dentro del método `RegistrarHabitacion()` para revisar las habitaciones existentes antes de continuar con el registro.

Mediante un ciclo `foreach`, el sistema comprueba si ya existe un registro que comienza con:

`Habitación {numeroHabitacion} |`

Si encuentra el mismo número:

1. Muestra un mensaje de error.
2. Ejecuta `return`.
3. Cancela inmediatamente el registro.
4. No solicita el tipo, precio ni estado.
5. No agrega otra habitación a la lista.

**Fecha de resolución:** 16 de agosto de 2026.

**Responsable de la solución:** Marco Antonio Machaca.

### Validación posterior

Se ejecutó nuevamente el caso `CP-11`.

Primero se registró la habitación `101` y posteriormente se intentó registrar el mismo número.

El sistema mostró:

`Error: ya existe una habitación registrada con el número 101.`

La prueba se repitió utilizando la habitación `102`.

El sistema mostró:

`Error: ya existe una habitación registrada con el número 102.`

En ambos casos, el proceso fue cancelado antes de solicitar los demás datos.

**Resultado del retest:** APROBADO ✅

**Frecuencia del retest:** 2 de 2 intentos.

---

## 10. Estado

**Estado actual:** CERRADO ✅

**Observaciones finales:**

La incidencia fue reproducida, analizada, corregida y verificada mediante un retest satisfactorio.

La solución actual es apropiada para la estructura temporal basada en `List<string>`.

Cuando el sistema sea refactorizado para utilizar una clase `Habitacion`, la validación deberá comparar directamente la propiedad `Numero` de cada objeto.