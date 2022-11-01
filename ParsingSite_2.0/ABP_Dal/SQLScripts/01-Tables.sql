CREATE TABLE dbo.Cars(
  Id int IDENTITY(1,1) NOT NULL,
  Name nvarchar(100) NOT NULL,
  CONSTRAINT PK_Cars PRIMARY KEY CLUSTERED ( Id ASC )
) 
GO

CREATE TABLE dbo.CarType(
  Id int IDENTITY(1,1) NOT NULL,
  Code nvarchar(100) NOT NULL,
  DateFrom datetime2(7)  NULL,
  DateTo datetime2(7) NULL,
  Complectation nvarchar(100) NULL,

  CarId int NOT NULL,

  CONSTRAINT PK_CarType PRIMARY KEY CLUSTERED ( Id ASC)
) 
GO

CREATE TABLE dbo.ComplectationVariable(
  Id int IDENTITY(1,1) NOT NULL,
  Complectation nvarchar(100) NULL,
  DateFrom datetime2(7) NOT NULL,
  DateTo datetime2(7) NOT NULL,
  Engine nvarchar(100) NOT NULL,
  Grade nvarchar(100) NOT NULL,
  AtmMtm nvarchar(100) NOT NULL,
  GearShiftType nvarchar(100) NOT NULL,
  DriversPosition nvarchar(100) NOT NULL,
  FuelInduction nvarchar(100) NOT NULL,

  CarTypeId int NOT NULL,

  CONSTRAINT PK_ComplectationVariable PRIMARY KEY CLUSTERED ( Id ASC)
) 
GO

CREATE TABLE dbo.SparePart(
  Id int IDENTITY(1,1) NOT NULL,
  Name nvarchar(100) NOT NULL,

  ComplectationVariableId int NOT NULL,

  CONSTRAINT PK_SparePart PRIMARY KEY CLUSTERED ( Id ASC)
) 
GO

CREATE TABLE dbo.SpareTypeDetail(
  Id int IDENTITY(1,1) NOT NULL,
  Code nvarchar(100) NOT NULL,
  ModifiedCode nvarchar(100)  NULL,
  Quantity nvarchar(100) NOT NULL,
  DateFrom datetime2(7) NOT NULL,
  DateTo datetime2(7) NOT NULL,
  Applying nvarchar(100) NOT NULL,

  SparePartId int NOT NULL,

  CONSTRAINT PK_SpareTypeDetail PRIMARY KEY CLUSTERED ( Id ASC)
) 
GO

