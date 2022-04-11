class Student : Person
    {
        public Student(string name) : base(name)
        {


        }


        public void ShowAge()
        {
            Console.WriteLine("Mi edad es " + age + " años.");
        }


        public void GoToClasses()
        {
            Console.WriteLine("voy a clase.");
        }


        public override void Greet() 
        {
            Console.WriteLine("Student  "  + name + " says hello.");
        }
    }