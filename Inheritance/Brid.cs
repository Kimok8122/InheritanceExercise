using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
        }

        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class

        public string TypeOfFood { get; set; }
        public string ColorOf { get; set; }
        public string FlySouth { get; set; }
        public string TypeOfSong { get; set; }
    }
}
