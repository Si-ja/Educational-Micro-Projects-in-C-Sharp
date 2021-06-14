using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starting_with_HashTables.Components
{
    class ClassRoom
    {
        Hashtable classRoom = new Hashtable();

        /// <summary>
        /// Adding of a new student to the Hashtable means that we add the name
        /// of the student and their name to the hash table. In essence, this
        /// can be done with Dictionaries, but here it is done with Hash Tables
        /// which do not show the most optimal use of their power, but get sort
        /// of the point accross on what they do.
        /// </summary>
        /// <param name="student">A Student object representing a puple in the class.</param>
        public void AddNewStudent(Student student)
        {
            // Add another student to the "wall".
            this.classRoom.Add(key: student.name, value: student.talent);
        }

        /// <summary>
        /// Get a talent of the student if such exists in the classroom.
        /// </summary>
        /// <param name="name">Name of the student you are searching for.</param>
        /// <returns></returns>
        public string GetStudentsTalent(string name)
        {
            // We will not bother returning errors if the student doesn't exist, and we will just treat
            // Returning of information as a string no matter the situation in the classroom

            // Iterate through the hashtable and find the student we want
            string studentTalent = "This student does not exist.";
            foreach(DictionaryEntry student in this.classRoom)
            {
                if (String.Equals(objA: student.Key, objB: name))
                {
                    studentTalent = (string)student.Value;

                    // If the talent is non existent, make note of that
                    if (String.IsNullOrEmpty(studentTalent))
                    {
                        studentTalent = "nothing...";
                    }
                }
            }
            return studentTalent;
        }

        /// <summary>
        /// Find the student's name, if the talent type does exist.
        /// </summary>
        /// <param name="talent"></param>
        /// <returns></returns>
        public string GetStudentName(string talent)
        {
            // Same story, if the talent doesn't exist among our students, just return a string with that information.

            // Iterate thjrough the hathable and find the student we are looking for
            string studentTalent = "This student does not exist.";
            foreach (DictionaryEntry student in this.classRoom)
            {
                if (String.Equals(objA: student.Value, objB: talent))
                {
                    studentTalent = (string) student.Key;
                }
            }
            return studentTalent;
        }

        /// <summary>
        /// Delete an entry on a student if such exists in our class.
        /// </summary>
        /// <param name="name">Name of the student. The name is also treated as key value for us in our class.</param>
        public void DeleteStudent(string name)
        {
            // Let's not itterate, but just delete a value as is
            this.classRoom.Remove(key: name);
        }

        /// <summary>
        /// Show all the kids that are in the class and what their talents are.
        /// The method automatically prints everything to a console.
        /// </summary>
        public void MyClass()
        {
            foreach (DictionaryEntry student in this.classRoom)
            {
                Console.WriteLine($"Student: {(string)student.Key}, Their Talent: {(string)student.Value}");
            }
        }
    }
}
