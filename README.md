# Testat_SAD
- - - -
# Anforderungen #
## Beschrieb ##
___(Nachfolgender Text wurde aus dem Anforderungsdokument übernommen)___

Es soll ein neues Autovermietungssystem „CarRent“ erstellt werden. Das System soll aus Server-Teilen und
optional einen Web-Client bestehen.
1. Die Daten sollen mittels «Repository Pattern» in eine Datenbank gespeichert werden können.
2. Die Business Logik soll auf dem Backend laufen und REST APIs anbieten.
3. Es soll zuerst ein Monolith erstellt werden und später auf eine Micro Service Architektur überführt
werden.

## Analyse ##
Nachfolgende Anforderungen lassen sich aus den Kundenwünschen ableiten.
Die Pflichtanforederungen und Qualitätsziele sind im vorherigen Kapitel 1:1 bereits beschrieben.

| Nr          | Role                      | Pflicht  | Anforderung               |
| ----------- | ------------------------- | -------- | ------------------------- |
| X01         | Sachbearbeiter            | JA       | Als Sachbearbeiter muss ich bei jeder Klasse eine Tagesgebühr hinterlegen können. |
| X02         | Sachbearbeiter            | JA       | Als Sachbearbeiter muss ich Kunden mit Namen oder Kundennummer suchen können. |
| X03         | Sachbearbeiter            | JA       | Als Sachbearbeiter muss ich Fahrzeuge den folgenden Typen zuordnen können: Luxusklasse, Mittelklasse, Einfachklasse.  |
| X04         | Sachbearbeiter            | JA       | Als Sachbearbeiter möchte ich Kunden mit CRUD Operationen verwalten können. Das gleiche gilt für Reservationen, Autos, etc.|
| X05         | Sachbearbeiter            | JA       | Als Sachbearbeiter müssen Reservationen, nach Abholung, den Status Vermietet erhalten. |
| X06         | System                    | JA       | Das System muss die Gesamtkosten berechnen können. |
| X07         | System                    | JA       | Jede Fahrzeug-Klasse erhält eine individuelle Tagesgebühr.  |
| X08         | Kunde                     | JA       | Als Kunde kann ich ein Fahrzeug anhand der Klasse suchen.  |
| X09         | Kunde                     | JA       | Als Kunde muss ich bei der Reservation das Start- und Enddatum angeben können. |
| X10         | Kunde                     | JA       | Als Kunde bekomme ich nach der Reservation eine Reservationsnummer.  |
| X11         | Kunde                     | NEIN     | Als Kunde sehe ich vor der Reservation die Gesamtkosten. |

## Technische Anforderungen ##
Folgende Technische Anforderugnen liessen sich ableiten:

1. Die Anwendung muss das Repository Pattern verwenden.
2. Die Anwendung wird über ein Backend laufen und via REST APIs abgefragt.
3. Initial al Monolith entworfen um diesen später in eine Micro Service Architektur zu übernehmen
4. Als Framework dient .NET


# C4 #

## Context ##

## Container ##

## Component ##

## Classes ##
Da dieser Schritt gemäss offiziellem C4-Beschrieb optional ist und die Klassen in keinem aussergewöhnlichen Verhältnis zueinander stehen, überspringe ich diese Grafik. Die Klassen können gut auch in der Solution betrachtet werden und sind klar gegliedert.

# Qualitätsanforderungen #
Die Qualitätsanforderungen aus der allgemein gültigen Grafik zu ISO25010 überschneiden sich komplett mit jenen aus diesem Projekt, weswegen ich diese driekt übernommen habe.

<img src="https://www.enzyklopaedie-der-wirtschaftsinformatik.de/wi-enzyklopaedie/Members/mikusz/QMSW.png/image_large">
Quelle: https://www.enzyklopaedie-der-wirtschaftsinformatik.de/wi-enzyklopaedie/Members/mikusz/QMSW.png/image_large

# Views #

## Logical ##

## Deployment ##

## Implementation ##

# Testing #
## UnitTests ##
Mittels Unit-Tests wird das Projekt CarRent mit Tests abgedeckt.Diese können beim Build automatisiert hinterlegt werden oder aber auch manuell gestartet und geprüft werden.
Zu finden sind diese im Projekt "UnitTest"
## Sonarcloud ##
Wie in der Anforderung beschrieben wurde Sonarcloud eingebunden um Die Qualität nachzuweisen.
