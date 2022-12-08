using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Ball
    {
        public int roll;
        public int jump;
        private string contact = "";
        public int height;
        
        public int Width { get { return roll * jump; }}






        public int Roll
        {
            get
            {
                return roll;
            }

            set
            {
                roll = value;
            }
        }

        public string Contact
        {
            get
            {
                return contact;
            }
            set
            {
                contact = value;
            }
        }
            

    }
}
