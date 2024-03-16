using RolePlayGame.Core.Entities.Utils;
using RolePlayGame.Core.Inv;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayGame.Core.Entities
{
    public class Character : Entity
    {
        public double ArmorBonus { get; private set; }
        public double StepPoints { get; private set; }
        public Inventory Inventory { get; private set; }
        public Equipment Equipment { get; private set; }
        public Character(double health,Point pos,Level level) :base(health,pos,level) { }
    }
}
