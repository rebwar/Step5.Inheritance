using System;

namespace Step5.Inheritance
{
    public class Lion : AbstractAnimal
    {
        public override void Eat()
        {
            Console.WriteLine("Lion Eat Meat!!");
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Lion is Moving");
            
        }
        public new string  PrintName()
        {
            return "";
        }
    }
}
