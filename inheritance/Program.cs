namespace inheritance
{

    // create a base/ parent class to make other classes inherit props from it direct 
    class Animel
    {
        public string name;
        public int age;
       // used virtual to override 
        public virtual void eat()
        {
            Console.WriteLine("is eating");
        }
    }
    // using inheritance 
    #region using inheritance

    // you can add a specific prop or method to this claas 
    class Dog : Animel {
        // you can add a specific prop or method to this claas
        public void Run()
        {
            Console.WriteLine("run fast");
        }
        //override 
        public override void eat()
        {
            Console.WriteLine("dog is eating");
        }
    }

    //derived class from Animal 
    class Elephent : Animel {
        //public override void eat()
        //{
        //    Console.WriteLine("elephent is eating");
        //}
    }
    #endregion

    // using sealed to prevent inheriance from this class 
    #region sealed class
    sealed class Garden
    {
        public int Area;
        public string Address;
    }
    #endregion
    //without using inheritance 
    #region without inheritance 
    //class Dog
    //{
    //    public string Name;
    //    public int age;

    //    public void eat()
    //    {
    //        Console.WriteLine("is eating");
    //    }
    //}
    //class Elephent 
    //{
    //    public string Name;
    //    public int age;

    //    public void eat()
    //    {
    //        Console.WriteLine("is eating");
    //    }
    //}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
             Dog dog1 = new Dog();
            dog1.name = "rex";
            dog1.age = 10;
            dog1.eat();

            Elephent elephent1 = new Elephent();
            elephent1.name = "eleph";
            elephent1.age = 20;
            elephent1.eat();
        }
    }
}

//compare betwwen not using inheritance and use it , sealed class