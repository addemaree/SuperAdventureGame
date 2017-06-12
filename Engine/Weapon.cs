using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //HealingPotion, Item, and Weapon all have the Properties: "ID, Name, and NamePlural"
    //They all also represent items that a player may collect during a game
    //We are going to make the "Item" class the base class since it has all the properties in it.

    //**NOTE: BY ADDING THE ": ITEM" CODE, WE ARE PLACING ALL THE PROPERTIES AND METHODS IN THE WEAPON CLASS**

    //Weapon class is now a child, or derived class, from the item class

    public class Weapon : Item
    {
        //Constructor
        public Weapon(int id, string name, string namePlural, int minimumDamage, int maximumDamage) : 
            base(id, name, namePlural)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }



        //Properties
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
    }
}
