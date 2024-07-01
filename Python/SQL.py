import sqlite3

# Verbindung zur SQLite-Datenbank herstellen (oder erstellen)
conn = sqlite3.connect('example.db')

# Cursor-Objekt erstellen
cursor = conn.cursor()

# Tabelle erstellen, wenn sie nicht existiert
cursor.execute('''
    CREATE TABLE IF NOT EXISTS users (
        id INTEGER PRIMARY KEY AUTOINCREMENT,
        name TEXT NOT NULL,
        age INTEGER NOT NULL
    )
''')

# Vorherige Einträge löschen
cursor.execute('DELETE FROM users')

# Beispiel-Daten einfügen
users = [('Alice', 30), ('Bob', 25), ('Charlie', 28), ('Dana', 22)]
cursor.executemany('INSERT INTO users (name, age) VALUES (?, ?)', users)

# Änderungen speichern
conn.commit()

# Daten abfragen und ausgeben
cursor.execute('SELECT * FROM users')
rows = cursor.fetchall()
for row in rows:
    print(f"ID: {row[0]}, Name: {row[1]}, Alter: {row[2]}")

# Verbindung schließen
conn.close()
