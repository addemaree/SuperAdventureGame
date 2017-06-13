using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class PlayerQuest
    {
        //Constructor
        public PlayerQuest(Quest details)
        {
            Details = details;
            IsCompleted = false;
        }

        //Properties
        public Quest Details { get; set; }
        public bool IsCompleted { get; set; }

    }
}
