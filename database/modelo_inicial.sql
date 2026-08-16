CREATE TABLE Habitaciones
(
    HabitacionId INT IDENTITY(1,1) PRIMARY KEY,
    Numero INT NOT NULL UNIQUE,
    Tipo NVARCHAR(30) NOT NULL,
    PrecioNoche DECIMAL(10,2) NOT NULL CHECK (PrecioNoche>0),
    Estado NVARCHAR(20) NOT NULL
);

CREATE TABLE Clientes
(
    ClienteId INT IDENTITY(1,1) PRIMARY KEY,
    Nombres NVARCHAR(60) NOT NULL,
    Apellidos NVARCHAR(60) NOT NULL,
    Documento NVARCHAR(20) NOT NULL UNIQUE,
    Telefono NVARCHAR(20) NULL,
    FechaRegistro DATETIME NOT NULL
);

CREATE TABLE Pagos
(
    PagoId INT IDENTITY(1,1) PRIMARY KEY,
    ClienteId INT NOT NULL,
    HabitacionId INT NULL,
    Concepto NVARCHAR(100) NOT NULL,
    Monto DECIMAL(10,2) NOT NULL CHECK (Monto>0),
    MetodoPago NVARCHAR(30) NOT NULL,
    FechaPago DATETIME NOT NULL,

    FOREIGN KEY (ClienteId)
        REFERENCES Clientes(ClienteId),
    FOREIGN KEY (HabitacionId)
        REFERENCES Habitaciones(HabitacionId)
);

CREATE TABLE Cochera
(
    CocheraId INT IDENTITY(1,1) PRIMARY KEY,
    ClienteId INT NULL,
    Placa NVARCHAR(15) NOT NULL,
    TipoVehiculo NVARCHAR(30) NULL,
    FechaIngreso DATETIME NOT NULL,
    FechaSalida DATETIME NULL,
    Monto DECIMAL(10,2) NOT NULL CHECK (Monto >=0),
    Estado NVARCHAR(20) NOT NULL,

    FOREIGN KEY (ClienteId)
        REFERENCES Clientes(ClienteId)
);

CREATE TABLE Gastos
(
    GastoId INT IDENTITY(1,1) PRIMARY KEY,
    Concepto NVARCHAR(100) NOT NULL,
    Categoria NVARCHAR(50) NULL,
    Monto DECIMAL(10,2) NOT NULL CHECK (Monto > 0),
    FechaGasto DATETIME NOT NULL,
    Observacion NVARCHAR(200) NULL
);

