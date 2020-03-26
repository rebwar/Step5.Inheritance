using System;

namespace Step5.Inheritance
{
    public class Sheep : AbstractAnimal
    {
        public override void Eat()
        {
            Console.WriteLine("Sheep Eat Grass!");
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Sheep is Moving!");
        }
    }
}
