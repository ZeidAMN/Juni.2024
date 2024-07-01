import sqlite3

# Verbindung zur SQLite-Datenbank herstellen und Tabelle erstellen
def initialize_db():
    conn = sqlite3.connect('books.db')
    cursor = conn.cursor()
    cursor.execute('''
        CREATE TABLE IF NOT EXISTS books (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            title TEXT NOT NULL,
            author TEXT NOT NULL
        )
    ''')
    conn.commit()
    conn.close()

# Buch hinzufügen
def add_book(title, author):
    conn = sqlite3.connect('books.db')
    cursor = conn.cursor()
    cursor.execute('INSERT INTO books (title, author) VALUES (?, ?)', (title, author))
    conn.commit()
    conn.close()

# Bücher abrufen
def get_books():
    conn = sqlite3.connect('books.db')
    cursor = conn.cursor()
    cursor.execute('SELECT * FROM books')
    books = cursor.fetchall()
    conn.close()
    return books

# Buch aktualisieren
def update_book(book_id, title, author):
    conn = sqlite3.connect('books.db')
    cursor = conn.cursor()
    cursor.execute('UPDATE books SET title = ?, author = ? WHERE id = ?', (title, author, book_id))
    conn.commit()
    conn.close()

# Buch löschen
def delete_book(book_id):
    conn = sqlite3.connect('books.db')
    cursor = conn.cursor()
    cursor.execute('DELETE FROM books WHERE id = ?', (book_id,))
    conn.commit()
    conn.close()

# Menü anzeigen
def show_menu():
    print("\nBuchdatenbank Verwaltung")
    print("1. Buch hinzufügen")
    print("2. Bücher abrufen")
    print("3. Buch aktualisieren")
    print("4. Buch löschen")
    print("5. Beenden")

# Hauptteil des Skripts
if __name__ == '__main__':
    initialize_db()
    
    while True:
        show_menu()
        choice = input("Wählen Sie eine Option: ")

        if choice == '1':
            title = input("Titel des Buches: ")
            author = input("Autor des Buches: ")
            add_book(title, author)
            print("Buch hinzugefügt.")

        elif choice == '2':
            books = get_books()
            if books:
                for book in books:
                    print(f'ID: {book[0]}, Titel: {book[1]}, Autor: {book[2]}')
            else:
                print("Keine Bücher gefunden.")

        elif choice == '3':
            book_id = int(input("ID des Buches, das aktualisiert werden soll: "))
            title = input("Neuer Titel des Buches: ")
            author = input("Neuer Autor des Buches: ")
            update_book(book_id, title, author)
            print("Buch aktualisiert.")

        elif choice == '4':
            book_id = int(input("ID des Buches, das gelöscht werden soll: "))
            delete_book(book_id)
            print("Buch gelöscht.")

        elif choice == '5':
            print("Programm beendet.")
            break

        else:
            print("Ungültige Option. Bitte wählen Sie erneut.")
