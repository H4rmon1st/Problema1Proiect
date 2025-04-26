namespace Problema1Proiect.Models
{
    public class Dog : Animal
    {
        public override string Type => "Dog";

        public override string MakeSound()
        {
            return "Woof!";
        }
    }
}
