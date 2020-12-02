--CREATE DATABASE bd_telefonos

USE bd_telefonos

CREATE TABLE telefonos
(

	nombre VARCHAR(30) NOT NULL,
	direccion VARCHAR(30) NOT NULL,
	telefono VARCHAR(12) PRIMARY KEY NOT NULL,
	observaciones VARCHAR(240)

)