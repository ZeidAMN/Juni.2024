class Stack:
    def __init__(self):
        self.stack = []

    def push(self, item):
        """Fügt ein Element oben auf den Stapel hinzu."""
        self.stack.append(item)
        print(f"Element '{item}' wurde zum Stapel hinzugefügt.")

    def pop(self):
        """Entfernt das Element oben auf dem Stapel und gibt es zurück.
        Gibt None zurück, wenn der Stapel leer ist."""
        if self.isEmpty():
            print("Der Stapel ist leer, kein Element zum Entfernen.")
            return None
        return self.stack.pop()

    def peek(self):
        """Gibt das Element oben auf dem Stapel zurück, ohne es zu entfernen.
        Gibt None zurück, wenn der Stapel leer ist."""
        if self.isEmpty():
            print("Der Stapel ist leer, kein Element zum Anzeigen.")
            return None
        return self.stack[-1]

    def isEmpty(self):
        """Überprüft, ob der Stapel leer ist."""
        return len(self.stack) == 0

    def size(self):
        """Gibt die Anzahl der Elemente im Stapel zurück."""
        return len(self.stack)

    def list_elements(self):
        """Listet alle Elemente im Stapel auf."""
        if self.isEmpty():
            print("Der Stapel ist leer.")
        else:
            print("Aktueller Stapel:")
            for item in reversed(self.stack):
                print(item)

# Hauptprogramm
def main():
    stack = Stack()

    while True:
        print("\n" + "=" * 40)
        print("           LIFO Stapel           ")
        print("=" * 40)
        print("1. Element hinzufügen (push)")
        print("2. Element entfernen (pop)")
        print("3. Oberstes Element anzeigen (peek)")
        print("4. Prüfen, ob der Stapel leer ist (isEmpty)")
        print("5. Anzahl der Elemente anzeigen (size)")
        print("6. Alle Elemente auflisten (list_elements)")
        print("7. Beenden")
        print("=" * 40)
        choice = input("Wähle eine Option (1-7): ")

        if choice == '1':
            item = input("Gib das Element ein, das hinzugefügt werden soll: ")
            stack.push(item)
        elif choice == '2':
            removed_item = stack.pop()
            if removed_item is not None:
                print(f"Entferntes Element: {removed_item}")
        elif choice == '3':
            top_item = stack.peek()
            if top_item is not None:
                print(f"Oberstes Element: {top_item}")
        elif choice == '4':
            if stack.isEmpty():
                print("Der Stapel ist leer.")
            else:
                print("Der Stapel ist nicht leer.")
        elif choice == '5':
            print(f"Anzahl der Elemente im Stapel: {stack.size()}")
        elif choice == '6':
            stack.list_elements()
        elif choice == '7':
            print("Programm beendet.")
            break
        else:
            print("Ungültige Option, bitte wähle eine Option von 1 bis 7.")

if __name__ == "__main__":
    main()
