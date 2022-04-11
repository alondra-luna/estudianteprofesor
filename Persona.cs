class Person
    {
        protected string name;
        protected int age;


        public Person(string name)
        {
            this.name = name;
        }


        public virtual void Greet() 
        {
            Console.WriteLine("Person " + name + " says hello.");
        }




        public void SetAge(int n) 
        {
            this.age = n;
        }
    }