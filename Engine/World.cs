﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //The purpose of the World class is to have one place to hold everything that exists in the game world.
    //In it, we'll have things such as the monster that exist at a location, the loot items you can collect
    //after defeating a monster, etc. 

    //It will also show how the locations connect with each other, builing our game map:

    //                           Herb Garden                         North
    //                               |                                 |
    //                               |                          West --|-- East
    //                           Alchemy Hut                           |
    //                               |                               South    
   //                                |
   //   Fields -> Farm House -> Town Square <- Guard House <- Bridge <- Spider Forest
   //                                |
   //                               Home

    public static class World
    {
        //Static List Variables:
        //These work similar to the properties in a class. We'll populate them with all the things in our game world,
        //then read from them in the rest of the program

        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        //Constants
        //Constants look, and work, like variables, except for one big difference-
        //they can never have their values changed

        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_RAT_TAIL = 2;
        public const int ITEM_ID_PIECE_OF_FUR = 3;
        public const int ITEM_ID_SNAKE_FANG = 4;
        public const int ITEM_ID_SNAKESKIN = 5;
        public const int ITEM_ID_CLUB = 6;
        public const int ITEM_ID_HEALING_POTION = 7;
        public const int ITEM_ID_SPIDER_FANG = 8;
        public const int ITEM_ID_SPIDER_SILK = 9;
        public const int ITEM_ID_ADVENTURER_PASS = 10;

        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_GIANT_SPIDER = 3;

        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;

        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_TOWN_SQUARE = 2;
        public const int LOCATION_ID_GUARD_POST = 3;
        public const int LOCATION_ID_ALCHEMIST_HUT = 4;
        public const int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
        public const int LOCATION_ID_FARMHOUSE = 6;
        public const int LOCATION_ID_FARM_FIELD = 7;
        public const int LOCATION_ID_BRIDGE = 8;
        public const int LOCATION_ID_SPIDER_FIELD = 9;

        //Static Constructor

        //With a static class, the constructor code is run the first time someone uses anything in the class.
        //So, when we start the game and want to display information about the player's current location, and 
        //we try to get the data from the World class, the constructor method will be run, and the lists will be
        //populated.

        //Inside the constructor, we call the four methods to populate the different lists. We don't need to have
        //seperate methods, and we could put all the code after this constructor into the constructor, but breaking
        //it up makes it easier to read. CLEAN CODE!
        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        //Methods: These methods we use to create the game objects and add them to static lists

        //By calling the Add() method on a list variable or property, we add an object to that list.
        //We used INLINING here, which means we created the value and added it to the list all on one line.

        //Scope: PRIVATE: means that this method can only be run by other code inside this class.
        //Static: Running a method WITHOUT instantiating an object from the class.
        //Void: Void means that this method is not going to return a value. It's just going to do some work.
        private static void PopulateItems()
        {
         //Look at line 100. Here we are adding a new Weapon object to the "Items" list.
         //When we call "new Weapon()" the constructor of the "Weapon" class returns a Weapon object
         //with the parameters passed in. Since that is all inside the "Items.Add()" method, that object gets added
         //to the "Items" list.
         Items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty sword", "Rusty swords", 0, 5));
         Items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat tail", "Rat tails"));
         Items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Piece of fur", "Pieces of fur"));
         Items.Add(new Item(ITEM_ID_SNAKE_FANG, "Snake fang", "Snake fangs"));
         Items.Add(new Item(ITEM_ID_SNAKESKIN, "Snakeskin", "Snakeskins"));
         Items.Add(new Weapon(ITEM_ID_CLUB, "Club", "Clubs", 3, 10));
         Items.Add(new HealingPotion(ITEM_ID_HEALING_POTION,
         "Healing potion", "Healing potions", 5));
         Items.Add(new Item(ITEM_ID_SPIDER_FANG, "Spider fang", "Spider fangs"));
         Items.Add(new Item(ITEM_ID_SPIDER_SILK, "Spider silk", "Spider silks"));
         Items.Add(new Item(ITEM_ID_ADVENTURER_PASS,
         "Adventurer pass", "Adventurer passes"));
         }

        private static void PopulateMonsters()
         {
            //We create a new Monster object and save it to the variable "rat"
            //On lines 121 and 122 we add items to the (list) property of "PotentialLootItems" that you might find
            //on the rat. 
            //Then on line 131 we add the rat variable to the static "Monsters" list
             Monster rat = new Monster(MONSTER_ID_RAT, "Rat", 5, 3, 10, 3, 3);
             rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 75, false));
             rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 75, true));

             Monster snake = new Monster(MONSTER_ID_SNAKE, "Snake", 5, 3, 10, 3, 3);
             snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_FANG), 75, false));
             snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKESKIN), 75, true));

             Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER,
             "Giant spider", 20, 5, 40, 10, 10);
             giantSpider.LootTable.Add(new LootItem(
             ItemByID(ITEM_ID_SPIDER_FANG), 75, true));
             giantSpider.LootTable.Add(new LootItem(
             ItemByID(ITEM_ID_SPIDER_SILK), 25, false));

             Monsters.Add(rat);
             Monsters.Add(snake);
             Monsters.Add(giantSpider);
          }

        private static void PopulateQuests()
        {
            Quest clearAlchemistGarden = new Quest(QUEST_ID_CLEAR_ALCHEMIST_GARDEN, "Clear the alchemist's garden",
                "Kill rats in the alchemist's garden and bring back 3 rat tails. " +
                "You will receive a healing potion and 10 gold pieces.", 20, 10);

            clearAlchemistGarden.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_RAT_TAIL), 3));

            clearAlchemistGarden.RewardItem = ItemByID(ITEM_ID_HEALING_POTION);
            
            Quest clearFarmersField = new Quest(QUEST_ID_CLEAR_FARMERS_FIELD,
             "Clear the farmer's field",
             "Kill snakes in the farmer's field and bring back 3 snake fangs. " +
             "You will receive an adventurer's pass and 20 gold pieces.", 20, 20);

            clearFarmersField.QuestCompletionItems.Add(new QuestCompletionItem(
            ItemByID(ITEM_ID_SNAKE_FANG), 3));
            
            clearFarmersField.RewardItem = ItemByID(ITEM_ID_ADVENTURER_PASS);
            
             Quests.Add(clearAlchemistGarden);
             Quests.Add(clearFarmersField);
        }

        private static void PopulateLocations()
        {
            // Create each location
            Location home = new Location(LOCATION_ID_HOME, "Home",
            "Your house. You really need to clean up the place.");

            Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE,
            "Town square", "You see a fountain.");

            Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT,
            "Alchemist's hut", "There are many strange plants on the shelves.");
            alchemistHut.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);

            Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMISTS_GARDEN,
            "Alchemist's garden", "Many plants are growing here.");
            alchemistsGarden.MonsterLivingHere = MonsterByID(MONSTER_ID_RAT);

            Location farmhouse = new Location(LOCATION_ID_FARMHOUSE,
            "Farmhouse", "There is a small farmhouse, with a farmer in front.");
            farmhouse.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD);

            Location farmersField = new Location(LOCATION_ID_FARM_FIELD,
            "Farmer's field", "You see rows of vegetables growing here.");
            farmersField.MonsterLivingHere = MonsterByID(MONSTER_ID_SNAKE);

            Location guardPost = new Location(LOCATION_ID_GUARD_POST,
            "Guard post", "There is a large, tough-looking guard here.",
            ItemByID(ITEM_ID_ADVENTURER_PASS));

            Location bridge = new Location(LOCATION_ID_BRIDGE,
            "Bridge", "A stone bridge crosses a wide river.");
            
            Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD,
            "Forest", "You see spider webs covering covering the trees in this forest.");
            spiderField.MonsterLivingHere = MonsterByID(MONSTER_ID_GIANT_SPIDER);
            
         // Link the locations together
            home.LocationToNorth = townSquare;
            
            townSquare.LocationToNorth = alchemistHut;
            townSquare.LocationToSouth = home;
            townSquare.LocationToEast = guardPost;
            townSquare.LocationToWest = farmhouse;

            farmhouse.LocationToEast = townSquare;
            farmhouse.LocationToWest = farmersField;
            
            farmersField.LocationToEast = farmhouse;
            
            alchemistHut.LocationToSouth = townSquare;
            alchemistHut.LocationToNorth = alchemistsGarden;
            
            alchemistsGarden.LocationToSouth = alchemistHut;
            
            guardPost.LocationToEast = bridge;
            guardPost.LocationToWest = townSquare;
         
            bridge.LocationToWest = guardPost;
            bridge.LocationToEast = spiderField;
            
            spiderField.LocationToWest = bridge;
            
         // Add the locations to the static list
            Locations.Add(home);
            Locations.Add(townSquare);
            Locations.Add(guardPost);
            Locations.Add(alchemistHut);
            Locations.Add(alchemistsGarden);
            Locations.Add(farmhouse);
            Locations.Add(farmersField);
            Locations.Add(bridge);
            Locations.Add(spiderField);
        }

        //These methods are ones we can call to get values from the static lists.
        //We could access the lists from lines 31-34 directly since they are public,
        // but these WRAPPER METHODS make it more obvious what we want to do.

        //We pass in the ID of the object we want to retrieve its list(by using the constants from lines 40-66).
        //The method will look at each item in the list (using the FOREACH) and see if the ID we passed matches the
        //ID of the object.

        //If so, it returns that object to us. If we get to the end of the list, and nothing matches 
        //(Which shouldn't happen), the method returns null-nothing.

        //Scope: Public because we are going to need to call this method from other parts of the game.
        //Static: This class is never an object
        //Instead of VOID we have ITEM because this method is going to return a value, and the datatype of that
        //value is going to be "Item", so when the user calls this method, they should get an Item back.

        //This method also has parameters "(int id)" which says the method accepts an id number and returns the item
        //matching that number.

         public static Item ItemByID(int id)
        {
            foreach(Item item in Items)
            {
                if(item.ID == id)
                {
                    return item;
                }
            }
            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach(Monster monster in Monsters)
            {
                if(monster.ID == id)
                {
                    return monster;
                }
            }
            return null;
        }

        public static Quest QuestByID(int id)
        {
            foreach(Quest quest in Quests)
            {
                if(quest.ID == id)
                {
                    return quest;
                }
            }
            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach(Location location in Locations)
            {
                if(location.ID == id)
                {
                    return location;
                }
            }
            return null;
        }
    }
}
