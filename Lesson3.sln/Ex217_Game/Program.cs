using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex217_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Rubick rubick = new Rubick();
             
 

            PhantomAssassin phantomAssassin = new PhantomAssassin();
            phantomAssassin.Skill1();

            rubick.SpellSteal(phantomAssassin);
            rubick.UseSkill();

            phantomAssassin.Skill2();

            rubick.SpellSteal(phantomAssassin);
            rubick.UseSkill();

            phantomAssassin.Skill3();

            rubick.SpellSteal(phantomAssassin);
            rubick.UseSkill();


          
            phantomAssassin.Skill1();

            rubick.SpellSteal(phantomAssassin);
            rubick.UseSkill();

        }
    }
}
