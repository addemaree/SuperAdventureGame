using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {
        //This is our new contructor code
        //Scope: Public because we want to create a new "Quest" object anywhere in the solution
        //Name: Constructors are always named after the class
        //Parameters: id, name, description, rewardexperiencepoints and rewardgold are placed 
        //inside () and are always lower-cased with the first word

        //By having a different case from the property, it's more obvious when you're working with 
        //the property and when you're working with parameter value.

        public Quest(int id, string name, string description, int rewardExperiencePoints, int rewardGold)
        {
            //Now we need to assign the values of the parameters to the properties in the class.
            ID = id;
            Name = name;
            Description = description;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
        }

        //Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }

    }
}
