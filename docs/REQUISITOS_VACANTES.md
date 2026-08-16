# Requisitos repetidos en vacantes y estrategia de puertas de entrada

**Fecha de revisión:** 15 de agosto de 2026.

## Objetivo

Identificar los requisitos que se repiten en vacantes relacionadas con desarrollo backend .NET, QA, soporte de aplicaciones y análisis funcional.

El propósito es utilizar estos requisitos para orientar el aprendizaje, fortalecer el portafolio y definir las puertas de entrada más realistas hacia una primera experiencia laboral remota.

---

## Roles laborales considerados

La revisión se concentró en los siguientes puestos:

- Desarrollador Backend .NET Trainee o Junior.
- QA Manual Junior.
- QA Funcional Junior.
- Tester Junior.
- Analista de Soporte de Aplicaciones.
- Soporte de Aplicaciones N1.
- Analista Funcional Trainee o Junior.
- Business Analyst Junior.
- Analista de Procesos Junior.

Se priorizaron oportunidades:

- Remotas.
- Disponibles para Perú o Latinoamérica.
- Dirigidas a perfiles trainee, entry-level o junior.
- Con experiencia requerida entre 0 y 2 años.
- Relacionadas con C#, .NET, SQL, QA, soporte o análisis funcional.

> Esta revisión es una muestra exploratoria de vacantes recientes. No representa un censo estadístico completo del mercado laboral.

---

# 10 requisitos repetidos

## 1. Conocimientos de SQL

SQL aparece en vacantes de desarrollo, QA, soporte de aplicaciones y análisis de datos.

Se utiliza para:

- Consultar información.
- Filtrar registros.
- Validar datos.
- Investigar incidencias.
- Comprobar resultados de pruebas.
- Apoyar reportes.

### Evidencia actual en el proyecto

- Modelo SQL inicial.
- Tablas de habitaciones, clientes, pagos, cochera y gastos.
- Consultas con `SELECT`, `WHERE` y `ORDER BY`.
- Uso de `AND`, `OR`, `ASC`, `DESC` e `IS NULL`.

### Pendiente

- Ejecutar las consultas en una base de datos real.
- Practicar `INSERT`, `UPDATE` y `DELETE`.
- Aprender `JOIN`, `COUNT`, `SUM` y `GROUP BY`.

---

## 2. APIs REST, HTTP y JSON

Las APIs aparecen especialmente en desarrollo backend y QA.

Las vacantes solicitan conocimientos como:

- Métodos `GET`, `POST`, `PUT` y `DELETE`.
- Códigos de estado HTTP.
- Peticiones y respuestas.
- Formato JSON.
- Validación de servicios REST.
- Pruebas de APIs con Postman.

### Evidencia actual en el proyecto

- Diseño conceptual de endpoints.
- Casos conceptuales de Postman.
- Ejemplos de respuestas `200`, `201` y `400`.

### Pendiente

- Implementar una API real con ASP.NET Core.
- Ejecutar peticiones reales con Postman.
- Validar respuestas y datos guardados.

---

## 3. Git y GitHub

El control de versiones aparece como requisito habitual en desarrollo y como conocimiento deseable en QA y soporte técnico.

Las empresas esperan que el candidato conozca:

- Repositorios.
- Ramas.
- Commits.
- Push y pull.
- Pull Requests.
- Revisión de cambios.
- Resolución básica de conflictos.

### Evidencia actual en el proyecto

- Repositorio publicado.
- Uso de ramas.
- Commits con mensajes descriptivos.
- Pull Requests.
- Merge de cambios.
- Eliminación y limpieza de ramas.

### Pendiente

- Continuar utilizando una rama diferente para cada avance.
- Evitar realizar cambios directamente sobre `main`.

---

## 4. Pruebas de software y control de calidad

Las pruebas no son exclusivas de QA. También aparecen en desarrollo backend y soporte de aplicaciones.

Se solicita experiencia en:

- Casos de prueba.
- Pruebas positivas y negativas.
- Resultado esperado y resultado obtenido.
- Pruebas funcionales.
- Pruebas de regresión.
- Validación de APIs.
- Registro de evidencias.

### Evidencia actual en el proyecto

- Diez casos de prueba funcionales.
- Pruebas positivas y negativas.
- Defecto encontrado.
- Corrección aplicada.
- Retest aprobado.

### Pendiente

- Probar una API real.
- Practicar pruebas de regresión.
- Introducir pruebas automatizadas básicas.

---

## 5. Documentación técnica

La documentación se repite en desarrollo, QA, soporte y análisis funcional.

Las empresas necesitan personas capaces de registrar:

- Requerimientos.
- Casos de prueba.
- Incidencias.
- Pasos para reproducir errores.
- Soluciones aplicadas.
- Evidencias.
- Manuales o procedimientos.
- Cambios realizados.

### Evidencia actual en el proyecto

