# NumberList

## Lernkontrolle

* Implementierung einfach verketteten Listen mit Sortierung
* Anwendung von Eigenschaften (Properties)

### Aufgabe

Erstellen Sie eine dynamische Liste 'ListOfNumbers' mit folgender Funktion:

```csharp
    /// <summary>
    /// This class manages a dynamic list of numbers. The added numbers are added to the list in ascending order.
    /// </summary>
    public class ListOfNumbers
    {
        /// <summary>
        /// Calculates the number of elements in the list.
        /// </summary>
        public int Count
        {
        ...
        }
        /// <summary>
        /// Adds a number to the list (descending by value) in the list.
        /// </summary>
        /// <param name="data">The number who will be added to the list.</param>
        public void Insert(int data)
        {
        ...
        }

        /// <summary>
        /// Determines the number at the position. If the position (position < 0 || >= Count) is invalid, an exception 'IndexOutOfRangeException()' is thrown.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <returns>The number at the position.</returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public int GetAt(int position)
        {
        ...
        }

        /// <summary>
        /// Removes an item at the position. If the position (position < 0 || >= Count) is invalid, an exception 'IndexOutOfRangeException()' is thrown.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public void RemoveAt(int position)
        {
        ...
        }

        /// <summary>
        /// Removes all duplicates from the list.
        /// </summary>
        public void RemoveDuplicates()
        {
        ...
        }

        /// <summary>
        /// Converts the list to an array.
        /// </summary>
        /// <returns>The list of values as an array.</returns>
        public int[] ToArray()
        {
         ...
        }
    }

```

> HINWEISE: Die dynamische Verkettung muss implementiert werden. Es duerfen keine Listen aus der Bibliothek verwendet werden. Vergessen Sie nicht den Programmkopf im Programm.

## Hilfsmitteln

- keine

## Abgabe

-  Termin: 100 min. nach Ausgabe (inkl. Vorbereitungszeit)
-  Klasse:
-  Name:

## Quellen

<center>Viel Erfolg!</center>