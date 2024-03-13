using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayGame.Core.Inventory
{
    public class Inventory
    {
        public double MaxWeight {  get; private set; }
        public double Weight { get; private set; }

        private List<Item>? _items;

        public Inventory(double maxWeight,List<Item>? items) 
        {
            MaxWeight = maxWeight;
            _items = items;
            Weight = CalcWeight();
        }

        private double CalcWeight() 
        { 
            if (_items != null)
            {
                double tempWeight = 0;

                foreach (Item? item in _items)
                {
                    if (item != null)
                    {
                        tempWeight += item.Weight;
                    }
                }

                return tempWeight;
            }
            else { return 0.0f; }
        }
    }
}
