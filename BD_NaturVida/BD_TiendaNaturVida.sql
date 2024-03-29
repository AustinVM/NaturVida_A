CREATE DATABASE NaturVida
GO

USE NaturVida
GO

--Parte Cliente
CREATE TABLE Cliente(
Documento INT PRIMARY KEY,
Nombre Varchar(250),
Direccion Varchar(250),
Telefono varchar(10),
Correo Varchar(250) UNIQUE
)

CREATE TABLE Productos(
Codigo INT PRIMARY KEY,
Descripción VARCHAR(50),
Valor_Unidad INT,
Cantidad INT
)

--Vendedores
CREATE TABLE Vendedores(
Codigo INT PRIMARY KEY,
Usuario VARCHAR(15),
Contraseña VARCHAR(250),
Nombre VARCHAR(50),
)

--Parte Facturacion
CREATE TABLE Factura(
IdFactu INT IDENTITY(1,1) PRIMARY KEY,
Fecha DATE,
Documento_Cliente INT,
Codigo_Vendedor INT

FOREIGN KEY (Documento_Cliente) REFERENCES Cliente (Documento),
FOREIGN KEY (Codigo_Vendedor) REFERENCES Vendedores (Codigo)
)

--Factura detalle
CREATE TABLE Factura_Detalle(
Id INT IDENTITY(1,1) PRIMARY KEY,
Numero_Factura INT,
Codigo_Productos INT,
Cantidad INT,
Valor_Unidad INT

FOREIGN KEY (Numero_Factura) REFERENCES Factura(IdFactu),
FOREIGN KEY (Codigo_Productos) REFERENCES Productos (Codigo)
)
GO

-- Datos

INSERT INTO Vendedores VALUES -- Contraseña admin es admin
(1212,'admin','8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918','Eladmin'),
(1542,'Carlos1995','8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918','Carlos Andres Lopez Rodriguez'),
(4584,'Luis1805','8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918','Luis Fernando Rojas Rojas'),
(8574,'AnaR7','8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918','Ana Milena Robles Lopez'),
(1365,'Andre85','8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918','Andres Felipe Jerez'),
(7586,'Lupita22','8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918','Guadalupe Anaya Rojas');

