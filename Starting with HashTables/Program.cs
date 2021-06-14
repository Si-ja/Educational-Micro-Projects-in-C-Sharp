using System;
using Starting_with_HashTables.Components;

namespace Starting_with_HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Let's create our class of students   
            Student charlie = new Student(name: "Charlie", age: 6, talent: "Bites fingers");
            Student mark = new Student(name: "Mark", 42, talent: "Throws Football");
            Student ellie = new Student(name: "Ellie", age: 27, talent: null);

            // Now we need to add all of the students to our class room (if we had more, we could skip a few if we don't want to deal with them)
            ClassRoom classRoom = new ClassRoom();
            classRoom.AddNewStudent(student: charlie);
            classRoom.AddNewStudent(student: mark);
            classRoom.AddNewStudent(student: ellie);

            // Show our class room
            classRoom.MyClass();
            Console.WriteLine("------------------------------------------------------\n");

            // Set few conditions to what we want to do
            string talentToSearch = "Bites fingers";
            string nameToSearch = "Ellie";
            string deleteStudent = "Mark";

            // Perform the set out to do actions
            string talentedStudent = classRoom.GetStudentName(talent: talentToSearch);
            Console.WriteLine($"A student who {talentToSearch} is {talentedStudent}");
            Console.WriteLine("------------------------------------------------------\n");

            string studentsTalent = classRoom.GetStudentsTalent(name: nameToSearch);
            Console.WriteLine($"A student known as {nameToSearch}, can do {studentsTalent}");
            Console.WriteLine("------------------------------------------------------\n");

            classRoom.DeleteStudent(name: deleteStudent);
            classRoom.MyClass();
            Console.WriteLine("------------------------------------------------------\n");

            string fakeStudent = "Margaret";
            studentsTalent = classRoom.GetStudentsTalent(name: fakeStudent);
            Console.WriteLine($"A student known as {fakeStudent}, can do {studentsTalent}");
            Console.WriteLine("------------------------------------------------------\n");

            string fakeTalent = "Can hold breath under water for 10 minutes";
            talentedStudent = classRoom.GetStudentName(talent: fakeTalent);
            Console.WriteLine($"A student who {fakeTalent} is {talentedStudent}");
            Console.WriteLine("------------------------------------------------------\n");
        }
    }
}
