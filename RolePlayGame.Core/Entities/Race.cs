using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayGame.Core.Entities
{
    //

    public class RaceManager
    {
        private Dictionary<string,Dictionary<int,List<Skill>>> _skills;
        public List<Skill> GetSkillsToChoose(string raceName, int lvl)
        {

        }
    }

    public class Race
    {
        public string Name { get; set; }
        public int Level { get;set; }
        public List<Skill> Skills { get;set; }   
    }



    public class Skill
    {

    }
}
