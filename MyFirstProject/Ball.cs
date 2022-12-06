using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Ball
    {
        private int roll, jump;

        public Ball(int roll)
        {
            this.roll = roll;
        }
        
        public int ballAction(int roll)
        {

            return this.roll+=roll;

        }

    }
}