- README completo.
- Casos de prueba.
- Checklist de pruebas.
- Plantilla de incidencias.
- Incidencia real documentada.
- Diseño de API.
- Práctica SQL documentada.

### Pendiente

- Documentar requisitos funcionales.
- Crear historias de usuario.
- Agregar criterios de aceptación.

---

## 6. Metodologías ágiles y herramientas de seguimiento

En QA, desarrollo y análisis funcional aparecen con frecuencia:

- Scrum.
- Kanban.
- Jira.
- Azure DevOps.
- Xray.
- Historias de usuario.
- Backlog.
- Sprints.
- Gestión de defectos.

### Evidencia actual en el proyecto

- Trabajo organizado mediante avances y sprints.
- Registro de tareas completadas.
- Documentación de defectos e incidencias.

### Pendiente

- Crear un backlog formal.
- Escribir historias de usuario.
- Simular el seguimiento de tareas e incidencias en una herramienta.

---

## 7. C# y .NET

C# y .NET son requisitos centrales para la puerta de entrada de desarrollo backend.

Las vacantes Junior .NET solicitan normalmente:

- Fundamentos de C#.
- Programación orientada a objetos.
- ASP.NET Core.
- APIs REST.
- Manejo de errores.
- Programación asíncrona.
- Inyección de dependencias.
- Acceso a bases de datos.

### Evidencia actual en el proyecto

- Aplicaciones de consola en C#.
- Variables y tipos de datos.
- Condicionales.
- Ciclos.
- Listas.
- Métodos.
- Validaciones con `TryParse()`.
- Registro temporal de habitaciones e ingresos.

### Pendiente

- Clases y objetos.
- ASP.NET Core.
- Entity Framework Core.
- Conexión real con SQL.
- Pruebas unitarias.

---

## 8. Análisis y solución de incidencias

Este requisito aparece principalmente en soporte de aplicaciones, pero también es importante en QA y desarrollo.

Incluye:

- Comprender el problema.
- Reproducir el error.
- Revisar datos y registros.
- Determinar el impacto.
- Encontrar una causa.
- Aplicar una solución.
- Realizar un retest.
- Documentar el cierre.

### Evidencia actual en el proyecto

- Incidencia `INC-001`.
- Análisis del precio negativo.
- Identificación de la causa.
- Corrección mediante `return`.
- Retest satisfactorio.
- Cierre documentado.

### Pendiente

- Practicar lectura de logs.
- Simular incidencias relacionadas con SQL y APIs.
- Aprender conceptos básicos de gestión de servicios e ITIL.

---

## 9. Comunicación, colaboración e inglés

El trabajo remoto exige comunicación escrita clara y capacidad para colaborar con otras personas.

Las vacantes pueden solicitar:

- Comunicación con desarrolladores, QA y usuarios.
- Explicación clara de problemas.
- Participación en revisiones.
- Documentación en inglés.
- Inglés básico, intermedio o B2 según la empresa.

### Evidencia actual

- Documentación técnica organizada.
- Explicación de problemas y soluciones.
- Uso de GitHub para compartir avances.

### Pendiente

- Alcanzar como mínimo inglés B1.
- Practicar vocabulario técnico.
- Escribir descripciones breves de proyectos en inglés.
- Explicar el proyecto de forma oral.

---

## 10. Experiencia demostrable mediante proyectos

Las vacantes junior pueden aceptar experiencia obtenida mediante:

- Proyectos personales.
- Proyectos académicos.
- Prácticas.
- Trabajo freelance.
- Contribuciones de código abierto.
- Portafolio en GitHub.

Un repositorio no reemplaza completamente la experiencia laboral, pero ayuda a demostrar conocimientos cuando todavía no se ha tenido un primer empleo tecnológico.

### Evidencia actual

El proyecto muestra:

- Desarrollo en C#.
- Git y GitHub.
- QA manual.
- Soporte de aplicaciones.
- Modelo SQL.
- Diseño de API.
- Postman conceptual.
- Documentación técnica.

### Pendiente

- Ejecutar SQL realmente.
- Implementar la API.
- Conectar C# con una base de datos.
- Incorporar pruebas reales con Postman.
- Agregar capturas y demostraciones.

---

# Estado frente a los requisitos

| Requisito | Estado actual | Nivel |
|---|---|---|
| SQL | Consultas documentadas, todavía sin ejecución real | En progreso |
| APIs REST | Diseño conceptual | Inicial |
| Git y GitHub | Ramas, commits, PR y merge realizados | Básico funcional |
| QA manual | Casos, defecto y retest documentados | Básico funcional |
| Documentación | Evidencia amplia y organizada | Fortaleza inicial |
| Agile y Jira | Conceptos básicos, sin herramienta real | Inicial |
| C# y .NET | Aplicaciones de consola funcionales | Básico |
| Soporte de aplicaciones | Incidencia analizada y documentada | Básico |
| Comunicación e inglés | Documentación en español; inglés en progreso | En progreso |
| Portafolio | Repositorio activo con evidencias | En progreso |

