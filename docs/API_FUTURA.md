# API futura — Sistema Hospedaje

## Objetivo

Definir conceptualmente los principales endpoints que podría utilizar una futura API REST del Sistema Hospedaje.

Esta propuesta servirá como referencia para una implementación posterior con C#, ASP.NET Core y una base de datos SQL.

---

## Habitaciones

### GET /api/habitaciones

Obtiene la lista de habitaciones registradas.

**Uso futuro:**
Mostrar habitaciones, tipos, precios y estados.

---

### POST /api/habitaciones

Registra una nueva habitación.

**Datos esperados conceptualmente:**

- Número de habitación.
- Tipo.
- Precio por noche.
- Estado.

---

### PUT /api/habitaciones/{id}

Actualiza los datos de una habitación existente.

**Ejemplo conceptual:**

`PUT /api/habitaciones/3`

Podría actualizar la habitación cuyo `HabitacionId` es `3`.

---

### DELETE /api/habitaciones/{id}

Elimina una habitación identificada por su ID.

**Ejemplo conceptual:**

`DELETE /api/habitaciones/3`

---

## Clientes

### GET /api/clientes

Obtiene la lista de clientes registrados.

---

### POST /api/clientes

Registra un nuevo cliente.

**Datos esperados conceptualmente:**

- Nombres.
- Apellidos.
- Documento.
- Teléfono.

---

## Pagos

### GET /api/pagos

Obtiene los pagos registrados.

---

### POST /api/pagos

Registra un nuevo pago.

**Datos esperados conceptualmente:**

- Cliente.
- Habitación, cuando corresponda.
- Concepto.
- Monto.
- Método de pago.
- Fecha.

---

## Cochera

### GET /api/cochera

Obtiene los registros de vehículos ingresados a la cochera.

---

### POST /api/cochera

Registra el ingreso de un vehículo.

**Datos esperados conceptualmente:**

- Cliente, cuando corresponda.
- Placa.
- Tipo de vehículo.
- Fecha de ingreso.
- Monto.
- Estado.

---

## Reportes

### GET /api/reportes/ingresos-dia

Obtiene información sobre los ingresos registrados durante un día.

---

### GET /api/reportes/ocupacion

Obtiene información relacionada con la ocupación de habitaciones.

---

### GET /api/reportes/cochera

Obtiene información relacionada con los movimientos o ingresos de cochera.

---

## Relación conceptual con el sistema

La arquitectura futura podría funcionar de la siguiente manera:

Cliente web / aplicación
↓
API REST
↓
ASP.NET Core
↓
Lógica del sistema
↓
Base de datos SQL

Los endpoints definidos en este documento son únicamente una propuesta conceptual y todavía no se encuentran implementados.