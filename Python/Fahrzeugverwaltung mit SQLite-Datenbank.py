import sqlite3

class Fahrzeug:
    def __init__(self, marke, modell, kennzeichen):
        self.marke = marke
        self.modell = modell
        self.kennzeichen = kennzeichen

    def __str__(self):
        return f"Marke: {self.marke}, Modell: {self.modell}, Kennzeichen: {self.kennzeichen}"

class Fuhrpark:
    def __init__(self):
        self.initialize_db()

    def initialize_db(self):
        self.conn = sqlite3.connect('fuhrpark.db')
        self.cursor = self.conn.cursor()
        self.cursor.execute('''
            CREATE TABLE IF NOT EXISTS fahrzeuge (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                marke TEXT NOT NULL,
                modell TEXT NOT NULL,
                kennzeichen TEXT NOT NULL UNIQUE
            )
        ''')
        self.conn.commit()

    def fahrzeug_hinzufuegen(self, fahrzeug):
        self.cursor.execute('INSERT INTO fahrzeuge (marke, modell, kennzeichen) VALUES (?, ?, ?)', 
                            (fahrzeug.marke, fahrzeug.modell, fahrzeug.kennzeichen))
        self.conn.commit()
        print(f"Fahrzeug hinzugefügt: {fahrzeug}")

    def fahrzeug_entfernen(self, kennzeichen):
        self.cursor.execute('DELETE FROM fahrzeuge WHERE kennzeichen = ?', (kennzeichen,))
        if self.cursor.rowcount > 0:
            self.conn.commit()
            print(f"Fahrzeug mit Kennzeichen {kennzeichen} entfernt.")
        else:
            print(f"Fahrzeug mit Kennzeichen {kennzeichen} nicht gefunden.")

    def fahrzeuge_anzeigen(self):
        self.cursor.execute('SELECT marke, modell, kennzeichen FROM fahrzeuge')
        fahrzeuge = self.cursor.fetchall()
        if not fahrzeuge:
            print("Der Fuhrpark ist leer.")
        else:
            print("Fuhrpark:")
            for marke, modell, kennzeichen in fahrzeuge:
                print(Fahrzeug(marke, modell, kennzeichen))

    def fahrzeug_aktualisieren(self, kennzeichen, neue_marke, neues_modell):
        self.cursor.execute('UPDATE fahrzeuge SET marke = ?, modell = ? WHERE kennzeichen = ?', 
                            (neue_marke, neues_modell, kennzeichen))
        if self.cursor.rowcount > 0:
            self.conn.commit()
            print(f"Fahrzeug mit Kennzeichen {kennzeichen} aktualisiert.")
        else:
            print(f"Fahrzeug mit Kennzeichen {kennzeichen} nicht gefunden.")

    def __del__(self):
        self.conn.close()

def interaktive_fuhrpark_verwaltung():
    fuhrpark = Fuhrpark()

    while True:
        print("\n" + "=" * 40)
        print("          Fuhrpark Verwaltung")
        print("=" * 40)
        print("\n1. Fahrzeug hinzufügen")
        print("2. Fahrzeug entfernen")
        print("3. Fahrzeuge anzeigen")
        print("4. Fahrzeug aktualisieren")
        print("5. Beenden")
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
            kennzeichen = input("Kennzeichen des zu aktualisierenden Fahrzeugs: ")
            neue_marke = input("Neue Marke: ")
            neues_modell = input("Neues Modell: ")
            fuhrpark.fahrzeug_aktualisieren(kennzeichen, neue_marke, neues_modell)
        elif wahl == "5":
            break
        else:
            print("Ungültige Option. Bitte erneut versuchen.")

# Interaktive Verwaltung starten
interaktive_fuhrpark_verwaltung()
