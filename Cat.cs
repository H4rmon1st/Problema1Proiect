namespace Problema1Proiect.Models
{
    public class Cat : Animal
    {
        public override string Type => "Cat";

        public override string MakeSound()
        {
            return "Meow!";
        }
    }
}
