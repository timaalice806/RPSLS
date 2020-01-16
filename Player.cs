using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSciz
{
    abstract class Player
    {
        //MEMBER VARIABLES (PLAYER HAS A)
        public string playerName;
        public int score;
        public int playerChoice;
        public List<string> gestureList;

        //CONTRUCTORS (DEFAULT SETTINGS)
        public Player()
        {
            
            this.score = 0;
                 
        }
        //MEMBER METHODS(PLAYER CAN DO)
        public abstract void InitGestureList();
        public abstract void ChooseGesture();
    }
}
