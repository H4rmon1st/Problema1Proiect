namespace Problema1Proiect.Models
{
    public class Cow : Animal
    {
        public override string Type => "Cow";

        public override string MakeSound()
        {
            return "Moo!";
        }
    }
}
