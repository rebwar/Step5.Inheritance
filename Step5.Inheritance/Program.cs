namespace Step5.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractAnimal animal1 = new Lion();
            animal1.Eat();
            animal1.Move();
        }
    }
}
