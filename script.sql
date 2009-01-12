/* --- set up database --- */
use master
set dateformat dmy

if exists(select name from sysdatabases where name = 'de2_uebung_fahrradkurier')
begin
drop database de2_uebung_fahrradkurier
end

create database de2_uebung_fahrradkurier
go
use de2_uebung_fahrradkurier




/* --- create tables --- */
if exists(select name from sysobjects where Name = 'Personen')
begin
Drop Table Personen
end

if exists(select name from sysobjects where Name = 'Fahrer')
begin
Drop Table Fahrer
end

if exists(select name from sysobjects where Name = 'Kunden')
begin
Drop Table Kunden
end

if exists(select name from sysobjects where Name = 'Adressen')
begin
Drop Table Adressen
end

if exists(select name from sysobjects where Name = 'Person_Adresse')
begin
Drop Table Person_Adresse
end

if exists(select name from sysobjects where Name = 'Orte')
begin
Drop Table Orte
end

if exists(select name from sysobjects where Name = 'Bereitschaftszeiten')
begin
Drop Table Bereitschaftszeiten
end

if exists(select name from sysobjects where Name = 'Auftraege')
begin
Drop Table Auftraege
end

if exists(select name from sysobjects where Name = 'Auftrag_Adresse')
begin
Drop Table Auftrag_Adresse
end

if exists(select name from sysobjects where Name = 'Status')
begin
Drop Table Status
end

if exists(select name from sysobjects where Name = 'Pakete')
begin
Drop Table Pakete
end

if exists(select name from sysobjects where Name = 'AuftragProtokoll')
begin
Drop Table AuftragProtokoll
end




/* --- creates --- */
create table Personen (
	Person_ID int not null identity(1,1),
	Anrede varchar(20) not null,
	Vorname nvarchar(30) not null,
	Nachname nvarchar(30) not null,
	Telefonnummer varchar(20) not null,
	EMail varchar(40) null
)

create table Fahrer (
	Fahrer_ID int not null identity(1000,1),
	Person_ID int not null,
	Foto image null,
	Geburtsdatum DateTime not null,
	SVNummer int not null,
	PassNummer int not null
)

create table Kunden (
	Kunde_ID int not null identity(1000,1),
	Person_ID int not null,
	Firma nvarchar(50) null,
	KreditkartenNummer varchar(30) null,
	KreditkartenPZ varchar(4) null,
	PremiumKunde bit default(0) not null
)

create table Status (
	Status_ID int not null identity(1,1),
	Statustitel varchar(20) not null
)

create table Auftraege (
	Auftrag_ID int not null identity(10000,2),
	Fahrer_ID int not null,
	Kunde_ID int not null,
	Status_ID int not null,
	Kilometer decimal(10,2) not null,
	Datum DateTime not null,
	Gesamtgewicht decimal(10,2) null,
	Startzeit DateTime not null,
	Endzeit DateTime not null,
	Dauer as DateDiff(minute, Startzeit, Endzeit)
)

create table Bereitschaftszeiten (
	Bereitschaftszeit_ID int not null identity(1,1),
	Fahrer_ID int not null,
	Datum DateTime not null,
	Startzeit DateTime not null,
	Endzeit DateTime not null
)

create table Orte (
	Ort_ID int not null identity(1,1),
	Ortsname nvarchar(60) not null,
	PLZ int not null,
	Land nvarchar(30) not null
)

create table Adressen (
	Adresse_ID int not null identity(1,1),
	Ort_ID int not null,
	Strasse nvarchar(50) not null	
)

create table Pakete (
	Paket_ID int not null identity(1,1),
	Auftrag_ID int not null,
	Titel varchar(40) not null,
	Hoehe decimal(10,2) not null,
	Breite decimal(10,2) not null,
	Tiefe decimal(10,2) not null,
	Gewicht decimal(10,2) not null,
	Fragile bit default(0) not null
)

create table Person_Adresse (
	PA_ID int not null identity(1,1),
	Person_ID int not null,
	Adresse_ID int not null
)

create table Auftrag_Adresse (
	AA_ID int not null identity(1,1),
	Auftrag_ID int not null,
	Adresse_ID int not null
)

