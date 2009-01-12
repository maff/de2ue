use de2_uebung_fahrradkurier

/* inserts 1 */

declare @person as int
declare @fahrer as int
declare @kunde as int
declare @auftrag as int
declare @adresse as int

/* Fahrer */
insert into Personen
(Anrede, Vorname, Nachname, Telefonnummer, EMail)
values
('Herr', 'Max', 'Mustermann', '+43 650 123 456', 'max@example.com')

select @person=@@identity

insert into Fahrer
(Person_ID, Geburtsdatum, SVNummer, Passnummer)
values
(@person, '1972-03-11', 1212434, 3242424)

select @fahrer=@@identity

insert into Orte
(Ortsname, PLZ, Land)
values
('Kitzbühel', 6440, 'Austria')

insert into Adressen
(Ort_ID, Strasse)
values
(@@identity, 'Museumstrasse 10')

insert into Person_Adresse
(Person_ID, Adresse_ID)
values
(@person, @@identity)

/* Kunde */
insert into Personen
(Anrede, Vorname, Nachname, Telefonnummer, EMail)
values
('Frau', 'Susi', 'Sorglos', '+43 650 654 321', 'susi@example.com')

select @person=@@identity

insert into Kunden
(Person_ID, KreditkartenNummer, KreditkartenPZ, Premiumkunde)
values
(@person, 1234567891234567, 5471, 0)

select @kunde=@@identity

insert into Orte
(Ortsname, PLZ, Land)
values
('Innsbruck', 6020, 'Austria')

insert into Adressen
(Ort_ID, Strasse)
values
(@@identity, 'Bürgerstrasse 7')

insert into Person_Adresse
(Person_ID, Adresse_ID)
values
(@person, @@identity)

insert into Status
(Statustitel)
values
('In Bearbeitung')

insert into Status
(Statustitel)
values
('Offen')

begin transaction
insert into Auftraege with(tablockx)
(Fahrer_ID, Kunde_ID, Status_ID, Kilometer, Datum, Startzeit, Endzeit)
values
(@fahrer, @kunde, @@identity, 24, '24-12-2008', '24-12-2008 15:00', '24-12-2008 17:00')

select @auftrag=(select max(Auftrag_ID) from Auftraege with(tablockx))
commit

insert into Orte
(Ortsname, PLZ, Land)
values
('Völs', 6176, 'Austria')

insert into Adressen
(Ort_ID, Strasse)
values
(@@identity, 'Maximilianstraße 8')

insert into Auftrag_Adresse
(Auftrag_ID, Adresse_ID)
values
(@auftrag, @@identity)

insert into Pakete
(Auftrag_ID, Titel, Hoehe, Breite, Tiefe, Gewicht, Fragile)
values
(@auftrag, 'Lego Technics', 10, 12, 5, 750, 0)

insert into Pakete
(Auftrag_ID, Titel, Hoehe, Breite, Tiefe, Gewicht, Fragile)
values
(@auftrag, 'Vase', 25, 10, 10, 1000, 1)

insert into Pakete
(Auftrag_ID, Titel, Hoehe, Breite, Tiefe, Gewicht, Fragile)
values
(@auftrag, 'Laptop', 5, 45, 30, 3000, 1)




/* inserts 2 */

declare @person1 as int
declare @fahrer1 as int
declare @kunde1 as int
declare @auftrag1 as int
declare @adresse1 as int


/* Fahrer */
insert into Personen
(Anrede, Vorname, Nachname, Telefonnummer, EMail)
values
('Frau', 'Anna', 'Huber', '+43 650 654 321', 'anna@example.com')

select @person1=@@identity

insert into Fahrer
(Person_ID, Geburtsdatum, SVNummer, Passnummer)
values
(@person1, '1985-28-09', 343434, 34343434)

select @fahrer1=@@identity

insert into Orte
(Ortsname, PLZ, Land)
values
('Seefeld', 6222, 'Austria')

insert into Adressen
(Ort_ID, Strasse)
values
(@@identity, 'Kohlweg 3')

