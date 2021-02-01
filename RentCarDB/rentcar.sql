--- Randolph Acosta
--- RentACar Database 
--- 2021---

CREATE DATABASE rentcar
GO
USE rentcar
GO

CREATE TABLE Tipos_Vehiculos(
Id_Tipos_Vehiculo int IDENTITY(1,1) NOT NULL,
Descripcion varchar(50) NOT NULL,
Estado varchar(20) CHECK (Estado IN ('Activo','Inactivo')) NOT NULL,
CONSTRAINT PK_IDTV PRIMARY KEY(Id_Tipos_Vehiculo)
);
GO

CREATE TABLE Marcas(
Id_Marca int IDENTITY(1,1) NOT NULL,
Descripcion varchar(50) NOT NULL,
Estado varchar(20) CHECK (Estado IN ('Activo','Inactivo')) NOT NULL,
CONSTRAINT PK_IDMA PRIMARY KEY(Id_Marca)
);
GO

CREATE TABLE Modelos(
Id_Modelo int IDENTITY(1,1) NOT NULL,
Id_Marca int NOT NULL,
Descripcion varchar(50) NOT NULL,
Estado varchar(20) CHECK (Estado IN ('Activo','Inactivo')) NOT NULL,
CONSTRAINT PK_IDMO PRIMARY KEY(Id_Modelo),
CONSTRAINT FK_IDMA1 FOREIGN KEY(Id_Marca) REFERENCES Marcas(Id_Marca)
);
GO

CREATE TABLE Tipos_Combustibles(
Id_Tipos_Combustible int IDENTITY(1,1) NOT NULL,
Descripcion varchar(50) NOT NULL,
Estado varchar(20) CHECK (Estado IN ('Activo','Inactivo')) NOT NULL,
CONSTRAINT PK_IDTC PRIMARY KEY(Id_Tipos_Combustible)
);
GO

CREATE TABLE Vehiculos(
Id_Vehiculo int IDENTITY(1,1) NOT NULL,
Descripcion varchar(50) NOT NULL,
No_Chasis varchar(50) NOT NULL,
No_Motor varchar(50) NOT NULL,
No_Placa varchar(50) NOT NULL,
Tipo_Vehiculo int NOT NULL,
Marca int NOT NULL,
Modelo int NOT NULL,
Tipo_Combustible int NOT NULL,
Estado varchar(20) CHECK (Estado IN ('Disponible','Mantenimiento','Rentado')) NOT NULL,
CONSTRAINT PK_IDV PRIMARY KEY(Id_Vehiculo),
CONSTRAINT FK_IDTV FOREIGN KEY(Tipo_Vehiculo) REFERENCES Tipos_Vehiculos(Id_Tipos_Vehiculo),
CONSTRAINT FK_IDMA2 FOREIGN KEY(Marca) REFERENCES Marcas(Id_Marca),
CONSTRAINT FK_IDMO FOREIGN KEY(Modelo) REFERENCES Modelos(Id_Modelo),
CONSTRAINT FK_IDTC FOREIGN KEY(Tipo_Combustible) REFERENCES Tipos_Combustibles(Id_Tipos_Combustible)
);
GO

CREATE TABLE Clientes(
Id_Cliente int IDENTITY(1,1) NOT NULL,
Nombre varchar(50) NOT NULL,
Apellido varchar(50) NOT NULL,
Cedula varchar(11) NOT NULL,
No_Tarjeta_CR varchar(16) NOT NULL,
Limite_Credito int NOT NULL,
Tipo_Persona varchar(10) CHECK (Tipo_Persona IN ('Fisica','Juridica')) NOT NULL,
Estado varchar(20) CHECK (Estado IN ('Activo','Inactivo')) NOT NULL,
CONSTRAINT PK_IDC PRIMARY KEY(Id_Cliente)
);
GO

CREATE TABLE Empleados(
Id_Empleado int IDENTITY(1,1) NOT NULL,
Nombre varchar(50) NOT NULL,
Apellido varchar(50) NOT NULL,
Cedula varchar(11) NOT NULL,
Correo varchar(50) NOT NULL,
Contrasena varchar(50) NOT NULL,
Tanda_laboral varchar(20) CHECK (Tanda_laboral IN ('Matutina','Vespertina','Nocturna')) NOT NULL,
Porciento_Comision int NOT NULL,
Fecha_Ingreso datetime NOT NULL,
Estado varchar(20) CHECK (Estado IN ('Activo','Inactivo')) NOT NULL,
CONSTRAINT PK_IDE PRIMARY KEY(Id_Empleado)
);
GO

