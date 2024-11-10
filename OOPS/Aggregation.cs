namespace PracticeProject.OOPS
{
    // Department class representing a department in a university
    public class Department
    {
        public string Name { get; set; }

        public Department(string name)
        {
            Name = name;
        }
        public void OfferCourses()
        {
            Console.WriteLine($"Department {Name} is offering courses.");
        }
    }

    // University class with aggregation relationship with Department
    public class University
    {
        public string Name { get; set; }
        private List<Department> departments;

        public University(string name)
        {
            Name = name;
            departments = new List<Department>();
        }

        public void AddDepartment(Department department)
        {
            departments.Add(department);
        }

        public void DisplayDepartments()
        {
            Console.WriteLine($"Departments of {Name}:");
            foreach (var department in departments)
            {
                Console.WriteLine(department.Name);
            }
        }
    }
    public class AggregationExample
    {
        public AggregationExample()
        {
            // Creating instances of University and Department
            University myUniversity = new University("My University");
            Department computerScience = new Department("Computer Science");
            Department physics = new Department("Physics");

            // Establishing an aggregation relationship
            myUniversity.AddDepartment(computerScience);
            myUniversity.AddDepartment(physics);

            // Displaying information
            myUniversity.DisplayDepartments();
        }
    }
}
