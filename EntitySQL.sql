
create table PacageEntity
(
  Id Int Primary key,
  FuelType nvarchar(20) not null,
  EngineVolume nvarchar(6) not null,
  EnginePower int not null,
  KPPType nvarchar(20) not null,
  DriveType nvarchar(20) not null,
  CallType nvarchar(20) not null,
  CallColor nvarchar(20) not null,
  Rudder nvarchar(20) not null,
  NamePacage nvarchar(20) not null,
);


create table GenerationEntity
(
  Id Int Primary key,
  NameGeneration nvarchar(22) not null,
);


create table ModelEntity
(
  Id Int Primary key,
  Название_модели nvarchar(22) not null,
);


create table MarkEntity
(
  Id Int Primary key,
  NameModelCar nvarchar(22) not null,
);


create table CarEntity
(
  Id Int Primary key,
  MarkID int,
  FOREIGN KEY (MarkID) REFERENCES MarkEntity(Id),
  ModelID int,
  FOREIGN KEY (ModelID) REFERENCES ModelEntity(Id),
  GenerationID int,
  FOREIGN KEY (GenerationID) REFERENCES GenerationEntity(Id),
  Mileage int not null,
  Price int not null,
  ReleaseYear int not null,
  PacageID int,
  FOREIGN KEY ( PacageID) REFERENCES  PacageEntity(Id),
  Picture Nvarchar(255) not null,
);
insert into CarEntity
values
(1,1,1,1,184000,2030000,2009,1,'C:\Users\Александр\Desktop\Учеба\baleva WPF\Пикчи\3series_chornijpg.jpeg'),
(2,1,1,3,84000,2500000,2012,2,'C:\Users\Александр\Desktop\Учеба\baleva WPF\Пикчи\3series_serai.jpg'),
(3,3,3,4,15000,4000000,2019,3,'C:\Users\Александр\Desktop\Учеба\baleva WPF\Пикчи\a5.jpeg'),
(4,4,4,3,44000,3420000,2016,4,'C:\Users\Александр\Desktop\Учеба\baleva WPF\Пикчи\supra.jpeg');


insert into PacageEntity
Values 
(1,'бензин','1.9',118,'МКПП','задний','Седан','Черный','левый','318iMT'),
(2,'бензин','2.2',170,'АКПП','задний','Седан','Серебристый','левый','320iAT'),
(3,'бензин','4.4',560,'робот','задний','Седан','Синий','левый','4.4 AMT'),
(4,'дизель','2.0',190,'робот','полный','Седан','Красный','левый','2.0 TDI'),
(5,'бензин','3.0',225,'МКПП','задний','Седан','Серый','Правый','3.0 SZ');


insert into GenerationEntity
values 
(1,'1'),
(2,'1 Рест'),
(3,'2'),
(4,'2 Рест'),
(5,'3'),
(6,'3 Рест'),
(7,'4'),
(8,'4 Рест'),
(9,'5'),
(10,'5 Рест');



insert into ModelEntity
values 
(1,'3-Series'),
(2,'M5'),
(3,'A5'),
(4,'Supra');

insert into MarkEntity
values 
(1,'BMW'),
(2,'BMW'),
(3,'Audi'),
(4,'Toyota');





SELECT 
    a.ID AS 'Автомобиль_ID',
    m.Название_марки AS 'Марка',
    mo.Название_модели AS 'Модель',
    p.Название_поколения AS 'Поколение',
    k.Тип_топлива,
    k.Объем_двигателя,
    k.Мощность_двигателя,
    k.Тип_КПП,
    k.Тип_привода,
    k.Тип_кузова,
    k.Цвет_кузова,
    k.Руль,
    k.Название_комплектации,
    a.Пробег,
    a.Цена,
    a.Год_выпуска,
    a.Изображение
FROM 
    Автомобиль a
INNER JOIN 
    Марка m ON a.Марка_ID = m.ID
INNER JOIN 
    Модель mo ON m.Модель_ID = mo.ID
INNER JOIN 
    Поколение p ON mo.Поколение_ID = p.ID
INNER JOIN 
    Комплектация k on a.ID = k.ID



Create table logins
(
	ID int Primary key,
	Logins nvarchar(20) not null,
	pass nvarchar(20) not null,
	roles nvarchar(20) not null
)

insert into logins
values
(1,'admin','adm','admin'),
(2,'guest','1234','guest'),
(3,'user1','bebra','user');