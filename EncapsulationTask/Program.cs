using EncapsulationTask.Models;

Student st1 = new Student("Nicat","Muxtarov");
Student st2 = new Student("Nicat","Muxtarov");
Student st3 = new Student("Nicat","Muxtarov");
Student st4 = new Student("Nicat","Muxtarov");
Student[] stuArr = new Student[4];
stuArr[0] = st1;
stuArr[1] = st2;
stuArr[2] = st3;
stuArr[3] = st4;
Group gr1 = new Group(137,5,stuArr);
Console.WriteLine(gr1.AddStudent(st1));
gr1.GetStudents();