---

# Estrategia de puertas de entrada

## Puerta 1: QA Manual o QA Funcional Junior

### Puestos objetivo

- QA Manual Junior.
- QA Funcional Junior.
- Tester Junior.
- Analista de Calidad Junior.

### Razón

Es una puerta realista porque el repositorio ya contiene casos de prueba, defectos, evidencias, retest, SQL básico y diseño conceptual de APIs.

### Brechas principales

- Ejecutar pruebas sobre una API real.
- Utilizar Postman realmente.
- Practicar Jira o Azure DevOps.
- Fortalecer SQL.
- Aprender regresión, smoke testing y UAT.

### Prioridad de postulaciones

**35 % de las postulaciones semanales.**

---

## Puerta 2: Soporte de Aplicaciones Junior

### Puestos objetivo

- Application Support Analyst I.
- Analista de Soporte de Aplicaciones.
- Soporte de Aplicaciones N1.
- Analista de Incidencias.
- Soporte Técnico de Software.

### Razón

La experiencia técnica previa, el análisis de problemas y la documentación de incidencias pueden utilizarse como fortalezas.

### Brechas principales

- SQL ejecutado realmente.
- Lectura de logs.
- Conceptos básicos de Linux.
- Gestión de tickets.
- Conceptos de ITIL.
- Diagnóstico de APIs.

### Restricción

Priorizar soporte de software remoto. Evitar puestos de soporte de hardware que exijan desplazamientos o atención presencial.

### Prioridad de postulaciones

**30 % de las postulaciones semanales.**

---

## Puerta 3: Backend .NET Trainee o Junior

### Puestos objetivo

- .NET Trainee.
- Backend C# Junior.
- Junior Backend .NET Developer.
- Desarrollador de Software Junior.
- Soporte y Desarrollo .NET.

### Razón

Es la ruta técnica principal y tiene el mayor potencial de crecimiento, pero actualmente exige cerrar más brechas que QA y soporte.

### Brechas principales

- Programación orientada a objetos.
- ASP.NET Core.
- API REST funcional.
- Entity Framework Core.
- SQL conectado al programa.
- Pruebas unitarias.
- Inglés técnico.

### Prioridad de postulaciones

**25 % de las postulaciones semanales.**

---

## Puerta 4: Analista Funcional Trainee o Junior

### Puestos objetivo

- Analista Funcional Junior.
- Business Analyst Trainee.
- Analista de Procesos Junior.
- Analista de Implementación.
- Consultor Funcional Trainee.

### Razón

Combina comprensión del negocio, documentación, procesos y tecnología.

### Brechas principales

- BPMN.
- Historias de usuario.
- Criterios de aceptación.
- Levantamiento de requerimientos.
- Excel y Power BI.
- ERP u Odoo.
- Presentación de procesos.

### Prioridad de postulaciones

**10 % de las postulaciones semanales.**

---

# Distribución semanal de postulaciones

Meta inicial: **12 postulaciones de calidad por semana**.

| Puerta de entrada | Postulaciones semanales |
|---|---:|
| QA Manual o Funcional | 4 |
| Soporte de Aplicaciones | 4 |
| Backend .NET | 3 |
| Analista Funcional | 1 |
| **Total** | **12** |

No se debe enviar el mismo CV sin adaptación a todas las vacantes. El resumen profesional y las evidencias deben ajustarse al puesto.

---

# Criterios para decidir si postular

## Sí postular

- La vacante es completamente remota.
- Acepta candidatos de Perú o Latinoamérica.
- Solicita entre 0 y 2 años.
- Se cumple aproximadamente el 60 % de los requisitos.
- Acepta proyectos personales o académicos.
- El inglés es básico, deseable o no excluyente.
- El puesto permite obtener experiencia tecnológica verificable.

## No priorizar

- La vacante es presencial o híbrida.
- Exige viajar o atender hardware físicamente.
- Solicita más de 3 años como requisito obligatorio.
- Exige inglés B2 o C1 para comunicación diaria y todavía no se posee ese nivel.
- Es una posición senior presentada como junior.
- No está relacionada con la ruta elegida.

---

# Palabras clave para buscar vacantes

## QA

```text
QA Junior remoto
QA Manual Junior remoto
Tester Junior remoto
Analista QA Funcional remoto
QA Trainee remoto
```

## SOPORTE

```text
Application Support Analyst Junior
Soporte de aplicaciones remoto
Soporte N1 remoto
Analista de incidencias junior
Soporte técnico de software remoto
```

## BACKEND

```text
.NET Trainee remoto
Backend C# Junior remoto
Junior Backend .NET Latin America
ASP.NET Core Junior remoto
Desarrollador .NET Junior Perú remoto
```

## ANÁLISIS FUNCIONAL

```text
Analista Funcional Junior remoto
Business Analyst Trainee Latin America
Analista de Procesos Junior remoto
Consultor Funcional Trainee
Analista de Implementación Junior
```