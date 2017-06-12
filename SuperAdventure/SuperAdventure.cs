using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        //Scope: Private since we don't need anything outside of theis screen to use the variable
        //Datatype: Player because we want to store a player object in it
        //Name: _player because it is a private variable, which is just a normal naming convention to use "_" 
        //when dealing with private variables.
        //**Note: YOU MUST CONNECT THE "Player" CLASS WITH A USING STATEMENT ON TOP**

        private Player _player;

        //Constructor to the "SuperAdventure" class
        //The code in the constructor is always public and is always named after the class, which is this case
        //is the form

        public SuperAdventure()
        {     
            InitializeComponent();

            //Here we create a new "Location" object and save it to the variable "location". 
            //Then we assign values to the properties of that object in the ().
            //**NOTE: NOTICE THE VARIABLE NAME (location) IS LOWER-CASE 
            //TO MAKE IT DIFFERENT FROM THE CLASS (Location).**

            

            Location location = new Location(1, "Home", "This is your house.");

            //This is where we will instantiate a "Player" object to store in the "_player" variable

            _player = new Player(10, 10, 20, 0, 1);

            //This ^^ creates a new player object using the "new Player();" code and assigning it 
            //to the "_player" variable.

            //Here we are assigning values to the properties of the "_player" object
            //**Note this is now shown in the parameters of the constructor**
            //_player.CurrentHitPoints = 10;
            //_player.MaximumHitPoints = 10;
            //_player.Gold = 20;
            //_player.ExperiencePoints = 0;
            //_player.Level = 1;

            //Here we are getting the value of the properties from the "_player" object, and assigning them to the 
            //text of the labels on the screen
            //**NOTE: THE "ToString()" METHOD ALLOWS INTEGER VALUES TO BE ASSIGNED TO A STRING**

            label1.Text = _player.CurrentHitPoints.ToString();
            label2.Text = _player.Gold.ToString();
            label3.Text = _player.ExperiencePoints.ToString();
            label4.Text = _player.Level.ToString();
        }

     
    }
}
