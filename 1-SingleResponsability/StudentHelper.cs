using System.Text;
using SingleResponsability;

public class StudentHelper()
{
    public static void Export(StudentRepository students)
    {
        IEnumerable<Student> _students = students.GetAll();
        string csv = String.Join(",", _students.Select(x => x.ToString()).ToArray());
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.AppendLine("Id;Fullname;Grades");
        foreach (var item in _students)
        {
            sb.AppendLine($"{item.Id};{item.Fullname};{string.Join("|", item.Grades)}");
        }
        System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"), sb.ToString(), Encoding.Unicode);
    }
}

