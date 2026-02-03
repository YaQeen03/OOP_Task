namespace Project_OPP
{

    abstract class Person
    {
        private int id;
        private string name;

        public int Id
        {
            get { return id; }
            set
            {
                if (value > 0)
                    id = value;
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract string GetRole();

        public virtual void GetInfo()
        {
            Console.WriteLine("ID:"+Id);
            Console.WriteLine("Name:"+ Name);
        }
    }

    class Student : Person
    {
        private string major;
        private double gpa;

        public string Major
        {
            get { return major; }
            set { major = value; }
        }

        public double GPA
        {
            get { return gpa; }
            set
            {
                if (value >= 0 && value <= 4)
                    gpa = value;
            }
        }

        public Student(int id, string name, string major, double gpa)
            : base(id, name)
        {
            Major = major;
            GPA = gpa;
        }

        public override string GetRole()
        {
            return "Student";
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Major:"+ Major);
            Console.WriteLine("GPA: "+GPA);
        }
    }

    class Instructor : Person
    {
        private string department;
        private double salary;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                    salary = value;
            }
        }


        public Instructor(int id, string name, string department, double salary)
            : base(id, name)
        {
            Department = department;
            Salary = salary;
        }

        public override string GetRole()
        {
            return "Instructor";
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Department:" +Department);
            Console.WriteLine("Salary:"+ Salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Student(1, "Yaqeen", "Computer Science", 3.3);
            Person p2 = new Instructor(2, "Dr. Ali", "IT", 1000);

            Console.WriteLine(p1.GetRole());
            p1.GetInfo();

            Console.WriteLine();

            Console.WriteLine(p2.GetRole());
            p2.GetInfo();
        }
    }
}