CREATE TABLE Inspecciones(
Id_Transaccion int IDENTITY(1,1) NOT NULL,
Vehiculo int NOT NULL,
Id_Cliente int NOT NULL,
Tiene_Ralladuras char(2) CHECK (Tiene_Ralladuras IN ('Si','No')) NOT NULL,
Cantidad_Combustible varchar(50) CHECK (Cantidad_Combustible IN ('1/4','1/2','3/4','Lleno')) NOT NULL,
Tiene_Goma_respuesta char(2) CHECK (Tiene_Goma_respuesta IN ('Si','No')) NOT NULL,
Tiene_Gato char(2) CHECK (Tiene_Gato IN ('Si','No')) NOT NULL,
Tiene_Roturas_Cristal char(2) CHECK (Tiene_Roturas_Cristal IN ('Si','No')) NOT NULL,
Estado_GomaA varchar(50) CHECK (Estado_GomaA IN ('Nueva','Regular','Gastada')) NOT NULL,
Estado_GomaB varchar(50) CHECK (Estado_GomaB IN ('Nueva','Regular','Gastada')) NOT NULL,
Estado_GomaC varchar(50) CHECK (Estado_GomaC IN ('Nueva','Regular','Gastada')) NOT NULL,
Estado_GomaD varchar(50) CHECK (Estado_GomaD IN ('Nueva','Regular','Gastada')) NOT NULL,
Fecha datetime NOT NULL,
Empleado_Inspeccion int NOT NULL,
Estado varchar(20) CHECK (Estado IN ('Activo','Inactivo')) NOT NULL,
CONSTRAINT PK_IDI PRIMARY KEY(Id_Transaccion),
CONSTRAINT FK_IDVE1 FOREIGN KEY(Vehiculo) REFERENCES Vehiculos(Id_Vehiculo),
CONSTRAINT FK_IDCL1 FOREIGN KEY(Id_Cliente) REFERENCES Clientes(Id_Cliente),
CONSTRAINT FK_IDE1 FOREIGN KEY(Empleado_Inspeccion) REFERENCES Empleados(Id_Empleado)
);
GO

CREATE TABLE Renta_Devolucion(
No_Renta int IDENTITY(1,1) NOT NULL,
Empleado int NOT NULL,
Vehiculo int NOT NULL,
Cliente int NOT NULL,
Fecha_Renta datetime NOT NULL,
Fecha_Devolucion datetime NOT NULL,
MontoxDia int NOT NULL,
Cantidad_Dias int NOT NULL,
Comentario varchar(50) NOT NULL,
Estado varchar(20) CHECK (Estado IN ('Activo','Inactivo')) NOT NULL,
CONSTRAINT PK_IDRD PRIMARY KEY(No_Renta),
CONSTRAINT FK_IDE2 FOREIGN KEY(Empleado) REFERENCES Empleados(Id_Empleado),
CONSTRAINT FK_IDC2 FOREIGN KEY(Cliente) REFERENCES Clientes(Id_Cliente),
CONSTRAINT FK_IDVE2 FOREIGN KEY(Vehiculo) REFERENCES Vehiculos(Id_Vehiculo)
);
GO

--- TRIGGERS ---
CREATE TRIGGER RENTA ON Renta_Devolucion AFTER INSERT
AS
DECLARE @IDVEHICULO INT
SELECT @IDVEHICULO = Vehiculo from INSERTED
UPDATE Vehiculos set Estado = 'Rentado' WHERE Id_Vehiculo = @IDVEHICULO
GO

CREATE TRIGGER DEVOLUCIONCOPIA ON Renta_Devolucion AFTER UPDATE
AS
DECLARE @IDVEHICULO INT
SELECT @IDVEHICULO = Vehiculo from DELETED;
UPDATE Vehiculos set Estado = 'Disponible' WHERE Id_Vehiculo = @IDVEHICULO
GO

