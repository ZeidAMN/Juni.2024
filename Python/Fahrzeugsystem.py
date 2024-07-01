class Fahrzeug:
    def __init__(self, marke, modell, kennzeichen):
        self.marke = marke
        self.modell = modell
        self.kennzeichen = kennzeichen

    def __str__(self):
        return f"Marke: {self.marke}, Modell: {self.modell}, Kennzeichen: {self.kennzeichen}"

class Fuhrpark:
    def __init__(self):
        self.fahrzeuge = []

    def fahrzeug_hinzufuegen(self, fahrzeug):
        self.fahrzeuge.append(fahrzeug)
        print(f"Fahrzeug hinzugefügt: {fahrzeug}")

    def fahrzeug_entfernen(self, kennzeichen):
        for fahrzeug in self.fahrzeuge:
            if fahrzeug.kennzeichen == kennzeichen:
                self.fahrzeuge.remove(fahrzeug)
                print(f"Fahrzeug entfernt: {fahrzeug}")
                return
        print(f"Fahrzeug mit Kennzeichen {kennzeichen} nicht gefunden.")

    def fahrzeuge_anzeigen(self):
        if not self.fahrzeuge:
            print("Der Fuhrpark ist leer.")
        else:
            print("Fuhrpark:")
            for fahrzeug in self.fahrzeuge:
                print(fahrzeug)

# Interaktive Eingabe-Funktion
def interaktive_fuhrpark_verwaltung():
    fuhrpark = Fuhrpark()

    while True:
        print("\n" + "=" * 40)
        print("          Fuhrpark Verwaltung")
        print("=" * 40)
        print("\n1. Fahrzeug hinzufügen")
        print("2. Fahrzeug entfernen")
        print("3. Fahrzeuge anzeigen")
        print("4. Beenden")
        print("=" * 40)
        wahl = input("Bitte eine Option wählen: ")

        if wahl == "1":
            marke = input("Marke: ")
            modell = input("Modell: ")
            kennzeichen = input("Kennzeichen: ")
            fahrzeug = Fahrzeug(marke, modell, kennzeichen)
            fuhrpark.fahrzeug_hinzufuegen(fahrzeug)
        elif wahl == "2":
            kennzeichen = input("Kennzeichen des zu entfernenden Fahrzeugs: ")
            fuhrpark.fahrzeug_entfernen(kennzeichen)
        elif wahl == "3":
            fuhrpark.fahrzeuge_anzeigen()
        elif wahl == "4":
            break
        else:
            print("Ungültige Option. Bitte erneut versuchen.")

# Interaktive Verwaltung starten
interaktive_fuhrpark_verwaltung()