create table AuftragProtokoll(
	Protokoll_ID int not null primary key identity(1,1),
	Auftrag_ID int not null,
	Datum datetime default (getdate()),
	Fahrer varchar(30) not null,
	Kunde varchar(30) not null,
	Aktion varchar(80) not null,
)




/* --- constraints --- */
alter table Personen
add
constraint Person_PK primary key(Person_ID),
constraint Person_Check_EMail check (EMail like '%@%.%'),
constraint Person_Check_Tel1 check (Telefonnummer not like '[a-z]'),
constraint Person_Check_Tel2 check (Telefonnummer not like '[A-Z]'),
constraint Person_Check_Tel3 check (Telefonnummer not like '[äöüÄÖÜß!"§$%&\()=?\{\}\[\]\,;.:<>|*+@~#´`]')

alter table Fahrer
add
constraint Fahrer_PK primary key(Fahrer_ID),
constraint Fahrer_Person_FK foreign key(Person_ID) references Personen(Person_ID)

alter table Kunden
add
constraint Kunde_PK primary key(Kunde_ID),
constraint Kunde_Person_FK foreign key(Person_ID) references Personen(Person_ID),
constraint Kunde_Check_KKNummer check (KreditkartenNummer like '%[0123456789]'),
constraint Kunde_Check_KKNummer_Length check (len (KreditkartenNummer) = 15 OR len(KreditkartenNummer) = 16),
constraint Kunde_Check_KKPZ check (KreditkartenPZ like '%[0123456789]'),
constraint Kunde_Check_KKPZ_Length check (len (KreditkartenPZ) = 3 OR len(KreditkartenPZ) = 4)

alter table Status
add
constraint Status_PK primary key(Status_ID)

alter table Auftraege
add
constraint Auftrag_PK primary key(Auftrag_ID),
constraint Auftrag_Fahrer_FK foreign key(Fahrer_ID) references Fahrer(Fahrer_ID),
constraint Auftrag_Kunde_FK foreign key(Kunde_ID) references Kunden(Kunde_ID),
constraint Auftrag_Status_FK foreign key(Status_ID) references Status(Status_ID)

alter table Bereitschaftszeiten
add
constraint Bereitschaftszeit_PK primary key(Bereitschaftszeit_ID),
constraint Bereitschaftszeit_Fahrer_FK foreign key(Fahrer_ID) references Fahrer(Fahrer_ID)

alter table Orte
add
constraint Ort_PK primary key(Ort_ID)

alter table Adressen
add
constraint Adresse_PK primary key(Adresse_ID),
constraint Ort_FK foreign key(Ort_ID) references Orte(Ort_ID)

alter table Pakete
add
constraint Paket_PK primary key(Paket_ID),
constraint Paket_Auftrag_FK foreign key(Auftrag_ID) references Auftraege(Auftrag_ID)

alter table Person_Adresse
add
constraint PA_PK primary key(PA_ID),
constraint PA_Person_FK foreign key(Person_ID) references Personen(Person_ID),
constraint PA_Adresse_FK foreign key(Adresse_ID) references Adressen(Adresse_ID)

alter table Auftrag_Adresse
add
constraint AA_PK primary key(AA_ID),
constraint AA_Auftrag_FK foreign key(Auftrag_ID) references Auftraege(Auftrag_ID),
constraint AA_Adresse_FK foreign key(Adresse_ID) references Adressen(Adresse_ID)

/* --- indizes --- */
create index Adressen_Strasse on Adressen(Strasse)
create index Kunden_Firma on Kunden(Firma)
create index Paket_Titel on Pakete(Titel)
create index Person_Nachname on Personen(Nachname)
create index Orte_Ortsname on Orte(Ortsname)



/* --- trigger --- */

go

/* Gesamtgewichtberechnung */
create trigger AuftragGesamtgewicht
on Pakete
for insert, delete, update as
update Auftraege
set Gesamtgewicht =
	(select sum(Pakete.Gewicht)
		from Pakete
		inner join inserted on Pakete.Auftrag_ID = inserted.Auftrag_ID)

go


