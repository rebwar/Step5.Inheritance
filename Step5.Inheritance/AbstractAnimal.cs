using System;

namespace Step5.Inheritance
{
    public abstract class AbstractAnimal
    {
        public string Name { get; set; }
        //cause have no implementaion ignore it and write abstract method for it
        //public virtual void Eat()
        //{

        //}
        public abstract void Eat();
        
        public virtual void Move()
        {
            Console.WriteLine("Start Moving");
        }
        public void PrintName()
        {
            Console.WriteLine(Name);
        }
    }
}
