using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //Player and Monster classes both have the Properties: "ID, CurrentHitPoints, and MaximumHitPoints"
    //They are both living creatures in the game
    //We are going to make the "LivingCreature" class the base class since it has all the properties in it. 

    //LivingCreature is now a base class, which means that all its properties will be inherited by its child classes

    public class LivingCreature
    {
        //Constructor

        public LivingCreature(int currentHitPoints, int maximumHitPoints)
        {
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;
        }



        //Properties
        //Base class needs to be at least as visible (with regards to its scope) as its child classes
        public int CurrentHitPoints { get; set; }
        public int MaximumHitPoints { get; set; }
    }
}
