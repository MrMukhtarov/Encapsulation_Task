namespace EncapsulationTask.Models;

internal class Group : Student
{
    public int No { get; set; }
    public int Limit { get; set; }
    public Student[] Students { get; private set; }

    public string AddStudent(Student student)
    {
        if (Students.Length > Limit)
        {
            return "Grupda Yer var";

        }
        return "Grupda Yer yoxdur";
    }
    public void GetStudents()
    {
        for (int i = 0; i < Students.Length; i++)
        {
            Console.WriteLine($"{Students[i].Name} {Students[i].Surname}");
        }
    }
    public Group(int no, int limit, Student[] students)
    {
        Limit = limit;
        No = no;
        Students = students;
    }
}
