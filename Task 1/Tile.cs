using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    abstract class Tile
    {
        private int posX;
        private int posy;

        public int PosX { get => posX; set => posX = value; }
        public int PosY { get => posy; set => posy = value; }

        enum TileType{Hero, Enemy,Gold, Weapon}

        public Tile(int x ,int y)
        {
            this.PosX = 0;
            this.PosY = 0;
        }


    }
}
