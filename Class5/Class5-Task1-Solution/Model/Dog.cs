
namespace Model
{
    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public Dog(string name, string race, string color)
        {
            Name = name;
            Race = race;
            Color = color;
        }
        public string eat()
        {
            return "is now eating.";
        }
        public string play()
        {
            return "is now playing.";
        }
        public string ChaseTail()
        {
            return "is now chasing its tail.";
        }
      
    }
}
