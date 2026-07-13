# Actividad 4 - Base de Datos Veterinaria

## Descripción
Este proyecto es una base de datos para una veterinaria desarrollada con SQLite3.
Permite gestionar las Mascotas, los Veterinarios y las Citas.

## Diagrama
Se incluye el Diagrama Entidad-Relacion y el Modelo Relacional.
Relacion: Una MASCOTA y un VETERINARIO pueden tener muchas CITAS. Relacion N:M

## Entidades y Atributos
- **MASCOTA**: id_mascota, nombre, especie, edad
- **VETERINARIO**: id_veterinario, nombre_vet, especialidad  
- **CITA**: id_mascota, id_veterinario, fecha_hora, motivo

## Archivos Incluidos
1. `diagrama_ER.png` - Diagrama Entidad-Relacion
2. `modelo_relacional.png` - Modelo Relacional
3. `consulta.sql` - Script con CREATE TABLE, PRIMARY KEY, FOREIGN KEY, INSERT y SELECT
4. `veterinaria.db` - Base de datos SQLite con 5 registros en cada tabla
5. `README.md` - Este archivo

## Instrucciones para Ejecutar
1. Abrir el archivo `veterinaria.db` con DB Browser for SQLite
2. Ir a la pestaña `Ejecutar SQL`
3. Abrir y ejecutar el archivo `consulta.sql`
4. Ir a `Examinar datos` para ver las tablas y los resultados del INNER JOIN

## Consulta Principal
El SELECT con INNER JOIN muestra: Nombre de la Mascota, Especie, Nombre del Veterinario, Especialidad, Fecha y Motivo de la cita.