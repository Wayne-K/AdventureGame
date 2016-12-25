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

            player = new Player();

            player.currentHitPoints = 10;
            player.maximumHitPoints = 10;
            player.gold = 20;
            player.experiencePoints = 0;
            player.level = 1;

            labelHP.Text = player.currentHitPoints.ToString();
            labelGold.Text = player.gold.ToString();
            labelExperience.Text = player.experiencePoints.ToString();
            labelLevel.Text = player.level.ToString();
        }
    }
}
