using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Map
    {
        private int[,] mapArray;
        private int[] enemyArray;
        private int mapheight;
        private int mapwidth;

        public int[,] MapArray { get => mapArray; set => mapArray = value; }
        public int[] EnemyArray { get => enemyArray; set => enemyArray = value; }
        public int Mapheight { get => mapheight; set => mapheight = value; }
        public int Mapwidth { get => mapwidth; set => mapwidth = value; }


    }
}
