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
![Context](https://user-images.githubusercontent.com/12933374/132244965-d481cb38-ea28-4376-b9a7-cf9489c21cec.PNG)

## Container ##
![Container](https://user-images.githubusercontent.com/12933374/132245033-330165ce-237d-42b6-aed5-8d25d0c572fa.PNG)

## Component ##
![Component](https://user-images.githubusercontent.com/12933374/132245039-421a2289-9540-4e33-bb1c-54f9e893ff87.jpg)

## Classes ##
Da dieser Schritt gemäss offiziellem C4-Beschrieb optional ist und die Klassen in keinem aussergewöhnlichen Verhältnis zueinander stehen, überspringe ich diese Grafik. Die Klassen können gut auch in der Solution betrachtet werden und sind klar gegliedert.

# Qualitätsanforderungen #
Die Qualitätsanforderungen aus der allgemein gültigen Grafik zu ISO25010 überschneiden sich komplett mit jenen aus diesem Projekt, weswegen ich diese driekt übernommen habe.

<img src="https://www.enzyklopaedie-der-wirtschaftsinformatik.de/wi-enzyklopaedie/Members/mikusz/QMSW.png/image_large">
Quelle: https://www.enzyklopaedie-der-wirtschaftsinformatik.de/wi-enzyklopaedie/Members/mikusz/QMSW.png/image_large

# Views #

## Logical ##
![Kunde](https://user-images.githubusercontent.com/12933374/132245136-28e8aa73-1371-41aa-8147-c6a4d1aa04d5.JPG)
![Auto](https://user-images.githubusercontent.com/12933374/132245147-2f103759-dd61-4d66-9a62-3a6f6ea438e6.JPG)
![Reservierung](https://user-images.githubusercontent.com/12933374/132245144-421cb644-6598-4a53-9fd8-81538ce67fd0.JPG)

## Deployment ##
![Deployment View](https://user-images.githubusercontent.com/12933374/132245009-a40925a4-a912-499f-a6b9-c50ad64ba177.JPG)

## Implementation ##
![Auto anlegen](https://user-images.githubusercontent.com/12933374/132245198-7e17da7c-d5b2-4bb9-bb01-85d044085ebe.JPG)
![Autos anzeigen](https://user-images.githubusercontent.com/12933374/132245202-1f8f386b-361b-4b57-b605-ac3d4fbd4182.JPG)
![Reservierung](https://user-images.githubusercontent.com/12933374/132245207-5b2b0785-d493-4076-8cc4-43615e7a8cf2.JPG)

# Testing #
## UnitTests ##
Mittels Unit-Tests wird das Projekt CarRent mit Tests abgedeckt.Diese können beim Build automatisiert hinterlegt werden oder aber auch manuell gestartet und geprüft werden.
Zu finden sind diese im Projekt "UnitTest"
## Sonarcloud ##
Wie in der Anforderung beschrieben wurde Sonarcloud eingebunden um Die Qualität nachzuweisen.
