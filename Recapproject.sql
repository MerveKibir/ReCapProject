CREATE TABLE Car(
	CarId int PRIMARY KEY IDENTITY(1,1),
	BrandId int,
	ColorId int,
	ModelYear int,
	DailyPrice decimal,
	Descriptions nvarchar(25),
	FOREIGN KEY (BrandId) REFERENCES Brand(BrandID),
	FOREIGN KEY (ColorId) REFERENCES Color(ColorID)
)

CREATE TABLE Color(
	ColorID int PRIMARY KEY IDENTITY(1,1),
	ColorName nvarchar(25)
)

CREATE TABLE Brand(
	BrandID int PRIMARY KEY IDENTITY(1,1),
	BrandName nvarchar(25)
)


INSERT INTO Car(BrandID,ColorID,ModelYear,DailyPrice,Descriptions)
VALUES
	('1','5','2012','110','Manuel Benzin'),
	('6','3','2015','115','Otomatik Dizel'),
	('2','1','2017','200','Otomatik Hybrid'),
	('3','4','2014','125','Manuel Dizel'),
	('4','2','2012','150','Manuel Benzin'),
	('1','1','2012','100','Manuel Benzin'),
	('5','4','2012','160','Manuel Benzin')

INSERT INTO Color(ColorName)
VALUES
	('Beyaz'),
	('Siyah'),
	('Kırmızı'),
	('Gri'),
	('Mavi')


INSERT INTO Brand(BrandName)
VALUES
	('Mercedes'),
	('Audi'),
	('BMW'),
	('Ford'),
	('Hyundai'),
	('Renault')



