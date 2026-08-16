# SQL práctico 1: SELECT, WHERE y ORDER BY

## Objetivo

Practicar consultas SQL básicas aplicadas a las habitaciones, los pagos y la cochera del hospedaje.

## 1. Consultar todas las habitaciones

```sql
SELECT *
FROM Habitaciones;
```

## 2. Consultar columnas específicas

```sql
SELECT Numero, Tipo, PrecioNoche
FROM Habitaciones;
```

## 3. Consultar habitaciones disponibles

```sql
SELECT Numero, Tipo, PrecioNoche
FROM Habitaciones
WHERE Estado = 'Disponible';
```

## 4. Consultar habitaciones de hasta S/50

```sql
SELECT Numero, Tipo, PrecioNoche, Estado
FROM Habitaciones
WHERE PrecioNoche <= 50;
```

## 5. Consultar habitaciones disponibles de hasta S/50

```sql
SELECT Numero, Tipo, PrecioNoche
FROM Habitaciones
WHERE Estado = 'Disponible'
  AND PrecioNoche <= 50;
```

## 6. Consultar habitaciones simples o dobles

```sql
SELECT Numero, Tipo, PrecioNoche, Estado
FROM Habitaciones
WHERE Tipo = 'Simple'
   OR Tipo = 'Doble';
```

## 7. Ordenar habitaciones por precio

```sql
SELECT Numero, Tipo, PrecioNoche, Estado
FROM Habitaciones
ORDER BY PrecioNoche ASC;
```

## 8. Ordenar habitaciones desde la más costosa

```sql
SELECT Numero, Tipo, PrecioNoche, Estado
FROM Habitaciones
ORDER BY PrecioNoche DESC;
```

## 9. Consultar habitaciones disponibles ordenadas por precio

```sql
SELECT Numero, Tipo, PrecioNoche
FROM Habitaciones
WHERE Estado = 'Disponible'
ORDER BY PrecioNoche ASC;
```

## 10. Consultar pagos realizados en efectivo

```sql
SELECT Concepto, Monto, MetodoPago
FROM Pagos
WHERE MetodoPago = 'Efectivo'
ORDER BY Monto DESC;
``` 

## 11. Consultar vehículos que todavía permanecen en la cochera

```sql
SELECT Placa, TipoVehiculo, FechaIngreso, Estado
FROM Cochera
WHERE FechaSalida IS NULL
ORDER BY FechaIngreso ASC;
```

## 12. Consultar vehículos activos por monto

```sql
SELECT Placa, TipoVehiculo, Monto
FROM Cochera
WHERE Estado = 'Activo'
ORDER BY Monto DESC;
```

## Resumen de lo aprendido

- `SELECT`: sirve para elegir las columnas que queremos mostrar.
- `FROM`: indica la tabla de la cual extraeremos los datos.
- `WHERE`: sirve para filtrar las filas que cumplen una condición.
- `ORDER BY`: sirve para ordenar los resultados utilizando una columna.
- `ASC`: ordena de menor a mayor.
- `DESC`: ordena de mayor a menor.
- `AND`: combina condiciones y exige que ambas se cumplan.
- `OR`: combina condiciones y basta con que una se cumpla.
- `IS NULL`: verifica que una columna todavía no tenga un valor registrado.
