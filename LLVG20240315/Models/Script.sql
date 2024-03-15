-- Creación de la base de datos LRVG20241103DB
CREATE DATABASE LLVG20241415DB;
USE LLVG20241415DB;

CREATE TABLE Clientes (
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    Nombre VARCHAR(200),
    Direccion VARCHAR(255),
    Correo VARCHAR(100),
);

-- Tabla de Números de Teléfono
CREATE TABLE NumerosTelefonos (
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    IdCliente INT,
    Telefono VARCHAR(9),
    TipoTelefono VARCHAR(50),
    FOREIGN KEY (IdCliente) REFERENCES Clientes(Id) ON DELETE CASCADE
);