/* Protokoll Insert */
create trigger AuftragInsert
on Auftraege
for insert as
insert into AuftragProtokoll(Auftrag_ID, Fahrer, Kunde, Aktion)
select
	i.Auftrag_ID,
	fp.Vorname + ' ' + fp.Nachname,
	kp.Vorname + ' ' + kp.Nachname,
	'INSERT'
from inserted i
	inner join Fahrer f on i.Fahrer_ID = f.Fahrer_ID
	inner join Kunden k on i.Kunde_ID = k.Kunde_ID
	inner join Personen fp on fp.Person_ID = f.Person_ID
	inner join Personen kp on kp.Person_ID = k.Person_ID


go

/* Protokoll Delete */
create trigger AuftragDelete
on Auftraege
for delete as
insert into AuftragProtokoll(Auftrag_ID, Fahrer, Kunde, Aktion)
select
	d.Auftrag_ID,
	fp.Vorname + ' ' + fp.Nachname,
	kp.Vorname + ' ' + kp.Nachname,
	'DELETE'
from deleted d
	inner join Fahrer f on d.Fahrer_ID = f.Fahrer_ID
	inner join Kunden k on d.Kunde_ID = k.Kunde_ID
	inner join Personen fp on fp.Person_ID = f.Person_ID
	inner join Personen kp on kp.Person_ID = k.Person_ID

go

/* Protokoll Update Auftraege */
create trigger AuftragUpdate
on Auftraege
for update as
if update(Gesamtgewicht)
begin
	insert into AuftragProtokoll(Auftrag_ID, Fahrer, Kunde, Aktion)
	select
		i.Auftrag_ID,
		fp.Vorname + ' ' + fp.Nachname,
		kp.Vorname + ' ' + kp.Nachname,
		'UPDATE Gesamtgewicht: ' + convert(varchar, isnull(d.Gesamtgewicht,0)) + ' -> ' + convert(varchar, isnull(i.Gesamtgewicht,0))
	from inserted i
	inner join deleted d on i.Auftrag_ID = d.Auftrag_ID
	inner join Fahrer f on i.Fahrer_ID = f.Fahrer_ID
	inner join Kunden k on i.Kunde_ID = k.Kunde_ID
	inner join Personen fp on fp.Person_ID = f.Person_ID
	inner join Personen kp on kp.Person_ID = k.Person_ID
end
if update(Status_ID)
begin
	insert into AuftragProtokoll(Auftrag_ID, Fahrer, Kunde, Aktion)
	select
		i.Auftrag_ID,
		fp.Vorname + ' ' + fp.Nachname,
		kp.Vorname + ' ' + kp.Nachname,
		'UPDATE Status: ' + os.Statustitel + ' -> ' + ns.Statustitel
	from inserted i
	inner join deleted d on i.Auftrag_ID = d.Auftrag_ID
	inner join Status os on d.Status_ID = os.Status_ID
	inner join Status ns on i.Status_ID = ns.Status_ID
	inner join Fahrer f on i.Fahrer_ID = f.Fahrer_ID
	inner join Kunden k on i.Kunde_ID = k.Kunde_ID
	inner join Personen fp on fp.Person_ID = f.Person_ID
	inner join Personen kp on kp.Person_ID = k.Person_ID
end
if not update(Gesamtgewicht) and not update (Status_ID)
begin
	insert into AuftragProtokoll(Auftrag_ID, Fahrer, Kunde, Aktion)
	select
		i.Auftrag_ID,
		fp.Vorname + ' ' + fp.Nachname,
		kp.Vorname + ' ' + kp.Nachname,
		'UPDATE Auftrag (ID ' + convert(varchar, isnull(i.Auftrag_ID,0)) + ')'
	from inserted i
	inner join deleted d on i.Auftrag_ID = d.Auftrag_ID
	inner join Fahrer f on i.Fahrer_ID = f.Fahrer_ID
	inner join Kunden k on i.Kunde_ID = k.Kunde_ID
	inner join Personen fp on fp.Person_ID = f.Person_ID
	inner join Personen kp on kp.Person_ID = k.Person_ID
end

