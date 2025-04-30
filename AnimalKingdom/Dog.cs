namespace AnimalKingdom
{
    public class Dog : Animal, IMammal
    {
        public int NumberOfNipples => 8 | 10;
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
    }
}
