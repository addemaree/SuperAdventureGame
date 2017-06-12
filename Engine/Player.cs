using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player
    {
        //What is going on? :

        //Property Names for Players
        //Public = Scope of the class. Means visible throughout the whole solution.

       //"int" is the data type. Int stands for integer, which deals only with whole numbers.
       //"get" is a function that is getting a value to store in that property
       //"set" is a function that is placing that value into the property

        public int CurrentHitPoints { get; set; }
        public int MaximumHitPoints { get; set; }
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }

    }
}