/* Protokoll Update Gesamtgewicht */
/* create trigger AuftragUpdateGesamtgewicht
on Auftraege
for update as
if update(Gesamtgewicht)
begin
insert into AuftragProtokoll(Auftrag_ID, Fahrer, Kunde, Aktion)
select
	i.Auftrag_ID,
	fp.Vorname + ' ' + fp.Nachname,
	kp.Vorname + ' ' + kp.Nachname,
	'UPDATE Gesamtgewicht: ' + convert(varchar, isnull(d.Gesamtgewicht,0)) + ' -> ' + convert(varchar, isnull(i.Gesamtgewicht,0))
from inserted i
inner join deleted d on i.Auftrag_ID = d.Auftrag_ID
inner join Fahrer f on i.Fahrer_ID = f.Fahrer_ID
inner join Kunden k on i.Kunde_ID = k.Kunde_ID
inner join Personen fp on fp.Person_ID = f.Person_ID
inner join Personen kp on kp.Person_ID = k.Person_ID
end */

/*create proc AuftragUebersicht @s int
as
select
	fp.Vorname + ' ' + fp.Nachname as Fahrer,
	kp.Vorname + ' ' + kp.Nachname as Kunde,
    s.Statustitel,
	a.Kilometer,
	a.Datum,
    a.Gesamtgewicht,
	a.Startzeit,
	a.Endzeit
from Auftraege a
inner join Fahrer f on a.Fahrer_ID = f.Fahrer_ID
inner join Kunden k on a.Kunde_ID = k.Kunde_ID
inner join Personen fp on fp.Person_ID = f.Person_ID
inner join Personen kp on kp.Person_ID = k.Person_ID
inner join Status s on s.Status_ID = a.Status_ID
where a.Status_ID = @s*/



/*select f.fahrer_ID as 'ID Fahrer', year(a.datum) as 'Jahr', month(a.datum) as 'Monat', p.nachname as 'Name', p.Vorname as 'Vorname', 
-- sum(datediff(hour ,b.startzeit, b.endzeit)) as Bereitschaftszeit, 
-- sum(gesamtgewicht) as Kilo, sum(kilometer) as Gesamtfahrstrecke, 
((sum(kilometer) * sum(gesamtgewicht) * 0.4) + (sum(datediff(hour ,b.startzeit, b.endzeit))*20)) as Lohn
--sum(datediff(hour ,b.startzeit, b.endzeit))*20 as Betrag
from bereitschaftszeiten as b
inner join fahrer as f on b.fahrer_ID = f.fahrer_ID
inner join personen as p on p.person_ID = f.person_ID
inner join auftraege as a on a.fahrer_ID = f.fahrer_ID
group by year(a.datum),month(a.datum) ,p.nachname, p.Vorname, f.fahrer_ID*/

/*select sum(kilometer) * sum(gesamtgewicht)/100 * 0.4 from auftraege
where fahrer_ID = 1001*/

create view FahrerAnzeigen as
select
	p.Anrede,
	p.Vorname,
	p.Nachname,
	p.Telefonnummer,
	p.Email,
	a.Strasse,
	o.PLZ,
	o.Ortsname as Ort,
	o.Land,
	f.Geburtsdatum,
	f.SVNummer,
	f.Passnummer
from fahrer f
inner join personen p on p.person_ID = f.person_ID
inner join person_adresse pa on p.person_id = pa.person_id
inner join adressen a on a.adresse_id = pa.adresse_id
inner join orte o on a.ort_id = o.ort_id

create view KundenAnzeigen as
select
	p.Anrede,
	p.Vorname,
	p.Nachname,
	p.Telefonnummer,
	p.Email,
	a.Strasse,
	o.PLZ,
	o.Ortsname as Ort,
	o.Land,
	k.Firma,
	k.KreditkartenNummer,
	k.KreditkartenPZ,
	k.Premiumkunde
from kunden k
inner join personen p on p.person_ID = k.person_ID
inner join person_adresse pa on p.person_id = pa.person_id
inner join adressen a on a.adresse_id = pa.adresse_id
inner join orte o on a.ort_id = o.ort_id



/*Diese Abfrage liefert die Anzahl und die Statusanzeige der Aufträge */
create view StatusUebersicht as
select statustitel as Status, count(auftrag_ID) as Anzahl from Auftraege as a
inner join kunden as k on a.kunde_ID = k.kunde_ID
inner join status as s on a.status_ID = s.status_ID
group by  statustitel


