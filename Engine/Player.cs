using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        //Constructor
        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level) :
            base(currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
            //These two lines set the value of the new properties to empty lists. If we didn't do this, the value
            //for those properties would be null-nothing
            
            //By setting them to an empty list, we can add items to them later, because you can add objects to
            //an empty list, but you can't add objects to nothing (null).
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }

        //What is going on? :

        //Property Names for Players
        //Public = Scope of the class. Means visible throughout the whole solution.

       //"int" is the data type. Int stands for integer, which deals only with whole numbers.
       //"get" is a function that is getting a value to store in that property
       //"set" is a function that is placing that value into the property

        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }
    }
}
