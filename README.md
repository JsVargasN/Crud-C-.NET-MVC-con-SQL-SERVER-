Para crear la conexión a la base de datos dirigirse a 
Herrmaientas => Administrador de paquetes NuGet => Consola de Administrador de Paquetes 
y en la consola escribir el siguiente codigo (Editar según el server y nombre de la BD)


Scaffold-DbContext "Server=NombreDelServer=ConfeccionesElCondor;Trusted_Connection=SSPI;MultipleActiveResultSets=true;Trust Server Certificate=true" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force

Si presenta error al arrancar con el Navegador Chrome, cambiarlo a Edge
