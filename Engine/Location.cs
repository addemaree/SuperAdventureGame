using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        //This is our new contructor code
        //Scope: Public because we want to create a new location object anywhere in the solution
        //Name: Constructors are always named after the class
        //Parameters: id, name and description are placed inside () and are always lower-cased 

        //By having a different case from the property, it's more obvious when you're working with 
        //the property and when you're working with parameter value.

        //Some of the properties are "= null" because some locations wont have an item required to enter,
        //Some quests wont be available there, or a monster living there
        //Null is set as a default value

        public Location(int id, string name, string description, Item itemRequiredToEnter = null, 
            Quest questAvailableHere = null, Monster monsterLivingHere = null)
        { 
            //Now we need to assign the values of the parameters to the properties in the class.

            ID = id;
            Name = name;
            Description = description;
            ItemRequiredToEnter = itemRequiredToEnter;
            QuestAvailableHere = questAvailableHere;
            MonsterLivingHere = monsterLivingHere;
        }

        //Properties:
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Additional properties to just ints and strings

        public Item ItemRequiredToEnter { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToWest { get; set; }
        public Location LocationToSouth { get; set; }

    }
}
