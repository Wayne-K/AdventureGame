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
namespace AdventureGame
{
    public partial class AdventureGame : Form
    {
        private Player player;

        public AdventureGame()
        {
            InitializeComponent();

            Location location = new Location(1, "Home", "This is your house.");

            player = new Player(10, 10, 20, 0, 1);

            labelHP.Text = player.currentHP.ToString();
            labelGold.Text = player.gold.ToString();
            labelExperience.Text = player.experiencePoints.ToString();
            labelLevel.Text = player.level.ToString();
        }
    }
}
