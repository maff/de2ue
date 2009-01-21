use de2_uebung_fahrradkurier;


/*Diese Abfrage liefert die Anzahl und die Statusanzeige der Aufträge */
select  statustitel as Status, count(auftrag_ID) as Anzahl   from auftraege as a
inner join kunden as k on a.kunde_ID = k.kunde_ID
inner join status as s on a.status_ID = s.status_ID
group by  statustitel
order by statustitel


select f.fahrer_ID as 'ID Fahrer', year(a.datum) as 'Jahr' ,month(a.datum) as 'Monat' ,
p.nachname as 'Name', p.Vorname as 'Vorname', 
-- sum(datediff(hour ,b.startzeit, b.endzeit)) as Bereitschaftszeit, 
-- sum(gesamtgewicht) as Kilo, sum(kilometer) as Gesamtfahrstrecke, 
((sum(kilometer) * sum(gesamtgewicht) * 0.4) + (sum(datediff(hour ,b.startzeit, b.endzeit))*20)) as Lohn
--sum(datediff(hour ,b.startzeit, b.endzeit))*20 as Betrag
from bereitschaftszeiten as b
inner join fahrer as f on b.fahrer_ID = f.fahrer_ID
inner join personen as p on p.person_ID = f.person_ID
inner join auftraege as a on a.fahrer_ID = f.fahrer_ID
group by year(a.datum),month(a.datum) ,p.nachname, p.Vorname, f.fahrer_ID


select sum(kilometer) * sum(gesamtgewicht)/100 * 0.4 from auftraege
where fahrer_ID = 1001


/*Ausgabe der Ist-Einsatzistzeit eines Fahrers zur weiteren Verrechnung*/
select f.fahrer_ID as 'ID Fahrer', year(datum) as 'Jahr' ,month(datum) as 'Monat' ,
p.nachname as 'Name', p.Vorname as 'Vorname', 
sum(datediff(hour ,b.startzeit, b.endzeit)) as 'Istzeit in h/Monat' 
from bereitschaftszeiten as b
inner join fahrer as f on b.fahrer_ID = f.fahrer_ID
inner join personen as p on p.person_ID = f.person_ID
group by year(datum),month(datum) ,p.nachname, p.Vorname, f.fahrer_ID




sp_who





alter view Lohnhilfe as 
select a.fahrer_ID as Fahrer_ID, year(a.datum) as Jahr ,month(a.datum) as Monat ,

sum(datediff(hour ,b.startzeit, b.endzeit)) as Bereitschaftszeit, 
sum(gesamtgewicht)/1000 as Kilo, 
sum(kilometer) as Gesamtfahrstrecke
from bereitschaftszeiten as b

inner join auftraege as a on a.fahrer_ID = b.fahrer_ID
where b.datum <= a.datum and b.datum >= a.datum
-- Transportzeit + Triger überprüfen
group by year(a.datum),month(a.datum), a.fahrer_ID


select fahrer_ID, Jahr, Monat, Nachname, Vorname, Bereitschaftszeit, Kilo, Gesamtfahrstrecke,
(Gesamtfahrstrecke * Kilo * 0.4) + (Bereitschaftszeit*20) as Lohn
from Lohnhilfe
group by 


select * from Lohnhilfe

select * from auftraege

select sum(gesamtgewicht)/1000 as Kilo from auftraege
group by fahrer_ID





((sum(kilometer) * sum(gesamtgewicht) * 0.4) + (sum(datediff(hour ,b.startzeit, b.endzeit))*20)) as Lohn