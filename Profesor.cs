 class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {


        }


        public void Explain()
        {
            Console.WriteLine("Comienza la explicación.");
        }
        public override void Greet() 
        {
            Console.WriteLine("Teacher " + name + " says hello.");
        }
    }