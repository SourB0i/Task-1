using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    abstract class CHaracter: Tile
    {


        private int HP;
        private int maxHP;
        private int damage;
        private int[] tile;
        private int DistanceTo;

        public int[] Tile { get => tile; set => tile = value; }
        public int Damage { get => damage; set => damage = value; }
        public int MaxHP { get => maxHP; set => maxHP = value; }
        public int HP1 { get => HP; set => HP = value; }
        public int DistanceTo1 { get => DistanceTo; set => DistanceTo = value; }

        //A public enum for Movement which contains definitions for:
        //No movement 
        //Up 
        //Down 
        //Left 
        //Right

        enum movement{ idlel, up, down, right, left}

        public CHaracter(int y, int x) : base(y, x) // We are specifically inhertating x and y postions thats all we want from tile.
        {

        }

        public virtual void character() 
        {

        }

        public bool Isdead() 
        {

            if (HP > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public virtual bool CheckRange(CHaracter target) 
        {
            DistanceTo = 0;
            return true;
        }

        public void Move() 
        {

        }

        public virtual void Attack(CHaracter  target) 
        {
            target.HP -= damage;
        }

        public void Move(movement move) 
        {

        }

        public abstract MovementEnum ReturnMove(MovementEnum move = 0) 
        {

        }

        public abstract override ToString();














    }
}
