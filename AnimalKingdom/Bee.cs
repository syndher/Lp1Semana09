namespace AnimalKingdom
{
    public class Bee : Animal, ICanFly
    {
        public override string Sound()
        {
            return base.Sound() + "Bzz!";
        }
        public int NumberOfWings()
        {
            return 4;
        }
    }
}