/*Ausgabe der Ist-Einsatzistzeit eines Fahrers zur weiteren Verrechnung*/
create view IstEinsatzzeit as
select f.fahrer_ID as 'ID Fahrer', year(datum) as 'Jahr' ,month(datum) as 'Monat' ,
p.nachname as 'Name', p.Vorname as 'Vorname', 
sum(datediff(hour ,b.startzeit, b.endzeit)) as 'Istzeit in h/Monat' 
from bereitschaftszeiten as b
inner join fahrer as f on b.fahrer_ID = f.fahrer_ID
inner join personen as p on p.person_ID = f.person_ID
group by year(datum),month(datum) ,p.nachname, p.Vorname, f.fahrer_ID


create view Lohnhilfe as 
select a.fahrer_ID as Fahrer_ID, p.Vorname, p.Nachname, year(a.datum) as Jahr, month(a.datum) as Monat,
sum(datediff(hour ,b.startzeit, b.endzeit)) as Bereitschaftszeit, 
sum(gesamtgewicht)/1000 as Kilo, 
sum(kilometer) as Gesamtfahrstrecke
from bereitschaftszeiten as b
inner join auftraege as a on a.fahrer_ID = b.fahrer_ID
inner join fahrer as f on a.fahrer_ID = f.fahrer_ID
inner join personen as p on f.person_ID = p.person_ID
where b.datum <= a.datum and b.datum >= a.datum
-- Transportzeit + Triger überprüfen
group by year(a.datum),month(a.datum), a.fahrer_ID, p.Vorname, p.Nachname

create view Lohn as
select Fahrer_ID, Vorname, Nachname, Jahr, Monat,
sum((Gesamtfahrstrecke * Kilo * 0.1) + (Bereitschaftszeit*20)) as Lohn
from Lohnhilfe
group by Jahr, Monat, Fahrer_ID, Vorname, Nachname

create view AuftragUebersicht as
select
	fp.Vorname + ' ' + fp.Nachname as Fahrer,
	kp.Vorname + ' ' + kp.Nachname as Kunde,
    a.Status_ID,
	s.Statustitel as Status,
	a.Kilometer,
	a.Datum,
    a.Gesamtgewicht,
	a.Startzeit,
	a.Endzeit
from Auftraege a
inner join Fahrer f on a.Fahrer_ID = f.Fahrer_ID
inner join Kunden k on a.Kunde_ID = k.Kunde_ID
inner join Personen fp on fp.Person_ID = f.Person_ID
inner join Personen kp on kp.Person_ID = k.Person_ID
inner join Status s on s.Status_ID = a.Status_ID

create view UmsatzProKunde as
select a.kunde_ID as Kunde_ID, p.Vorname, p.Nachname,
sum((Gesamtgewicht/1000) * Kilometer * 0.5) as Umsatz
from auftraege a
inner join kunden as k on k.kunde_ID = a.kunde_ID
inner join personen as p on k.person_ID = p.person_ID
group by a.Kunde_ID, p.Vorname, p.Nachname

--

create proc AuftragNachStatusID @s int as
select * from AuftragUebersicht
where Status_ID = @s

create proc NeuerFahrer
	@Anrede varchar(20),
	@Vorname nvarchar(30),
	@Nachname nvarchar(30),
	@Telefonnummer varchar(20), 
	@EMail varchar(40),
	@Strasse nvarchar(50),
	@PLZ int,
	@Ort nvarchar(60),
	@Land nvarchar(30),
	@Geburtsdatum datetime,
	@SVNummer int,
	@PassNummer int