insert into Person_Adresse
(Person_ID, Adresse_ID)
values
(@person1, @@identity)

/* Kunde */
insert into Personen
(Anrede, Vorname, Nachname, Telefonnummer, EMail)
values
('Herr', 'Christian', 'Morgenstern', '+43 664 654 321', 'christian@example.com')

select @person1=@@identity

insert into Kunden
(Person_ID, KreditkartenNummer, KreditkartenPZ, Premiumkunde)
values
(@person1, 1234567891234567, 5532, 1)

select @kunde1=@@identity

insert into Orte
(Ortsname, PLZ, Land)
values
('Völs', 6176, 'Austria')

insert into Adressen
(Ort_ID, Strasse)
values
(@@identity, 'Bahnhofsstraße 32')

insert into Person_Adresse
(Person_ID, Adresse_ID)
values
(@person1, @@identity)

insert into Status
(Statustitel)
values
('Erledigt')

begin transaction
insert into Auftraege with(tablockx)
(Fahrer_ID, Kunde_ID, Status_ID, Kilometer, Datum, Startzeit, Endzeit)
values
(@fahrer1, @kunde1, @@identity, 24, '12-09-2008', '12-09-2008 15:00', '12-09-2008 16:00')

select @auftrag1=(select max(Auftrag_ID) from Auftraege with(tablockx))
commit

insert into Orte
(Ortsname, PLZ, Land)
values
('Telfs', 6820, 'Austria')

insert into Adressen
(Ort_ID, Strasse)
values
(@@identity, 'Müllerstraße 7')

insert into Auftrag_Adresse
(Auftrag_ID, Adresse_ID)
values
(@auftrag1, @@identity)

insert into Pakete
(Auftrag_ID, Titel, Hoehe, Breite, Tiefe, Gewicht, Fragile)
values
(@auftrag1, 'Dell Inspirion 1720', 5, 40, 30, 3250, 1)

insert into Pakete
(Auftrag_ID, Titel, Hoehe, Breite, Tiefe, Gewicht, Fragile)
values
(@auftrag1, 'HP 2408h', 45, 110, 35, 14000, 1)

insert into Pakete
(Auftrag_ID, Titel, Hoehe, Breite, Tiefe, Gewicht, Fragile)
values
(@auftrag1, 'Dan Brown Illuminati Taschenbuch', 25, 15, 5, 200, 0)

















insert into Bereitschaftszeiten
(Fahrer_ID, Datum, Startzeit, Endzeit)
values
(1000, '24-12-2008', '24-12-2008 08:00', '24-12-2008 13:00')

insert into Bereitschaftszeiten
(Fahrer_ID, Datum, Startzeit, Endzeit)
values
(1000, '24-12-2008', '24-12-2008 15:00', '24-12-2008 20:00')

insert into Bereitschaftszeiten
(Fahrer_ID, Datum, Startzeit, Endzeit)
values
(1000, '25-12-2008', '25-12-2008 08:00', '25-12-2008 13:00')

insert into Bereitschaftszeiten
(Fahrer_ID, Datum, Startzeit, Endzeit)
values
(1000, '25-12-2008', '25-12-2008 15:00', '25-12-2008 20:00')




insert into Bereitschaftszeiten
(Fahrer_ID, Datum, Startzeit, Endzeit)
values
(1001, '12-09-2008', '12-09-2008 08:00', '12-09-2008 12:00')

insert into Bereitschaftszeiten
(Fahrer_ID, Datum, Startzeit, Endzeit)
values
(1001, '12-09-2008', '12-09-2008 13:30', '12-09-2008 18:00')

insert into Bereitschaftszeiten
(Fahrer_ID, Datum, Startzeit, Endzeit)
values
(1001, '14-09-2008', '14-09-2008 08:00', '14-09-2008 12:00')

insert into Bereitschaftszeiten
(Fahrer_ID, Datum, Startzeit, Endzeit)
values
(1001, '14-09-2008', '14-09-2008 13:30', '14-09-2008 18:00')

select * from bereitschaftszeiten