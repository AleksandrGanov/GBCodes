using System;

namespace Ex217_Game
{
    class Zeus  
    {
        public string Name { get; private set; }
        public Zeus(string Name)
        {
           this.Name = Name;
        }
        public void Skill()
        {
            Console.WriteLine($"LightningBolt...");
        }
    }

}
