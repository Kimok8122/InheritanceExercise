using System;
namespace Inheritance
{
    public class Reptile :Animal
    {
        public Reptile()
        {
        }

        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class

        public int BigOrSmall { get; set; }
        public string ColorOfEyes { get; set; }
        public string ChangeColor { get; set; }
        public string InAMovie { get; set; }
    }
}
