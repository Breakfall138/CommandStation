using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BasicGame
    {
        const int numPlayers = 2;
        List<Player> players = new List<Player>();
        string[] playerNames = { "player1", "player2" };

        
        //Setup
        BasicGame()
        {
            for(int i=0; i<numPlayers; i++)
            {
                players.Add(NewPlayer(playerNames[i]));
            }
        }
        private Player NewPlayer(string name)
        {
            Player play = new Player();
            play.name = name;

            //setup grids
            AddDefenseGrid(play);
            AddOffensiveGrid(play);

            //buildings
            
            //resources

            return play;

        }
        public void AddDefenseGrid(Player plyr)
        {
           plyr.grids.Add(new GridFactory().Create("DefenseGrid",10, 10) as DefenseGrid);

        }
        public void AddOffensiveGrid(Player plyr)
        {
            plyr.grids.Add(new GridFactory().Create("OffenseGrid", 10, 10) as OffenseGrid);
        }
        public void AddStartingBuildings(Player plyr)
        {

        }
        public void AddStartingResources(Player plyr)
        {

        }
        public void TakeTurn(Player plyr)
        {
            //Logic for each turn is here
        }
    }
}
