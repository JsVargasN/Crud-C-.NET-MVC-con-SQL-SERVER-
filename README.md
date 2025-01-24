**IMPORTANTE**

***1. Agregar Paquetes NuGet Entity FrameWork***

**Herramientas** => **Administador de paquetes NuGet** => **Administrar paquetes NuGet**

En "Examinar" buscar el paquete *Microsoft.EntityFrameWorkCore.SqlServer*, selecciona el proyecto e instala.
Buscar el paquete *Microsoft.EntityFrameWorkCore.Tools*, selecciona el proyecto e instala.

_2. CREAR LA BASE DE DATOS_

**3. CONEXION BASE DE DATOS CON ENTITY FRAMEWORK**

Para crear la conexión a la base de datos dirigirse a 
**Herramientas** => **Administrador de paquetes NuGet** => **Consola de Administrador de Paquetes**
y en la consola escribir el siguiente codigo (Editar según el server y nombre de la BD)

_(El nombre del server se puede encontrar en SQL SERVER En la ventana de inicio de sesión, el campo "Nombre del servidor" muestra el nombre del servidor)_

Scaffold-DbContext "Server=NOMBREDELSERVER=ConfeccionesElCondor;Trusted_Connection=SSPI;MultipleActiveResultSets=true;Trust Server Certificate=true" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force

Este comando en particular se usa para generar las clases de modelo y el contexto de base de datos a partir de una base de datos existente.

Si presenta error al arrancar con el Navegador Chrome, cambiarlo a Edge
