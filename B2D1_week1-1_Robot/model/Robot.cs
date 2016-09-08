using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace B2D1_week1_1_Robot.model
{
    public class Robot
    {
        private int plaats;
        private int richting;

        public Robot(int r, int p)
        {
            this.plaats = p;
            this.richting = r;
        }

        public void zetEenStap()
        {
            //this.plaats = this.plaats + this.richting;
            this.plaats += this.richting;
            Console.WriteLine("Robot is verplaatst ga naar " + this.plaats.ToString());
        }

        public void gaNaar(int b)
        {
            while (this.plaats != b)
            {
                if (this.plaats < b)
                {
                    this.plaats += 1;
                }
                else
                {
                    this.plaats -= 1;
                }
                Console.WriteLine("Robot is verplaatst ga naar "+this.plaats.ToString());
            }

        }
    }
}
