
# Aplicación CRUD de Estudiantes y Asignaturas

## Descripción
Esta aplicación es una solución para gestionar información de **Estudiantes** y **Asignaturas**. Permite realizar operaciones de **Creación**, **Lectura**
, **Actualización** y **Eliminación** (CRUD) tanto para los datos de estudiantes como de asignaturas dentro de una base de datos SQL Server.

## Estructura del Proyecto
El proyecto está organizado en tres capas principales para facilitar la separación de responsabilidades:

1. **Business Object Layer (BOL)**: Contiene las clases de entidades (`Estu` para estudiantes y `Materia` para asignaturas) 
que representan la estructura de datos en el sistema.
2. **Data Access Layer (DAL)**: Maneja la interacción directa con la base de datos usando ADO.NET para ejecutar consultas y comandos SQL.
3. **Business Logic Layer (BL)**: Implementa la lógica de negocio, llamando a las funciones de la capa DAL para ejecutar las 
operaciones solicitadas en los datos.

## Configuración
Para ejecutar la aplicación, asegúrate de tener configurada la cadena de conexión correcta para tu instancia de SQL Server 
en `EstudiantesDAL` y `AsignaturaDAL`.


## Funcionalidades Principales

### 1. CRUD de Estudiantes
- **Insertar Estudiante**: Permite agregar un nuevo estudiante a la base de datos.
- **Modificar Estudiante**: Actualiza los datos de un estudiante existente.
- **Eliminar Estudiante**: Elimina un estudiante de la base de datos.
- **Seleccionar Todos los Estudiantes**: Obtiene la lista completa de estudiantes.
- **Seleccionar Un Estudiante**: Recupera los datos de un estudiante específico por su ID.

### 2. CRUD de Asignaturas
- **Insertar Asignatura**: Permite agregar una nueva asignatura a la base de datos.
- **Modificar Asignatura**: Actualiza los datos de una asignatura existente.
- **Eliminar Asignatura**: Elimina una asignatura de la base de datos.
- **Seleccionar Todas las Asignaturas**: Obtiene la lista completa de asignaturas.
- **Seleccionar Una Asignatura**: Recupera los datos de una asignatura específica por su ID.

## Uso
1. Instancia la capa de negocio (BL) y utiliza sus métodos para gestionar los datos.
2. Los métodos de la capa BL validan y llaman a la DAL, ejecutando el código de acceso a datos que interactúa con SQL Server.

## Notas
- Asegúrate de que la base de datos y las tablas (`Alumnos` y `Asignaturas`) estén creadas en el servidor SQL Server antes de ejecutar la aplicación.
- Revisa y ajusta la cadena de conexión según el entorno donde se ejecute la aplicación.
