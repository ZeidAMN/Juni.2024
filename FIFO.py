class Queue:
    def __init__(self):
        self.queue = []

    def enqueue(self, item):
        """Fügt ein Element am Ende der Warteschlange hinzu."""
        self.queue.append(item)
        print(f"Element '{item}' wurde zur Warteschlange hinzugefügt.")

    def dequeue(self):
        """Entfernt das Element am Anfang der Warteschlange und gibt es zurück. 
        Gibt None zurück, wenn die Warteschlange leer ist."""
        if self.isEmpty():
            print("Die Warteschlange ist leer, kein Element zum Entfernen.")
            return None
        return self.queue.pop(0)

    def peek(self):
        """Gibt das Element am Anfang der Warteschlange zurück, ohne es zu entfernen. 
        Gibt None zurück, wenn die Warteschlange leer ist."""
        if self.isEmpty():
            print("Die Warteschlange ist leer, kein Element zum Anzeigen.")
            return None
        return self.queue[0]

    def isEmpty(self):
        """Überprüft, ob die Warteschlange leer ist."""
        return len(self.queue) == 0

    def size(self):
        """Gibt die Anzahl der Elemente in der Warteschlange zurück."""
        return len(self.queue)

    def list_elements(self):
        """Listet alle Elemente in der Warteschlange auf."""
        if self.isEmpty():
            print("Die Warteschlange ist leer.")
        else:
            print("Aktuelle Warteschlange:")
            for item in self.queue:
                print(item)

# Hauptprogramm
def main():
    queue = Queue()

    while True:
        print("\n" + "=" * 40)
        print("           FIFO Warteschlange           ")
        print("=" * 40)
        print("1. Element hinzufügen (enqueue)")
        print("2. Element entfernen (dequeue)")
        print("3. Vorderstes Element anzeigen (peek)")
        print("4. Prüfen, ob die Warteschlange leer ist (isEmpty)")
        print("5. Anzahl der Elemente anzeigen (size)")
        print("6. Alle Elemente auflisten (list_elements)")
        print("7. Beenden")
        print("=" * 40)
        choice = input("Wähle eine Option (1-7): ")

        if choice == '1':
            item = input("Gib das Element ein, das hinzugefügt werden soll: ")
            queue.enqueue(item)
        elif choice == '2':
            removed_item = queue.dequeue()
            if removed_item is not None:
                print(f"Entferntes Element: {removed_item}")
        elif choice == '3':
            front_item = queue.peek()
            if front_item is not None:
                print(f"Vorderstes Element: {front_item}")
        elif choice == '4':
            if queue.isEmpty():
                print("Die Warteschlange ist leer.")
            else:
                print("Die Warteschlange ist nicht leer.")
        elif choice == '5':
            print(f"Anzahl der Elemente in der Warteschlange: {queue.size()}")
        elif choice == '6':
            queue.list_elements()
        elif choice == '7':
            print("Programm beendet.")
            break
        else:
            print("Ungültige Option, bitte wähle eine Option von 1 bis 7.")

if __name__ == "__main__":
    main()
