CREATE TABLE Klient
(
  ID_Klient NUMERIC identity(1,1) NOT NULL,
  Klient VARCHAR(100) NOT NULL,
  PRIMARY KEY (ID_Klient)
);

CREATE TABLE Gruz
(
  Nazvanie varchar(100) not null,
  VesT NUMERIC(2) NOT NULL,
  Opisanie VARCHAR(1000) NOT NULL,
  ID_Gruz NUMERIC identity(1,1) NOT NULL,
  PRIMARY KEY (ID_Gruz)
);

CREATE TABLE Gruzovik
(
  ID_Gruzovik NUMERIC identity(1,1) NOT NULL,
  Nomer VARCHAR(6) UNIQUE NOT NULL,
  Gruzopodemnost NUMERIC(2) NOT NULL,
  Voditel VARCHAR(100) NOT NULL,
  MarkaAvto varchar(100) not null,
  PRIMARY KEY (ID_Gruzovik)
);

CREATE TABLE Goroda
(
  ID_Gorod NUMERIC identity(1,1) NOT NULL,
  Gorod VARCHAR(100) NOT NULL,
  PRIMARY KEY (ID_Gorod)
);

CREATE TABLE Perevozki
(
  DataPostavki DATE NOT NULL,
  ID_Perevozki NUMERIC identity(1,1) NOT NULL,
  ID_Klient NUMERIC NOT NULL,
  ID_Gruz NUMERIC NOT NULL,
  ID_Gorod NUMERIC NOT NULL,
  ID_Gruzovik NUMERIC NOT NULL,
  PRIMARY KEY (ID_Perevozki),
  FOREIGN KEY (ID_Klient) REFERENCES Klient(ID_Klient),
  FOREIGN KEY (ID_Gruz) REFERENCES Gruz(ID_Gruz),
  FOREIGN KEY (ID_Gorod) REFERENCES Goroda(ID_Gorod),
  FOREIGN KEY (ID_Gruzovik) REFERENCES Gruzovik(ID_Gruzovik)
);


insert into Klient(Klient) values
('Крохалева Алена Евгеньевна'),('Сухнев Данила Андреевич')
,('Сапегин Андрей Михайлович'),('Егоров Михаил Юрьевич'),('Комиссаренко Вячеслав Станиславович');

insert into Gruzovik(Voditel,MarkaAvto,Nomer,Gruzopodemnost) values
('Поперечный Данила Юрьевич','DAF XF 105','г100аб',12),--6
('Иванов Юрий Аркадьевич','Mercedes-Benz New Actros','г101аб',10),--7
('Косач Александр Александрович','MAN TGX Euro6','г102аб',10),--8
('Киселев Александ Сергеевич','DAF XF','г103аб',5),--9
('Пунтус Сергей Андреевич','Renault T','г104аб',7);--10

insert into Gruz(Nazvanie,Opisanie,VesT) values
('Одежда','Одежда всех видов, не нуждается в особых условиях транспортировки',5),
('Строительные материалы','Строительные материалы, в основном древесина и керпичь, не нуждается в особых условиях транспортировки',10),
('Мебель','Мебель, разного вида, не нуждается в особых условиях транспортировки',7),
('Продукты питания','Продукты питания первой необходимости, нужно соблюдение норм перевозки',8);

insert into Goroda(Gorod) values
('Казань'),('Набережные Челны'),('Нижнекамск'),('Альметьевск');

insert into Perevozki(ID_Klient,ID_Gruz,ID_Gorod,ID_Gruzovik,DataPostavki) values
(1,1,1,6,'2023-04-26'),(2,2,2,7,'2023-04-26'),(3,3,3,8,'2023-04-26'),(4,4,4,7,'2023-04-30'),(1,2,3,8,'2023-04-30'),(4,3,4,7,'2023-04-30');

--drop trigger addPerevozki;

go
create trigger addPerevozki
on Perevozki 
after insert, update
as
begin
	set nocount on;
	if not exists(select * from gruz, gruzovik, inserted
	where vest <= Gruzopodemnost and inserted.ID_Gruz=Gruz.ID_Gruz and inserted.ID_Gruzovik= Gruzovik.ID_Gruzovik)
	rollback 
	print 'отказ! недостаточная грузоподъемность'
end

--insert into Perevozki(ID_Klient,ID_Gruz,ID_Gorod,ID_Gruzovik,DataPostavki) values
--(2,2,1,9,'2023-04-28');

--select * from perevozki 
--where DataPostavki = '2023-04-28';

--delete from Perevozki
--where DataPostavki = '2023-04-28';
go
create view Perevozki_info as
select DataPostavki,Nazvanie, Klient, Gorod, Voditel,Nomer from Goroda,Gruz,Gruzovik,Perevozki,Klient
where Perevozki.ID_Gorod= Goroda.ID_Gorod and Perevozki.ID_Gruz=Gruz.ID_Gruz
and Perevozki.ID_Gruzovik = Gruzovik.ID_Gruzovik and  Perevozki.ID_Klient = klient.ID_Klient;
go

go
create view most_pop_tovar as
select nazvanie, count(*) cnt from gruz,perevozki
where perevozki.id_gruz = gruz.id_gruz
group by nazvanie
go

go
create view most_pop_city as
select Gorod,count(*) cnt from Goroda,Perevozki
where Goroda.ID_Gorod = Perevozki.ID_Gorod
group by Gorod
go

go 
create view most_work_voditel as
select Voditel, count(*) cnt from Gruzovik, Perevozki
where Perevozki.ID_Gruzovik = Gruzovik.ID_Gruzovik
group by Voditel
go