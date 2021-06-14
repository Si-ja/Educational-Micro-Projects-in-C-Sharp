# Starting with HashTables

This repository is mean to help start working with HashTable object types.

## Concept

The main program creates a structure where there exists a class of students, who each have their individual parameters, such as names, their ages and one specific talent (or potentially none). Such data as names and talents from each student object is saved into a HashTable (Dictionaries could have also worked, but this is an example).

Further on, it is possible to see all the students in the class with their unique talents, search for a student by their name and find their talent, search for a student based on the talent we assume someone might have, or remove a student from the class.

Hashtables allow for a bit easier manipulation and look up of data than if we would be dealing with complicated and long lists, removing from us the requirement to deal with indexes and similar components.

## Running

If you run the main code located in the `Program.cs` file, you should get some print outs on what students are present in the class, and some information look ups that are performed with their data. Try experimenting and adding more students or change certain parameters of theirs and see how the code reacts. To help deal with students you have a small `struct` in the file `Students.cs` and all the look ups and data modifications that are performed are done via a class located in the `ClassRoom.cs` file.

