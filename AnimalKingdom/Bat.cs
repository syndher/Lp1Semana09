namespace AnimalKingdom
{
    public class Bat : Animal, IMammal, ICanFly
    {
        public override string Sound()
        {
            return base.Sound() + "Eek!";
        }
        public int NumberOfNipples()
        {
            return 4;
        }
        public int NumberOfWings()
        {
            return 2;
        }
    }
}
