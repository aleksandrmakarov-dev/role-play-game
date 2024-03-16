using RolePlayGame.Core.Inv.Items;
using RolePlayGame.Core.Inv.Items.itemsUtils;
using RolePlayGame.Core.Inv.Items.Weapons;
using RolePlayGame.Core.Inv.Items.Weapons.WeaponTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayGame.Core.Inv
{
    public class HandsEqupment
    {
        public IHandsEquipable? leftHand { get; private set; }
        public IHandsEquipable? rightHand { get; private set; }
        public Weapon<TwoHanded>? bothHands { get; private set; }

        public HandsEqupment(Weapon<TwoHanded> weapon)
        {
            leftHand = null;
            rightHand = null;
            bothHands = weapon;
        }

        public HandsEqupment(IHandsEquipable item1, IHandsEquipable item2)
        {
            leftHand = item1;
            rightHand = item2;
            bothHands = null;
        }

        public double CalcArmorBonus()
        {
            double tempArmorBonus = 0;

            if (leftHand != null) { tempArmorBonus += leftHand.GetArmorBonus();}
            if (rightHand != null) { tempArmorBonus += rightHand.GetArmorBonus(); }

            return tempArmorBonus;
        }
    }

    public class Equipment
    {
        public IEquipable? Armor { get;private set; }
        public IEquipable? Clothes { get; private set; }
        public HandsEqupment? HandsEqupment { get; private set; }

        public Equipment(IEquipable? armor, IEquipable? clothes, HandsEqupment? handsEqupment)
        {
            Armor = armor;
            Clothes = clothes;
            HandsEqupment = handsEqupment;
        }
    }
}
