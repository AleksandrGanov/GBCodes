using System;

namespace Ex217_Game
{
    class PhantomAssassin : ITalent
    {
        public Action Skill { get; set; }

        public void Skill1()
        {
            Console.WriteLine("Skill1 StiflingDagger...");
            Skill = Skill1;
        }

        public void Skill2()
        {
            Console.WriteLine("Skill2 StiflingDagger...");
            Skill = Skill2;
        }

        public void Skill3()
        {
            Console.WriteLine("Skill3 StiflingDagger...");
            Skill = Skill3;
        }
        public void Skill4()
        {
            Console.WriteLine("Skill3 StiflingDagger...");
            Skill = Skill4;
        }
    }

}
