using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex217_Game
{
    class Rubick: ITalent
    {
        public Action RubicTalent { get;   set; }

       
        Action ITalent.Skill { get; set; }

        public Rubick( )
        {
            RubicTalent = () => { };
        }

        public void SpellSteal(ITalent Talent)
        {
            RubicTalent = Talent.Skill;
        }

        public void UseSkill()
        {
            Console.Write("Rubick использует ");
            RubicTalent();
        }

         
    }
}
