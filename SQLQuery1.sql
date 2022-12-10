CREATE TABLE Carro (
	 ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
     Nombre varchar(150),
     Img varchar(150),
     Horarios varchar(150),
     Ubicacion varchar(150), 
     Rating numeric(2,1),
     CTop numeric(1) UNIQUE,
);

INSERT INTO Carro(Nombre, Img, Horarios, Ubicacion, Rating, CTop) VALUES
('Macanudo', 'img/maccarro.jpg', '24/7', 'centro', 5.0 , 1),
('El Italiano', 'img/maccarro.jpg', '24/7', 'centro', 5.0, 3),
('MCCarro', 'img/maccarro.jpg', '24/7', 'centro', 5.0, 4);


select * from Carro