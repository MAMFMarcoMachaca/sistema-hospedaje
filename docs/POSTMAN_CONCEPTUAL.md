# Pruebas conceptuales en Postman — Sistema Hospedaje

## Objetivo

Definir ejemplos de peticiones que podrán probarse en Postman cuando la API REST del Sistema Hospedaje sea implementada.

Actualmente estas pruebas son conceptuales y los endpoints todavía no están implementados.

---

## PC-01 — Consultar habitaciones

**Método:** GET

**Endpoint:**

`GET /api/habitaciones`

### Objetivo

Obtener todas las habitaciones registradas en el sistema.

### Datos enviados

No requiere body.

### Respuesta esperada

**Código HTTP:** `200 OK`

Ejemplo conceptual:

```json
[
  {
    "habitacionId": 1,
    "numero": 201,
    "tipo": "Matrimonial",
    "precioNoche": 35.00,
    "estado": "Ocupada"
  },
  {
    "habitacionId": 2,
    "numero": 202,
    "tipo": "Doble",
    "precioNoche": 45.00,
    "estado": "Disponible"
  }
]
```

### Interpretación

La petición solicita la lista de habitaciones.

Si la consulta se realiza correctamente, la futura API debería responder con `200 OK` y devolver las habitaciones encontradas.

---

## PC-02 — Registrar una habitación válida

**Método:** POST

**Endpoint:**

`POST /api/habitaciones`

### Objetivo

Registrar una nueva habitación en el sistema.

### Datos enviados

En este caso sí se necesita enviar información mediante el body de la petición.

Ejemplo conceptual:

```json
{
  "numero": 203,
  "tipo": "Simple",
  "precioNoche": 30.00,
  "estado": "Disponible"
}
```

### Respuesta esperada

**Código HTTP:** `201 Created`

Ejemplo conceptual:

```json
{
  "habitacionId": 3,
  "numero": 203,
  "tipo": "Simple",
  "precioNoche": 30.00,
  "estado": "Disponible"
}
```

### Interpretación

La petición solicita crear una nueva habitación.

Los datos enviados indican que se desea registrar:

- Habitación número `203`.
- Tipo `Simple`.
- Precio por noche de `S/ 30.00`.
- Estado `Disponible`.

Si los datos son válidos y la habitación se crea correctamente, la futura API debería responder con `201 Created`.

El campo `habitacionId` representa el identificador único que tendría la habitación dentro del sistema.

---

## PC-03 — Intentar registrar una habitación con precio negativo

**Método:** POST

**Endpoint:**

`POST /api/habitaciones`

### Objetivo

Comprobar que la futura API rechace una habitación cuyo precio por noche sea menor o igual a cero.

### Datos enviados

Ejemplo conceptual:

```json
{
  "numero": 204,
  "tipo": "Matrimonial",
  "precioNoche": -35.00,
  "estado": "Disponible"
}
```

### Respuesta esperada

La habitación no debe registrarse.

**Código HTTP esperado:** `400 Bad Request`

Ejemplo conceptual:

```json
{
  "error": "El precio debe ser mayor que cero."
}
```

### Interpretación

La petición intenta crear una habitación, pero contiene un dato inválido:

`precioNoche: -35.00`

La regla del sistema establece que el precio debe ser mayor que cero.

Por ello, la futura API debería rechazar la petición y responder con `400 Bad Request`.

La habitación no debería almacenarse en la base de datos.

---

# Resumen de pruebas conceptuales

| Caso | Método | Endpoint | Objetivo | Respuesta esperada |
|---|---|---|---|---|
| PC-01 | GET | `/api/habitaciones` | Consultar habitaciones | `200 OK` |
| PC-02 | POST | `/api/habitaciones` | Crear habitación válida | `201 Created` |
| PC-03 | POST | `/api/habitaciones` | Rechazar precio negativo | `400 Bad Request` |

---

# Conceptos básicos utilizados

## GET

Se utiliza para consultar u obtener información.

Ejemplo:

`GET /api/habitaciones`

Interpretación:

"Dame las habitaciones registradas."

---

## POST

Se utiliza para enviar información con el objetivo de crear un nuevo registro.

Ejemplo:

`POST /api/habitaciones`

Interpretación:

"Quiero registrar una nueva habitación."

---

## Body

Es la información que se envía junto con una petición.

Ejemplo:

```json
{
  "numero": 203,
  "tipo": "Simple",
  "precioNoche": 30.00,
  "estado": "Disponible"
}
```

En este caso, el body contiene los datos de la habitación que se desea registrar.

---

## JSON

JSON es un formato utilizado para intercambiar información entre aplicaciones.

Por ejemplo:

```json
{
  "numero": 203,
  "tipo": "Simple"
}
```

Conceptualmente significa:

- Número = 203.
- Tipo = Simple.

---

## 200 OK

Indica que una petición se realizó correctamente.

Ejemplo:

`GET /api/habitaciones`

Respuesta:

`200 OK`

---

## 201 Created

Indica que se creó correctamente un nuevo recurso.

Ejemplo:

`POST /api/habitaciones`

Respuesta:

`201 Created`

---

## 400 Bad Request

Indica que la petición contiene datos inválidos que el sistema no debería aceptar.

Ejemplo:

```json
{
  "precioNoche": -35.00
}
```

Respuesta esperada:

`400 Bad Request`

---

# Flujo conceptual futuro

La arquitectura futura podría funcionar de la siguiente manera:

```text
Postman / Página web / Aplicación
                ↓
          Petición HTTP
                ↓
             API REST
                ↓
          ASP.NET Core
                ↓
            Lógica C#
                ↓
         Base de datos SQL
```

La respuesta realizaría el camino inverso:

```text
Base de datos SQL
        ↓
     C#
        ↓
      API
        ↓
     JSON
        ↓
Postman / Web / Aplicación
```

---

# Estado actual

Los casos `PC-01`, `PC-02` y `PC-03` son únicamente pruebas conceptuales.

La API todavía no se encuentra implementada, por lo que estas peticiones aún no pueden ejecutarse realmente en Postman.

Este documento servirá como referencia para futuras pruebas cuando se implemente la API REST del Sistema Hospedaje con ASP.NET Core.