﻿using System;
using System.Collections.Generic;
using System.Text;

namespace B20_Ex02
{
    class Move
    {
        private Location firstCardLocation;
        private Location secondCardLocation;
        private Player currentPlayer;

        public Move(Player i_Player)
        {
            this.currentPlayer = i_Player;
        }

        public void SetLocation(Location i_CardLocation)
        {
            if(firstCardLocation == null)
            {
                firstCardLocation = i_CardLocation;
            }
            else
            {
                secondCardLocation = i_CardLocation;
            }
        }

        public Location GetFirstCardLocation()
        {
            return firstCardLocation;
        }
        public Location GetSecondCardLocation()
        {
            return secondCardLocation;
        }
    }
}