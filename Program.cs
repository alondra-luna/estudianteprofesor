class StudentAndTeacherTest
    {
        static void Main(string[] args) // Example of program usage
        {
            Person person = new Person("Joel");
            person.Greet();


            Student student = new Student("Jesse");
            student.SetAge(20);
            student.Greet();
            student.ShowAge();


            Teacher teacher = new Teacher("Walter");
            teacher.SetAge(30);
            teacher.Greet();
            teacher.Explain();


            Console.ReadKey();
        }
    }