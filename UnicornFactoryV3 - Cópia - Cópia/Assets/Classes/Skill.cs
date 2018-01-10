using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Classes
{
    public class Skill
    {
        String name;//o nome do skill
        String Name
        {
            get;
            set;
        }
        int cost; // o custo do skill em orbs
        int Cost
        {
            get;
            set;
        }
        bool passiveSkill; // um boleano que é true se o skill for passivo/false se for ativo
        bool PassiveSkil
        {
            get;
            set;
        }
        float baseDamage; // indica o basedamage para se poder aplicar nos multiplicadores e formulas
        float BaseDamage
        {
            get;
            set;
        }
        SkillType type; // o tipo de skill,que determina o seu funcionamento
        SkillType Type
        {
            get;
            set;
        }
    }
}
