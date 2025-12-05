# lernperiode-12

07.11.2025 – 19.12.2025

## Planung
In dieser Lernperiode möchte ich ein 2D-Videospiel mit Unity und C# entwickeln.  
Mein Ziel ist es, ein funktionierendes Spiel zu erstellen und dabei den gesamten Entwicklungsprozess kennenzulernen. Von der Steuerung und Physik bis zu Effekten und Gegnerlogik.

## Projektidee
Ich entwickle ein 2D-Bomber-Spiel, in dem der Spieler ein Flugzeug steuert, das feindliche Bodeneinheiten (z. B. Panzer oder Flakgeschütze) bombardiert.  
Die Gegner schiessen mit Kanonen oder Raketen auf das Flugzeug, wodurch der Spieler gezwungen ist, taktisch zu fliegen und Angriffen auszuweichen.  
Ziel ist es, alle Gegner eines Levels zu zerstören, um das Level erfolgreich abzuschliessen.  

Wenn genug Zeit bleibt, soll zusätzlich ein Upgrade-System entstehen, mit dem man nach erfolgreichen Missionen neue Bomben, Flares oder Waffenverbesserungen kaufen kann.

## Ziele
- Eigenständige Entwicklung eines 2D-Spiels mit Unity  
- Verständnis für Physik, Gegnerverhalten und Spielstruktur aufbauen
- Erstellung eines spielbaren Prototyps 

## Features
- Steuerung des Bombers per Tastatur  
- Bombenabwurf mit Explosionseffekten  
- Verschiedene Gegner (Panzer, Flak, Raketenstellungen)  
- Unterschiedliche Karten mit steigendem Schwierigkeitsgrad  
- Treffer- und Schadenssystem  
- Sieg-/Niederlagenbedingungen  
- Optional: Upgradesystem für Bomben oder Flugzeugausrüstung

## Epics
1. Als Spieler möchte ich den Bomber mit einer Tastatur steuern können.
2. Als Spieler möchte ich Bomben abwerfen können und sie sollen Schaden ausrichten.
3. Als Spieler möchte ich, dass die Gegner mich angreifen, so dass ich eine Herausforderung habe.
4. Als Spieler möchte ich, dass das Spiel beendetwird nach dem ich gewinne oder verliere.
5. Als Spieler möchte ich auf vielen verschiedenen Maps und Levels spielen können
6. Als Spieler möchte ich ein gutes UI habe, damit ich leicht durch das Spiel navigieren kann.
7. Als Spieler möchte ich das meine Aktionen Effecte und Sounds auslösen
8. (optional) Als Spieler möchte ich mein Flugzeug verbessern können mit Upgrades

## 07.11.2025
Epic-Nr: 1
- [x]  Als Spieler möchte ich mit dem Pfeil nach oben beschläunigen können, damit das Flugzeug fligt.
- [x]  Als Spieler möchte ich mit den Tasten Pfeil nach Links und nach rechts die richtung des Flugzeuges ändern können, damit die Steuerung komplett ist.
- [x]  Als Spieler möchte ich, dass mein Bomber von Flugphysik betroffen ist. 

Heute habe ich erflogreich mit Hilfe von Tutorials eine gute Steuerung für mein Bomber entwickelt, ausserdem habe ich dafür gesorgt, das mein Bomber von Flugphysik betroffen ist und wenn man nicht Beschleunigt fängt es an, langsam zu sinken und hat auch ein Drag Effekt wegen des Windwiderstandes.

# 14.11.2025
Epic-Nr: 3
- [x] Als Entwickler möchte ich, dass alle Gegner in einem bestimmten Radius den Bomber tracken, damit sie seinen Flugweg berechnen können.
- [x] Als Entwickler möchte ich, dass die Gegner mit diesen Daten die Flugbahn des Bombers vorhersagen können, damit sie den Flieger abschiessen können.
- [x] Als Spieler möchte ich, dass die Gegner auf mich schiessen, damit ich auch verlieren kann.

Heute habe ich den Anti-Air-Gegner vollständig programmiert. Er kann nun auf den Bomber schiessen. Allerdings funktioniert die Berechnung der Flugbahn noch nicht korrekt. Der Gegner zielt derzeit direkt auf das Flugzeug, was das Ausweichen sehr einfach macht. Ausserdem müssen die Schüsse limitiert werden, da eine zu hohe Schussrate die Performance beeinträchtigt. Aktuell verursachen die Schüsse noch keinen Schaden. Zusätzlich schiesst der Gegner weiter, selbst nachdem er zerstört wurde, da er erst mit einer Verzögerung aus dem Spiel entfernt wird.

# 21.11.2025
Epic-Nr: 3
- [x] Als Spieler möchte ich, dass die entstandenen Bugs, beim erstellen des AntiAirs, gefixt werden, damit das Spiel ohne Probleme läuft. 
- [x] Als Spieler möchte ich, dass die Schüsse des Gegners Schaden anrichten, sodass ich auch verlieren kann.
- [x] Als Entwickler möchte ich die Berechnung der Flugbahn des Bombers verbessern, damit die Gegner ihn mit grösserer Genauigkeit abschiessen können.
- [x] Als Spieler möchte ich, dass die Gegner aufhören zu schiessen, wenn ich sie getroffen habe.

Heute habe ich die Bugs des Anti-Air-Systems behoben. Die Gegner verursachen nun korrekt Schaden und hören sofort auf zu schiessen, wenn sie zerstört wurden. Die berechnete Flugbahn des Bombers ist zudem deutlich präziser, sodass die Gegner nicht mehr direkt auf die aktuelle Position zielen. Dadurch funktioniert das gesamte System nun stabil.

# 28.11.2025
Epic-Nr: 4
- [x] Als Spieler möchte ich, dass ein erstes spielbares Level erstellt wird, damit das Spiel gespielt werden kann
- [x] Als Spieler möchte ich, dass getrackt wird, wie viele Gegner noch am leben sind, so dass das Spiel beendet wird, wenn alle Gegner ausgeschaltet werden.
- [x] Als Spieler möchte ich, dass das Spiel beendet wird wenn ich Abgeschossen werde.

Heute habe ich ein erstes vollständig spielbares Level erstellt, sodass das Spiel nun grundsätzlich funktioniert. Ich habe eine Logik implementiert, die die verbleibenden Gegner trackt und das Spiel erfolgreich beendet, sobald alle eliminiert sind. Zudem wurde die „Game Over“-Bedingung eingebaut, sodass das Spiel stoppt, wenn der Spieler abgeschossen wird.

# 05.12.2025
- [ ] Als Spieler möchte ich ferschiedene Maps mit verschiedenen Schwierigkeiten
- [ ] Als Entwickler möchte ich Unitys Gui Systhem lernen, um die navigation und das spiel viel Benutzerfreundlicher zu machen.
- [ ] Als Enttwickler möchte ich ein erstes Menü screen erstellen mit GUI für die einfache Navigation

