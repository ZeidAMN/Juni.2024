# Definition der Basisklasse Person
class Person:
    def __init__(self, name, alter):
        self.name = name
        self.alter = alter
 
    def begruessen(self):
        print(f"Hallo, mein Name ist {self.name} und ich bin {self.alter} Jahre alt.")
 
    def __str__(self):
        return f"Person(Name: {self.name}, Alter: {self.alter})"
 
# Definition der abgeleiteten Klasse Student
class Student(Person):
    def __init__(self, name, alter, matrikelnummer):
        super().__init__(name, alter)  # Aufruf des Konstruktors der Basisklasse
        self.matrikelnummer = matrikelnummer
 
    def __str__(self):
        return f"Student(Name: {self.name}, Alter: {self.alter}, Matrikelnummer: {self.matrikelnummer})"
 
    def studieren(self):
        print(f"{self.name} mit der Matrikelnummer {self.matrikelnummer} studiert.")
 
# Erstellen von Objekten der Klasse Person
person1 = Person("Alice", 30)
person2 = Person("Bob", 25)
 
# Erstellen eines Objekts der Klasse Student
student1 = Student("Charlie", 22, "S12345")
 
# Verwenden der Methode begruessen
person1.begruessen()
person2.begruessen()
student1.begruessen()
 
# Verwenden der Methode studieren
student1.studieren()
 
# Ausgabe der Objekte mit __str__
print(person1)
print(person2)
print(student1)
 
# Ausgabe der Attribute
print(f"{person1.name} ist {person1.alter} Jahre alt.")
print(f"{person2.name} ist {person2.alter} Jahre alt.")
print(f"{student1.name} ist {student1.alter} Jahre alt und hat die Matrikelnummer {student1.matrikelnummer}.")
