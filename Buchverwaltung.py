class Book:
	def _init_(self, title, author, year):
		self.title = title
		self.author = author
		self.year = year
		
	def _str_(self):
		return f"'{self.title}' von {self.author}, {self.year}"
		
class Library:
	def _init_(self):
		self.books = []
		
	def add_book(self, title, author, year):
		new_book = Book(title, author, year)
		self.book.append(new_book)
		print(f"\Buch hinzugefügt: {new_book}")
		
	def list_books(self):
		if not self.book:
			print("\nKeine Bücher in der Bibliothek.")
		else:
			print("\nListe der Bücher in der Bibliothek:")
			print("-" * 40)
			for book in self.books:
				print(book)
			print("-" * 40)
	 
	def delete_book(self, title):
		book_to_delete = None
		for book in self.books:
			if book.title == title:
				book_to_delete = book
				break
		if book_to_delete:
			self.book.remove(book_to_delete)
			print(f"\nBuch gelöscht: {book_to_delete}")
		else:
			print(f"\nKein Buch mit dem Title '{title}' gefunden.")
		
 # Hauptprogramm
def main():
	library = Library()
		
	while True:
		print("\n" + "=" * 40)
		print("           Buchverwaltungssystem           ")
		print("=" * 40)
		print("1. Buch hinzufügen")
		print("2. Liste der Bücher anzeigen")
		print("3. Buch löschen")
		print("4. Beenden")
		print("=" * 40)
		choice = input("Wähle eine Option (1-4): ")
			
		if choice == '1':
			title = input("\nTitle des Buches: ")
			author = input("Author des Buches: ")
			year = input ("Jahr der Veröffentlichung: ")
			library.add.book(title, author, year)
		elif choice == '2':
			library.list.books()
		elif choice == '3':
			title = input ("\nTitle des zu löschenden Buches: ")
			library.delete.book(title)
		elif choice == '4':
			print("\nProgramm beendet.")
			break
		else:
			print("\nUngültige Option, bitte wähle eine Option von 1 bis 4.")
	
if __name__ == "__main__":
    main()
