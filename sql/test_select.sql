use de2_uebung_fahrradkurier

update Auftraege set kilometer=27.0 where Auftrag_ID=10000


/* --- selects --- */

select * from Auftrag_Adresse
select * from Pakete
select * from AuftragProtokoll order by Auftrag_ID
select * from Auftraege
select * from Fahrer
select * from Status



create proc AuftragUebersicht @s int
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
where a.Status_ID = @s

AuftragUebersicht 1
AuftragUebersicht 2
AuftragUebersicht 3