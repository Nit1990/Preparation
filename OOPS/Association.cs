namespace OOPS
{
    public class Teacher
    {
        public string Name { get; set; }
        public Teacher(string name)
        {
            this.Name = name;
        }

        public void Teach()
        {
            Console.WriteLine($"{Name} is teaching.");
        }
    }

    public class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
        }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying.");
        }
    }

    // Classroom class representing a classroom with an association with Teacher and Students
    public class Classroom
    {
        private Teacher teacher;
        private IList<Student> students;

        public Classroom(Teacher teacher)
        {
            this.teacher = teacher;
            this.students = new List<Student>();
        }
        public void AddStudents(Student student)
        {
            students.Add(student);
        }

        public void StartClass()
        {
            teacher.Teach();

            foreach (var student in students)
            {
                student.Study();
            }
            Console.WriteLine("Class is in Session");
        }
    }

    public class AssociationExample
    {
        public AssociationExample()
        {
            Teacher teacher = new("Mr. John");
            Student student1 = new("Ramesh");
            Student student2 = new("Mahesh");

            Classroom myclassromm = new(teacher);

            // Adding student to the class through Association
            myclassromm.AddStudents(student1);
            myclassromm.AddStudents(student2);

            // Start the class
            myclassromm.StartClass();
        }
    }
}