INSERT INTO Cliente Values
(14100142,'José Dante Amato Martínez','Cra. 17 #12 # 13, Bucaramanga','3124578912',
'Josedante12@gmail.com'),
(16421785,'Juan Miguel Abdo Francis','Cra. 35 ##52- 69, Bucaramanga, Santander','3209378645',
'Abdoju17@gmail.com'),
(19873048,'Jose Francisco Perez',' Cl. 33 #21-15, Floridablanca, Santander','3144123783',
'Josefran@outlook.com'),
(22479990,'Pablo Daniel Schwarz ','Cl. 33 ##29 - 64, Bucaramanga, Santander','3227278568',
'PabloDniel23@gmail.com'),
(22516311, 'Eduardo Julio Piriz','Cl. 50 ##27a - 59, Bucaramanga, Santander','3004569321',
'EduardoPiriz@gmail.com'),
(22528066,'Gerardo Prospero','Cl. 8N#3 ##130, Piedecuesta, Santander','3118967544',
'Gerardo2403@gmail.com'),
(23452786,'María Lucinda Aguirre Cruz','Samanes #30-116, Las Mercedes,
Bucaramanga','3112234578', 'Maria672@hotmail.com'),
(32651141,'Rosa Cristina Lenzner','Carrera 18_18-05, San Gil, Santander','3145671200',
'Rosa0101@hotmail.com'),
(32668195,'Ricardo Elpidio Costa','Cl. 32 ## 30-15, Bucaramanga, Santander','3227568982',
'Ricardo234@gmail.com'),
(32789559,'Efrain Andres Cabrera','Cl. 37 ##3-16, Bucaramanga, Santander','3214567432',
'Efrainandres02@gmail.com'),
(32890499,' Nicolari Raquel Elizabet','Cl. 54 N, Bucaramanga, Santander','3152123458',
'RaquelElizabet@hotmail.com'),
(34879675,' Herlaynne Segura Jiménez','Cra. 34 ##18-05, Bogotá, Cundinamarca','3118459351',
'Herlay2002@gmail.com'),
(55224208,'Boris Silvestre Funtes','Cra. 10 #No 6-84, San Gil, Santander','3227189456',
'Borissill@outlook.com'),
(56783241,'Claudia Marcela Martinez Galvis','Cra. 24 #898, Bucaramanga,
Santander','3226785251', ' Claudiamar@hotmail.com'),
(72043455,'Jose Bartolome Madera','Cra. 19 #1242, Bucaramanga, Santander','3209897567',
'Bartolome2345@gmail.com'),
(72181696,'María Cristina Barreiro ','Dg. 105 ##29a-30, Bucaramanga,
Santander','3116789564', 'Cristinamaria45@hotmail.com'),
(73156765,'Francisco Javier Álvarez Leffmans','Cra. 17C ##55-44 Apto 306, Bucaramanga,
Santander','3207689645', 'Leffjavier@gmail.com'),
(80845402,'Daniel Carlos Blanco','Cra. 31 #53-35, Bucaramanga, Santander','3126789560',
'Danielcarlo09@gmail.com'),
(785675423,'Rodolfo Barragán García','Cra. 40 #4863, Bucaramanga','3209298634',
'Rodolbarragan@hotmail.com'),
(1067452691,'Reinaldo Narvaez','Cra. 24 ##101 79, Bucaramanga','3227135894',
'reinald_34@hotmail.com'),
(1075475921,'María Del Carmen Amigo Castañeda','Cra. 20 #22-78, Bucaramanga,
Santander','3124578458', 'Maria0202outlook.com'),
(1095475238,'Maria Victoria Higuita Otero','Cra. 24 ## 17 - 61, Bucaramanga,
Santander','3124567836', 'Maria1700@gmail.com'),
(1097456324,'Juan Fernando Uribe','Carrera 3 ##3-18 Floridablanca, Santander','3226754560',
'juanjuribe33@gmail.com'),
(1097563281,'José Ferdusi Avalos Romero','Cra. 32 ##33-36, Bucaramanga,
Santander','3227459369', 'Jos2407@outlook.com'),
(1098456743,'Pablo Álvarez Maldonado','Cl. 12 ## 10, Bucaramanga, Santander','3004567983',
'Alvarez03@outlook.com'),
(1098830652,'Oscar Andres Cardenas Garces','Cra. 34 ## 48 - 93, Bucaramanga,
Santander','3117683071', 'Osandres@gmail.com'),
(1098839567,'Arturo Ángeles','Calle 37 No. 26-15Apto 203D, Bucaramanga,
Santander','3156734897', 'Arturoaaa@gmail.com'),
(1129509728,'Winston Franklin Beloqui','Carrera 9#12-34, Lebrija, Santander','3007865432',
'Wfranflin23@hotmail.com'),
(1129572839,'Juan Carlos Perez','Cra. 27 #18-45, Bucaramanga, Santander','3105678451',
'Juanccc@outlook.com'),
(1297455327,'Maria Ines Abadie Fossatti','Tv. 29 #104-112, Bucaramanga,
Santander','3126754324', 'Mariaines02@gmail.com')

INSERT INTO Productos VALUES
(2695,'Castalo de Indias Tabletas 1.500gr',4500,8),
(2570,'Antax jarabe 360ml',35700,6),
(2341,'Arnica gotas 90gr',15000,10),
(2822,'Sangre de dragon crema 60gr',12000,5),
(2343,'Mieltertos Jarabe 250ml',18000,4),
(2966,'Ice Gel Crema 110gr',10000,11),
(2857,'Miesterto Sobre 14gr',1500,40),
(2148,'Arnica Crema 60gr',8000,7),
(2739,'Finacid Jarabe 360ml',24500,7),
(3089,'Calendula Jarabe 240ml',18000,4),
(3312,'Labfarve Hojas de Tomate Jarabe 120ml',14200,6),
(3695,'labfarve Ortiga Gotas 60ml',13400,10),
(3404,'Arandano Capsulas 400mg',20000,9),
(3564,'Extracto de Ruibarbo Gotas 60ml',14600,11),
(3681,'Faroliva Aceite de olivia Lata 140ml',10000,8),
(3731,'Faroliva Aceite de olivia Botella 500ml',25000,5),
(3891,'Botanitas Miel de abeja Botella 340gr',14400,6),
(3956,'Prostafort Forte Capsula 160gr', 23500,4),
(4075,'Curcuma Botella 50gr',14000,8),
(4151,'Meta mucil Polvo 175gr',1200,4),
(4232,'Raizarrilla Plus Jarabe 360ml',18400,10),
(4453,'Propomielito Jarabe 350ml',16400,12),
(4456,'Passiflora Gotas 60ml',8000,24),
(4865,'Ovix: Gotas 80ml',11600,12),
(4639,'Valeriana Officinalis L Gotas 60ml',8000,14),
(4742,'Glucosamina mix Caja 1.500gr',40800,5),
(4808,'Green Marihuana Grema 20gr',24000,10),
(0659,'Chais Caja 20 Bolsas', 25000, 15),
(1010,'Chang: Botellas 12 oz', 19000, 25),
(0120,'Jarabe de anís Botella 550 ml',10000, 12),
(0046,'Mishi Kobe Niku Paquete 500g',97000, 17),
(4008,'Ikura Botella 200 ml', 31000, 55),
(5455, 'Queso Cabrales Caja 1 kg.', 21050, 36),
(2501,'Konbu Cajas de 2 kg', 45000, 20),
(3562,'Tofu Paquetes 100 g.', 23500, 66),
(0254, 'Genen Shouyu Botellas 250 ml', 15500, 46),
(0251, 'Pavlova Cajas 500 g', '64500', 19),
(0911, 'Alice cordero Latas 1 kg', 39000, 350),
(0245, 'Carnarvon Tigers Paqetes de 16 kg.', 62500, 100),
(8021, 'Gustaf ́s Knäckebröd 24 Paquetes - 500 g.', 21000,82),
(1021, 'Tunnbrod 12 Paquetes - 250 g.', 9000, 3)
GO



------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- Se crea un procedimiento almacenado llamado "SP_AGGFACT" que recibe como parámetros las variables "@Fech", "@DoClient", "@CodVende", "@CodProd", "@Cant" y "@ValUnidad".
CREATE PROC SP_AGREGARFACTURA
@Fech DATE,
@DoClient INT,
@CodVende INT,
@CodProd INT,
@Cant INT,
@ValUnidad INT
AS
BEGIN
    -- Se insertan los valores de las variables "@Fech", "@DoClient" y "@CodVende" en la tabla "Factura".
    INSERT INTO Factura (Fecha, Documento_Cliente, Codigo_Vendedor) VALUES (@Fech, @DoClient, @CodVende)

	-- Se declara una variable local llamada "@IDFac" de tipo INT que almacenará el valor máximo del campo "IdFactu" de la tabla "Factura".
    DECLARE @IDFac INT

	SET @IDFac = (SELECT TOP 1 IdFactu FROM Factura ORDER BY IdFactu DESC) -- Se le asigna el valor a la variable local del valor máximo del campo "IdFactu" de la tabla "Factura".

    -- Se inicia un bloque "BEGIN-END" en el que se ejecutará el procedimiento almacenado "SP_AGGFACTDETA" con los parámetros "@IDFac", "@CodProd", "@Cant" y "@ValUnidad".
    BEGIN
        EXEC SP_AGGFACTDETA @IDFac, @CodProd, @Cant, @ValUnidad;
    END
END
GO