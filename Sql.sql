CREATE DATABASE ConfeccionesElCondor;

use ConfeccionesElCondor;

CREATE TABLE Empleados (
    IDEmpleado INT IDENTITY PRIMARY KEY,
    TipoDocumento VARCHAR(50) NOT NULL,
    NumDocumento VARCHAR(50) NOT NULL UNIQUE,
    Nombres VARCHAR(100) NOT NULL,
    Apellidos VARCHAR(100) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    Area VARCHAR(100) NOT NULL
);

INSERT INTO Empleados(TipoDocumento, NumDocumento, Nombres, Apellidos, FechaNacimiento, Area) values
('Cedula',1040346298,'Nicolas','Olarte Anteliz', CONVERT(date, '05/14/1985'),'Logistica');
INSERT INTO Empleados(TipoDocumento, NumDocumento, Nombres, Apellidos, FechaNacimiento, Area) values
('Cedula',1192087239,'Ana Maria','Pinzon Ascanio',CONVERT(date, '01/14/2000'),'Ventas')
INSERT INTO Empleados(TipoDocumento, NumDocumento, Nombres, Apellidos, FechaNacimiento, Area) values
('Cedula',1009673451,'Erick Santiago','Rodriguez Caicedo',CONVERT(date, '09/23/2003'),'Produccion')




select * from empleados