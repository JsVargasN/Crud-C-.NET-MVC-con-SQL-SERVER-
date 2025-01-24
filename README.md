Para crear la conexión a la base de datos dirigirse a 
Herrmaientas => Administrador de paquetes NuGet => Consola de Administrador de Paquetes 
y en la consola escribir el siguiente codigo (Editar según el server y nombre de la BD)


Scaffold-DbContext "Server=NOMBREDELSERVER=ConfeccionesElCondor;Trusted_Connection=SSPI;MultipleActiveResultSets=true;Trust Server Certificate=true" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force

El nombre del server se puede encontrar en SQL SERVER En la ventana de inicio de sesión, el campo "Nombre del servidor" muestra el nombre del servidor.
Este comando en particular se usa para generar las clases de modelo y el contexto de base de datos a partir de una base de datos existente.

Si presenta error al arrancar con el Navegador Chrome, cambiarlo a Edge