as
begin
	declare @Ort_ID as int
	declare @Adresse_ID as int
	declare @Person_ID as int
	declare @Fahrer_ID as int

	declare @OrtTmp as int
	select @OrtTmp = (select Count(Ort_ID) from Orte where Ortsname=@Ort and PLZ=@PLZ and Land=@Land)

	if (@OrtTmp = 1)
		begin
			select @Ort_ID = (select Ort_ID from Orte where Ortsname=@Ort and PLZ=@PLZ and Land=@Land)
		end
	else
		begin
			insert into Orte(Ortsname, PLZ, Land) values (@Ort, @PLZ, @Land)
			select @Ort_ID = @@identity
		end

	declare @AdresseTmp as int
	select @AdresseTmp = (select Count(Adresse_ID) from Adressen where Strasse=@Strasse and Ort_ID=@Ort_ID)

	if (@AdresseTmp = 1)
		begin
			select @Adresse_ID = (select Adresse_ID from Adressen where Strasse=@Strasse and Ort_ID=@Ort_ID)
		end
	else
		begin
			insert into Adressen(Strasse, Ort_ID) values (@Strasse, @Ort_ID)
			select @Adresse_ID = @@identity
		end

	insert into Personen(Anrede, Vorname, Nachname, Telefonnummer, EMail)
		values(@Anrede, @Vorname, @Nachname, @Telefonnummer, @EMail)
	
	select @Person_ID = @@identity

	insert into Person_Adresse(Person_ID, Adresse_ID) values (@Person_ID, @Adresse_ID)

	insert into Fahrer(Person_ID, Geburtsdatum, SVNummer, PassNummer)
		values(@Person_ID, @Geburtsdatum, @SVNummer, @PassNummer)

	select @Fahrer_ID = @@identity
end

create proc NeuerKunde
	@Anrede varchar(20),
	@Vorname nvarchar(30),
	@Nachname nvarchar(30),
	@Telefonnummer varchar(20), 
	@EMail varchar(40),
	@Strasse nvarchar(50),
	@PLZ int,
	@Ort nvarchar(60),
	@Land nvarchar(30),
	@Firma nvarchar(50),
	@KreditkartenNummer varchar(30),
	@KreditkartenPZ varchar(4),
	@PremiumKunde bit	
as
begin
	declare @Ort_ID as int
	declare @Adresse_ID as int
	declare @Person_ID as int
	declare @Kunde_ID as int

	declare @OrtTmp as int
	select @OrtTmp = (select Count(Ort_ID) from Orte where Ortsname=@Ort and PLZ=@PLZ and Land=@Land)

	if (@OrtTmp = 1)
		begin
			select @Ort_ID = (select Ort_ID from Orte where Ortsname=@Ort and PLZ=@PLZ and Land=@Land)
		end
	else
		begin
			insert into Orte(Ortsname, PLZ, Land) values (@Ort, @PLZ, @Land)
			select @Ort_ID = @@identity
		end

	declare @AdresseTmp as int
	select @AdresseTmp = (select Count(Adresse_ID) from Adressen where Strasse=@Strasse and Ort_ID=@Ort_ID)

	if (@AdresseTmp = 1)
		begin
			select @Adresse_ID = (select Adresse_ID from Adressen where Strasse=@Strasse and Ort_ID=@Ort_ID)
		end
	else
		begin
			insert into Adressen(Strasse, Ort_ID) values (@Strasse, @Ort_ID)
			select @Adresse_ID = @@identity
		end

	insert into Personen(Anrede, Vorname, Nachname, Telefonnummer, EMail)
		values(@Anrede, @Vorname, @Nachname, @Telefonnummer, @EMail)
	
	select @Person_ID = @@identity

	insert into Person_Adresse(Person_ID, Adresse_ID) values (@Person_ID, @Adresse_ID)

	insert into Kunden(Person_ID, Firma, KreditkartenNummer, KreditkartenPZ, PremiumKunde)
		values(@Person_ID, @Firma, @KreditkartenNummer, @KreditkartenPZ, @PremiumKunde)

	select @Fahrer_ID = @@identity
end









select * from StatusUebersicht
select * from IstEinsatzzeit
select * from Lohnhilfe
select * from Lohn
select * from AuftragUebersicht
select * from UmsatzProKunde
select * from KundenAnzeigen
select * from FahrerAnzeigen

select *  from adressen
select * from orte

AuftragNachStatusID 2
AuftragNachStatusName Offen

select * from auftraege
select * from bereitschaftszeiten
select * from fahrer

select sum(gesamtgewicht)/1000 as Kilo from auftraege
group by fahrer_ID





((sum(kilometer) * sum(gesamtgewicht) * 0.4) + (sum(datediff(hour ,b.startzeit, b.endzeit))*20)) as Lohn